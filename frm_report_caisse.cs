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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Disdriver
{
    public partial class frm_report_caisse : DevExpress.XtraEditors.XtraForm
    {
        public frm_report_caisse()
        {
            InitializeComponent();
            FillCaisse();
        }
        Double solde = 0.0;
        int num = 0;
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();
        int selectdChx = 0;
        public void showInTable(int chx,String num,int selectdChx)
        {
            this.dgvReport.DataSource = null;
            this.dgvReport.Rows.Clear();
            dtbl.Clear();
                 if (chx ==0) { dtbl = db.readData("select transactions.id ,transactions.montant,transactions.date,transactions.rais_nom,transactions.remarque"+
                     " from transactions inner join caisse on transactions.num_caisse = caisse.id  where num_caisse=" + num + "", "");}

            else if (chx ==1) { dtbl = db.readData("select transactions.id ,transactions.montant,transactions.date,transactions.rais_nom,transactions.remarque" +
                     " from transactions inner join caisse on transactions.num_caisse = caisse.id  where transactions.num_caisse=" + num + " and type_opra=" + selectdChx , ""); } 

            else if (chx ==2) { dtbl = db.readData("select transactions.id ,transactions.montant,transactions.date,transactions.rais_nom,transactions.remarque" +
                     "   from transactions inner join caisse on transactions.num_caisse = caisse.id  where transactions.num_caisse=" + num + " and type_opra=" + selectdChx + " and date BETWEEN '" +
                dpfrom.Value.ToString("yyyy-MM-dd") + "' and '" + dpTo.Value.ToString("yyyy-MM-dd") + "'", ""); }
            else if (chx == 3)
            {
                dtbl = db.readData("select transactions.id ,transactions.montant,transactions.date,transactions.rais_nom,transactions.remarque" +
                     "  from transactions inner join caisse on transactions.num_caisse = caisse.id  where transactions.num_caisse=" + num + " and date BETWEEN '" +
                dpfrom.Value.ToString("yyyy-MM-dd") + "' and '" + dpTo.Value.ToString("yyyy-MM-dd") + "' ", "");
            }

            try
            {
                int j = 1;
                foreach (DataRow row in dtbl.Rows)
                {
                    int nc = dgvReport.Rows.Add();
                    dgvReport.Rows[nc].Cells[0].Value = j++;
                    dgvReport.Rows[nc].Cells[1].Value = row["id"].ToString();
                    dgvReport.Rows[nc].Cells[2].Value = row["montant"].ToString();
                    dgvReport.Rows[nc].Cells[3].Value = row["date"].ToString();
                    dgvReport.Rows[nc].Cells[4].Value = row["rais_nom"].ToString();
                    dgvReport.Rows[nc].Cells[5].Value = row["remarque"].ToString();
                    //dgvReport.Rows[nc].Cells[6].Value = row["num_caisse"].ToString();
                    //dgvReport.Rows[nc].Cells[7].Value = row["nom"].ToString();
                    //dgvReport.Rows[nc].Cells[8].Value = row["timer"].ToString();
                    //dgvReport.Rows[nc].Cells[9].Value = row["user_id"].ToString();
                }
            }
            catch (Exception) {}
            Double TotalOrder = 0;
            lblNombre.Text = dgvReport.Rows.Count.ToString();
            for (int i = 0; i <= dgvReport.Rows.Count - 1; i++)
            {
                TotalOrder += Convert.ToDouble(dgvReport.Rows[i].Cells[2].Value);
            }
            lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
        }
        int chxo = 0;
        private void FillCaisse()
        {
            cbxCaise.DataSource = db.readData("SELECT * FROM caisse ", "");
            cbxCaise.DisplayMember = "nom";
            cbxCaise.ValueMember = "id";
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectdChx = 1;
            showInTable(1, cbxCaise.SelectedValue.ToString(), selectdChx);
            chxo = 2;
        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectdChx = 0;
            showInTable(1, cbxCaise.SelectedValue.ToString(), selectdChx);
            chxo = 2;
        }
        private void checkButton3_CheckedChanged(object sender, EventArgs e)
        {
            showInTable(0, cbxCaise.SelectedValue.ToString(), 0);
            chxo = 3;
        }
        private void cbxCaise_DropDownClosed(object sender, EventArgs e)
        {
            showInTable(0,cbxCaise.SelectedValue.ToString(),3);
            chxo = 2;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            showInTable(chxo, cbxCaise.SelectedValue.ToString(), selectdChx);
        }
        public void ExportWorkbookToPdf(string workbookPath, string outputPath)
        {
            // If either required string is null or empty, stop and bail out
            if (string.IsNullOrEmpty(workbookPath) || string.IsNullOrEmpty(outputPath))
            {
                MessageBox.Show("It wasn't possible to write the data to the disk.");
            }

            // Create COM Objects
            Microsoft.Office.Interop.Excel.Application excelApplication;
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook;

            // Create new instance of Excel
            excelApplication = new Microsoft.Office.Interop.Excel.Application();

            // Make the process invisible to the user
            excelApplication.ScreenUpdating = false;

            // Make the process silent
            excelApplication.DisplayAlerts = false;

            // Open the workbook that you wish to export to PDF
            excelWorkbook = excelApplication.Workbooks.Open(workbookPath);

            // If the workbook failed to open, stop, clean up, and bail out
            if (excelWorkbook == null)
            {
                excelApplication.Quit();

                excelApplication = null;
                excelWorkbook = null;

                MessageBox.Show("It wasn't possible to write the data to the disk.");
            }

            var exportSuccessful = true;
            try
            {
                // Call Excel's native export function (valid in Office 2007 and Office 2010, AFAIK)
                excelWorkbook.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, outputPath);
            }
            catch (System.Exception ex)
            {
                // Mark the export as failed for the return value...
                exportSuccessful = false;

                // Do something with any exceptions here, if you wish...
                // MessageBox.Show...        
            }
            finally
            {
                // Close the workbook, quit the Excel, and clean up regardless of the results...
                excelWorkbook.Close();
                excelApplication.Quit();

                excelApplication = null;
                excelWorkbook = null;
            }

            // You can use the following method to automatically open the PDF after export if you wish
            // Make sure that the file actually exists first...
            if (System.IO.File.Exists(outputPath))
            {
                System.Diagnostics.Process.Start(outputPath);
            }

            MessageBox.Show("Data Exported Successfully !!!", "Info");
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            ExportWorkbookToPdf("D:\\DR Rapports\\Rapport Caisse.xls", "D:\\DR Rapports\\Rapport Caisse.pdf");

            //if (dgvReport.Rows.Count > 0)
            //{
            //    SaveFileDialog sfd = new SaveFileDialog();
            //    sfd.Filter = "PDF (*.pdf)|*.pdf";
            //    sfd.FileName = "Output.pdf";
            //    bool fileError = false;
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        if (File.Exists(sfd.FileName))
            //        {
            //            try
            //            {
            //                File.Delete(sfd.FileName);
            //            }
            //            catch (IOException ex)
            //            {
            //                fileError = true;
            //                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
            //            }
            //        }
            //        if (!fileError)
            //        {
            //            try
            //            {
            //                PdfPTable pdfTable = new PdfPTable(dgvReport.Columns.Count);
            //                pdfTable.DefaultCell.Padding = 3;
            //                pdfTable.WidthPercentage = 100;
            //                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            //                //BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            //                var tahomaFontFile = Path.Combine(   Environment.GetFolderPath(Environment.SpecialFolder.Fonts),  "Tahoma.ttf");
            //                var tahomaBaseFont = BaseFont.CreateFont(tahomaFontFile, BaseFont.IDENTITY_H,  BaseFont.EMBEDDED);
            //                var tahomaFont = new iTextSharp.text.Font(tahomaBaseFont, 8, iTextSharp.text.Font.NORMAL);

            //              //  iTextSharp.text.Font font = new iTextSharp.text.Font(tahomaBaseFont, 10, iTextSharp.text.Font.TIMES_ROMAN);
            //                int i = 0;
            //                int[] columnWidths = { 15, 40, 40, 40, 40, 40 };
            //                foreach (DataGridViewColumn column in dgvReport.Columns)
            //                { 
            //                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
            //                    {
            //                        RunDirection = PdfWriter.RUN_DIRECTION_RTL,
            //                        Border = 0
            //                    };

            //                    pdfTable.AddCell(cell);

            //                    i++;
            //                }
            //                pdfTable.SetWidths(columnWidths);
            //                foreach (DataGridViewRow row in dgvReport.Rows)
            //                {
            //                    foreach (DataGridViewCell cell in row.Cells)
            //                    {
            //                        pdfTable.AddCell(new Paragraph(cell.Value.ToString(), tahomaFont));
            //                    }
            //                }


            //                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
            //                {
            //                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
            //                    PdfWriter.GetInstance(pdfDoc, stream);
            //                    pdfDoc.Open();
            //                    pdfDoc.Add(new Paragraph("ETAT DE STOCK  Le: " + DateTime.Now));
            //                    pdfDoc.Add(new Paragraph(" "));
            //                    pdfDoc.Add(new Paragraph(" "));
            //                    pdfDoc.Add(pdfTable);
            //                    pdfDoc.Close();
            //                    stream.Close();
            //                }

            //                MessageBox.Show("Data Exported Successfully !!!", "Info");
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Error :" + ex.Message);
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No Record To Export !!!", "Info");
            //}
        }

        private void btnPrint_Click(object sender, EventArgs e)
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
            for (int i = 0; i < dgvReport.Rows.Count; i++)
            {
                for (int j = 0; j < dgvReport.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvReport.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  RAPPORT FINNANCE
            workbook.SaveAs("D:\\Rapports\\Rapport Caisse.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            //app.Quit();
        }
    }
}