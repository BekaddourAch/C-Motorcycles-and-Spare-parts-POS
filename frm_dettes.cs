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

namespace Disdriver
{
    public partial class frm_dettes : DevExpress.XtraEditors.XtraForm
    {
        private Boolean isClient;
        public frm_dettes(Boolean isClient)
        {
            InitializeComponent();
            this.isClient = isClient;
            if (!this.isClient)
            {
                title1.Text = "ديون الموزعين";
                title2.Text = " Dette des fournisseurs";
            }
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();
        Double TotalOrder = 0;
        DataTable tblItems = new DataTable();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            showInTable(true);
         //   btnAdd.Enabled = false;
           
            //btnSave.Enabled = true;
        }




        public void showInTable(Boolean search)
        {
            this.dgvCustomer.DataSource = null;
            this.dgvCustomer.Rows.Clear();
            tblItems.Clear();
            
              if (isClient) {
                if (search)
                { tblItems = db.readData("select * from clients where nomFr like '%" + txtSearch.Text + "%'", ""); }
                else
                { tblItems = db.readData("SELECT * FROM clients ", ""); }
            } else {
                if (search)
                { tblItems = db.readData("select * from fournisseur where nomFr like '%" + txtSearch.Text + "%'", ""); }
                else
                { tblItems = db.readData("SELECT * FROM fournisseur  ", ""); }
            }
               
            // MessageBox.Show(" tblItems.Rows.Count " + tblItems.Rows.Count);


            if (tblItems.Rows.Count > 0)
            {
                try
                {
 
                   // int j = 0;
 
                    foreach (DataRow row in tblItems.Rows)
                    {
                        int nc = dgvCustomer.Rows.Add();
                        //MessageBox.Show(" dgvCustomer.Rows.Add " + nc);

                        dgvCustomer.Rows[nc].Cells[0].Value = row["id"].ToString();
                        dgvCustomer.Rows[nc].Cells[1].Value = row["nomFr"].ToString();
                        dgvCustomer.Rows[nc].Cells[2].Value = row["Dette"].ToString();

                    }


                }
                catch (Exception) { }
            }
        }

