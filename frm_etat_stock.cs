using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Disdriver
{
    public partial class frm_etat_stock : DevExpress.XtraEditors.XtraForm
    {
        public frm_etat_stock()
        {
            InitializeComponent(); 
            showInTable(0, null);
            colorIt();
            


            // no selection in dgv at the begening   
            //dgvReport.FirstDisplayedCell = null;
            //
            // try this it is working !
            

            // ClearSelection();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();

        DataTable tblItems = new DataTable();
        private void FillMagas()
        {
            cbxMags.DataSource = db.readData("SELECT * FROM magasins ", "");
            cbxMags.DisplayMember = "name";
            cbxMags.ValueMember = "id";
        }
        private void ClearSelection()

        {

            DataGridViewSelectionMode oldmode = dgvReport.SelectionMode;

            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvReport.ClearSelection();

            dgvReport.SelectionMode = oldmode;

        }
        public void colorIt()
        {
            //if (dgvReport.Rows.Count >= 0){
            //    foreach (DataGridViewRow dgvr in dgvReport.Rows)

            //     {
            //        //    if (Convert.ToDecimal( dgvReport.Rows[counter].Cells[5].Value) > Convert.ToDecimal( dgvReport.Rows[counter].Cells[7].Value))
            //        //{
            //            dgvr.DefaultCellStyle.ForeColor = Color.Beige;
            //        //}
            //    }
            //}
            dgvReport.ClearSelection();
            int counter = dgvReport.Rows.Count;
             if (counter >= 0)
            {
                for (int i = 0; i < counter; i++)
                {
                    if (Convert.ToDecimal(dgvReport.Rows[i].Cells[5].Value) > Convert.ToDecimal(dgvReport.Rows[i].Cells[7].Value))
                    {
                        //this is where your LAST LINE code goes
                        //row.DefaultCellStyle.BackColor = Color.Yellow;
                        dgvReport.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        //this is your normal code NOT LAST LINE
                        //row.DefaultCellStyle.BackColor = Color.Red;
                        dgvReport.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                    }
                }
            }
        }

        public void showInTable(int search, string name)
        {
            this.dgvReport.DataSource = null;
            this.dgvReport.Rows.Clear();
            tblItems.Clear();


            if (search == 0)
            {
                tblItems = db.readData("SELECT * FROM `v_etat_stock` ", "");  // 

            }
            if (search == 1)
            {
                tblItems = db.readData("SELECT * FROM `v_etat_rup_stock` ", "");  // 
            }
            else if (search == 2)
            {
                tblItems = db.readData("select * from v_etat_stock where  magasin like '" + name + "'", "");
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
                        dgvReport.Rows[nc].Cells[1].Value = row["name"].ToString();
                        dgvReport.Rows[nc].Cells[2].Value = row["price"].ToString();
                        dgvReport.Rows[nc].Cells[3].Value = row["categorie"].ToString();
                        dgvReport.Rows[nc].Cells[4].Value = row["magasin"].ToString();
                        dgvReport.Rows[nc].Cells[5].Value = row["quantity_min"].ToString();
                        dgvReport.Rows[nc].Cells[6].Value = row["totalqtt"].ToString();
                        dgvReport.Rows[nc].Cells[7].Value = row["rest2"].ToString(); 
                    }
                }
                catch (Exception) { }



                //Double TotalOrder = 0;
                //lblNombre.Text = dgvReport.Rows.Count.ToString();
                //for (int i = 0; i <= dgvReport.Rows.Count - 1; i++)
                //{
                //    TotalOrder += Convert.ToDouble(dgvReport.Rows[i].Cells[8].Value);
                //}
                //lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));

            }
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
            app.Visible = false;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Etat de Stock Desert Riders";
            // storing header part in Excel  
            for (int i = 1; i < dgvReport.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvReport.Columns[i - 1].HeaderText;
            }
            try
            {
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvReport.Rows.Count ; i++)
            {
                for (int j = 0; j < dgvReport.Columns.Count; j++)
                {
                    
                    worksheet.Cells[i + 2, j + 1] = dgvReport.Rows[i].Cells[j].Value.ToString();
                }
                    label2.Text = ((i+1) * 100) / dgvReport.Rows.Count  + " %";
                    progressBar1.Value = ((i+1)*100) / dgvReport.Rows.Count ;
                   
            }

            // save the application  
            workbook.SaveAs("D:\\Rapports\\Rapport Etat de Stock le " + DateTime.Now.ToString("d_M_yyyy hh_mm_ss") + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
              app.Quit();
            }
            catch (Exception ec)
            {
                Console.Write(ec);
            }
            
            

        }

        private void frm_etat_stock_Load(object sender, EventArgs e)
        {
            dgvReport.ClearSelection();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvReport.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                           pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                           
                            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                            int i = 0;
                            int[] columnWidths = { 15, 130, 25,40, 40, 20, 25,20 };
                            foreach (DataGridViewColumn column in dgvReport.Columns)
                            {

                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                

                                pdfTable.AddCell(cell);
                                i++;
                            }
                            pdfTable.SetWidths(columnWidths);
                            foreach (DataGridViewRow row in dgvReport.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(new Paragraph(cell.Value.ToString(), font));
                                }
                            }
                          

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new Paragraph("ETAT DE STOCK  Le: "+ DateTime.Now));
                                pdfDoc.Add(new Paragraph(" "));
                                pdfDoc.Add(new Paragraph(" "));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            showInTable(0, null);
            colorIt();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            showInTable(1, null);
            colorIt();
        }

        private void cbxMags_Click(object sender, EventArgs e)
        {
            FillMagas();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            showInTable(2, cbxMags.SelectedText);
        }
    }
}