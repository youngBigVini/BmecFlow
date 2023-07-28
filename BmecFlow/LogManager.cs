using System.IO;

namespace BmecFlow
{
    class LogManager
    {
        string pathName = @"Q:\quality_data\test_results";
        string strLogPattern = "*.rslt*";


        SQLManager sqlManager = new SQLManager();

        protected virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                return true;
            }
            //file is not locked
            return false;
        }
        public void getPatternAndWriteToDB(string line)
        {
            string[] tempSplit = line.Split(',');
            string logTrackId = tempSplit[1];
            string stationType = tempSplit[4];
            string passFail = tempSplit[9];

            sqlManager.InsertToMdb(logTrackId, stationType, passFail);
        }

        public void getLogResult()
        {
            FileInfo fileInfoMQS;
            try
            {
                foreach (string file_name in Directory.GetFiles(pathName, strLogPattern, SearchOption.TopDirectoryOnly))
                {
                    fileInfoMQS = new FileInfo(file_name);
                    if (!IsFileLocked(fileInfoMQS))
                    {
                        using (var reader = new StreamReader(file_name))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (line.Contains("TH4") && !line.Contains("LEAK"))
                                    getPatternAndWriteToDB(line);
                            }
                        }
                    }
                }
            }
            catch
            { }
        }

    }
}
