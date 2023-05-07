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
    public partial class frm_Cloture_rep : DevExpress.XtraEditors.XtraForm
    {
        public frm_Cloture_rep()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();

        DataTable tblItems = new DataTable();



        public void showInTable(int search, string fourn)
        {
            this.dgvReport.DataSource = null;
            this.dgvReport.Rows.Clear();
            tblItems.Clear();


            if (search == 0)
            {


                tblItems = db.readData("SELECT cloture.*,users.Name FROM `cloture` inner join users on cloture.user_id =users.id   where " + fourn, "");  // 

            }
            else if (search == 1)
            {
                tblItems = db.readData("SELECT cloture.*,users.Name FROM `cloture` inner join users on cloture.user_id =users.id WHERE MONTH(date_start)= " + fourn, "");
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
                            dgvReport.Rows[nc].Cells[0].Value = row["id"].ToString(); ;
                            dgvReport.Rows[nc].Cells[1].Value = row["clotured"].ToString();
                            dgvReport.Rows[nc].Cells[2].Value = row["total_day"].ToString();
                            dgvReport.Rows[nc].Cells[3].Value = row["sold_ouvert"].ToString(); 
                            dgvReport.Rows[nc].Cells[4].Value = row["sold_cloture"].ToString();
                            dgvReport.Rows[nc].Cells[5].Value = row["differnce"].ToString();
                            dgvReport.Rows[nc].Cells[6].Value = row["retrait"].ToString();
                            dgvReport.Rows[nc].Cells[7].Value = row["raison"].ToString();
                            dgvReport.Rows[nc].Cells[8].Value = row["remarque"].ToString();
                            dgvReport.Rows[nc].Cells[9].Value = row["retour"].ToString();
                            dgvReport.Rows[nc].Cells[10].Value = Convert.ToDateTime(row["date_start"]).ToString("dd/MM/yyyy");
                            dgvReport.Rows[nc].Cells[11].Value = Convert.ToDateTime(row["date_fin"]).ToString("dd/MM/yyyy");
                            dgvReport.Rows[nc].Cells[12].Value = row["Name"].ToString();  
                        }
                    }
                    catch (Exception) { }
                }
             
                Double TotalOrder = 0; Double Totalbenfice = 0;
                lblNombre.Text = dgvReport.Rows.Count.ToString();
                for (int i = 0; i <= dgvReport.Rows.Count - 1; i++)
                {
                     TotalOrder += Convert.ToDouble(dgvReport.Rows[i].Cells[5].Value);
                    //Totalbenfice += Convert.ToDouble(dgvReport.Rows[i].Cells[11].Value);
                }
                lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                //lblBenifice.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(Totalbenfice));

            
        }
 



        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            showInTable(0, " date_start BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'");
        }

        private void btnSearchMonth_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(" العافية = " + cbxMonths.SelectedIndex);
            showInTable(1, cbxMonths.SelectedIndex+1+"");
        }
        private void copyAlltoClipboard()
        {
            dgvReport.SelectAll();
            DataObject dataObj = dgvReport.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            //// creating Excel Application  
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //// creating new WorkBook within Excel application  
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //// creating new Excelsheet in workbook  
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //// see the excel sheet behind the program  
            //app.Visible = true;
            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //// changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";
            //try
            //{ 
            //    // storing header part in Excel  
            //    for (int i = 1; i < dgvReport.Columns.Count; i++)
            //    {
            //        worksheet.Cells[1, i] = dgvReport.Columns[i - 1].HeaderText;
            //    }
            //    // storing Each row and column value to excel sheet  
            //    for (int i = 0; i < dgvReport.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dgvReport.Columns.Count-1; j++)
            //        {
            //            worksheet.Cells[i + 2, j + 1] = dgvReport.Rows[i].Cells[j].Value.ToString();
            //            //if (dgvReport.Rows[i].Cells[j].Value.ToString() != null)
            //            //{
            //            //    worksheet.Cells[i + 2, j + 1] = dgvReport.Rows[i].Cells[j].Value.ToString(); }
            //            //else { worksheet.Cells[i + 2, j + 1] = "-";
            //            //}

            //        }
            //     }
            //}
            //catch (Exception) { }
            //// save the application  
            //workbook.SaveAs("D:\\DR Rapports\\Rapport Ventes Détaillé Le " + DateTime.Now.ToString("d_M_yyyy hh_mm_ss") + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //// Exit from the application  
            ////app.Quit();
        }
    }
}