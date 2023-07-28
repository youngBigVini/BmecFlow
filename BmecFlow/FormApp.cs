using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BmecFlow
{
    public partial class FormMain : Form
    {
        private System.Threading.Timer timer;
        LogManager logManager = new LogManager();
        SQLManager sQLManager = new SQLManager();
        string cqa = string.Empty;
        string invalidTrackIdMsg = "trackId inválido!!!";
        string strFieldCheck = "Preencha corretamente todos os campos para serem inseridos!!!";
        string trackingDir = @"X:\DC\BmecFlow\tracking";
        string dbDir = @"X:\DC\BmecFlow\db\";
        string cfgPattern = ".cfg";
        public FormMain()
        {
            InitializeComponent();
            readRouteFilesAndFillComboBox();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bmecFlowDataSet.BFlow' table. You can move, or remove it, as needed.
            this.bFlowTableAdapter.Fill(this.bmecFlowDataSet.BFlow);

        }
        public void readRouteFilesAndFillComboBox()
        {
            string line = string.Empty;
            foreach (string s in Directory.GetFiles(dbDir, "*", SearchOption.AllDirectories))
            {
                line = s;
                line = line.Replace(dbDir, "");
                if (line.Contains(cfgPattern))
                {
                    line = line.Replace(cfgPattern, "");
                    comboBoxProductName.Items.Add(line);
                    comboBoxProcessProduct.Items.Add(line);
                }
            }

        }
        private void buttonRun_Click(object sender, EventArgs e)
        {

            if (comboBoxStationType.Text == string.Empty)
                MessageBox.Show("Selecione o tipo da estação!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (comboBoxProductName.Text == "")
                MessageBox.Show("Digite o nome do Produto!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                buttonRun.Text = "Running!";
                if (comboBoxStationType.Text == "IFLASH")
                    startTimer();
                else
                {
                    buttonRun.BackColor = Color.Green;
                    Application.DoEvents();
                }
            }
        }
        private void startTimer()
        {
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(10);
            timer = new System.Threading.Timer((obj) =>
            {
                buttonRun.BackColor = Color.Green;
                Application.DoEvents();

                logManager.getLogResult();

                buttonRun.BackColor = Color.Yellow;
                Application.DoEvents();

            }, null, startTimeSpan, periodTimeSpan);
        }
        private void textBoxTrackID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTrackID.TextLength != 10)
            {

            }
            else if (comboBoxStationType.Text == "")
            {
                MessageBox.Show("Escolha o tipo da estação!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    datagridViewUpdateData();
                    string selectedStationType = comboBoxStationType.GetItemText(comboBoxStationType.SelectedItem);
                    string verifylatestStation = checkRouteFlow(selectedStationType);
                    bool bStatus = false;
                    bStatus = sQLManager.CheckRouteStatus(textBoxTrackID.Text, verifylatestStation);
                    if (!bStatus)
                    {
                        MessageBox.Show("Erro de ROTA, volte para estação anterior!!!", "ERRO DE ROTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        labelRouteStatus.Text = textBoxTrackID.Text + " ERRO de ROTA!";
                        labelRouteStatus.ForeColor = Color.Red;
                        Application.DoEvents();
                    }
                    else
                    {
                        labelRouteStatus.Text = "      " + textBoxTrackID.Text + " ROTA OK!";
                        labelRouteStatus.ForeColor = Color.Green;
                        Application.DoEvents();
                    }
                    textBoxTrackID.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Query Error!! :" + ex);
                }
            }
        }
        private string checkRouteFlow(string currentStation)
        {
            string routeVerify = string.Empty;
            try
            {
                string selectedProduct = comboBoxProductName.GetItemText(comboBoxProductName.SelectedItem);
                string[] splitFile = File.ReadAllLines(dbDir + selectedProduct + cfgPattern);
                string productName = splitFile[0];
                string routeFlow = splitFile[1];

                string[] flowStations = routeFlow.Split(',');

                for (int i = 0; i < flowStations.Length; i++)
                {
                    if (flowStations[i] == currentStation)
                        routeVerify = flowStations[i - 1];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a ROTA!!! reason: " + ex);
            }
            return routeVerify;

        }
        private void buttonBkp_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string strFilePath = dbDir + "BmecFlow.mdb";
            string strFileDestination = @"C:\temp\Backup_" + dt.ToString("yyyyMMdd") + "_BmecFlow.mdb";

            try
            {
                File.Copy(strFilePath, strFileDestination, true);
                MessageBox.Show("Backup do DataBase criado com sucesso na folder C:\\temp\\!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Não foi possivel criar um backup do DataBase! : " + ex);
            }
        }
        private void datagridViewUpdateData()
        {
            bFlowTableAdapter.Fill(bmecFlowDataSet.BFlow);
        }
        private void buttonROUTESave_Click(object sender, EventArgs e)
        {
            if (textBoxProductName.Text == "" || comboBoxRouteME.Text == "" || comboBoxRouteBE.Text == "")
                MessageBox.Show(strFieldCheck, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    File.WriteAllText(dbDir + textBoxProductName.Text + cfgPattern, textBoxProductName.Text + "\n" + comboBoxRouteME.Text + "," + comboBoxRouteBE.Text);
                }
                catch
                {
                    MessageBox.Show("Erro ao criar a ROTA do produto!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Rota criada com sucesso!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            datagridViewUpdateData();
        }
        private void cleanPInfos()
        {
            textBoxOBSTrackId.Text = "";
            textBoxOBSCQA.Text = "";
            textBoxTrackIdProcess.Text = "";
            textBoxTrackingInfos.Text = "";
        }

        private void buttonObs_Click(object sender, EventArgs e)
        {
            bool result = false;
            if (textBoxOBSTrackId.Text == "" || textBoxOBSCQA.Text == "")
            {
                MessageBox.Show(strFieldCheck, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cleanPInfos();
            }
            else if (textBoxOBSTrackId.TextLength != 10)
            {
                MessageBox.Show(invalidTrackIdMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cleanPInfos();
            }
            else
            {
                result = sQLManager.InsertObstoDb(textBoxOBSTrackId.Text, textBoxOBSCQA.Text);
                if (result)
                    MessageBox.Show("Observações inseridas com sucesso!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);
                cleanPInfos();
            }
        }

        private void buttonTracking_Click(object sender, EventArgs e)
        {
            if (textBoxTrackIdProcess.Text == "" || textBoxTrackingInfos.Text == "" || comboBoxProcessProduct.Text == "" || comboBoxAREA.Text == "" || comboBoxBuild.Text == "")
            {
                MessageBox.Show(strFieldCheck, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cleanPInfos();
            }
            else if (textBoxTrackIdProcess.TextLength != 10)
            {
                MessageBox.Show("TrackId invalido!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cleanPInfos();
            }
            else
            {
                UnitTrackingGenTxt(comboBoxProcessProduct.Text, comboBoxProcessProduct.Text + "->" + comboBoxBuild.Text + "-" + comboBoxAREA.Text + ": " + textBoxTrackingInfos.Text, textBoxTrackIdProcess.Text);
                MessageBox.Show("informações inseridas com sucesso!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);
                cleanPInfos();
            }
        }
        public void UnitTrackingGenTxt(string folderName, string trackingInfos, string fileNameTrackId)
        {
            string dirName = trackingDir + folderName;
            Directory.CreateDirectory(dirName);

            string filepath = dirName + "\\" + fileNameTrackId + ".tracking";
            try
            {
                string logString = trackingInfos;
                if (!File.Exists(filepath))
                {
                    using (StreamWriter writer = new StreamWriter(new FileStream(filepath, FileMode.Create, FileAccess.Write)))
                    {
                        writer.WriteLine(logString);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(new FileStream(filepath, FileMode.Append, FileAccess.Write)))
                    {
                        writer.WriteLine(logString);
                    }
                }
            }
            catch
            {
                MessageBox.Show("diretório e/ou arquivo não encontrados!!!" + fileNameTrackId);
            }
        }

        private void buttonPASS_Click(object sender, EventArgs e)
        {
            if (textBoxOBSTrackId.TextLength != 10)
            {
                MessageBox.Show(invalidTrackIdMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxOBSTrackId.Text = "";

            }
            else
            {
                cqa = comboBoxCQA.Text;
                sQLManager.InsertToMdb(textBoxOBSTrackId.Text, cqa, "P");
                MessageBox.Show("CQA result PASS adicionado com sucesso!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);
                textBoxOBSTrackId.Text = "";
            }
        }

        private void buttonFAIL_Click(object sender, EventArgs e)
        {
            if (textBoxOBSTrackId.TextLength != 10)
            {
                MessageBox.Show(invalidTrackIdMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxOBSTrackId.Text = "";
            }
            else
            {
                cqa = comboBoxCQA.Text;
                sQLManager.InsertToMdb(textBoxOBSTrackId.Text, cqa, "F");
                MessageBox.Show("CQA result FAIL adicionado com sucesso!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);
                textBoxOBSTrackId.Text = "";
            }
        }

        private void buttonRuninPASS_Click(object sender, EventArgs e)
        {
            if (textBoxRunin.TextLength != 10)
            {
                MessageBox.Show(invalidTrackIdMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRunin.Text = "";
            }
            else
            {
                sQLManager.InsertToMdb(textBoxRunin.Text, "RUNNIN", "P");
                MessageBox.Show("RUNNIN result PASS adicionado com sucesso!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);
                textBoxRunin.Text = "";
            }
        }

        private void buttonRuninFAIL_Click(object sender, EventArgs e)
        {
            if (textBoxRunin.TextLength != 10)
            {
                MessageBox.Show(invalidTrackIdMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRunin.Text = "";
            }
            else
            {
                sQLManager.InsertToMdb(textBoxRunin.Text, "RUNNIN", "F");
                MessageBox.Show("RUNNIN result FAIL adicionado com sucesso!!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);
                textBoxRunin.Text = "";
            }
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            openFolder();
        }

        private void buttonInserirFDetails_Click(object sender, EventArgs e)
        {
            bool result = false;
            if (textBoxFailDetailTrackid.TextLength != 10)
            {
                MessageBox.Show(invalidTrackIdMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFailDetailTrackid.Text = "";
            }
            else if (textBoxFailDetailTrackid.Text == "" || textBoxFailDetails.Text == "")
            {
                MessageBox.Show(strFieldCheck, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFailDetailTrackid.Text = "";
                textBoxFailDetails.Text = "";
            }
            else
            {
                result = sQLManager.InsertFailDetailsToDb(textBoxFailDetailTrackid.Text, textBoxFailDetails.Text);
                if (result)
                    MessageBox.Show("Detalhes da falha incluidos com sucesso!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);

                textBoxFailDetails.Text = "";
                textBoxFailDetailTrackid.Text = "";
            }
        }

        public void getRestrictionUnits()
        {
            textBoxRestrictionUnits.Text = "-> Unidades com restrições:" + Environment.NewLine + "->PRODUTO \\ TRACKID" + Environment.NewLine;
            string strTrackingPattern = "*.tracking*";
            string unittrackid = string.Empty;
            try
            {
                foreach (string file_name in Directory.GetFiles(trackingDir, strTrackingPattern, SearchOption.AllDirectories))
                {
                    unittrackid = file_name;
                    unittrackid = unittrackid.Replace(trackingDir, "");
                    textBoxRestrictionUnits.Text += Environment.NewLine + unittrackid;
                }
            }
            catch
            { }

        }
        private void openFolder()
        {
            System.Diagnostics.Process.Start(trackingDir);
        }
        private void buttonRestrictionUnits_Click(object sender, EventArgs e)
        {
            getRestrictionUnits();
        }

        private void buttonOFolder2_Click(object sender, EventArgs e)
        {
            openFolder();
        }
    }
}
