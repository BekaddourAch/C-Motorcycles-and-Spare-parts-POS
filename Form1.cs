using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Disdriver
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
             showInTable(Properties.Settings.Default.userID);
            getStatus(Properties.Settings.Default.userID);
            this.Text = "Desert Riders Sales Management system : " + Properties.Settings.Default.userPseudo;
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private Boolean getBoolFromSTR(string word)
        {
            if (word == "True") { return true; } else { return false; } 
        }
        public void showInTable(String search)
        { 
            tbl.Clear(); 
                tbl = db.readData("SELECT * FROM users where id = "+ search, ""); 
            if (tbl.Rows.Count > 0)
            {
                try
                { 
                    foreach (DataRow row in tbl.Rows)
                    {
                        ribAch.Enabled = getBoolFromSTR(row["alow_achat"].ToString());

                        ribArticl.Enabled = getBoolFromSTR(row["alow_article"].ToString());
                        ribMag.Enabled = getBoolFromSTR(row["alow_article"].ToString());

                        ribVent.Enabled = getBoolFromSTR(row["alow_vente"].ToString());
                        ribRet.Enabled = getBoolFromSTR(row["alow_vente"].ToString());

                        ribFourn.Enabled = getBoolFromSTR(row["alow_fournisseur"].ToString());

                        ribClint.Enabled = getBoolFromSTR(row["alow_client"].ToString());

                        RebDeponce.Enabled = getBoolFromSTR(row["alow_caisse"].ToString());
                        rebGestDep.Enabled = getBoolFromSTR(row["alow_caisse"].ToString());
                        rebCaiss.Enabled = getBoolFromSTR(row["alow_caisse"].ToString());
                        rebFonds.Enabled = getBoolFromSTR(row["alow_caisse"].ToString());
                        repTransf.Enabled = getBoolFromSTR(row["alow_caisse"].ToString());

                        //cbxSauv.Enabled = getBoolFromSTR(row["alow_sauvgard"].ToString());
                        rebUseres.Enabled = getBoolFromSTR(row["alow_reglage"].ToString());

                        ribRap.Enabled = getBoolFromSTR(row["alow_reports"].ToString());
                        rebStock.Enabled = getBoolFromSTR(row["alow_reports"].ToString());
                        rebFactsVent.Enabled = getBoolFromSTR(row["alow_reports"].ToString());
                        rebVentsRep.Enabled = getBoolFromSTR(row["alow_reports"].ToString());
                        rebFournRap.Enabled = getBoolFromSTR(row["alow_reports"].ToString());
                        ribClintRep.Enabled = getBoolFromSTR(row["alow_reports"].ToString());
                        RebDeponceRep.Enabled = getBoolFromSTR(row["alow_reports"].ToString());
                        rebCaissRep.Enabled = getBoolFromSTR(row["alow_reports"].ToString());
                        rebCaissRep.Enabled = getBoolFromSTR(row["alow_reports"].ToString());
                        rebCaissRep.Enabled = getBoolFromSTR(row["alow_reports"].ToString());
                    } 
                }
                catch (Exception) { }
            }
        }
        private Boolean getVentAllowed(String iduser)
        {
            Boolean levar = false;
            tbl.Clear();
            tbl = db.readData("SELECT alow_vente FROM users where id = " + iduser, "");
            if (tbl.Rows.Count > 0)
            {
                levar = Convert.ToBoolean(tbl.Rows[0][0].ToString());
            }

            return levar;
        }

        public void getStatus(String iduser)
        {
            Boolean Cloture_Status = false;
           btnSaleMenu.Enabled = false;
            btnRetour.Enabled = false;
            if (getVentAllowed(iduser))
            {
                // Cloture_Status = "";
                tbl.Clear();
                tbl = db.readData("SELECT id,clotured FROM cloture ORDER BY id DESC LIMIT 1", "");
                if (tbl.Rows.Count > 0)
                {
                    Cloture_Status = Convert.ToBoolean(tbl.Rows[0][1].ToString());
                    //MessageBox.Show("hhhh " + Cloture_Status);
                    if (Cloture_Status)
                    {
                        btnSaleMenu.Enabled = false; btnRetour.Enabled = false;
                    }
                    else
                    {
                        btnSaleMenu.Enabled = true; btnRetour.Enabled = true;
                    }

                }
                else
                {
                    btnSaleMenu.Enabled = true; btnRetour.Enabled = true;
                }
            }

        }
        private void btnHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.panel1.Controls.Clear();
            frm_home home = new frm_home()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }
             ;
            this.panel1.Controls.Add(home);

            home.frmMenu = this;
           // home.getStatus();
            home.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.panel1.Controls.Clear();
            frm_products home = new frm_products()  
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }
             ;
            this.panel1.Controls.Add(home);
            home.Show(); home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.panel1.Controls.Clear();
            frm_motos moto = new frm_motos()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }
             ;
            this.panel1.Controls.Add(moto);
            moto.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            frm_home home = new frm_home()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }
             ;
            this.panel1.Controls.Add(home);
            home.frmMenu = this;
          //  home.getStatus();
            home.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_clients frmCln = new frm_clients();
            frmCln.ShowDialog();
        }


        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Deponce frmDpns = new frm_Deponce();
            frmDpns.ShowDialog();
        }
        
        private void btnFourn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Fourns frmFourn = new frm_Fourns();
            frmFourn.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Depnc_Mang frmdepMa = new frm_Depnc_Mang();
            frmdepMa.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_deponc_Report frmdepRep = new frm_deponc_Report();
            frmdepRep.ShowDialog();

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.ShowDialog();
        }
         
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
 Application.Exit();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Magazin frmMaga = new frm_Magazin();
            frmMaga.ShowDialog();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.panel1.Controls.Clear();
            //frm_buy buy = new frm_buy()
            //{ Dock = DockStyle.Fill, TopLevel = false, TopMost = true }
            //;
            //this.panel1.Controls.Add(buy);
            //buy.Show();
            frm_buy frmMaga = new frm_buy(false);
            frmMaga.ShowDialog();

        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_sales sales = new frm_sales(false);
            sales.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_dettes frmdette = new frm_dettes(true); 
            frmdette.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_dettes frmdette = new frm_dettes(false);//Fournissure
            frmdette.ShowDialog();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Buy_Report frmdette = new frm_Buy_Report();
            frmdette.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_sale_Report frmdette = new frm_sale_Report();
            frmdette.ShowDialog();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_fact_sale_report frmdette = new frm_fact_sale_report();
            frmdette.ShowDialog();

        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_etat_stock frmdette = new frm_etat_stock();
            frmdette.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_caisses frmdette = new frm_caisses();
            frmdette.Show();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_transactions frmdette = new frm_transactions();
            frmdette.Show();
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_transfer frmdette = new frm_transfer();
            frmdette.Show();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_report_caisse frmdette = new frm_report_caisse();
            frmdette.Show();
        }

        private void barButtonItem16_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_returns_ed frmreturn = new frm_returns_ed();
            frmreturn.Show();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Users users = new frm_Users();
            users.Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Category catego = new frm_Category();
            catego.Show();
        }

        private void barButtonItem16_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            returnes_report catego = new returnes_report();
            catego.Show();
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_fact_buy fact_buy = new frm_fact_buy();
            fact_buy.Show();
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_total_Report total_buy = new frm_total_Report();
            total_buy.Show();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Cloture_rep Cloture_rep = new frm_Cloture_rep();
            Cloture_rep.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //var proc1 = new ProcessStartInfo();
            //string anyCommand;
            //proc1.UseShellExecute = true;
            //proc1.WorkingDirectory = @"D:\xampp\mysql\bin";
            //proc1.FileName = @"C:\Windows\System32\cmd.exe";
            //proc1.Arguments = "/c " + @"mysqldump.exe -u root --password= -h localhost ""desetriders"" > " + "D:\\backupfile" + DateTime.Now.ToString("yyyy_MM_dd__hh_mm_ss") + ".sql" + "";
            //proc1.WindowStyle = ProcessWindowStyle.Hidden;
            //Process.Start(proc1);
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.backup(@"./back_ups/backupfile_befor_opr" + DateTime.Now.ToString("yyyy_MM_dd__hh_mm_ss") + ".sql");
           

            frm_buy clouture = new frm_buy(false);
            clouture.btnNew.Visible = false;
            clouture.lblFactNumAuto.Text = 1+"";
            clouture.showEtatStockInTable();
            clouture.edit = false;
            clouture.txtFactNum.Text = "Stock-" + DateTime.Now.Year;
            // cbxForniss.SelectedValue = Convert.ToDateTime(row.Cells[3].Value);
            //clouture.dpFactDate.Value = Convert.ToDateTime(row.Cells[2].Value);
            clouture.Show();

        /*
            db.backup(@"./back_ups/backupfile_befor_opr" + DateTime.Now.ToString("yyyy_MM_dd__hh_mm_ss") + ".sql");
            db.executeData("TRUNCATE TABLE agenda ", "");
            db.executeData("TRUNCATE TABLE buy ", "");
            db.executeData("TRUNCATE TABLE  TableName ", "");
            db.executeData("TRUNCATE TABLE  TableName ", "");

            db.executeData("insert into buy values (" +
                       1 +//id 
                   ",'" + 1 +//code_fact
                 "','" + DateTime.Now.ToString("yyyy-MM-dd") +//date
                 "','" + cbxForniss.SelectedValue +//sup_id
                 "','" + TotalOrder +// totalOrder
                 "','" + txtApay.Text +//apay
                 "','" + leRest +//lereste
                 "','" + dpToDette.Value.ToString("yyyy-MM-dd") +//detteDate
                 "','" + payedAll +//payed_all
                 "','" + txtRemrq.Text +//Remarque
                 "',null" +//timer
                 "," + Properties.Settings.Default.userID + ") ;", "");//user_id
            */
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "sql File";
            theDialog.Filter = "SQL files|*.sql";
            theDialog.InitialDirectory = @"D:\Rapports\backups";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        db.restore(theDialog.FileName);
                         
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.backup(@"D:/Rapports/backups/backupfile_" + DateTime.Now.ToString("yyyy_MM_dd__hh_mm_ss") + ".sql");
        }
    }
}
