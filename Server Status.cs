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
using MySql.Data.MySqlClient;
//using Microsoft.WindowsAPICodePack.Shell;
//using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;

namespace Disdriver
{
    public partial class Server_Status : DevExpress.XtraEditors.XtraForm
    {
        public Server_Status()
        {
            InitializeComponent();
        }
        String host="", port="",db="",user="" , password="";
        private void Server_Status_Load(object sender, EventArgs e)
        { getData();
            bool test = false;
            checkDB_Conn(host, port, db, user, password,test);
        }

        public void getData()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");
            XPathNavigator navigator = doc.CreateNavigator();

            host = GetStringValues("", navigator, "/config/host"); txtHost.Text = host;
            port = GetStringValues("", navigator, "/config/port"); txtPort.Text = port;
            db = GetStringValues("", navigator, "/config/db"); txtDB.Text = db;
            user = GetStringValues("", navigator, "/config/user"); txtUsrName.Text = user;
            password = GetStringValues("", navigator, "/config/password"); txtPwd.Text = password; 
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
        public  void checkDB_Conn(String host,String port,String db,String user,String password,bool test)
        {
 

            var conn_info = "server = "+ host + ";port="+ port + ";  database ="+ db + ";user id = "+ user + ";password="+ password + "; CHARSET = utf8; Convert Zero Datetime = True";
            bool isConn = false;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(conn_info);
                conn.Open();
                isConn = true;
                
                     if ( isConn)
                {
                    lblStatus.Text = "Server Is Running";
                    if (test)
                    {
                        MessageBox.Show("Server has been connected sucessfully ! ", "");
                    }
                }
                else
                {
                    lblStatus.Text = "Server Off";

                }
            }
            catch (ArgumentException a_ex)
            {
                MessageBox.Show("Check the Connection ! "+" "+ a_ex.Message +" "+ a_ex.ToString(), "Warning");
                /*
                Console.WriteLine("Check the Connection String.");
                Console.WriteLine(a_ex.Message);
                Console.WriteLine(a_ex.ToString());
                */
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Check the Connection ! sqlErrorMessage : "+ ex.Message +" " + ex.Source +" "+ ex.Number, "Warning");
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

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("config.xml");
            doc.Root.Element("host").Value = txtHost.Text;
            doc.Root.Element("port").Value = txtPort.Text;
            doc.Root.Element("db").Value = txtDB.Text;
            doc.Root.Element("user").Value = txtUsrName.Text;
            doc.Root.Element("password").Value = txtPwd.Text;
            doc.Save("config.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           bool test = true;
            checkDB_Conn(txtHost.Text, txtPort.Text, txtDB.Text, txtUsrName.Text, txtPwd.Text, test);
        }
    }
}