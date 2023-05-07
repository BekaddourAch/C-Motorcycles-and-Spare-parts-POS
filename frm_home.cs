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
using EasyTabs;
using System.Diagnostics;
using System.IO;

//using System.Net;
//using System.Net.Mail;


using Spire.Email; 
 using Spire.Email.IMap; 
 using Spire.Email.Smtp;
namespace Disdriver
{
    public partial class frm_home : DevExpress.XtraEditors.XtraForm
    {
        public Form1 frmMenu = new Form1();
        DataTable tbl = new DataTable();
        DataTable tbl1 = new DataTable();
        Database db = new Database();
        public frm_home()
        {
            InitializeComponent();
           
            setAutorisation(Properties.Settings.Default.userID);
            frmMenu.Refresh();
            getStatus(Properties.Settings.Default.userID);
            getStatistics();
            showInTable();
        }
        public void setAutorisation(String search)
        {
            tbl.Clear();
            tbl = db.readData("SELECT * FROM users where id = " + search, "");
            if (tbl.Rows.Count > 0)
            {
                try
                {
                    foreach (DataRow row in tbl.Rows)
                    {
                        tileItem8.Enabled = getBoolFromSTR(row["alow_achat"].ToString());

                        tileItem1.Enabled = getBoolFromSTR(row["alow_article"].ToString());
                        tileItem3.Enabled = getBoolFromSTR(row["alow_article"].ToString());

                       // tileItem7.Enabled = getBoolFromSTR(row["alow_vente"].ToString());
                        tileItem4.Enabled = getBoolFromSTR(row["alow_vente"].ToString());
                       // tileItem5.Enabled = getBoolFromSTR(row["alow_vente"].ToString());

                        btnOpenCloture.Enabled = getBoolFromSTR(row["alow_vente"].ToString()); 
                        btnCloseCloture.Enabled = getBoolFromSTR(row["alow_vente"].ToString());
                        tileItem2.Enabled = getBoolFromSTR(row["alow_fournisseur"].ToString());

                        tileItem6.Enabled = getBoolFromSTR(row["alow_client"].ToString());

                       
                    }
                }
                catch (Exception) { }
            }
        } private Boolean getBoolFromSTR(string word)
        {
            if (word == "True") { return true; } else { return false; }
        }
       
        private Boolean getVentAllowed(String iduser)
        {
            Boolean levar=false;
            tbl1.Clear();
            tbl1 = db.readData("SELECT alow_vente FROM users where id = " + iduser, "");
            if (tbl1.Rows.Count > 0)
            {
                levar = Convert.ToBoolean(tbl1.Rows[0][0].ToString());
            } 
             
            return levar;
        }
       
