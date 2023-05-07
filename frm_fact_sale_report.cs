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
    public partial class frm_fact_sale_report : DevExpress.XtraEditors.XtraForm
    {
        public frm_fact_sale_report()
        {
            InitializeComponent();
            FillClient();
            showInTable(0, null);
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();

        DataTable tblItems = new DataTable();
        private void FillClient()
        {
            cbxForniss.DataSource = db.readData("SELECT * FROM clients ", "");
            cbxForniss.DisplayMember = "nomFr";
            cbxForniss.ValueMember = "id";
        }

        public void showInTable(int search, string fourn)
        {
            this.dgvReport.DataSource = null;
            this.dgvReport.Rows.Clear();
            tblItems.Clear();


            if (search == 0)
            {


                tblItems = db.readData("SELECT `sales`.*,clients.nomFr FROM `sales` LEFT JOIN clients ON sales.client_id=clients.id   ", "");  // 

            }
            else if (search == 1)
            {
                tblItems = db.readData("SELECT `sales`.*,clients.nomFr FROM `sales` LEFT JOIN clients ON sales.client_id=clients.id where nomFr like '%" + fourn + "%'", "");
            }
            else if (search == 2)
            {
                tblItems = db.readData("SELECT `sales`.*,clients.nomFr FROM `sales` LEFT JOIN clients ON sales.client_id=clients.id  where sales.id like '" + fourn + "'", "");
            }
            else if (search == 3)
            {
                tblItems = db.readData("SELECT `sales`.*,clients.nomFr FROM `sales` LEFT JOIN clients ON sales.client_id=clients.id  where date " + fourn + "", "");
            }

            if (tblItems.Rows.Count >= 0)
            {
                try
                {
                    //  MessageBox.Show("tblItems.Rows.Count = "+ tblItems.Rows.Count);
                    
                    foreach (DataRow row in tblItems.Rows)
                    {
                        int nc = dgvReport.Rows.Add();
                        dgvReport.Rows[nc].Cells[0].Value = row["id"].ToString();
                        dgvReport.Rows[nc].Cells[1].Value = row["code_fact"].ToString();
                        dgvReport.Rows[nc].Cells[2].Value = Convert.ToDateTime(row["date"]).ToString("dd/MM/yyyy");
                        dgvReport.Rows[nc].Cells[3].Value = row["nomFr"].ToString();
                        dgvReport.Rows[nc].Cells[4].Value = row["totalsale"].ToString();
                        dgvReport.Rows[nc].Cells[5].Value = row["apay"].ToString();
                        dgvReport.Rows[nc].Cells[6].Value = row["lereste"].ToString();
                        dgvReport.Rows[nc].Cells[7].Value = Convert.ToDateTime(row["detteDate"]).ToString("dd/MM/yyyy");
                        dgvReport.Rows[nc].Cells[8].Value = row["payed_all"].ToString();
                        dgvReport.Rows[nc].Cells[9].Value = row["Remarque"].ToString();
                        dgvReport.Rows[nc].Cells[10].Value = row["timer"].ToString();
                        dgvReport.Rows[nc].Cells[11].Value = row["user_id"].ToString(); 
                    }

                }
                catch (Exception) { }

                Double TotalOrder = 0; Double Totalbenfice = 0;
                lblNombre.Text = dgvReport.Rows.Count.ToString();
                for (int i = 0; i <= dgvReport.Rows.Count - 1; i++)
                {
                    TotalOrder += Convert.ToDouble(dgvReport.Rows[i].Cells[4].Value);
                  Totalbenfice += Convert.ToDouble(dgvReport.Rows[i].Cells[6].Value);
                }
                lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                lblBenifice.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(Totalbenfice));

            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                showInTable(0, null); radioButton2.Checked = false; cbxForniss.Enabled = false;
            }

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false; cbxForniss.Enabled = true;
            }

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
            showInTable(3, " BETWEEN '" + dpfrom.Value.ToString("yyyy-MM-dd") + "' and '" + dpTo.Value.ToString("yyyy-MM-dd") + "'");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dgvReport.Columns.Count + 1; i++)
            {
               
                    worksheet.Cells[1, i] = dgvReport.Columns[i - 1].HeaderText;
                
               
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvReport.Rows.Count ; i++)
            {
                for (int j = 0; j < dgvReport.Columns.Count; j++)
                { 
                        worksheet.Cells[i + 2, j + 1] = dgvReport.Rows[i].Cells[j].Value.ToString(); 
                }
            }
            // save the application  
            workbook.SaveAs("D:\\Rapports\\Rapport Ventes Par Factures Le " + DateTime.Now.ToString("d_M_yyyy hh_mm_ss") + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
         //   app.Quit();
        }

        private void cbxForniss_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showInTable(1, cbxForniss.Text);
        }

        private void cbxForniss_TextChanged(object sender, EventArgs e)
        {
            showInTable(1, cbxForniss.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("حل حقا تريد حذف هاته الفاتورة", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataGridViewRow row = this.dgvReport.SelectedRows[0];
            String Sales_ID = row.Cells[0].Value.ToString();
            db.executeData("DELETE FROM sales WHERE id= " + Sales_ID, "");  // 
            showInTable(0, null);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_sales sale = new frm_sales(true);
            DataGridViewRow row = this.dgvReport.SelectedRows[0];
            String Sales_ID = row.Cells[0].Value.ToString();
            sale.lblFactNumAuto.Text = Sales_ID;
            sale.showInTable(Sales_ID); 
            sale.cbxForniss.Text = row.Cells[3].Value.ToString();
            sale.dpFactDate.Value = Convert.ToDateTime(row.Cells[2].Value);
            sale.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
           
            DataGridViewRow row = this.dgvReport.SelectedRows[0];
            String buy_id = row.Cells[0].Value.ToString(); 

            frm_show_det_fact det_fact = new frm_show_det_fact();
            det_fact.simpleButton4.Visible = true;
            det_fact.lblFactNumAuto.Text = buy_id;
            det_fact.showInTableSale(buy_id);

            det_fact.dpFactDate.Text = Convert.ToDateTime(row.Cells[2].Value).ToString();

            det_fact.cbxForniss.Text = row.Cells[3].Value.ToString();
            det_fact.txtApay.Text = row.Cells[5].Value.ToString();
            det_fact.lblRest.Text = row.Cells[6].Value.ToString();
            det_fact.dpToDette.Text = row.Cells[7].Value.ToString();
            det_fact.txtRemrq.Text = row.Cells[8].Value.ToString();
            det_fact.ShowDialog();
        }
    }
}