        private void frm_dettes_Load(object sender, EventArgs e)
        {
            showInTable(false); 
        }
        public double getDette(string id)
        {
            
                double val=0;
            DataGridViewRow row = this.dgvCustomer.SelectedRows[0];
            id_client = row.Cells[0].Value.ToString();
            tbl.Clear();
            if (isClient)
            {
                tbl = db.readData("select Dette from clients where id =" + id_client, "");
            }else
            {

                tbl = db.readData("select Dette from fournisseur where id =" + id_client, "");
            }
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
               // lblFactNumAuto.Text = "1";
            }
            else
            {
              return  val = Convert.ToDouble(tbl.Rows[0][0]) ;
               
            }
            return val;
        }
        public string id_client = "";
        public double TotalDette=0;
        private void dgvCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dgvCustomer.SelectedRows.Count > 0)
            {
                this.dgvDettes.Rows.Clear();
                this.dgvPayedDettes.Rows.Clear();
                TotalOrder = 0; 
                DataGridViewRow row = this.dgvCustomer.SelectedRows[0];
                id_client = row.Cells[0].Value.ToString();
                TotalDette = getDette(id_client);

                lblNombre.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(12));
                showDetails(id_client);
                showPayedDetails(id_client);
            }
        }
        public void showDetails(string id_client)
        {
            
            if (this.dgvCustomer.SelectedRows.Count > 0)
            {DataTable tbl = new DataTable();
                if (this.dgvDettes.DataSource != null)
                {
                    this.dgvDettes.DataSource = null;
                    lblFactNum.Text = "0"; lblTotFact.Text = "0"; lblNombre.Text = "0"; btnAdd.Enabled = true;
                }
                else
                {
                    this.dgvDettes.Rows.Clear();
                    lblFactNum.Text = "0"; lblTotFact.Text = "0"; lblNombre.Text = "0"; btnAdd.Enabled = true;
                }
                
                tbl.Clear();
                if (isClient)
                {
                    tbl = db.readData("SELECT id,num_fact,total_dette,date_to_pay,is_payed,date_payemnt  FROM dettes_clients WHERE id_client =" + id_client + " and is_payed =0   ORDER BY date_to_pay  ASC ", "");
                }
                else
                {
                    tbl = db.readData("SELECT id,num_fact,total_dette,date_to_pay,is_payed,date_payemnt  FROM dettes_fournisseur  WHERE id_fourniss =" + id_client + " and is_payed =0   ORDER BY date_to_pay  ASC ", "");
                }
                   
                if (tbl.Rows.Count == 0)
                {
                    lblFactNum.Text = "0"; lblTotFact.Text = "0"; lblNombre.Text = "0"; btnAdd.Enabled = true;
                }
                else
                {
                    if (tbl.Rows.Count > 0)
                    {
                        dgvDettes.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";
                        dgvDettes.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd";
                        try
                        {

                            int j = 1;

                            foreach (DataRow rowa in tbl.Rows)
                            {
                                int nc = dgvDettes.Rows.Add();
                                //MessageBox.Show(" dgvCustomer.Rows.Add " + nc);

                                dgvDettes.Rows[nc].Cells[0].Value = rowa["id"].ToString();
                                dgvDettes.Rows[nc].Cells[1].Value = rowa["num_fact"].ToString();
                                dgvDettes.Rows[nc].Cells[2].Value = rowa["total_dette"].ToString();
                                //dgvDettes.Rows[nc].Cells[3].Value = Convert.ToDateTime(rowa["date_to_pay"]).ToString("yyyy-MM-dd");
                                dgvDettes.Rows[nc].Cells[3].Value = rowa["date_to_pay"];
                                dgvDettes.Rows[nc].Cells[4].Value = rowa["is_payed"].ToString();
                                //dgvDettes.Rows[nc].Cells[5].Value = Convert.ToDateTime(rowa["date_payemnt"]).ToString("yyyy-MM-dd");
                                dgvDettes.Rows[nc].Cells[5].Value = rowa["date_payemnt"];

                            }


                        }
                        catch (Exception) { }
                    }


                      //decimal TotalOrder = 0;
                    //Double  TotalOrder = 0;
                    //for (int i = 0; i <= dgvDettes.Rows.Count - 1; i++)
                    //{

                    //    TotalOrder += Convert.ToDouble(dgvDettes.Rows[i].Cells[2].Value);

                    //}
                    //lblNombre.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                    lblNombre.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(getDette(id_client)));
                }
                // txtPrixAchat.Text = "0"; txtDiscount.Text = "0"; togswRemise.IsOn = false;
            }
        }



        public void showPayedDetails(string id_client)
        {
            
            if (this.dgvCustomer.SelectedRows.Count > 0)
            {DataTable tbl = new DataTable();
                //if (this.dgvPayedDettes.DataSource != null)
                //{
                //    this.dgvPayedDettes.DataSource = null;
                //    lblFactNum.Text = "0"; lblTotFact.Text = "0"; lblNombre.Text = "0"; btnAdd.Enabled = true;
                //}
                //else
                //{
                //    this.dgvPayedDettes.Rows.Clear();
                //    lblFactNum.Text = "0"; lblTotFact.Text = "0"; lblNombre.Text = "0"; btnAdd.Enabled = true;
                //}

                tbl.Clear();
                if (isClient)
                {
                    tbl = db.readData("SELECT id,total_dette,montant_payer,reste_dette,date_payemnt FROM  dettes_clients_mod2 WHERE id_client =" + id_client + "   ORDER BY date_payemnt  ASC ", "");
                }
                else
                {
                    tbl = db.readData("SELECT id,total_dette,montant_payer,reste_dette,date_payemnt FROM  dettes_fournisseur_mod2 WHERE id_fourniss =" + id_client + "    ORDER BY date_payemnt  ASC ", "");
                }

                //if (tbl.Rows.Count == 0)
                //{
                //    lblFactNum.Text = "0"; lblTotFact.Text = "0"; lblNombre.Text = "0"; btnAdd.Enabled = true;
                //}
                
                    if (tbl.Rows.Count > 0)
                    {
                        dgvPayedDettes.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
                       // dgvPayedDettes.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd";
                        try
                        {

                            int j = 1;

                            foreach (DataRow rowa in tbl.Rows)
                            {
                                int nc = dgvPayedDettes.Rows.Add();
                                //MessageBox.Show(" dgvCustomer.Rows.Add " + nc);

                                dgvPayedDettes.Rows[nc].Cells[0].Value = rowa["id"].ToString(); 
                                dgvPayedDettes.Rows[nc].Cells[1].Value = rowa["total_dette"].ToString();
                                //dgvDettes.Rows[nc].Cells[3].Value = Convert.ToDateTime(rowa["date_to_pay"]).ToString("yyyy-MM-dd");
                                dgvPayedDettes.Rows[nc].Cells[2].Value = rowa["montant_payer"];
                                dgvPayedDettes.Rows[nc].Cells[3].Value = rowa["reste_dette"].ToString();
                                //dgvDettes.Rows[nc].Cells[5].Value = Convert.ToDateTime(rowa["date_payemnt"]).ToString("yyyy-MM-dd");
                                dgvPayedDettes.Rows[nc].Cells[4].Value = rowa["date_payemnt"];

                            }


                        }
                        catch (Exception) { }
                    }


                    //  decimal TotalOrder = 0;
                 /*   for (int i = 0; i <= dgvDettes.Rows.Count - 1; i++)
                    {

                        TotalOrder += Convert.ToDouble(dgvDettes.Rows[i].Cells[2].Value);

                    }
                    //lblNombre.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                    lblNombre.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalDette));*/
               
                // txtPrixAchat.Text = "0"; txtDiscount.Text = "0"; togswRemise.IsOn = false;
            }
        }



        private void dgvDettes_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dgvDettes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvDettes.SelectedRows[0];
                lblFactNum.Text = row.Cells[1].Value.ToString();
                lblTotFact.Text = row.Cells[2].Value.ToString();
                btnAdd.Enabled = true;
            }
        }
        double payo = 0;
        double leRest = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TotalDette > 0)
            {

                if (txtApay.Text == "" || txtApay.Text == null)
                {
                    // txtApay.Text = "0";
                    payo = 0;
                }
                else
                {
                    payo = Convert.ToDouble(txtApay.Text);
                }
                double testvar = payo - TotalDette;
                var number = double.Parse(testvar + "".Replace("−", "-"));
                if (number > 0)
                {
                    txtApay.Text = "0";
                }

                Boolean isZero;
                leRest = TotalDette - payo;
                //MessageBox.Show("leRest = "+ leRest+ " ; TotalOrder = "+ TotalOrder+ " ; payo = "+ payo);
                lblRest.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}",  leRest);
                //if (leRest == 0)
                //{
                //    isZero = true;
                //    dpToDette.Enabled = false; label22.Enabled = false;
                //}
                //else
                //{
                //    isZero = false;
                //    dpToDette.Enabled = true; label22.Enabled = true;
                //}

            }
            else
            {
              //  MessageBox.Show("pas de Articles dans la liste");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous payer les dettes !", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (isClient)
                {
                    
                    Double olddette = getDette(id_client);
                    Boolean test = db.executeData("UPDATE clients SET " +
                      " Dette = Dette-" + payo +
                                  " where id='" + id_client + "'", "");
                    if (test)
                    {
                        String STRquery = "";
                        // 	id 	id_client 	total_dette 	montant_payer 	reste_dette 	date_payemnt 	user_id 	timmer 
                        STRquery = @"insert into dettes_clients_mod2 values (null" +// 
                                            "," + id_client +//  
                                            "," + olddette +//  
                                            "," + payo +//  
                                            "," + leRest +// 
                                            ",'" + dpToDette.Value.ToString("yyyy-MM-dd") +//   
                                            "'," + Properties.Settings.Default.userID +//  
                                         ",null);";
                        db.executeData(STRquery, "");
                    }
                    txtApay.Text = "";
                    lblNombre.Text = "";
                    lblRest.Text = "";
                }
                else
                {
                    
                    Double olddette = getDette(id_client);
                    Boolean test = db.executeData("UPDATE  fournisseur SET " +
                      " Dette = Dette-" + payo +
                                  " where id='" + id_client + "'", "");
                    if (test)
                    {
                        String STRquery = "";
                        // 	id 	id_client 	total_dette 	montant_payer 	reste_dette 	date_payemnt 	user_id 	timmer 
                        STRquery = @"insert into  dettes_fournisseur_mod2 values (null" +// 
                                            "," + id_client +//  
                                            "," + olddette +//  
                                            "," + payo +//  
                                            "," + leRest +// 
                                            ",'" + dpToDette.Value.ToString("yyyy-MM-dd") +//   
                                            "'," + Properties.Settings.Default.userID +//  
                                         ",null);";
                        db.executeData(STRquery, "");
                    }
                    txtApay.Text = "";
                    lblNombre.Text = "";
                    lblRest.Text = "";
                }
               
            }

            //if (this.dgvDettes.SelectedRows.Count > 0)
            //{
            //    if (isClient)
            //    {
            //        DataGridViewRow row = this.dgvDettes.SelectedRows[0];
            //         row.Cells[1].Value.ToString();
            //        if (MessageBox.Show("voulez vous payer les dettes de cette facture !", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //        {
            //            db.executeData("UPDATE dettes_clients SET " +
            //              " is_payed ='" + 1 +
            //           "', date_payemnt='" + dtpTo.Value.ToString("yyyy-MM-dd") +
            //           "',user_id="+ Properties.Settings.Default.userID + ",timmer=null where id='" + row.Cells[0].Value.ToString() + "'", "");

            //            db.executeData("UPDATE sales SET " +
            //             " apay = apay+" + Convert.ToDouble(lblTotFact.Text) +
            //             ", lereste =" + 0 +
            //              ", detteDate='" + dtpTo.Value.ToString("yyyy-MM-dd") +
            //               "', payed_all =" + 1 +
            //              " where id='" + lblFactNum.Text + "'", "");

            //            db.executeData("UPDATE clients SET " +
            //             " Dette = Dette-" + Convert.ToDouble(lblTotFact.Text) +
            //             " where id='" + id_client + "'", "");

            //            showDetails(id_client);
            //        }
            //    } else
            //    {
            //        if (MessageBox.Show("voulez vous payer les dettes de cette facture !", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //        {
            //            db.executeData("UPDATE dettes_fournisseur SET " +
            //              " is_payed ='" + 1 +
            //           "', date_payemnt='" + dtpTo.Value.ToString("yyyy-MM-dd") +
            //           "',user_id=" + Properties.Settings.Default.userID + ",timmer=null where num_fact='" + lblFactNum.Text + "'", "");

            //            db.executeData("UPDATE buy SET " +
            //             " apay = apay+" + Convert.ToDouble(lblTotFact.Text) +
            //             ", lereste =" + 0 +
            //              ", detteDate='" + dtpTo.Value.ToString("yyyy-MM-dd") +
            //               "', payed_all =" + 1 +
            //              " where id='" + lblFactNum.Text + "'", "");

            //            db.executeData("UPDATE fournisseur SET " +
            //             " Dette = Dette-" + Convert.ToDouble(lblTotFact.Text) +
            //             " where id='" + id_client + "'", "");

            //            showDetails(id_client);
            //        }
            //    }


            //}
        }

       

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}