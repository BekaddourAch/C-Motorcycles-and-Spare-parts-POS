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
    public partial class frm_show_det_fact : DevExpress.XtraEditors.XtraForm
    {
        public frm_show_det_fact()
        {
            InitializeComponent();
        }
        Database db = new Database();
        System.Data.DataTable tbl = new System.Data.DataTable();
        public void showInTableBuy(string sale_id)
        {
            this.dgvBuy.Visible = true;
            this.dgvSales.Visible = false;
            this.dgvBuy.DataSource = null;
            this.dgvBuy.Rows.Clear();
            tbl.Clear();

            tbl = db.readData("SELECT * FROM v_buys_toupdate WHERE buy_id=" + sale_id, "");  //  

            if (tbl.Rows.Count >= 0)
            {
                try
                {
                    //  MessageBox.Show("tblItems.Rows.Count = "+ tblItems.Rows.Count);

                    foreach (DataRow row in tbl.Rows)
                    {
                        int nc = dgvBuy.Rows.Add();
                        dgvBuy.Rows[nc].Cells[0].Value = row["id"].ToString();
                        dgvBuy.Rows[nc].Cells[1].Value = row["pro_id"].ToString();
                        dgvBuy.Rows[nc].Cells[2].Value = row["name"].ToString();
                        dgvBuy.Rows[nc].Cells[3].Value = row["price"].ToString();
                        dgvBuy.Rows[nc].Cells[4].Value = row["qty"].ToString();
                        dgvBuy.Rows[nc].Cells[5].Value = row["total"].ToString();
                        dgvBuy.Rows[nc].Cells[6].Value = row["pricesale"].ToString();
                        dgvBuy.Rows[nc].Cells[7].Value = row["pricehelp"].ToString();
                        dgvBuy.Rows[nc].Cells[8].Value = row["prix_grox"].ToString();
                        dgvBuy.Rows[nc].Cells[9].Value = row["remise"].ToString();
                        // dgvBuy.Rows[nc].Cells[10].Value = 1;
                    }

                }
                catch (Exception) { }

                Double TotalOrder = 0; Double Totalbenfice = 0;
                lblNombre.Text = dgvBuy.Rows.Count.ToString();
                for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                {
                    TotalOrder += Convert.ToDouble(dgvBuy.Rows[i].Cells[5].Value);
                    //  Totalbenfice += Convert.ToDouble(dgvBuy.Rows[i].Cells[6].Value);
                }
                lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                //  lblBenifice.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(Totalbenfice));

            }
        }
        public void showInTableSale(string sale_id)
        {
            this.dgvBuy.Visible = false;
            this.dgvSales.Visible =true ;
            this.dgvSales.DataSource = null;
            this.dgvSales.Rows.Clear();
            tbl.Clear();
             
            tbl = db.readData("SELECT * FROM v_sales_toupdate WHERE sale_id=" + sale_id, "");  // 


            if (tbl.Rows.Count >= 0)
            {
                try
                {
                    //  MessageBox.Show("tblItems.Rows.Count = "+ tblItems.Rows.Count);

                    foreach (DataRow row in tbl.Rows)
                    {
                        int nc = dgvSales.Rows.Add();
                        dgvSales.Rows[nc].Cells[0].Value = row["id"].ToString();
                        dgvSales.Rows[nc].Cells[1].Value = row["pro_id"].ToString();
                        dgvSales.Rows[nc].Cells[2].Value = row["name"].ToString();
                        dgvSales.Rows[nc].Cells[3].Value = row["type_pay"].ToString();
                        dgvSales.Rows[nc].Cells[4].Value = row["price"].ToString();
                        dgvSales.Rows[nc].Cells[5].Value = row["remise"].ToString();
                        dgvSales.Rows[nc].Cells[6].Value = row["qty"].ToString();
                        dgvSales.Rows[nc].Cells[7].Value = row["total"].ToString();
                        dgvSales.Rows[nc].Cells[8].Value = row["buy_id"].ToString();
                        dgvSales.Rows[nc].Cells[9].Value = row["prixAchat"].ToString();
                        dgvSales.Rows[nc].Cells[10].Value = 1;
                    }

                }
                catch (Exception) { }

                Double TotalOrder = 0; Double Totalbenfice = 0;
                lblNombre.Text = dgvSales.Rows.Count.ToString();
                for (int i = 0; i <= dgvSales.Rows.Count - 1; i++)
                {
                    TotalOrder += Convert.ToDouble(dgvSales.Rows[i].Cells[7].Value);
                    //Totalbenfice += Convert.ToDouble(dgvSales.Rows[i].Cells[6].Value);
                }
                lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                //  lblBenifice.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(Totalbenfice));

            }
        }
        private Double getDetteClient(String nomFr)
        {
            Double valDette = 0.0;
            tbl.Clear();
            tbl = db.readData("select Dette from clients where nomFr='"+ nomFr+"'", "");
            if (tbl.Rows.Count >= 0)
            {
                valDette = Convert.ToDouble(tbl.Rows[0][0])   ;
            }
            else
            {
                valDette=0.0;
            }
            return valDette;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                //WriteExcel();
                Microsoft.Office.Interop.Excel.Application xlApp;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                string filePath = @"c:\Modele\model.xlsx"; 
                xlWorkBook = xlApp.Workbooks.Open(filePath);
                // xlWorkBook = xlApp.Workbooks.Open("C:\\Users\\AirGun\\Documents\\Visual Studio 2015\\Projects\\DXApplication9\\DXApplication9\\Disdriver\\bin\\Debug\\ol.xlsx");
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // creating Excel Application  
                //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                //Microsoft.Office.Interop.Excel._Workbook workbook = xlApp.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                xlApp.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = xlWorkBook.Sheets["Sheet1"];
                worksheet = xlWorkBook.ActiveSheet;
                // changing the name of active sheet  
               // worksheet.Name = "Exported from gridview";
                worksheet.Cells[7, 3] = cbxForniss.Text;
                tbl.Clear();
                tbl = db.readData("SELECT * FROM `clients` where nomFr = '" + cbxForniss.Text + "'", "");
                if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
                {
                    //  lblFactNumAuto.Text = "1";
                }
                else
                {
                    worksheet.Cells[8, 3] = tbl.Rows[0][6].ToString();//address
                    worksheet.Cells[9, 3] = tbl.Rows[0][3].ToString() + " / " + tbl.Rows[0][4].ToString();//Telephone 
                    worksheet.Cells[10, 3] = tbl.Rows[0][12].ToString() + " - MF: " + tbl.Rows[0][13].ToString();
                    worksheet.Cells[11, 3] = tbl.Rows[0][14].ToString() + " - AI: " + tbl.Rows[0][15].ToString();
                }
                worksheet.Cells[5, 8] = lblFactNumAuto.Text;
                worksheet.Cells[16, 4] = lblNombre.Text;
                worksheet.Cells[18, 8] = getDetteClient(cbxForniss.Text);
                   worksheet.Cells[20, 8] = txtApay.Text;
                //    worksheet.Cells[21, 8] = lblTotal.Text;
                // Insert five rows into the worksheet at the 9th position.
                // worksheet.Rows.Insert(18, 10);
                CopyRowsDown(worksheet, 14, dgvSales.Rows.Count);

                // storing header part in Excel  
                //for (int i = 1; i < dgvBuy.Columns.Count + 1; i++)
                //{

                //        worksheet.Cells[1, i] = dgvBuy.Columns[i - 1].HeaderText;

                //}
                // storing Each row and column value to excel sheet   

                for (int i = 0; i < dgvSales.Rows.Count; i++)
                {

                    int col = 0;
                    for (int j = 0; j < dgvSales.Columns.Count - 3; j++)
                    {
                        if (j != 4  )
                        {
                            if (j == 0)
                            {
                                worksheet.Cells[i + 14, col + 2] = i+1; col++;
                            }
                            else {  worksheet.Cells[i + 14, col + 2] = dgvSales.Rows[i].Cells[j].Value.ToString(); col++;}
                           
                        }
                    }

                }

                // save the application  
                xlWorkBook.SaveAs(@"D:\DR Rapports\Facture Le  " + DateTime.Now.ToString("d_M_yyyy hh_mm_ss") + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                // app.Quit();
            }
            catch { }
        }

        public static void CopyRowsDown(Microsoft.Office.Interop.Excel._Worksheet worksheet, int startRowIndex, int countToCopy)
        {
            for (int i = 1; i < countToCopy; i++)
            {
                var range = worksheet.get_Range(string.Format("{0}:{0}", startRowIndex, Type.Missing));
                range.Select();
                range.Copy();

                range = worksheet.get_Range(string.Format("{0}:{1}", startRowIndex + i, startRowIndex + i, Type.Missing));
                range.Select();
                range.Insert(-4121);
            }
        }
    }
}