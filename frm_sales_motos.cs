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
using System.Reflection;
using System.IO;
using System.Runtime.InteropServices;
namespace Disdriver
{
    public partial class frm_sales_motos : DevExpress.XtraEditors.XtraForm
    {
        public frm_sales_motos()
        {
            InitializeComponent();
        }

        Database db = new Database();
         DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();
        double TotalOrder = 0.0, leRest = 0.0; double Discount = 0;
        public String prixVGros, prixNormal, prixhelp; public String laRemise, prixachat;
        public frm_motos allMotos = new frm_motos();
        public int SelectedID = 1;
        public void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from sales_moto", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                lblFactNumAuto.Text = "1";
            }
            else
            {
                lblFactNumAuto.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }



            //btnSave.Enabled = true; 
        }
        public void clearAllData()
        {
            txtNomAr.Clear();
            txtNomFr.Clear();
            txtPhone1.Clear();
            txtPhone2.Clear();
            txtlieu.Clear();
            txtNumCart.Clear();
            txtLieuCart.Clear();
            txtNSerie.Clear();
            txtPrixAchat.Clear();
            txtDiscount.Clear();
            txtApay.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
             
            db.executeData("insert into sales_moto values (null,'" +//1
                         lblMoto_id.Text +//2
                "','" + txtNomAr.Text +//3
                "','" + txtNomFr.Text +//4
                "','" + txtPhone1.Text +//5
                "','" + txtPhone2.Text +//6
                "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + //7
                "','" + txtlieu.Text +//8
                "','" + txtAdresse.Text +//9
                "','" + txtNumCart.Text +//10
                "','" + dpDateCartN.Value.ToString("yyyy-MM-dd") +//11
                "','" + txtLieuCart.Text +//12
                "','" + dpFactDate.Value.ToString("yyyy-MM-dd") +//13
                "','" + txtNSerie.Text + //14
                "','" + TotalOrder +//15
                 "','" + 0 + //16
                 "','" + "قيد الانجاز" + //17
                 "','" + 1+ //18
                 "','" +  //19
                "'," + "null" +//20
                "," + Properties.Settings.Default.userID  + "  )", "");//21
           // clearAllData();
           // AutoNumber();
        allMotos.showInTable(false);

        }

        private void txtPrixAchat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
       

        private void checkButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtPrixAchat.Text = prixhelp;
            txtApay.Text = prixhelp;
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPrixAchat.Text = prixNormal;
            txtApay.Text = prixNormal;
        }
 

        private void checkButton4_Click(object sender, EventArgs e)
        {
           
        }
        Boolean test = true;
        double payo = 0;
        Boolean isZero = false;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            TotalOrder = Convert.ToDouble(txtPrixAchat.Text) - Convert.ToDouble(txtDiscount.Text);
            lblPrixVent.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (test != false)
                {button1.Text = "Oui";
                    Discount = Convert.ToDouble(laRemise);
                    txtDiscount.Text = laRemise;
                    test = false;
                    
                }
                else
                {
                    button1.Text = "Non";
                    txtDiscount.Text = "0";
                    Discount = 0;
                    test = true;
                }

            }
            catch { }
        }
       
        private void simpleButton4_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(@"D:\Rapports\Model\model.docx");

            Microsoft.Office.Interop.Word.Range range = doc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: "nom", ReplaceWith: txtNomAr.Text, Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            range.Find.Execute(FindText: "date", ReplaceWith: dateTimePicker1.Text+" - " + txtlieu.Text, Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            range.Find.Execute(FindText: "adresse", ReplaceWith: txtAdresse.Text, Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            range.Find.Execute(FindText: "type", ReplaceWith: lblType.Text, Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            range.Find.Execute(FindText: "nserie", ReplaceWith: txtNSerie.Text, Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            range.Find.Execute(FindText: "cc", ReplaceWith: lblPiston.Text, Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            range.Find.Execute(FindText: "nplace", ReplaceWith: lblNbrPlaces.Text, Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            range.Find.Execute(FindText: "energie", ReplaceWith: lblEnregie.Text, Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            range.Find.Execute(FindText: "dvente", ReplaceWith: dpFactDate.Text, Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
            //if (doc.Bookmarks.Exists("Name"))
            //{

            //    object oBookMark = "Name";
            //    doc.Bookmarks.get_Item(ref oBookMark).Range.Text = "My Text To Replace";
            //}
            //if (doc.Bookmarks.Exists("bookmark_2"))
            //{
            //    object oBookMark = "bookmark_2";
            //    doc.Bookmarks.get_Item(ref oBookMark).Range.Text = "My Text To Replace bookmark_2";
            //}

            //doc.ExportAsFixedFormat("D:/myNewPdf.pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
            //doc.ExportAsFixedFormat("D:/myNewPdf.docx", Microsoft.Office.Interop.Word);

            doc.SaveAs(@"D:\Rapports\Motos\" + txtNomAr.Text +" "+ txtPhone1.Text+ ".docx");
            ((Microsoft.Office.Interop.Word._Document)doc).Close();
            ((Microsoft.Office.Interop.Word._Application)app).Quit();
        }
        /*Setting up a printable invoice for the required Customer
        */
        public void print()
        {


             
            var application = new Microsoft.Office.Interop.Word.Application();
            string path = Path.GetDirectoryName(Path.GetFullPath("Invoice.doc"));
            //object path_YourDocsName = path + @"\folder\YourDocsName.doc";

            object o = Missing.Value;
            object oFalse = false;
            object oTrue = true;

            Microsoft.Office.Interop.Word._Application app = null;
            Microsoft.Office.Interop.Word.Documents docs = null;
            Microsoft.Office.Interop.Word.Document doc = null;
            object path_YourDocsName = path + @"D:/Invoice.doc";
            try
            {
                app = new Microsoft.Office.Interop.Word.Application();
                app.Visible = false;
                app.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;

                docs = app.Documents;
                doc = docs.Open(ref path_YourDocsName, ref o, ref o, ref o, ref o, ref o, ref o, ref o, ref o, ref o, ref o, ref o, ref o, ref o, ref o, ref o);
                doc.Activate();

                foreach (Microsoft.Office.Interop.Word.Range range in doc.StoryRanges)
                {

                    Microsoft.Office.Interop.Word.Find find = range.Find;
                    object findText1 = "Name";
                    object replacText1 = "hhhhhh";
                    object replace1 = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
                    object findWrap1 = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue;
                    find.Execute(ref findText1, ref o, ref o, ref o, ref oFalse, ref o,
                        ref o, ref findWrap1, ref o, ref replacText1,
                        ref replace1, ref o, ref o, ref o, ref o);


                    Marshal.FinalReleaseComObject(find); 
                }
                
                Console.WriteLine(path_YourDocsName);
                doc.SaveAs(path_YourDocsName);
                ((Microsoft.Office.Interop.Word._Document)doc).Close(ref o, ref o, ref o);
                doc.Close();
                app.Quit(ref o, ref o, ref o);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (doc != null) Marshal.FinalReleaseComObject(doc);

                if (docs != null) Marshal.FinalReleaseComObject(docs);

                if (app != null)  Marshal.FinalReleaseComObject(app);
            }
            //Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

            //Microsoft.Office.Interop.Word.Document doc = app.Documents.Add("D:/Invoice.docx");

            //doc.Variables["Name"].Value = txtNomAr.Text ;

            //doc.Variables["Address"].Value = txtPhone1.Text;

            //doc.Variables["Town"].Value = txtlieu.Text;

            //doc.Variables["County"].Value = txtNumCart.Text;

            //doc.Variables["Phone_No"].Value = txtLieuCart.Text;

            //doc.Variables["Date"].Value = txtNSerie.Text;

            ////doc.Variables["Balance"].Value = lbl_Acc_Balance.Text;

            ////doc.Variables["Id"].Value = lbl_Customer_Id.Text;
            //doc.Fields.Update();

            //doc.SaveAs2("D:/Invoice2.docx");

            //doc.PrintOut();

            //doc.Close();

            //app.Quit();
        }
        private void txtPrixAchat_TextChanged(object sender, EventArgs e)
        {
            TotalOrder = Convert.ToDouble(txtPrixAchat.Text) - Convert.ToDouble(txtDiscount.Text);
            lblPrixVent.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
            txtApay.Text = TotalOrder+"";
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            TotalOrder = Convert.ToDouble(txtPrixAchat.Text) - Convert.ToDouble(txtDiscount.Text);
            lblPrixVent.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
            txtApay.Text = TotalOrder + "";
        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.dgvProduct.SelectedRows.Count > 0)
            //{
                 
                txtPrixAchat.Text = prixVGros;
             txtApay.Text = prixVGros;
            //}
            //else
            //{
            //    txtPrixAchat.Text = "0";
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (TotalOrder > 0)
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
                double testvar = payo - TotalOrder;
                var number = double.Parse(testvar + "".Replace("−", "-"));
                if (number > 0)
                {
                    txtApay.Text = "0";
                }


                leRest = TotalOrder - payo;
                //MessageBox.Show("leRest = "+ leRest+ " ; TotalOrder = "+ TotalOrder+ " ; payo = "+ payo);
                lblRest.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(leRest));
                if (leRest == 0)
                {
                    isZero = true;
                    dpToDette.Enabled = false; label22.Enabled = false;
                }
                else
                {
                    isZero = false;
                    dpToDette.Enabled = true; label22.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("pas de Articles dans la liste");
            }

        }
    }
}