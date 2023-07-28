namespace BmecFlow
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LabelAppName = new System.Windows.Forms.Label();
            this.comboBoxStationType = new System.Windows.Forms.ComboBox();
            this.labelStationType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTrackID = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonBkp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.tabControlApp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelRouteStatus = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonROUTESave = new System.Windows.Forms.Button();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxRouteBE = new System.Windows.Forms.ComboBox();
            this.comboBoxRouteME = new System.Windows.Forms.ComboBox();
            this.labelBE = new System.Windows.Forms.Label();
            this.labelME = new System.Windows.Forms.Label();
            this.labelRouteConfig = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelOBSTRACKID = new System.Windows.Forms.Label();
            this.textBoxOBSTrackId = new System.Windows.Forms.TextBox();
            this.labelObs = new System.Windows.Forms.Label();
            this.labelPInfos = new System.Windows.Forms.Label();
            this.buttonObs = new System.Windows.Forms.Button();
            this.dataGridViewApp = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelProcess = new System.Windows.Forms.Label();
            this.textBoxTrackIdProcess = new System.Windows.Forms.TextBox();
            this.buttonTracking = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTrackingInfos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPASS = new System.Windows.Forms.Button();
            this.buttonFAIL = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRuninFAIL = new System.Windows.Forms.Button();
            this.buttonRuninPASS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRunin = new System.Windows.Forms.TextBox();
            this.comboBoxProcessProduct = new System.Windows.Forms.ComboBox();
            this.labelPProduct = new System.Windows.Forms.Label();
            this.comboBoxBuild = new System.Windows.Forms.ComboBox();
            this.labelBuild = new System.Windows.Forms.Label();
            this.comboBoxAREA = new System.Windows.Forms.ComboBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.bmecFlowDataSet = new BmecFlow.BmecFlowDataSet();
            this.bFlowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bFlowTableAdapter = new BmecFlow.BmecFlowDataSetTableAdapters.BFlowTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iFLASHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brdTestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5GFR1BdTstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRINTLABELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fODTESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l2VISIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioSlimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCDCALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l2ARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sQTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthCalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthValDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraSOISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQA2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUNNINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQAOBSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAILDETAILSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxCQA = new System.Windows.Forms.ComboBox();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.labelFAILDetail = new System.Windows.Forms.Label();
            this.textBoxFailDetailTrackid = new System.Windows.Forms.TextBox();
            this.labelFDetails = new System.Windows.Forms.Label();
            this.buttonInserirFDetails = new System.Windows.Forms.Button();
            this.labelDetalhesFail = new System.Windows.Forms.Label();
            this.textBoxFailDetails = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOBSCQA = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textBoxRestrictionUnits = new System.Windows.Forms.TextBox();
            this.buttonRestrictionUnits = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonOFolder2 = new System.Windows.Forms.Button();
            this.groupBoxSettings.SuspendLayout();
            this.tabControlApp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApp)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmecFlowDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFlowBindingSource)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelAppName
            // 
            this.LabelAppName.AutoSize = true;
            this.LabelAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAppName.ForeColor = System.Drawing.Color.Teal;
            this.LabelAppName.Location = new System.Drawing.Point(3, 3);
            this.LabelAppName.Name = "LabelAppName";
            this.LabelAppName.Size = new System.Drawing.Size(152, 33);
            this.LabelAppName.TabIndex = 1;
            this.LabelAppName.Text = "BmecFlow";
            // 
            // comboBoxStationType
            // 
            this.comboBoxStationType.FormattingEnabled = true;
            this.comboBoxStationType.Items.AddRange(new object[] {
            "IFLASH",
            "BrdTest",
            "T5GFR1BdTst",
            "L2AR",
            "L2VISION",
            "DepthCal",
            "DepthVal",
            "FODTEST",
            "RadioSlim",
            "CFC",
            "UCT",
            "BE",
            "CQA",
            "PRODUTO"});
            this.comboBoxStationType.Location = new System.Drawing.Point(6, 85);
            this.comboBoxStationType.Name = "comboBoxStationType";
            this.comboBoxStationType.Size = new System.Drawing.Size(155, 21);
            this.comboBoxStationType.TabIndex = 2;
            // 
            // labelStationType
            // 
            this.labelStationType.AutoSize = true;
            this.labelStationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStationType.Location = new System.Drawing.Point(4, 66);
            this.labelStationType.Name = "labelStationType";
            this.labelStationType.Size = new System.Drawing.Size(75, 16);
            this.labelStationType.TabIndex = 3;
            this.labelStationType.Text = "ESTAÇÃO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "TRACK-ID";
            // 
            // textBoxTrackID
            // 
            this.textBoxTrackID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrackID.Location = new System.Drawing.Point(420, 53);
            this.textBoxTrackID.Multiline = true;
            this.textBoxTrackID.Name = "textBoxTrackID";
            this.textBoxTrackID.Size = new System.Drawing.Size(190, 41);
            this.textBoxTrackID.TabIndex = 5;
            this.textBoxTrackID.TextChanged += new System.EventHandler(this.textBoxTrackID_TextChanged);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(167, 77);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 30);
            this.buttonRun.TabIndex = 6;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonBkp
            // 
            this.buttonBkp.BackColor = System.Drawing.Color.Teal;
            this.buttonBkp.Location = new System.Drawing.Point(951, 15);
            this.buttonBkp.Name = "buttonBkp";
            this.buttonBkp.Size = new System.Drawing.Size(75, 36);
            this.buttonBkp.TabIndex = 8;
            this.buttonBkp.Text = "BackupDB";
            this.buttonBkp.UseVisualStyleBackColor = false;
            this.buttonBkp.Click += new System.EventHandler(this.buttonBkp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 620);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Developed by A. Patricio";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.comboBoxProductName);
            this.groupBoxSettings.Controls.Add(this.labelProductName);
            this.groupBoxSettings.Controls.Add(this.comboBoxStationType);
            this.groupBoxSettings.Controls.Add(this.labelStationType);
            this.groupBoxSettings.Controls.Add(this.buttonRun);
            this.groupBoxSettings.Location = new System.Drawing.Point(9, 39);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(248, 113);
            this.groupBoxSettings.TabIndex = 11;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Setting";
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(7, 36);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(154, 21);
            this.comboBoxProductName.TabIndex = 9;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(3, 16);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(79, 16);
            this.labelProductName.TabIndex = 8;
            this.labelProductName.Text = "PRODUTO:";
            // 
            // tabControlApp
            // 
            this.tabControlApp.Controls.Add(this.tabPage1);
            this.tabControlApp.Controls.Add(this.tabPage2);
            this.tabControlApp.Controls.Add(this.tabPage3);
            this.tabControlApp.Controls.Add(this.tabPage4);
            this.tabControlApp.Controls.Add(this.tabPage5);
            this.tabControlApp.Controls.Add(this.tabPage6);
            this.tabControlApp.Controls.Add(this.tabPage7);
            this.tabControlApp.Location = new System.Drawing.Point(12, 4);
            this.tabControlApp.Name = "tabControlApp";
            this.tabControlApp.SelectedIndex = 0;
            this.tabControlApp.Size = new System.Drawing.Size(1063, 613);
            this.tabControlApp.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonRefresh);
            this.tabPage1.Controls.Add(this.labelRouteStatus);
            this.tabPage1.Controls.Add(this.LabelAppName);
            this.tabPage1.Controls.Add(this.groupBoxSettings);
            this.tabPage1.Controls.Add(this.dataGridViewApp);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonBkp);
            this.tabPage1.Controls.Add(this.textBoxTrackID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1055, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BMECFLOW";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRefresh.Location = new System.Drawing.Point(951, 58);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 28);
            this.buttonRefresh.TabIndex = 13;
            this.buttonRefresh.Text = "Refresh DB";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelRouteStatus
            // 
            this.labelRouteStatus.AutoSize = true;
            this.labelRouteStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRouteStatus.Location = new System.Drawing.Point(304, 101);
            this.labelRouteStatus.Name = "labelRouteStatus";
            this.labelRouteStatus.Size = new System.Drawing.Size(0, 39);
            this.labelRouteStatus.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonROUTESave);
            this.tabPage2.Controls.Add(this.textBoxProductName);
            this.tabPage2.Controls.Add(this.labelProduct);
            this.tabPage2.Controls.Add(this.comboBoxRouteBE);
            this.tabPage2.Controls.Add(this.comboBoxRouteME);
            this.tabPage2.Controls.Add(this.labelBE);
            this.tabPage2.Controls.Add(this.labelME);
            this.tabPage2.Controls.Add(this.labelRouteConfig);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1055, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ROUTE CFG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonROUTESave
            // 
            this.buttonROUTESave.BackColor = System.Drawing.Color.Teal;
            this.buttonROUTESave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonROUTESave.ForeColor = System.Drawing.Color.White;
            this.buttonROUTESave.Location = new System.Drawing.Point(186, 260);
            this.buttonROUTESave.Name = "buttonROUTESave";
            this.buttonROUTESave.Size = new System.Drawing.Size(135, 35);
            this.buttonROUTESave.TabIndex = 9;
            this.buttonROUTESave.Text = "Salvar ROTA";
            this.buttonROUTESave.UseVisualStyleBackColor = false;
            this.buttonROUTESave.Click += new System.EventHandler(this.buttonROUTESave_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(18, 88);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(172, 20);
            this.textBoxProductName.TabIndex = 8;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(14, 64);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(94, 20);
            this.labelProduct.TabIndex = 7;
            this.labelProduct.Text = "PRODUCT";
            // 
            // comboBoxRouteBE
            // 
            this.comboBoxRouteBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRouteBE.FormattingEnabled = true;
            this.comboBoxRouteBE.Items.AddRange(new object[] {
            "FODTEST,RadioSlim,L2AR,DepthCal,DepthVal,CFC",
            "FODTEST,L2VISION,L2AR,DepthCal,DepthVal,CFC",
            "UCT,L2AR,ACT,SQT,RadioSlim,LCDCAL,TOF,DepthCal,DepthVal",
            "UCT,FODTEST,RadioSlim,L2AR,DepthCal,DepthVal,Camera_SOIS",
            "RadioSlim,L2AR,DepthVal",
            "L2VISION,L2AR,DepthVal",
            "RadioSlim,L2AR"});
            this.comboBoxRouteBE.Location = new System.Drawing.Point(16, 216);
            this.comboBoxRouteBE.Name = "comboBoxRouteBE";
            this.comboBoxRouteBE.Size = new System.Drawing.Size(459, 23);
            this.comboBoxRouteBE.TabIndex = 6;
            this.comboBoxRouteBE.Text = "FODTEST,RadioSlim,L2AR,DepthCal,DepthVal,CFC";
            // 
            // comboBoxRouteME
            // 
            this.comboBoxRouteME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRouteME.FormattingEnabled = true;
            this.comboBoxRouteME.Items.AddRange(new object[] {
            "IFLASH,BrdTest,T5GFR1BdTst",
            "IFLASH,BrdTest"});
            this.comboBoxRouteME.Location = new System.Drawing.Point(16, 148);
            this.comboBoxRouteME.Name = "comboBoxRouteME";
            this.comboBoxRouteME.Size = new System.Drawing.Size(459, 23);
            this.comboBoxRouteME.TabIndex = 5;
            this.comboBoxRouteME.Text = "IFLASH,BrdTest,T5GFR1BdTst";
            // 
            // labelBE
            // 
            this.labelBE.AutoSize = true;
            this.labelBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBE.Location = new System.Drawing.Point(14, 184);
            this.labelBE.Name = "labelBE";
            this.labelBE.Size = new System.Drawing.Size(33, 20);
            this.labelBE.TabIndex = 4;
            this.labelBE.Text = "BE";
            // 
            // labelME
            // 
            this.labelME.AutoSize = true;
            this.labelME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelME.Location = new System.Drawing.Point(12, 124);
            this.labelME.Name = "labelME";
            this.labelME.Size = new System.Drawing.Size(35, 20);
            this.labelME.TabIndex = 3;
            this.labelME.Text = "ME";
            // 
            // labelRouteConfig
            // 
            this.labelRouteConfig.AutoSize = true;
            this.labelRouteConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRouteConfig.ForeColor = System.Drawing.Color.Teal;
            this.labelRouteConfig.Location = new System.Drawing.Point(-4, 3);
            this.labelRouteConfig.Name = "labelRouteConfig";
            this.labelRouteConfig.Size = new System.Drawing.Size(184, 33);
            this.labelRouteConfig.TabIndex = 2;
            this.labelRouteConfig.Text = "Route Config";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxOBSCQA);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.buttonObs);
            this.tabPage3.Controls.Add(this.labelPInfos);
            this.tabPage3.Controls.Add(this.labelObs);
            this.tabPage3.Controls.Add(this.labelOBSTRACKID);
            this.tabPage3.Controls.Add(this.textBoxOBSTrackId);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1055, 587);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CQA";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelOBSTRACKID
            // 
            this.labelOBSTRACKID.AutoSize = true;
            this.labelOBSTRACKID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOBSTRACKID.Location = new System.Drawing.Point(478, 32);
            this.labelOBSTRACKID.Name = "labelOBSTRACKID";
            this.labelOBSTRACKID.Size = new System.Drawing.Size(77, 18);
            this.labelOBSTRACKID.TabIndex = 6;
            this.labelOBSTRACKID.Text = "TRACK-ID";
            // 
            // textBoxOBSTrackId
            // 
            this.textBoxOBSTrackId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOBSTrackId.Location = new System.Drawing.Point(420, 53);
            this.textBoxOBSTrackId.MaxLength = 10;
            this.textBoxOBSTrackId.Multiline = true;
            this.textBoxOBSTrackId.Name = "textBoxOBSTrackId";
            this.textBoxOBSTrackId.Size = new System.Drawing.Size(190, 41);
            this.textBoxOBSTrackId.TabIndex = 7;
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObs.Location = new System.Drawing.Point(47, 391);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(173, 24);
            this.labelObs.TabIndex = 8;
            this.labelObs.Text = "Observações CQA:";
            // 
            // labelPInfos
            // 
            this.labelPInfos.AutoSize = true;
            this.labelPInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPInfos.ForeColor = System.Drawing.Color.Teal;
            this.labelPInfos.Location = new System.Drawing.Point(6, 3);
            this.labelPInfos.Name = "labelPInfos";
            this.labelPInfos.Size = new System.Drawing.Size(192, 33);
            this.labelPInfos.TabIndex = 9;
            this.labelPInfos.Text = "CQA Process";
            // 
            // buttonObs
            // 
            this.buttonObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObs.Location = new System.Drawing.Point(51, 470);
            this.buttonObs.Name = "buttonObs";
            this.buttonObs.Size = new System.Drawing.Size(96, 39);
            this.buttonObs.TabIndex = 11;
            this.buttonObs.Text = "Inserir";
            this.buttonObs.UseVisualStyleBackColor = true;
            this.buttonObs.Click += new System.EventHandler(this.buttonObs_Click);
            // 
            // dataGridViewApp
            // 
            this.dataGridViewApp.AutoGenerateColumns = false;
            this.dataGridViewApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.trackidDataGridViewTextBoxColumn,
            this.iFLASHDataGridViewTextBoxColumn,
            this.brdTestDataGridViewTextBoxColumn,
            this.t5GFR1BdTstDataGridViewTextBoxColumn,
            this.pRINTLABELDataGridViewTextBoxColumn,
            this.uCTDataGridViewTextBoxColumn,
            this.fODTESTDataGridViewTextBoxColumn,
            this.l2VISIONDataGridViewTextBoxColumn,
            this.radioSlimDataGridViewTextBoxColumn,
            this.lCDCALDataGridViewTextBoxColumn,
            this.l2ARDataGridViewTextBoxColumn,
            this.sQTDataGridViewTextBoxColumn,
            this.depthCalDataGridViewTextBoxColumn,
            this.depthValDataGridViewTextBoxColumn,
            this.cameraSOISDataGridViewTextBoxColumn,
            this.aCTDataGridViewTextBoxColumn,
            this.tOFDataGridViewTextBoxColumn,
            this.cFCDataGridViewTextBoxColumn,
            this.cQADataGridViewTextBoxColumn,
            this.cQA2DataGridViewTextBoxColumn,
            this.rUNNINDataGridViewTextBoxColumn,
            this.bEDataGridViewTextBoxColumn,
            this.cQAOBSDataGridViewTextBoxColumn,
            this.fAILDETAILSDataGridViewTextBoxColumn});
            this.dataGridViewApp.DataSource = this.bFlowBindingSource;
            this.dataGridViewApp.Location = new System.Drawing.Point(9, 158);
            this.dataGridViewApp.Name = "dataGridViewApp";
            this.dataGridViewApp.Size = new System.Drawing.Size(1040, 423);
            this.dataGridViewApp.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.buttonOpenFolder);
            this.tabPage4.Controls.Add(this.comboBoxAREA);
            this.tabPage4.Controls.Add(this.labelArea);
            this.tabPage4.Controls.Add(this.comboBoxBuild);
            this.tabPage4.Controls.Add(this.labelBuild);
            this.tabPage4.Controls.Add(this.comboBoxProcessProduct);
            this.tabPage4.Controls.Add(this.labelPProduct);
            this.tabPage4.Controls.Add(this.textBoxTrackingInfos);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.buttonTracking);
            this.tabPage4.Controls.Add(this.labelProcess);
            this.tabPage4.Controls.Add(this.textBoxTrackIdProcess);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1055, 587);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PROCESS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcess.Location = new System.Drawing.Point(478, 32);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(77, 18);
            this.labelProcess.TabIndex = 8;
            this.labelProcess.Text = "TRACK-ID";
            // 
            // textBoxTrackIdProcess
            // 
            this.textBoxTrackIdProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrackIdProcess.Location = new System.Drawing.Point(420, 53);
            this.textBoxTrackIdProcess.MaxLength = 10;
            this.textBoxTrackIdProcess.Multiline = true;
            this.textBoxTrackIdProcess.Name = "textBoxTrackIdProcess";
            this.textBoxTrackIdProcess.Size = new System.Drawing.Size(190, 41);
            this.textBoxTrackIdProcess.TabIndex = 9;
            // 
            // buttonTracking
            // 
            this.buttonTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonTracking.Location = new System.Drawing.Point(468, 400);
            this.buttonTracking.Name = "buttonTracking";
            this.buttonTracking.Size = new System.Drawing.Size(96, 39);
            this.buttonTracking.TabIndex = 10;
            this.buttonTracking.Text = "Inserir";
            this.buttonTracking.UseVisualStyleBackColor = true;
            this.buttonTracking.Click += new System.EventHandler(this.buttonTracking_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(-4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Process";
            // 
            // textBoxTrackingInfos
            // 
            this.textBoxTrackingInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrackingInfos.Location = new System.Drawing.Point(21, 183);
            this.textBoxTrackingInfos.Multiline = true;
            this.textBoxTrackingInfos.Name = "textBoxTrackingInfos";
            this.textBoxTrackingInfos.Size = new System.Drawing.Size(1010, 211);
            this.textBoxTrackingInfos.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCQA);
            this.groupBox1.Controls.Add(this.buttonFAIL);
            this.groupBox1.Controls.Add(this.buttonPASS);
            this.groupBox1.Location = new System.Drawing.Point(306, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 143);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CQA result";
            // 
            // buttonPASS
            // 
            this.buttonPASS.BackColor = System.Drawing.Color.Green;
            this.buttonPASS.Location = new System.Drawing.Point(6, 72);
            this.buttonPASS.Name = "buttonPASS";
            this.buttonPASS.Size = new System.Drawing.Size(103, 56);
            this.buttonPASS.TabIndex = 0;
            this.buttonPASS.Text = "PASS";
            this.buttonPASS.UseVisualStyleBackColor = false;
            this.buttonPASS.Click += new System.EventHandler(this.buttonPASS_Click);
            // 
            // buttonFAIL
            // 
            this.buttonFAIL.BackColor = System.Drawing.Color.Red;
            this.buttonFAIL.Location = new System.Drawing.Point(290, 72);
            this.buttonFAIL.Name = "buttonFAIL";
            this.buttonFAIL.Size = new System.Drawing.Size(103, 56);
            this.buttonFAIL.TabIndex = 1;
            this.buttonFAIL.Text = "FAIL";
            this.buttonFAIL.UseVisualStyleBackColor = false;
            this.buttonFAIL.Click += new System.EventHandler(this.buttonFAIL_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.textBoxRunin);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1055, 587);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "RUNIN";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRuninFAIL);
            this.groupBox2.Controls.Add(this.buttonRuninPASS);
            this.groupBox2.Location = new System.Drawing.Point(306, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Runnin Result";
            // 
            // buttonRuninFAIL
            // 
            this.buttonRuninFAIL.BackColor = System.Drawing.Color.Red;
            this.buttonRuninFAIL.Location = new System.Drawing.Point(287, 22);
            this.buttonRuninFAIL.Name = "buttonRuninFAIL";
            this.buttonRuninFAIL.Size = new System.Drawing.Size(103, 56);
            this.buttonRuninFAIL.TabIndex = 1;
            this.buttonRuninFAIL.Text = "FAIL";
            this.buttonRuninFAIL.UseVisualStyleBackColor = false;
            this.buttonRuninFAIL.Click += new System.EventHandler(this.buttonRuninFAIL_Click);
            // 
            // buttonRuninPASS
            // 
            this.buttonRuninPASS.BackColor = System.Drawing.Color.Green;
            this.buttonRuninPASS.Location = new System.Drawing.Point(6, 23);
            this.buttonRuninPASS.Name = "buttonRuninPASS";
            this.buttonRuninPASS.Size = new System.Drawing.Size(103, 56);
            this.buttonRuninPASS.TabIndex = 0;
            this.buttonRuninPASS.Text = "PASS";
            this.buttonRuninPASS.UseVisualStyleBackColor = false;
            this.buttonRuninPASS.Click += new System.EventHandler(this.buttonRuninPASS_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "RUNIN Process";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "TRACK-ID";
            // 
            // textBoxRunin
            // 
            this.textBoxRunin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRunin.Location = new System.Drawing.Point(420, 53);
            this.textBoxRunin.MaxLength = 10;
            this.textBoxRunin.Multiline = true;
            this.textBoxRunin.Name = "textBoxRunin";
            this.textBoxRunin.Size = new System.Drawing.Size(190, 41);
            this.textBoxRunin.TabIndex = 14;
            // 
            // comboBoxProcessProduct
            // 
            this.comboBoxProcessProduct.FormattingEnabled = true;
            this.comboBoxProcessProduct.Location = new System.Drawing.Point(21, 73);
            this.comboBoxProcessProduct.Name = "comboBoxProcessProduct";
            this.comboBoxProcessProduct.Size = new System.Drawing.Size(154, 21);
            this.comboBoxProcessProduct.TabIndex = 14;
            // 
            // labelPProduct
            // 
            this.labelPProduct.AutoSize = true;
            this.labelPProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPProduct.Location = new System.Drawing.Point(17, 53);
            this.labelPProduct.Name = "labelPProduct";
            this.labelPProduct.Size = new System.Drawing.Size(79, 16);
            this.labelPProduct.TabIndex = 13;
            this.labelPProduct.Text = "PRODUTO:";
            // 
            // comboBoxBuild
            // 
            this.comboBoxBuild.FormattingEnabled = true;
            this.comboBoxBuild.Items.AddRange(new object[] {
            "DVT",
            "PVT"});
            this.comboBoxBuild.Location = new System.Drawing.Point(186, 73);
            this.comboBoxBuild.Name = "comboBoxBuild";
            this.comboBoxBuild.Size = new System.Drawing.Size(75, 21);
            this.comboBoxBuild.TabIndex = 16;
            // 
            // labelBuild
            // 
            this.labelBuild.AutoSize = true;
            this.labelBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuild.Location = new System.Drawing.Point(182, 53);
            this.labelBuild.Name = "labelBuild";
            this.labelBuild.Size = new System.Drawing.Size(50, 16);
            this.labelBuild.TabIndex = 15;
            this.labelBuild.Text = "BUILD:";
            // 
            // comboBoxAREA
            // 
            this.comboBoxAREA.FormattingEnabled = true;
            this.comboBoxAREA.Items.AddRange(new object[] {
            "SMT",
            "PROCESSO",
            "PRODUTO",
            "TESTE",
            "CQA",
            "CQA2",
            "RUNNIN",
            "FALHA"});
            this.comboBoxAREA.Location = new System.Drawing.Point(276, 73);
            this.comboBoxAREA.Name = "comboBoxAREA";
            this.comboBoxAREA.Size = new System.Drawing.Size(85, 21);
            this.comboBoxAREA.TabIndex = 18;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(272, 53);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(48, 16);
            this.labelArea.TabIndex = 17;
            this.labelArea.Text = "AREA:";
            // 
            // bmecFlowDataSet
            // 
            this.bmecFlowDataSet.DataSetName = "BmecFlowDataSet";
            this.bmecFlowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bFlowBindingSource
            // 
            this.bFlowBindingSource.DataMember = "BFlow";
            this.bFlowBindingSource.DataSource = this.bmecFlowDataSet;
            // 
            // bFlowTableAdapter
            // 
            this.bFlowTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // trackidDataGridViewTextBoxColumn
            // 
            this.trackidDataGridViewTextBoxColumn.DataPropertyName = "Trackid";
            this.trackidDataGridViewTextBoxColumn.HeaderText = "Trackid";
            this.trackidDataGridViewTextBoxColumn.Name = "trackidDataGridViewTextBoxColumn";
            // 
            // iFLASHDataGridViewTextBoxColumn
            // 
            this.iFLASHDataGridViewTextBoxColumn.DataPropertyName = "IFLASH";
            this.iFLASHDataGridViewTextBoxColumn.HeaderText = "IFLASH";
            this.iFLASHDataGridViewTextBoxColumn.Name = "iFLASHDataGridViewTextBoxColumn";
            // 
            // brdTestDataGridViewTextBoxColumn
            // 
            this.brdTestDataGridViewTextBoxColumn.DataPropertyName = "BrdTest";
            this.brdTestDataGridViewTextBoxColumn.HeaderText = "BrdTest";
            this.brdTestDataGridViewTextBoxColumn.Name = "brdTestDataGridViewTextBoxColumn";
            // 
            // t5GFR1BdTstDataGridViewTextBoxColumn
            // 
            this.t5GFR1BdTstDataGridViewTextBoxColumn.DataPropertyName = "T5GFR1BdTst";
            this.t5GFR1BdTstDataGridViewTextBoxColumn.HeaderText = "T5GFR1BdTst";
            this.t5GFR1BdTstDataGridViewTextBoxColumn.Name = "t5GFR1BdTstDataGridViewTextBoxColumn";
            // 
            // pRINTLABELDataGridViewTextBoxColumn
            // 
            this.pRINTLABELDataGridViewTextBoxColumn.DataPropertyName = "PRINTLABEL";
            this.pRINTLABELDataGridViewTextBoxColumn.HeaderText = "PRINTLABEL";
            this.pRINTLABELDataGridViewTextBoxColumn.Name = "pRINTLABELDataGridViewTextBoxColumn";
            // 
            // uCTDataGridViewTextBoxColumn
            // 
            this.uCTDataGridViewTextBoxColumn.DataPropertyName = "UCT";
            this.uCTDataGridViewTextBoxColumn.HeaderText = "UCT";
            this.uCTDataGridViewTextBoxColumn.Name = "uCTDataGridViewTextBoxColumn";
            // 
            // fODTESTDataGridViewTextBoxColumn
            // 
            this.fODTESTDataGridViewTextBoxColumn.DataPropertyName = "FODTEST";
            this.fODTESTDataGridViewTextBoxColumn.HeaderText = "FODTEST";
            this.fODTESTDataGridViewTextBoxColumn.Name = "fODTESTDataGridViewTextBoxColumn";
            // 
            // l2VISIONDataGridViewTextBoxColumn
            // 
            this.l2VISIONDataGridViewTextBoxColumn.DataPropertyName = "L2VISION";
            this.l2VISIONDataGridViewTextBoxColumn.HeaderText = "L2VISION";
            this.l2VISIONDataGridViewTextBoxColumn.Name = "l2VISIONDataGridViewTextBoxColumn";
            // 
            // radioSlimDataGridViewTextBoxColumn
            // 
            this.radioSlimDataGridViewTextBoxColumn.DataPropertyName = "RadioSlim";
            this.radioSlimDataGridViewTextBoxColumn.HeaderText = "RadioSlim";
            this.radioSlimDataGridViewTextBoxColumn.Name = "radioSlimDataGridViewTextBoxColumn";
            // 
            // lCDCALDataGridViewTextBoxColumn
            // 
            this.lCDCALDataGridViewTextBoxColumn.DataPropertyName = "LCDCAL";
            this.lCDCALDataGridViewTextBoxColumn.HeaderText = "LCDCAL";
            this.lCDCALDataGridViewTextBoxColumn.Name = "lCDCALDataGridViewTextBoxColumn";
            // 
            // l2ARDataGridViewTextBoxColumn
            // 
            this.l2ARDataGridViewTextBoxColumn.DataPropertyName = "L2AR";
            this.l2ARDataGridViewTextBoxColumn.HeaderText = "L2AR";
            this.l2ARDataGridViewTextBoxColumn.Name = "l2ARDataGridViewTextBoxColumn";
            // 
            // sQTDataGridViewTextBoxColumn
            // 
            this.sQTDataGridViewTextBoxColumn.DataPropertyName = "SQT";
            this.sQTDataGridViewTextBoxColumn.HeaderText = "SQT";
            this.sQTDataGridViewTextBoxColumn.Name = "sQTDataGridViewTextBoxColumn";
            // 
            // depthCalDataGridViewTextBoxColumn
            // 
            this.depthCalDataGridViewTextBoxColumn.DataPropertyName = "DepthCal";
            this.depthCalDataGridViewTextBoxColumn.HeaderText = "DepthCal";
            this.depthCalDataGridViewTextBoxColumn.Name = "depthCalDataGridViewTextBoxColumn";
            // 
            // depthValDataGridViewTextBoxColumn
            // 
            this.depthValDataGridViewTextBoxColumn.DataPropertyName = "DepthVal";
            this.depthValDataGridViewTextBoxColumn.HeaderText = "DepthVal";
            this.depthValDataGridViewTextBoxColumn.Name = "depthValDataGridViewTextBoxColumn";
            // 
            // cameraSOISDataGridViewTextBoxColumn
            // 
            this.cameraSOISDataGridViewTextBoxColumn.DataPropertyName = "Camera_SOIS";
            this.cameraSOISDataGridViewTextBoxColumn.HeaderText = "Camera_SOIS";
            this.cameraSOISDataGridViewTextBoxColumn.Name = "cameraSOISDataGridViewTextBoxColumn";
            // 
            // aCTDataGridViewTextBoxColumn
            // 
            this.aCTDataGridViewTextBoxColumn.DataPropertyName = "ACT";
            this.aCTDataGridViewTextBoxColumn.HeaderText = "ACT";
            this.aCTDataGridViewTextBoxColumn.Name = "aCTDataGridViewTextBoxColumn";
            // 
            // tOFDataGridViewTextBoxColumn
            // 
            this.tOFDataGridViewTextBoxColumn.DataPropertyName = "TOF";
            this.tOFDataGridViewTextBoxColumn.HeaderText = "TOF";
            this.tOFDataGridViewTextBoxColumn.Name = "tOFDataGridViewTextBoxColumn";
            // 
            // cFCDataGridViewTextBoxColumn
            // 
            this.cFCDataGridViewTextBoxColumn.DataPropertyName = "CFC";
            this.cFCDataGridViewTextBoxColumn.HeaderText = "CFC";
            this.cFCDataGridViewTextBoxColumn.Name = "cFCDataGridViewTextBoxColumn";
            // 
            // cQADataGridViewTextBoxColumn
            // 
            this.cQADataGridViewTextBoxColumn.DataPropertyName = "CQA";
            this.cQADataGridViewTextBoxColumn.HeaderText = "CQA";
            this.cQADataGridViewTextBoxColumn.Name = "cQADataGridViewTextBoxColumn";
            // 
            // cQA2DataGridViewTextBoxColumn
            // 
            this.cQA2DataGridViewTextBoxColumn.DataPropertyName = "CQA2";
            this.cQA2DataGridViewTextBoxColumn.HeaderText = "CQA2";
            this.cQA2DataGridViewTextBoxColumn.Name = "cQA2DataGridViewTextBoxColumn";
            // 
            // rUNNINDataGridViewTextBoxColumn
            // 
            this.rUNNINDataGridViewTextBoxColumn.DataPropertyName = "RUNNIN";
            this.rUNNINDataGridViewTextBoxColumn.HeaderText = "RUNNIN";
            this.rUNNINDataGridViewTextBoxColumn.Name = "rUNNINDataGridViewTextBoxColumn";
            // 
            // bEDataGridViewTextBoxColumn
            // 
            this.bEDataGridViewTextBoxColumn.DataPropertyName = "BE";
            this.bEDataGridViewTextBoxColumn.HeaderText = "BE";
            this.bEDataGridViewTextBoxColumn.Name = "bEDataGridViewTextBoxColumn";
            // 
            // cQAOBSDataGridViewTextBoxColumn
            // 
            this.cQAOBSDataGridViewTextBoxColumn.DataPropertyName = "CQAOBS";
            this.cQAOBSDataGridViewTextBoxColumn.HeaderText = "CQAOBS";
            this.cQAOBSDataGridViewTextBoxColumn.Name = "cQAOBSDataGridViewTextBoxColumn";
            // 
            // fAILDETAILSDataGridViewTextBoxColumn
            // 
            this.fAILDETAILSDataGridViewTextBoxColumn.DataPropertyName = "FAILDETAILS";
            this.fAILDETAILSDataGridViewTextBoxColumn.HeaderText = "FAILDETAILS";
            this.fAILDETAILSDataGridViewTextBoxColumn.Name = "fAILDETAILSDataGridViewTextBoxColumn";
            // 
            // comboBoxCQA
            // 
            this.comboBoxCQA.FormattingEnabled = true;
            this.comboBoxCQA.Items.AddRange(new object[] {
            "CQA",
            "CQA2"});
            this.comboBoxCQA.Location = new System.Drawing.Point(171, 19);
            this.comboBoxCQA.Name = "comboBoxCQA";
            this.comboBoxCQA.Size = new System.Drawing.Size(59, 21);
            this.comboBoxCQA.TabIndex = 2;
            this.comboBoxCQA.Text = "CQA";
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(21, 101);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFolder.TabIndex = 19;
            this.buttonOpenFolder.Text = "Open Folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textBoxFailDetails);
            this.tabPage6.Controls.Add(this.buttonInserirFDetails);
            this.tabPage6.Controls.Add(this.labelDetalhesFail);
            this.tabPage6.Controls.Add(this.labelFDetails);
            this.tabPage6.Controls.Add(this.labelFAILDetail);
            this.tabPage6.Controls.Add(this.textBoxFailDetailTrackid);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1055, 587);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "FAIL DETAILS";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // labelFAILDetail
            // 
            this.labelFAILDetail.AutoSize = true;
            this.labelFAILDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFAILDetail.Location = new System.Drawing.Point(478, 32);
            this.labelFAILDetail.Name = "labelFAILDetail";
            this.labelFAILDetail.Size = new System.Drawing.Size(77, 18);
            this.labelFAILDetail.TabIndex = 8;
            this.labelFAILDetail.Text = "TRACK-ID";
            // 
            // textBoxFailDetailTrackid
            // 
            this.textBoxFailDetailTrackid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFailDetailTrackid.Location = new System.Drawing.Point(420, 53);
            this.textBoxFailDetailTrackid.MaxLength = 10;
            this.textBoxFailDetailTrackid.Multiline = true;
            this.textBoxFailDetailTrackid.Name = "textBoxFailDetailTrackid";
            this.textBoxFailDetailTrackid.Size = new System.Drawing.Size(190, 41);
            this.textBoxFailDetailTrackid.TabIndex = 9;
            // 
            // labelFDetails
            // 
            this.labelFDetails.AutoSize = true;
            this.labelFDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFDetails.ForeColor = System.Drawing.Color.Teal;
            this.labelFDetails.Location = new System.Drawing.Point(3, 3);
            this.labelFDetails.Name = "labelFDetails";
            this.labelFDetails.Size = new System.Drawing.Size(174, 33);
            this.labelFDetails.TabIndex = 16;
            this.labelFDetails.Text = "FAIL Details";
            // 
            // buttonInserirFDetails
            // 
            this.buttonInserirFDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserirFDetails.Location = new System.Drawing.Point(468, 400);
            this.buttonInserirFDetails.Name = "buttonInserirFDetails";
            this.buttonInserirFDetails.Size = new System.Drawing.Size(96, 39);
            this.buttonInserirFDetails.TabIndex = 19;
            this.buttonInserirFDetails.Text = "Inserir";
            this.buttonInserirFDetails.UseVisualStyleBackColor = true;
            this.buttonInserirFDetails.Click += new System.EventHandler(this.buttonInserirFDetails_Click);
            // 
            // labelDetalhesFail
            // 
            this.labelDetalhesFail.AutoSize = true;
            this.labelDetalhesFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalhesFail.Location = new System.Drawing.Point(16, 156);
            this.labelDetalhesFail.Name = "labelDetalhesFail";
            this.labelDetalhesFail.Size = new System.Drawing.Size(166, 24);
            this.labelDetalhesFail.TabIndex = 17;
            this.labelDetalhesFail.Text = "Detalhes da Falha:";
            // 
            // textBoxFailDetails
            // 
            this.textBoxFailDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFailDetails.Location = new System.Drawing.Point(21, 183);
            this.textBoxFailDetails.Multiline = true;
            this.textBoxFailDetails.Name = "textBoxFailDetails";
            this.textBoxFailDetails.Size = new System.Drawing.Size(1010, 211);
            this.textBoxFailDetails.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Descrições / Restrições:";
            // 
            // textBoxOBSCQA
            // 
            this.textBoxOBSCQA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOBSCQA.Location = new System.Drawing.Point(51, 418);
            this.textBoxOBSCQA.Multiline = true;
            this.textBoxOBSCQA.Name = "textBoxOBSCQA";
            this.textBoxOBSCQA.Size = new System.Drawing.Size(929, 46);
            this.textBoxOBSCQA.TabIndex = 13;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.buttonOFolder2);
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Controls.Add(this.buttonRestrictionUnits);
            this.tabPage7.Controls.Add(this.textBoxRestrictionUnits);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1055, 587);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "RESTRICTIONS";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // textBoxRestrictionUnits
            // 
            this.textBoxRestrictionUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRestrictionUnits.Location = new System.Drawing.Point(53, 117);
            this.textBoxRestrictionUnits.Multiline = true;
            this.textBoxRestrictionUnits.Name = "textBoxRestrictionUnits";
            this.textBoxRestrictionUnits.Size = new System.Drawing.Size(940, 442);
            this.textBoxRestrictionUnits.TabIndex = 12;
            // 
            // buttonRestrictionUnits
            // 
            this.buttonRestrictionUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestrictionUnits.Location = new System.Drawing.Point(53, 72);
            this.buttonRestrictionUnits.Name = "buttonRestrictionUnits";
            this.buttonRestrictionUnits.Size = new System.Drawing.Size(96, 39);
            this.buttonRestrictionUnits.TabIndex = 13;
            this.buttonRestrictionUnits.Text = "Buscar";
            this.buttonRestrictionUnits.UseVisualStyleBackColor = true;
            this.buttonRestrictionUnits.Click += new System.EventHandler(this.buttonRestrictionUnits_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "Restriction Units";
            // 
            // buttonOFolder2
            // 
            this.buttonOFolder2.Location = new System.Drawing.Point(918, 88);
            this.buttonOFolder2.Name = "buttonOFolder2";
            this.buttonOFolder2.Size = new System.Drawing.Size(75, 23);
            this.buttonOFolder2.TabIndex = 20;
            this.buttonOFolder2.Text = "Open Folder";
            this.buttonOFolder2.UseVisualStyleBackColor = true;
            this.buttonOFolder2.Click += new System.EventHandler(this.buttonOFolder2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 637);
            this.Controls.Add(this.tabControlApp);
            this.Controls.Add(this.label2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BmecFlow v1.2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.tabControlApp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApp)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bmecFlowDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bFlowBindingSource)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelAppName;
        private System.Windows.Forms.ComboBox comboBoxStationType;
        private System.Windows.Forms.Label labelStationType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTrackID;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonBkp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TabControl tabControlApp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelRouteStatus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxRouteBE;
        private System.Windows.Forms.ComboBox comboBoxRouteME;
        private System.Windows.Forms.Label labelBE;
        private System.Windows.Forms.Label labelME;
        private System.Windows.Forms.Label labelRouteConfig;
        private System.Windows.Forms.Button buttonROUTESave;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonObs;
        private System.Windows.Forms.Label labelPInfos;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.Label labelOBSTRACKID;
        private System.Windows.Forms.TextBox textBoxOBSTrackId;
        private System.Windows.Forms.DataGridView dataGridViewApp;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.TextBox textBoxTrackIdProcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTracking;
        private System.Windows.Forms.TextBox textBoxTrackingInfos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFAIL;
        private System.Windows.Forms.Button buttonPASS;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRuninFAIL;
        private System.Windows.Forms.Button buttonRuninPASS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRunin;
        private System.Windows.Forms.ComboBox comboBoxProcessProduct;
        private System.Windows.Forms.Label labelPProduct;
        private System.Windows.Forms.ComboBox comboBoxAREA;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.ComboBox comboBoxBuild;
        private System.Windows.Forms.Label labelBuild;
        private BmecFlowDataSet bmecFlowDataSet;
        private System.Windows.Forms.BindingSource bFlowBindingSource;
        private BmecFlowDataSetTableAdapters.BFlowTableAdapter bFlowTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iFLASHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brdTestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5GFR1BdTstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRINTLABELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fODTESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn l2VISIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radioSlimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCDCALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn l2ARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sQTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthCalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthValDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cameraSOISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQA2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUNNINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQAOBSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAILDETAILSDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxCQA;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBoxFailDetails;
        private System.Windows.Forms.Button buttonInserirFDetails;
        private System.Windows.Forms.Label labelDetalhesFail;
        private System.Windows.Forms.Label labelFDetails;
        private System.Windows.Forms.Label labelFAILDetail;
        private System.Windows.Forms.TextBox textBoxFailDetailTrackid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOBSCQA;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textBoxRestrictionUnits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRestrictionUnits;
        private System.Windows.Forms.Button buttonOFolder2;
    }
}

