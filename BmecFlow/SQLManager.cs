﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BmecFlow
{
    class SQLManager
    {
        string dbConnection = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = X:\DC\BmecFlow\db\BmecFlow.mdb";
        public void InsertToMdb(string trackID, string stationType, string result)
        {
            bool status = false;
            try
            {
                status = DoesTrackIDExist(trackID);
                var con = new OleDbConnection(dbConnection);
                var cmd = new OleDbCommand();
                cmd.Connection = con;
                if (!status)
                {
                    cmd.CommandText = "INSERT INTO BFlow (Trackid, [" + stationType + "])  VALUES (" + trackID + ", " + result + ");";
                    cmd.Parameters.AddWithValue("@Trackid", trackID);
                    cmd.Parameters.AddWithValue(stationType, result);
                }
                else
                {
                    cmd.Parameters.AddWithValue(stationType, result);
                    cmd.CommandText = "UPDATE BFlow SET " + stationType + " = " + result + " Where Trackid = '" + trackID + "'";
                }
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }

        }
        private bool DoesTrackIDExist(string trackID)
        {
            bool result = false;
            DataTable dtTemp = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(dbConnection))
            {
                string sql = @"SELECT * FROM BFlow WHERE Trackid = " + trackID + "";
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.Add(new OleDbParameter("@Trackid", trackID));
                    using (OleDbDataAdapter oAdapter = new OleDbDataAdapter(command))
                    {
                        try
                        {
                            oAdapter.Fill(dtTemp);
                            if (dtTemp != null && dtTemp.Rows.Count > 0)
                                result = true;
                        }
                        catch
                        { }
                    }
                }
            }
            return result;
        }
        public bool InsertObstoDb(string trackID, string observ)
        {
            bool status = false;
            bool result = false;
            try
            {
                status = DoesTrackIDExist(trackID);
                var con = new OleDbConnection(dbConnection);
                var cmd = new OleDbCommand();
                cmd.Connection = con;
                if (!status)
                {
                    cmd.CommandText = "INSERT INTO BFlow (Trackid, CQAOBS)  VALUES (" + trackID + ", " + observ + ");";
                    cmd.Parameters.AddWithValue("@Trackid", trackID);
                    cmd.Parameters.AddWithValue("@CQAOBS", observ);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CQAOBS", observ);
                    cmd.CommandText = "UPDATE BFlow SET CQAOBS = '" + observ + "' Where Trackid = '" + trackID + "'";
                }
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Application.DoEvents();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
                result = false;
            }
            return result;

        }
        public bool InsertFailDetailsToDb(string trackID, string failDetail)
        {
            bool status = false;
            bool result = false;
            try
            {
                status = DoesTrackIDExist(trackID);
                var con = new OleDbConnection(dbConnection);
                var cmd = new OleDbCommand();
                cmd.Connection = con;
                if (!status)
                {
                    cmd.CommandText = "INSERT INTO BFlow (Trackid, FAILDETAILS)  VALUES (" + trackID + ", " + failDetail + ");";
                    cmd.Parameters.AddWithValue("@Trackid", trackID);
                    cmd.Parameters.AddWithValue("@FAILDETAILS", failDetail);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FAILDETAILS", failDetail);
                    cmd.CommandText = "UPDATE BFlow SET FAILDETAILS = '" + failDetail + "' Where Trackid = '" + trackID + "'";
                }
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Application.DoEvents();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
                result = false;
            }
            return result;

        }

        public bool CheckRouteStatus(string trackID, string stationType)
        {
            bool result = false;
            string queryStatus = "SELECT " + stationType + " FROM BFlow WHERE Trackid = " + trackID + " AND " + stationType + " = P";
            using (OleDbConnection connection = new OleDbConnection(dbConnection))
            {
                OleDbCommand command = new OleDbCommand(queryStatus, connection);
                command.Parameters.AddWithValue("Trackid", trackID);
                command.Parameters.AddWithValue(stationType, "P");

                try
                {
                    connection.Open();
                    object resultado = command.ExecuteScalar();
                    if (resultado != null)
                        result = true;
                    else
                        result = false;
                }
                catch (Exception ex)
                {
                    string temp = ex.ToString();
                    result = false;
                }
                return result;
            }
        }
        public void exportDbToCsv()
        {

        }
    }
}
