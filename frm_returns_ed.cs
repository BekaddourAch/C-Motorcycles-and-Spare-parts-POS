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
    public partial class frm_returns_ed : DevExpress.XtraEditors.XtraForm
    {
        public frm_returns_ed()
        {
            InitializeComponent();
            FillClient();
           // showInTable(0, null);
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();

        DataTable tblItems = new DataTable();
        private void FillClient()
        {
            //cbxForniss.DataSource = db.readData("SELECT * FROM clients ", "");
            //cbxForniss.DisplayMember = "nomFr";
            //cbxForniss.ValueMember = "id";
        }

        public void showInTable(int search, string fourn)
        {
            this.dgvReport.DataSource = null;
            this.dgvReport.Rows.Clear();
            tblItems.Clear();


            if (search == 0)
            {


                tblItems = db.readData("SELECT * FROM `v_sales_to_returnd` where " + fourn, "");  // 

            }
            else if (search == 1)
            {
                tblItems = db.readData("SELECT *,DATEDIFF(CURRENT_DATE(), date) as nbrdys FROM `v_sales_to_returnd` WHERE DATEDIFF(CURRENT_DATE(), date) <="+ numericUpDown1.Value.ToString() + " AND (  name like '%" + fourn+ "%' OR  barcode = '" + fourn + "' )", "");
              //  MessageBox.Show("SELECT *,DATEDIFF(CURRENT_DATE(), date) as nbrdys FROM `v_sales_to_returnd` WHERE DATEDIFF(CURRENT_DATE(), date) <=200 AND (  name like '%" + fourn + "%' OR  barcode = '" + fourn + "' )");
            }
            else if (search == 2)
            {
                tblItems = db.readData("select *,DATEDIFF(CURRENT_DATE(), date) as nbrdys from `v_sales_to_returnd` where id = '" + fourn + "'", "");
            }
            else if (search == 3)
            {
                tblItems = db.readData("SELECT * FROM `v_sales_to_returnd`  WHERE date " + fourn , "");
            }
             
            if (tblItems.Rows.Count >= 0)
            {
                if (search!=3) {
                    try
                    {
                        // MessageBox.Show("in show_loop tblItems.Rows.Count = "+ tblItems.Rows.Count);
 
                        //int j = 1;
                        foreach (DataRow row in tblItems.Rows)
                        {
                            int nc = dgvReport.Rows.Add();
                            dgvReport.Rows[nc].Cells[0].Value = row["iddetail"].ToString(); 
                            dgvReport.Rows[nc].Cells[1].Value = row["nomFr"].ToString(); 
                            dgvReport.Rows[nc].Cells[2].Value = row["id"].ToString();
                            dgvReport.Rows[nc].Cells[3].Value = row["prod_id"].ToString();
                            dgvReport.Rows[nc].Cells[4].Value = row["barcode"].ToString(); 
                            dgvReport.Rows[nc].Cells[5].Value = row["name"].ToString();
                            dgvReport.Rows[nc].Cells[6].Value = Convert.ToDateTime(row["date"]).ToString("dd/MM/yyyy");
                            dgvReport.Rows[nc].Cells[7].Value = row["qty"].ToString();
                            dgvReport.Rows[nc].Cells[8].Value = row["remise"].ToString();
                            dgvReport.Rows[nc].Cells[9].Value = row["total"].ToString();
                            dgvReport.Rows[nc].Cells[10].Value = row["totalsale"].ToString();
                            dgvReport.Rows[nc].Cells[11].Value = row["apay"].ToString();
                            dgvReport.Rows[nc].Cells[12].Value = row["lereste"].ToString();
                            dgvReport.Rows[nc].Cells[13].Value = row["benifice"].ToString();
                            dgvReport.Rows[nc].Cells[14].Value = row["nbrdys"].ToString();
                            dgvReport.Rows[nc].Cells[15].Value = row["buy_id"].ToString();
                        }

                    }
                    catch (Exception) { }
                }else
                {
                   // MessageBox.Show("tblItems.Rows.Count = " + dtbl.Rows.Count);
                    try
                    {
                        //dataGridView1.DataSource = dtbl;
                        //  MessageBox.Show("tblItems.Rows.Count = "+ tblItems.Rows.Count);
                        int j = 1;
                        foreach (DataRow row in tblItems.Rows)
                        {
                            int nc = dgvReport.Rows.Add();
                            dgvReport.Rows[nc].Cells[0].Value = row["iddetail"].ToString();
                            dgvReport.Rows[nc].Cells[1].Value = row["nomFr"].ToString();
                            dgvReport.Rows[nc].Cells[2].Value = row["id"].ToString();
                            dgvReport.Rows[nc].Cells[3].Value = row["prod_id"].ToString();
                            dgvReport.Rows[nc].Cells[4].Value = row["barcode"].ToString();
                            dgvReport.Rows[nc].Cells[5].Value = row["name"].ToString();
                            dgvReport.Rows[nc].Cells[6].Value = Convert.ToDateTime(row["date"]).ToString("dd/MM/yyyy");
                            dgvReport.Rows[nc].Cells[7].Value = row["qty"].ToString();
                            dgvReport.Rows[nc].Cells[8].Value = row["remise"].ToString();
                            dgvReport.Rows[nc].Cells[9].Value = row["total"].ToString();
                            dgvReport.Rows[nc].Cells[10].Value = row["totalsale"].ToString();
                            dgvReport.Rows[nc].Cells[11].Value = row["apay"].ToString();
                            dgvReport.Rows[nc].Cells[12].Value = row["lereste"].ToString();
                            dgvReport.Rows[nc].Cells[13].Value = row["benifice"].ToString();
                            dgvReport.Rows[nc].Cells[14].Value = row["nbrdys"].ToString(); 
                            dgvReport.Rows[nc].Cells[15].Value = row["buy_id"].ToString();
                        }

                    }
                    catch (Exception) { }
                }
                Double TotalOrder = 0; Double Totalbenfice = 0;
                lblNombre.Text = dgvReport.Rows.Count.ToString();
                for (int i = 0; i <= dgvReport.Rows.Count - 1; i++)
                {
                    TotalOrder += Convert.ToDouble(dgvReport.Rows[i].Cells[7].Value);
                    Totalbenfice += Convert.ToDouble(dgvReport.Rows[i].Cells[11].Value);
                }
                //lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                //lblBenifice.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(Totalbenfice));

            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            //if (radioButton1.Checked == true)
            //{
            ////    showInTable(0, null);
            //    radioButton2.Checked = false; cbxForniss.Enabled = false;
            //}

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            //if (radioButton2.Checked == true)
            //{
            //    radioButton1.Checked = false; cbxForniss.Enabled = true;
            //}

        }

        private void btnSaveFact_Click(object sender, EventArgs e)
        {
            if (txtFactNum.Text != "")
            {
                showInTable(2, txtFactNum.Text);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //if (radioButton2.Checked == true && cbxForniss.Text != null)
            //{
            //    //MessageBox.Show("cbx fournisseur : "+ cbxForniss.Text);
            //    showInTable(1, cbxForniss.Text + "' and date BETWEEN '" + dpfrom.Value.ToString("yyyy-MM-dd") + "' and '" + dpTo.Value.ToString("yyyy-MM-dd") + "'");
            //}
            //if (radioButton1.Checked == true)
            //{
            //    showInTable(0, " date BETWEEN '" + dpfrom.Value.ToString("yyyy-MM-dd") + "' and '" + dpTo.Value.ToString("yyyy-MM-dd") + "'");
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = this.dgvReport.SelectedRows[0];
            ////tbl.Clear();
            ////tbl = db.readData("SELECT id FROM  sales_details  where pro_id=" + row.Cells[0].Value.ToString(), "");
            //String numFact = row.Cells[2].Value.ToString();
            //String numArt = row.Cells[3].Value.ToString();
            //String codbar = row.Cells[4].Value.ToString();
            //String name = row.Cells[5].Value.ToString();  
            //String qttSale = row.Cells[7].Value.ToString();
            //String buy_id = row.Cells[15].Value.ToString();
            //String iddetail = row.Cells[0].Value.ToString();
            //if (Convert.ToInt32(qttSale) >1)
            //{
            //    Return_Qtty rqty = new Return_Qtty(iddetail, buy_id, numFact,  name,  numArt,  codbar,  qttSale);
            //    rqty.Show();
            //}
            //else
            //{
            //    if (MessageBox.Show("هل تريد إرجاع هاته السلعة إلى المخزون ؟", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //    {
            //        db.readData("delete from sales_details  where id='" + iddetail + "'", "");
            //        // AutoNumber();
            //        this.dgvReport.Rows.RemoveAt(this.dgvReport.SelectedRows[0].Index);
            //        //showInTable(false, Convert.ToInt32(lblIndex.Text), PgSize);
            //    }
            //}
        }

        private void cbxForniss_SelectionChangeCommitted(object sender, EventArgs e)
        {
          //  showInTable(1, cbxForniss.Text);
        }

        private void cbxForniss_TextChanged(object sender, EventArgs e)
        {
         //   showInTable(1, cbxForniss.Text);
        }

        private void frm_sale_Report_Load(object sender, EventArgs e)
        {

        }

 
 
     
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                showInTable(1, txtSearch.Text);
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            frm_Return sale = new frm_Return(true);
            DataGridViewRow row = this.dgvReport.SelectedRows[0];
            String Sales_ID = row.Cells[2].Value.ToString();
            sale.lblFactNumAuto.Text = Sales_ID;
            sale.isReturned = true;
            sale.showInTable(Sales_ID);
            sale.cbxForniss.Text = row.Cells[1].Value.ToString();
            sale.dpFactDate.Text =Convert.ToDateTime(row.Cells[6].Value).ToString("yyyy-MM-dd");
            sale.Show();
        }
    }
}