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
    public partial class frm_Buy_Report : DevExpress.XtraEditors.XtraForm
    {
        public frm_Buy_Report()
        {
            InitializeComponent();
          
            showInTable(0,null);
        }

        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();

        DataTable tblItems = new DataTable();
        private void frm_Buy_Report_Load(object sender, EventArgs e)
        {

        }
        private void FillSupplier()
        {
            cbxForniss.DataSource = db.readData("SELECT * FROM fournisseur ", "");
            cbxForniss.DisplayMember = "nomFr";
            cbxForniss.ValueMember = "id";
        }
        public void showInTable(int search,string fourn)
        {
            this.dgvReport.DataSource = null;
            this.dgvReport.Rows.Clear();
            tblItems.Clear();


            if (search==0)
            {


                tblItems = db.readData("SELECT * FROM `v_report_buy_det` ", "");  // 

            }
            else if (search == 1)
            {
                tblItems = db.readData("select * from v_report_buy_det where nomFr like '%" + fourn + "%'", ""); 
            }
            else if (search == 2)
            {
                tblItems = db.readData("select * from `v_report_buy_det` where num like '" + fourn + "'", "");
            }
            else if (search == 3)
            {
                tblItems = db.readData("select * from v_report_buy_det where date " + fourn + "", "");
            }

            if (tblItems.Rows.Count >= 0)
            {
                try
                {
                  //  MessageBox.Show("tblItems.Rows.Count = "+ tblItems.Rows.Count);
                    int j = 1;
                    foreach (DataRow row in tblItems.Rows)
                    {
                        int nc = dgvReport.Rows.Add();
                        dgvReport.Rows[nc].Cells[0].Value = j++; 
                        dgvReport.Rows[nc].Cells[1].Value = row["num"].ToString();
                        dgvReport.Rows[nc].Cells[2].Value = row["code_fact"].ToString();
                        dgvReport.Rows[nc].Cells[3].Value = row["nomFr"].ToString();
                        dgvReport.Rows[nc].Cells[4].Value = row["name"].ToString();
                        dgvReport.Rows[nc].Cells[5].Value = Convert.ToDateTime(row["date"]).ToString("dd/MM/yyyy");
                        dgvReport.Rows[nc].Cells[6].Value = row["qty"].ToString(); 
                        dgvReport.Rows[nc].Cells[7].Value = row["price"].ToString();
                        dgvReport.Rows[nc].Cells[8].Value = row["total"].ToString();
                        dgvReport.Rows[nc].Cells[9].Value = row["totalOrder"].ToString();
                        dgvReport.Rows[nc].Cells[10].Value = row["apay"].ToString();
                        dgvReport.Rows[nc].Cells[11].Value = row["lereste"].ToString();
                        dgvReport.Rows[nc].Cells[12].Value = row["qtt_rest"].ToString();
                        dgvReport.Rows[nc].Cells[13].Value = row["quantity_min"].ToString();
                        dgvReport.Rows[nc].Cells[14].Value = row["rest2"].ToString(); 
                    }
                    
                }
                catch (Exception) { }

                Double TotalOrder = 0;
                lblNombre.Text = dgvReport.Rows.Count.ToString();
                for (int i = 0; i <= dgvReport.Rows.Count - 1; i++)
                {
                    TotalOrder += Convert.ToDouble(dgvReport.Rows[i].Cells[8].Value);
                }
                lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));

            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                showInTable(0,null); radioButton2.Checked = false;cbxForniss.Enabled = false;
            }
            
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false; cbxForniss.Enabled = true;
            }
           
        }

        private void cbxForniss_SelectionChangeCommitted(object sender, EventArgs e)
        {
            showInTable(1, cbxForniss.Text);
        }

        private void cbxForniss_TextChanged(object sender, EventArgs e)
        {
            showInTable(1, cbxForniss.Text);
        }

        private void btnSaveFact_Click(object sender, EventArgs e)
        {
            if (txtFactNum.Text!="")
            {
                showInTable(2, txtFactNum.Text);
            }
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            showInTable(3, " BETWEEN '" + dpfrom.Value.ToString("yyyy-MM-dd") + "' and '" + dpTo.Value.ToString("yyyy-MM-dd")+ "'");
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
            workbook.SaveAs("D:\\Rapports\\Rapport achat" + DateTime.Now.ToString("d_M_yyyy hh_mm_ss")+ ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
           // app.Quit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void cbxForniss_Click(object sender, EventArgs e)
        {
            FillSupplier();
        }
    }
}