        public void getStatus(String iduser)
        {
            Boolean Cloture_Status=false;
            tileItem4.Enabled = false; tileItem5.Enabled = false; tileItem7.Enabled = false;
            frmMenu.btnSaleMenu.Enabled = false;
            frmMenu.btnRetour.Enabled = false;
            if (getVentAllowed(iduser))
            {
          // Cloture_Status = "";
            tbl1.Clear();
            tbl1 = db.readData("SELECT id,clotured FROM cloture ORDER BY id DESC LIMIT 1", "");
            if (tbl1.Rows.Count > 0)
            {
                    Cloture_Status = Convert.ToBoolean( tbl1.Rows[0][1].ToString() );
                 //MessageBox.Show("hhhh " + Cloture_Status);
                if (Cloture_Status)
                {
                    btnOpenCloture.Enabled = true;
                    btnCloseCloture.Enabled = false;
                    tileItem4.Enabled = false; tileItem5.Enabled = false; tileItem7.Enabled = false;
                        frmMenu.btnSaleMenu.Enabled = false;
                        frmMenu.btnRetour.Enabled = false;
                    }
                else  
                    {
                        btnOpenCloture.Enabled = false;
                        btnCloseCloture.Enabled = true;
                        tileItem4.Enabled = true; tileItem5.Enabled = true; tileItem7.Enabled = true;
                        frmMenu.btnSaleMenu.Enabled = true;
                        frmMenu.btnRetour.Enabled = true;
                    }
                   
            }
            else
            {
                    btnOpenCloture.Enabled = true;
                    btnCloseCloture.Enabled = false;
                    tileItem4.Enabled = false; tileItem5.Enabled = false; tileItem7.Enabled = false;
                    frmMenu.btnSaleMenu.Enabled = false;
                    frmMenu.btnRetour.Enabled = false;

                    //btnOpenCloture.Enabled = false;
                    // btnCloseCloture.Enabled = true;
                    //tileItem4.Enabled = true; tileItem5.Enabled = true; tileItem7.Enabled = true;
                    //frmMenu.btnSaleMenu.Enabled = true;
                    //frmMenu.btnRetour.Enabled = true;
                }
            }
 
        }
        public void getStatistics()
        {
            tbl.Clear();
            tbl = db.readData("select COUNT(id) from products", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            { tilArticles.Elements[1].Text = 0+"";  }
            else  {  tilArticles.Elements[1].Text = (Convert.ToInt32(tbl.Rows[0][0])  ).ToString();  }

            tbl.Clear();
            tbl = db.readData("select COUNT(id) from motos", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            { tilMotos.Elements[1].Text = 0 + ""; }
            else { tilMotos.Elements[1].Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString(); }

            tbl.Clear();
            tbl = db.readData("select COUNT(id) from clients", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            { tilClients.Elements[1].Text = 0 + ""; }
            else { tilClients.Elements[1].Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString(); }
            tbl.Clear();
            tbl = db.readData("select COUNT(id) from buy", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            { tileItem10.Elements[1].Text = 0 + ""; }
            else { tileItem10.Elements[1].Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString(); }
            tbl.Clear();
            tbl = db.readData("select COUNT(id) from sales", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            { tileVentes.Elements[1].Text = 0 + ""; }
            else { tileVentes.Elements[1].Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString(); }
            //tileVentes
        }
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            this.panel1.Controls.Clear();
            frm_products home = new frm_products()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }
             ;
            this.panel1.Controls.Add(home);
            home.Show(); home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            this.panel1.Controls.Clear();
            frm_motos moto = new frm_motos()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }
             ;
            this.panel1.Controls.Add(moto);
            moto.Show();
        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_clients frmCln = new frm_clients();
            frmCln.Show();
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_Fourns frmFourn = new frm_Fourns();
            frmFourn.Show();
        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_sales frmsales = new frm_sales(false);
            frmsales.Show();
        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_buy frmbuy = new frm_buy(false);
            frmbuy.edit=false;
            frmbuy.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_cloture cloturo = new frm_cloture();
            cloturo.homy = this;
            cloturo.open_Close_Caisse(false);
            cloturo.Show();
            
        }

        private void btnCloseCloture_Click(object sender, EventArgs e)
        {
            frm_cloture cloturo = new frm_cloture();
            cloturo.homy = this;
            cloturo.open_Close_Caisse(true);
            cloturo.Show();
            
        }

        private void frm_home_Load(object sender, EventArgs e)
        {

            //btnOpenCloture.Enabled = false;
            //btnCloseCloture.Enabled = false;
            //tileItem7.Enabled = false;
            
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {

            frm_Cashier container = new frm_Cashier();
             

            // Add the initial Tab
            container.Tabs.Add(
                // Our First Tab created by default in the Application will have as content the Form1
                new TitleBarTab(container)
                {
                    Content = new frm_sales_cash
                    {
                        Text = "New Tab"
                    }
                }
            );

            // Set initial tab the first one
            container.SelectedTabIndex = 0;

            //// Create tabs and start application
            //TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            //applicationContext.Start(container);
            //Application.Run(applicationContext);
             container.Show();
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_returns_ed frmreturn = new frm_returns_ed();
            frmreturn.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_agenda age = new frm_agenda();
            age.the_home_object = this;
            age.ShowDialog();
        }
        public void showInTable()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            tbl1.Clear();
            tbl1 = db.readData("select * from agenda where id_user=" + Properties.Settings.Default.userID, "");
            if (tbl1.Rows.Count >= 1)
            {
                try
                {
 
                    foreach (DataRow row in tbl1.Rows)
                    {
                        int nc = dataGridView1.Rows.Add();
                        dataGridView1.Rows[nc].Cells[0].Value = row["id"].ToString();
                        dataGridView1.Rows[nc].Cells[1].Value = Convert.ToDateTime(row["date"]).ToString("dd/MM/yyyy");
                        dataGridView1.Rows[nc].Cells[2].Value = row["heur"];
                        dataGridView1.Rows[nc].Cells[3].Value = row["text"].ToString(); 
                    }
                }
                catch 
                {

                }
             }
        }
        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer celui-ci !", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from agenda where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", "Data Deleted successfully");
                // AutoNumber();

                showInTable();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ////db.backup();
            //Process process = new Process();// C:\\dump mysqldump- -host = "localhost"--user = "root"--password = "" "desetriders" - r "D:\\backupfile.sql";
            ////mysqldump --host= "localhost" --user="root" "desetriders" > "D:\\backupfile.sql" 
            //ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", @"mysqldump.exe -u root --password= -h localhost ""desetriders"" > " + "D:\\backupfile le.sql"+"");
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            //startInfo.WorkingDirectory = @"D:\xampp\mysql\bin";
            //Process.Start(startInfo);
            db.backup(@"D:/Rapports/backups/backupfile_" + DateTime.Now.ToString("yyyy_MM_dd__hh_mm_ss") +".sql");
            //var proc1 = new ProcessStartInfo();
            //string anyCommand;
            //proc1.UseShellExecute = true;
            //proc1.WorkingDirectory = @"C:\xampp\mysql\bin";
            //proc1.FileName = @"C:\Windows\System32\cmd.exe"; 
            //proc1.Arguments = "/c " + @"mysqldump.exe -u root --password= -h localhost ""desertriders"" > " + "G:\\desert report\\backupfile" + DateTime.Now.ToString("yyyy_MM_dd__hh_mm_ss") +".sql" + "";
            //proc1.WindowStyle = ProcessWindowStyle.Hidden;
            //Process.Start(proc1);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
           
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "sql File";
            theDialog.Filter = "SQL files|*.sql";
            theDialog.InitialDirectory = @"D:/Rapports/backups/";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        db.restore(theDialog.FileName);
                        //using (myStream)
                        //{
                        //    //var proc1 = new ProcessStartInfo();
                        //    //string anyCommand;
                        //    //proc1.UseShellExecute = true;
                        //    //proc1.WorkingDirectory = @"C:\xampp\mysql\bin";
                        //    //proc1.FileName = @"C:\Windows\System32\cmd.exe";
                        //    //// proc1.Verb = "runas"; 
                        //    ////proc1.Arguments = "/c " + @"mysql - DROP DATABASE desetriders && mysql -  CREATE DATABASE blog && mysql - u root - p desetriders < backupfile.sql";
                        //    //proc1.Arguments = "/c " + @"mysql.exe  --host=localhost --user=root  desetriders < " + + "";
                        //    ////proc1.WindowStyle = ProcessWindowStyle.Normal;
                        //    //Process.Start(proc1);
                        //}
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }




        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
                MailAddress addressFrom = "bma010@domain.com";
                MailAddress addressTo = "achraf.bma@gmail.com";
                //MailAddress adressCC = "Shawn_Smithhh@outlook.com";
                MailMessage message = new MailMessage(addressFrom, addressTo);
                message.Subject = "Spire.Email Component";
                message.BodyText = "sxqxqxqxqx"  ;
                message.Attachments.Add(new Attachment(@"D://textfile.txt"));
               // message.Cc.Add(adressCC.Address);
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.ConnectionProtocols = ConnectionProtocols.StartTls;
                smtp.Username = addressFrom.Address;
                smtp.Password = "abm000abm";
                smtp.Port = 587;
                Console.WriteLine("From   : " + message.From.ToString());
                Console.WriteLine("To     : " + message.To.ToString());
                Console.WriteLine("Date   : " + DateTime.Now);
                Console.WriteLine("Subject: " + message.Subject);
                Console.WriteLine("Attachment: " + message.Attachments.Count);
                Console.WriteLine("------------------- BODY -----------------");

