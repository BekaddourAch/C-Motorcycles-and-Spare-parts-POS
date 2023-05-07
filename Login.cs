using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.IO;

namespace Disdriver
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }
        String host = "", port = "", db = "", user = "", password = "";
        private void Login_Load(object sender, EventArgs e)
        {
            txtUserName.Focus()  ;
            if (!File.Exists("config.xml"))
            {
                new XDocument(
                       new XElement("config",
                           new XElement("host", "127.0.0.1"),
                           new XElement("port", "3306"),
                           new XElement("db", "desertriders"),
                           new XElement("user", "root"),
                           new XElement("password", "")
                       )
                    )
                    .Save("config.xml");
            }

            getData();
            checkDB_Conn( host,  port,  db,  user, password);

        }
        public void getData()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");
            XPathNavigator navigator = doc.CreateNavigator();

            host = GetStringValues("", navigator, "/config/host");
            port = GetStringValues("", navigator, "/config/port");
            db = GetStringValues("", navigator, "/config/db");
            user = GetStringValues("", navigator, "/config/user");
            password = GetStringValues("", navigator, "/config/password");
        }
        private static string GetStringValues(string description,
                              XPathNavigator navigator, string xpath)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(description);
            XPathNodeIterator bookNodesIterator = navigator.Select(xpath);
            while (bookNodesIterator.MoveNext())
                sb.Append(string.Format("{0}", bookNodesIterator.Current.Value));
            return sb.ToString();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                simpleButton1_Click(sender, new EventArgs());
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Server_Status frmLogin = new Server_Status();
            frmLogin.ShowDialog();
        }

        public void checkDB_Conn(String host, String port, String db, String user, String password)
        {


            var conn_info = "server = " + host + ";port=" + port + ";  database =" + db + ";user id = " + user + ";password=" + password + "; CHARSET = utf8; Convert Zero Datetime = True";
            bool isConn = false;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(conn_info);
                conn.Open();
                isConn = true;

                if (isConn)
                {
                    //lblStatus.Text = "Server Is Running";
                   
                        Properties.Settings.Default.host = host;
                        Properties.Settings.Default.port = port;
                        Properties.Settings.Default.db = db;
                        Properties.Settings.Default.username = user;
                        Properties.Settings.Default.password = password;
                        Properties.Settings.Default.Save();
                        //MessageBox.Show("Server has been connected sucessfully ! ", "");
                   
                }
                else
                {
                     
                    MessageBox.Show("Server Off ! "  ,"Warning");

                }
            }
            catch (ArgumentException a_ex)
            {
                MessageBox.Show("Check the Connection ! " + " " + a_ex.Message + " " + a_ex.ToString(), "Warning");
                /*
                Console.WriteLine("Check the Connection String.");
                Console.WriteLine(a_ex.Message);
                Console.WriteLine(a_ex.ToString());
                */
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Check the Connection ! sqlErrorMessage : " + ex.Message + " " + ex.Source + " " + ex.Number, "Warning");
                /*string sqlErrorMessage = "Message: " + ex.Message + "\n" +
                "Source: " + ex.Source + "\n" +
                "Number: " + ex.Number;
                Console.WriteLine(sqlErrorMessage);
                */
                isConn = false;
                switch (ex.Number)
                {
                    //http://dev.mysql.com/doc/refman/5.0/en/error-messages-server.html
                    case 1042: // Unable to connect to any of the specified MySQL hosts (Check Server,Port)
                        break;
                    case 0: // Access denied (Check DB name,username,password)
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    // conn.Close();

                }
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var cs = "server = " + Properties.Settings.Default.host 
                + ";port=" + Properties.Settings.Default.port 
                + ";  database =" + Properties.Settings.Default.db 
                + ";user id = " + Properties.Settings.Default.username 
                + ";password=" + Properties.Settings.Default.password 
                + "; CHARSET = utf8; Convert Zero Datetime = True";
            //MessageBox.Show("server = " + Properties.Settings.Default.host
            //    + ";port=" + Properties.Settings.Default.port
            //    + ";  database =" + Properties.Settings.Default.db
            //    + ";user id = " + Properties.Settings.Default.username
            //    + ";password=" + Properties.Settings.Default.password
            //    + "; CHARSET = utf8; Convert Zero Datetime = True" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //String cs = @"Data Source=(LocalDB)v11.0;Integrated Security=True;  AttachDbFilename=|DataDirectory|Login.mdf; Connect Timeout=30";
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            try
            {
                MySqlConnection myConnection = default(MySqlConnection);
                myConnection = new MySqlConnection(cs);

                MySqlCommand myCommand = default(MySqlCommand);
                 
                myCommand = new MySqlCommand("SELECT id, UsrName,Password FROM users WHERE UsrName = @Username AND Password = @Password", myConnection);

                MySqlParameter uName = new MySqlParameter("@Username", MySqlDbType.VarChar);
                MySqlParameter uPassword = new MySqlParameter("@Password", MySqlDbType.VarChar);

                uName.Value = txtUserName.Text;
                uPassword.Value = CreateMD5(txtPassword.Text);

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                MySqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    //MessageBox.Show("You have logged in successfully " + txtUserName.Text);
                    //Hide the login form
                    Properties.Settings.Default.userID= myReader.GetString(0);
                    Properties.Settings.Default.userPseudo = txtUserName.Text;
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }


                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

    }
}
