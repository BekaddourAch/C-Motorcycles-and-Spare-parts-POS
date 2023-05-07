using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms; 
namespace Disdriver
{
    class Database
    {
        //Connection To DataBase
                        // Properties.Settings.Default.host 
                        //Properties.Settings.Default.port 
                        //Properties.Settings.Default.db  
                        //Properties.Settings.Default.username  
                        //Properties.Settings.Default.password  
        MySqlConnection conn = new MySqlConnection("server = " + Properties.Settings.Default.host + ";port=" + Properties.Settings.Default.port + ";  database =" + Properties.Settings.Default.db + ";user id = " + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password + "; CHARSET=utf8;Convert Zero Datetime=True");
        MySqlCommand cmd = new MySqlCommand();
        string file = "G:\\desert report\\backupfile\\backup.sql";
        public void backup(string file)
        {
            using (conn)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
            //System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            //psi.FileName = @"C:\xampp\mysql\bin\mysql.exe";
            //psi.RedirectStandardInput = true;
            //psi.RedirectStandardOutput = false;
            //psi.CreateNoWindow = true;
            //psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", "root", "password", "localhost", "your_dbname");
            //psi.UseShellExecute = false;
            //System.Diagnostics.Process process = System.Diagnostics.Process.Start(psi);
            //process.StandardInput.Write(System.IO.File.ReadAllText(file));
            //process.StandardInput.Close();
            //process.WaitForExit();
            //process.Close();
        }
        public void restore(string file)
        {
            using (conn)
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                    }
                }
            }
        }
       
        //Read Data From DataBase
        public DataTable readData(string stmt, string msg)
        {
            try
            {
                DataTable tbl = new DataTable();
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                tbl.Load(cmd.ExecuteReader());
                conn.Close();
                if (msg != "")
                {
                    MessageBox.Show(msg, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return tbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                 conn.Close();
            }
        }

        // Insert Update Delete
        public bool executeData(string stmt, string msg)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if (msg != "")
                {
                    MessageBox.Show(msg, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        public DataSet getResults(string sql)
        {
            string connectionString = null;

            conn.Open();

            MySqlDataAdapter dscmd = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds, "v_sales");
            // MessageBox.Show(ds.Tables[1].Rows.Count.ToString());
            conn.Close();

            //            String connString = @"Provider=Microsoft.Jet.OLEDB.4.0;_
            //	Data Source=..\\..\\myDB.mdb;User ID=Admin;Password=";

            //            OleDbConnection Oconn = new OleDbConnection(connString);
            //            Oconn.Open();

            //OleDbDataAdapter oleDA = new OleDbDataAdapter(sql, Oconn);
            //            OleDbDataAdapter myDataAdapter = DBConn.getDataFromDB();

            //            // use the created Dataset to fill it with data got
            //            // from the DB by using the DataAdapter
            //            DataSet dataReport = new DataSet();
            //            myDataAdapter.Fill(dataReport, "facturedata");
            //            // create a new report from the created CrystalReport
            //            myDataReport myDataReport = new myDataReport();

            //            // set the data source of the report
            //            myDataReport.SetDataSource(dataReport);

            return ds;
        }
    }
}