                Console.WriteLine(message.BodyText);

                Console.WriteLine("------------------- END ------------------");
                smtp.SendOne(message);
                Console.WriteLine("Message Sent.");
                Console.ReadLine();
            //try
            //{
            //    //Create the object of MailMessage
            //    MailMessage mailMessage = new MailMessage();
            //    mailMessage.From = new MailAddress("bma010@domain.com", "BMA10 Bma"); //From Email Id & Display name
            //    mailMessage.Subject = "Test Email"; //Subject of Email
            //    mailMessage.Body = "This is the test email body text"; //body or message of Email
            //    mailMessage.IsBodyHtml = true;
            //    mailMessage.Priority = MailPriority.High; //if you want to send High importance email

            //    //You can add either multiple To,CC,BCC or single emails
            //    mailMessage.To.Add(new MailAddress("achraf.bma@gmail.com")); //adding multiple TO Email Id


            //    //Add Attachments, here i gave one folder name, and it will add all files in that folder as attachments, Or if you want only one file also can add
            //    string attachmentsPath = @"D:\textfile.txt";
            //    if (Directory.Exists(attachmentsPath))
            //    {
            //        string[] files = Directory.GetFiles(attachmentsPath);
            //        foreach (string fileName in files)
            //        {
            //            Attachment file = new Attachment(fileName);
            //            mailMessage.Attachments.Add(file);
            //        }
            //    }

