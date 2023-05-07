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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Drawing.Printing;
using ZXing;
using System.IO;
using IronBarCode;
namespace Disdriver
{
    public partial class frm_Barcode : DevExpress.XtraEditors.XtraForm
    {
        public frm_Barcode(String article, String prix, String barcode, String id)
        {
            InitializeComponent();
            this.article = article;
            this.prix = prix;
            this.barcode = barcode;
            this.id = id;
            initFrame();
            checkBox1.Checked = true;
            checkBox2.Checked = true;
        }
        void initFrame()
        {
            lblArticle.Text = article;
            txtArticle.Text = article;
            lblPrix.Text = prix;
            txtPrix.Text =   String.Format("Prix: {0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(prix));
            txtBarcode.Text = barcode;
            lblShow.Text = barcode;

        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        public String article = "", prix = "", barcode = "", id = "";

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {

                txtPrix.Visible = true;
            }
            else
            {
                txtPrix.Visible = false;
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                txtArticle.Visible = true;
            }
            else
            {
                txtArticle.Visible = false;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraReport1 xtra = new XtraReport1();
            Baracuda bara = new Baracuda();
            xtra.CreateDocument();
            if (!checkBox1.Checked)  {  xtra.xrLabel3.Text = "";  }  else   {  xtra.xrLabel3.Text = txtArticle.Text; }
            if(!checkBox2.Checked) { xtra.xrLabel1.Text = ""; } else { xtra.xrLabel1.Text = txtPrix.Text; }
            xtra.xrBarCode1.Text = txtBarcode.Text;
           
            xtra.CreateDocument();
            bara.documentViewer1.PrintingSystem = xtra.PrintingSystem;
            bara.Show();

        } 

        private void btnPrnt_Click(object sender, EventArgs e)
        {


            ///******     WRITE     *******/
            //// Create A Barcode in 1 Line of Code
            //IronBarCode.BarcodeWriter.CreateBarcode("*"+barcode+"*", BarcodeWriterEncoding.Code128).SaveAsJpeg(@"D:\\mage.png");
            
            //frm_fact fact = new frm_fact();
            //rptBarcode cry = new rptBarcode();
            ////cry.SetDataSource(ds);
            ////var barcodeWriter = new BarcodeWriter();
            ////// set the barcode format barcodeWriter.Write(barcode).ToString();
            ////barcodeWriter.Format = BarcodeFormat.CODE_128;
            ////GenerateBarcode();
            //String com = "";
            ////Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            ////cry.ReportDefinition.Sections["Section2"].ReportObjects["Picture1"]. = cry.ReportDefinition.Sections["Section2"].ReportObjects["Picture1"];

            //////  instantiate a writer object
            //// var barcodeWriter = new BarcodeWriter();

            //// // set the barcode format
            ////  barcodeWriter.Format = BarcodeFormat.ITF;

            ////// create a barcode reader instance
            ////BarcodeReader reader = new BarcodeReader();
            ////// load a bitmap
            ////var barcodeBitmap = (Bitmap)Bitmap.FromFile("D:\\sample-barcode-image.png");
            ////// detect and decode the barcode inside the bitmap
            ////var result = reader.Decode(barcodeBitmap);
            ////// do something with the result
            ////if (result != null)
            ////{
            ////    lblShow.Text = result.BarcodeFormat.ToString();
            ////    com = result.Text;
            ////}
           
            //TextObject Text1 = (TextObject)cry.ReportDefinition.Sections["Section2"].ReportObjects["Text1"];
            //Text1.Text = com;

            ////TextObject Text2 = (TextObject)cry.ReportDefinition.Sections["Section2"].ReportObjects["Text2"];
            ////Text2.Text = barcode;

            ////TextObject Text3 = (TextObject)cry.ReportDefinition.Sections["Section2"].ReportObjects["Text3"];
            ////Text3.Text = article;
            ////TextObject Text4 = (TextObject)cry.ReportDefinition.Sections["Section2"].ReportObjects["Text4"];
            ////Text4.Text = String.Format("Prix: {0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(prix));
            ////cry.SetParameterValue("Picture1", @"D:\\sample-barcode-image.png");
            //PrintDocument printDoc = new PrintDocument();
            //cry.PrintOptions.PrinterName = printDoc.PrinterSettings.PrinterName;
            //cry.PrintToPrinter(1, false, 0, 0);
        }

        private void btnPrevPrnt_Click(object sender, EventArgs e)
        {
            frm_fact fact = new frm_fact();
            rptBarcode cry = new rptBarcode();
            //cry.SetDataSource(ds);.PrintToPrinter(1, false, 0, 0);

            TextObject Text1 = (TextObject)cry.ReportDefinition.Sections["Section2"].ReportObjects["Text1"];
            Text1.Text = barcode;

            TextObject Text2 = (TextObject)cry.ReportDefinition.Sections["Section2"].ReportObjects["Text2"];
            Text2.Text = barcode;
            TextObject Text3 = (TextObject)cry.ReportDefinition.Sections["Section2"].ReportObjects["Text3"];
            Text3.Text = article;
            TextObject Text4 = (TextObject)cry.ReportDefinition.Sections["Section2"].ReportObjects["Text4"];
            Text4.Text = String.Format("Prix: {0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(prix));
            fact.crystalReportViewer1.ReportSource = cry;
            fact.crystalReportViewer1.Refresh();
            fact.ShowDialog();


            //frm_fact fact = new frm_fact();
            //rptbar cry = new rptbar();
            ////cry.SetDataSource(ds);.PrintToPrinter(1, false, 0, 0);

            ////TextObject Text1 = (TextObject)cry.ReportDefinition.Sections["Section2"].ReportObjects["Text1"];
            ////Text1.Text = barcode;

            ////TextObject Text2 = (TextObject)cry.ReportDefinition.Sections["Section2"].ReportObjects["Text2"];
            ////Text2.Text = barcode;
            ////TextObject Text3 = (TextObject)cry.ReportDefinition.Sections["Section2"].ReportObjects["Text3"];
            ////Text3.Text = article;
            ////TextObject Text4 = (TextObject)cry.ReportDefinition.Sections["Section2"].ReportObjects["Text4"];
            ////Text4.Text = String.Format("Prix: {0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(prix));
            //fact.crystalReportViewer1.ReportSource = cry;
            //fact.crystalReportViewer1.Refresh();
            //fact.ShowDialog();
        }
    }
}