            //    //Assign the SMTP address and port
            //    SmtpClient smtp = new SmtpClient();
            //    smtp.Host = "smtp.gmail.com";
            //    smtp.Port = 465;
            //    smtp.EnableSsl = true; //If required make it true

            //    //Network and security related credentials
            //    NetworkCredential networkCredential = new NetworkCredential();
            //    networkCredential.UserName = "bma010@gmail.com";
            //    networkCredential.Password = "abm000abm";
            //    networkCredential.Domain = "https://mail.google.com";

            //    smtp.Credentials = networkCredential;

            //    //Finally send Email
            //    smtp.Send(mailMessage);
            //    MessageBox.Show("The email has been sent successfully.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //try
            //{
            //    MailMessage mail = new MailMessage();
            //    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //    mail.From = new MailAddress("bma010@gmail.com");
            //    mail.To.Add("achraf.bma@gmail.com");
            //    mail.Subject = "Test Mail - 1";
            //    mail.Body = "mail with attachment";

            //    //System.Net.Mail.Attachment attachment;
            //    //attachment = new System.Net.Mail.Attachment("your attachment file");
            //    //mail.Attachments.Add(attachment);

            //    SmtpServer.Port = 465;
            //    SmtpServer.Credentials = new System.Net.NetworkCredential("bma010@gmail.com", "abm000abm");
            //    SmtpServer.EnableSsl = true;

            //    SmtpServer.Send(mail);
            //    MessageBox.Show("mail Send");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            //try
            //{
            //    SmtpClient mailServer = new SmtpClient("smtp.gmail.com", 465);
            //    mailServer.EnableSsl = true;

            //    mailServer.Credentials = new System.Net.NetworkCredential("achraf.bma@gmail.com", "abmabm010");

            //    string from = "achraf.bma@gmail.com";
            //    string to = "bma010@gmail.com";
            //    MailMessage msg = new MailMessage(from, to);
            //    msg.Subject = "Enter the subject here";
            //    msg.Body = "The message goes here.";
            //    // msg.Attachments.Add(new Attachment("D:\\textfile.txt"));
            //    mailServer.Send(msg);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Unable to send email. Error : " + ex);
            //}
        }


    //    public void email_send()
    //{
    //    MailMessage mail = new MailMessage();
    //    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
    //    mail.From = new MailAddress("bma010@gmail.com");
    //    mail.To.Add("achraf.bma@gmail.com");
    //    mail.Subject = "Test Mail - 1";
    //    mail.Body = "mail with attachment";

    //    //System.Net.Mail.Attachment attachment;
    //    //attachment = new System.Net.Mail.Attachment("d:/textfile.txt");
    //    //mail.Attachments.Add(attachment);

    //    SmtpServer.Port = 465;
    //    SmtpServer.Credentials = new System.Net.NetworkCredential("bma010@gmail.com", "abm000abm");
    //    SmtpServer.EnableSsl = true;

    //    SmtpServer.Send(mail);

    //}
}
}