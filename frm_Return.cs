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
using System.Runtime.InteropServices;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using Microsoft.Office.Interop.Excel; 

namespace Disdriver
{
    public partial class frm_Return : DevExpress.XtraEditors.XtraForm
    {
        [DllImport("user32.dll")]
        static extern IntPtr LoadKeyboardLayout(string pwszKLID, uint Flags);
        Boolean edit;
        public frm_Return(Boolean edit)
        {
            this.edit = edit;
            InitializeComponent();
            AutoNumberReturns();
            if (!edit)
            {
            AutoNumber();
            
                title1.Text = "إدارة المبيعات";
            }
            else
            {
                title1.Text = "إدارة المرجعات";
            } 
        }
        Database db = new Database(); 
         System.Data.DataTable tbl = new System.Data.DataTable();
        System.Data.DataTable dtbl = new System.Data.DataTable();
        String typePay = "";
        private void frm_sales_Load(object sender, EventArgs e)
        {

        }
        private void AutoNumberReturns()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from returns", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                lblRetNumFact.Text = "1";
            }
            else
            {
                lblRetNumFact.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }  
        }
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from sales", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                lblFactNumAuto.Text = "1";
            }
            else
            {
                lblFactNumAuto.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            //clearAllData();
            dpFactDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dpToDette.Text = DateTime.Now.ToString("yyyy-MM-dd");
            //dpDete1.Text = DateTime.Now.ToString("yyyy-MM-dd");
            //dpDete.Text = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
               // cbxForniss.SelectedIndex = 0;
                //cbxProd.SelectedIndex = 0;
            }
            catch (Exception) { }
            clearAll();
            //nudPrice.Value = 1;
            //btnAdd.Enabled = true;
            //btnNew.Enabled = true;
            //btnDelete.Enabled = false;
            //btnSave.Enabled = false;

        }
        public int oo = 1;
        public void clearAll()
        {
            db.executeData("TRUNCATE TABLE proforma", "");
            oo = 1;
            cbxForniss.Text = "choisissez un Cli ";
            txtApay.Clear();
            lblRest.Text = "";
            lblNombre.Text = "00"; 
            txtRemrq.Clear();
            lblTotal.Text = "0,00 DA";
        }

        private void FillClient()
        {
            cbxForniss.DataSource = db.readData("SELECT * FROM clients ", "");
            cbxForniss.DisplayMember = "nomFr";
            cbxForniss.ValueMember = "id";
        }

       
        double TotalOrder = 0.0, leRest = 0.0; double Discount = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
 

            DataGridViewRow row = this.dgvBuy.SelectedRows[0];
            String Product_ID = row.Cells[1].Value.ToString();
            tbl.Clear();
            tbl = db.readData("SELECT  qtt_rest   FROM buy_details WHERE pro_id=" + Product_ID + " and qtt_rest>0   ORDER BY buy_id  ASC ", "");
            if (tbl.Rows.Count == 0 || tbl.Rows[0][0] == DBNull.Value)
            {
                lblQttFact.Text = "0";
            }
            else
            {
                lblQttFact.Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString();
            }
            dgvBuy.Refresh();
            int IndexRowde = 0;
            foreach (DataGridViewRow rowede in dgvBuy.Rows)
            {
                if (rowede.Cells[1].Value.ToString().Equals(Product_ID))
                {
                   // MessageBox.Show("id of row selected :" + rowede.Index);
                    IndexRowde=rowede.Index;
                     dgvBuy.Rows[IndexRowde].Cells[11].Value = txtQtt.Text;

                  dgvBuy.Rows[IndexRowde].Cells[12].Value = Convert.ToDouble(dgvBuy.Rows[IndexRowde].Cells[11].Value) * Convert.ToDouble(dgvBuy.Rows[IndexRowde].Cells[5].Value);
                    rowede.Cells[11].Style.BackColor = Color.Yellow;
                    rowede.Cells[11].Style.ForeColor = Color.Black;
                    rowede.Cells[12].Style.BackColor = Color.Yellow;
                    rowede.Cells[12].Style.ForeColor = Color.Black;
                    break;
                }
                
            }
            
            
            dgvBuy.Refresh();
            refreche_Total();
        }
       public double TotalReturn = 0;
        public void refreche_Total()
        {
            dgvBuy.Refresh();
            try
            {
                TotalReturn = 0;
                for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                {

                    TotalReturn += Convert.ToDouble(dgvBuy.Rows[i].Cells[12].Value);
                }
                TotalOrder = 0;
                for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                {

                    TotalOrder += Convert.ToDouble(dgvBuy.Rows[i].Cells[7].Value);
                }
                TotalOrder = TotalOrder - TotalReturn;
                lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                txtApay.Text = Convert.ToString(TotalOrder);
                lblQttReturn.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalReturn));
                lblRest.Text = 0+"";
                //lblRest.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                lblNombre.Text = (dgvBuy.Rows.Count).ToString();
                dgvBuy.ClearSelection();
                dgvBuy.FirstDisplayedScrollingColumnIndex = dgvBuy.Rows.Count - 1;
                dgvBuy.Rows[dgvBuy.Rows.Count - 1].Selected = true;

            }
            catch
            {

            }
        }
        int payedAll = 0, payDette = 0;
        
///    //// //// / / / / / /   / ////                   //////            //////// ////             /////////     /////// /      //
        private void btnSaveFact_Click(object sender, EventArgs e)
        {
            if (cbxForniss.SelectedValue != null)
            { do_payement(); }
            else
            {
                MessageBox.Show(" لم يتم تحديد زبون من القائمة  ");
            }
        }
        private String getLastId()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from sales", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                return "0";
            }
            else
            {
                return (Convert.ToInt32(tbl.Rows[0][0])).ToString();

            }
        }
       public int id_payedAll(String idr)
        {
            int dd = 2;
                tbl.Clear();
                tbl = db.readData("select payed_all from sales where id ="+ idr, "");
                if (tbl.Rows.Count > 0)
                {
                dd=(Convert.ToInt32(tbl.Rows[0][0]));
                }
            return dd;
        }

        public Boolean isReturned=false;
        private void do_payement()
        {
            btnSaveFact.Enabled = false;
            //  String ClientNom = txtBoxClientN.Text;
            //if (clientSelection)
            //{
            //    ClientNom = txtBoxClientN.Text;
            //}
            //else
            //{
            String ClientNom = cbxForniss.Text;
            //}
            if (txtApay.Text == "" || txtApay.Text == null) { MessageBox.Show("أدخل المبلغ "); txtApay.Text = "0"; txtApay.Focus(); }
            else
            {
                

                //btnPrint.Enabled = true;
                if (Convert.ToBoolean(isZero)) { payedAll = 0; } else { payedAll = 0; };
                if (edit)
                {

                    db.executeData("UPDATE sales SET   " +
                    //     txtFactNum.Text +
                    " date='" + dpFactDate.Value.ToString("yyyy-MM-dd") +
                    //"',client_id='" + ClientNom +
                    "',totalsale='" + TotalOrder +
                    "',apay='" + txtApay.Text +
                    "',lereste='" + leRest +
                    "',detteDate='" + dpToDette.Value.ToString("yyyy-MM-dd") +
                    "',payed_all='" + payedAll +
                    "',Remarque='" + txtRemrq.Text +
                    "',timer=null" +
                    ",user_id=" + Properties.Settings.Default.userID + " WHERE id= " + lblFactNumAuto.Text, "");

                    db.executeData("DELETE FROM sales_details WHERE sale_id = " + lblFactNumAuto.Text, "");
                    /////////////////////////////////////////////////////// IF Sales returned 
                    if (isReturned)
                    {
                        db.executeData("insert into returns values (null" +
                         "," +  lblFactNumAuto.Text +
                    ",'" + dpFactDate.Value.ToString("yyyy-MM-dd") +
                    "'," + TotalReturn +
                    "," + 0 +
                    ",'" + ClientNom +
                    "','" + txtRemrq.Text +
                    "'," + Properties.Settings.Default.userID +
                    ",null )", "");
                        String Strqueryss = "";
                        for (int dd = 0; dd <= dgvBuy.Rows.Count - 1; dd++)
                        {
                            if (Convert.ToInt32(dgvBuy.Rows[dd].Cells[11].Value) >0)
                            {
                                  Strqueryss = @"Insert into returns_details values ("
                                        + "null" + ", "
                                        + lblRetNumFact.Text + ", "
                                        + dgvBuy.Rows[dd].Cells[1].Value + ", "// pro id 
                                        + dgvBuy.Rows[dd].Cells[5].Value + ", "// prix
                                        + dgvBuy.Rows[dd].Cells[11].Value + ", "// qtt
                                        + dgvBuy.Rows[dd].Cells[12].Value + ", "// total 
                                        + 0 + ", "// total خسارة
                                         + "null" + "  );";
                                   db.executeData(Strqueryss, "");
                            }
                        }
                    }
                }
                //else
                //{

                //    db.executeData("insert into sales values (null,'" +
                //                    //     txtFactNum.Text +
                //                    "','" + dpFactDate.Value.ToString("yyyy-MM-dd") +
                //                    "','" + ClientNom +
                //                    "','" + TotalOrder +
                //                    "','" + txtApay.Text +
                //                    "','" + leRest +
                //                    "','" + dpToDette.Value.ToString("yyyy-MM-dd") +
                //                    "','" + payedAll +
                //                    "','" + txtRemrq.Text +
                //                    "',null" +
                //                    "," + Properties.Settings.Default.userID + ")", "");
                //    // MessageBox.Show("after insert in sale");
                //}
                

                String Strquery = "";
                for (int dd = 0; dd <= dgvBuy.Rows.Count - 1; dd++)
                {
                    Double benifice = Convert.ToDouble(dgvBuy.Rows[dd].Cells[7].Value) - (Convert.ToDouble(dgvBuy.Rows[dd].Cells[9].Value) * Convert.ToDouble(dgvBuy.Rows[dd].Cells[6].Value));
                    if (Convert.ToDouble(dgvBuy.Rows[dd].Cells[6].Value)!= Convert.ToDouble(dgvBuy.Rows[dd].Cells[11].Value))
                    {
                        //MessageBox.Show("before insert in saledetails");
                             Strquery = @"Insert into sales_details  values ("
                                + "null" + ", "
                                + lblFactNumAuto.Text + ", "
                                + dgvBuy.Rows[dd].Cells[1].Value + ", "// pro id
                                + dgvBuy.Rows[dd].Cells[8].Value + ", '"// fact achat id
                                + dgvBuy.Rows[dd].Cells[3].Value + "', "// type
                                + dgvBuy.Rows[dd].Cells[4].Value + ", "// prix
                                + dgvBuy.Rows[dd].Cells[5].Value + ", "// remise
                                + (Convert.ToDouble(dgvBuy.Rows[dd].Cells[6].Value) - Convert.ToDouble(dgvBuy.Rows[dd].Cells[11].Value)) + ", "// qtt
                                +(Convert.ToDouble(dgvBuy.Rows[dd].Cells[5].Value) * (Convert.ToDouble(dgvBuy.Rows[dd].Cells[6].Value) - Convert.ToDouble(dgvBuy.Rows[dd].Cells[11].Value))) + ", "// total
                                + benifice + ", "// total + "', '"// total/////////////////////////////////////////////////////////////// catastrophe
                                 + "null" + "  );";
                             db.executeData(Strquery, "");
                    }
                   
                    if (Convert.ToDecimal(lblQttFact.Text) >= Convert.ToDecimal(txtQtt.Text))
                    {
                        db.executeData(@"update buy_details set " +
                        " qtt_rest=qtt_rest-" + (Convert.ToDouble(dgvBuy.Rows[dd].Cells[6].Value) - Convert.ToDouble(dgvBuy.Rows[dd].Cells[11].Value)) +
                        " where buy_id =" + dgvBuy.Rows[dd].Cells[8].Value + " AND pro_id=" + dgvBuy.Rows[dd].Cells[1].Value + " ", "");
                    }
                    else
                    {

                        //100
                        //63-33=30
                        //Decimal qttTest = Convert.ToDecimal(dgvBuy.Rows[dd].Cells[6].Value);// 63
                        Decimal qttTest = (Convert.ToDecimal(dgvBuy.Rows[dd].Cells[6].Value) - Convert.ToDecimal(dgvBuy.Rows[dd].Cells[11].Value));// 63
                        Decimal qttRestTest;
                        Boolean isEnded = false;
                        while (!isEnded)
                        {
                             
                            // 
                            tbl = db.readData("SELECT buy_id,qtt_rest,price  FROM buy_details WHERE pro_id=" + dgvBuy.Rows[dd].Cells[1].Value + " and qtt_rest>0   ORDER BY buy_id  ASC ", "");

                            if (tbl.Rows.Count > 0)
                            {
                                
                                qttRestTest = Convert.ToDecimal(tbl.Rows[0][1]);// 33
                                Decimal result = qttTest - qttRestTest;// 36-35=1  ....  1-33
                                if (result >= 0)
                                {
                                    db.executeData(@"update buy_details set " +
                                    " qtt_rest=0" +
                                    " where buy_id =" + Convert.ToDecimal(tbl.Rows[0][0]) + " AND pro_id=" + dgvBuy.Rows[dd].Cells[1].Value + " ", "");
                                    qttTest = result;//=1
                                }

                                else
                                {
                                    db.executeData(@"update buy_details set " +
                                    " qtt_rest=" + (qttRestTest - qttTest) +//33-1=32
                                    " where buy_id =" + Convert.ToDecimal(tbl.Rows[0][0]) + " AND pro_id=" + dgvBuy.Rows[dd].Cells[1].Value + " ", "");
                                    isEnded = true;
                                }
                            }
                            else
                            {
                                isEnded = true;
                            }



                        }


                    }


                }
                if (id_payedAll(lblFactNumAuto.Text) ==0)
                {
                    MessageBox.Show("its 00000000");
                    Strquery = @"update clients  SET Dette =Dette-" + TotalReturn +
                       " where id=" + cbxForniss.SelectedValue + "    ;";
                    db.executeData(Strquery, "");
                    Strquery = "";
                    //Strquery = @"Insert into dettes_clients  values ("
                    //            + "null" + ", "
                    //            + cbxForniss.SelectedValue + ", '"
                    //            + lblFactNumAuto.Text + "', '"
                    //            + leRest + "', '"
                    //            + dpToDette.Value.ToString("yyyy-MM-dd") + "',  "
                    //             + 0 + " , null ," + Properties.Settings.Default.userID + ",  null);";
                    Strquery = @"update dettes_clients  set total_dette=total_dette-'" + TotalReturn
                               + "' ,date_to_pay='" + dpToDette.Value.ToString("yyyy-MM-dd") + "' " +
                              " where id_client=" + cbxForniss.SelectedValue + " and num_fact=" + lblFactNumAuto.Text + ";";
                    db.executeData(Strquery, "");
                }

                //if (payedAll == 0)
                //{

                //    Strquery = @"update clients  SET Dette =Dette- " + leRest +
                //       " where id=" + cbxForniss.SelectedValue + "    ;";
                //    db.executeData(Strquery, "");
                //    Strquery = "";
                //    if (edit)
                //    {
                //        Strquery = @"update dettes_clients  set total_dette='" + leRest
                //                + "' ,date_to_pay='" + dpToDette.Value.ToString("yyyy-MM-dd") + "' " +
                //               " where id_client=" + cbxForniss.SelectedValue + " and num_fact=" + lblFactNumAuto.Text + ";";
                //    }
                //    else
                //    {
                //        Strquery = @"Insert into dettes_clients  values ("
                //                + "null" + ", "
                //                + cbxForniss.SelectedValue + ", '"
                //                + lblFactNumAuto.Text + "', '"
                //                + leRest + "', '"
                //                + dpToDette.Value.ToString("yyyy-MM-dd") + "',  "
                //                 + 0 + " , null ," + Properties.Settings.Default.userID + ",  null);";
                //    }

                //    db.executeData(Strquery, "");
                //}


            }

            tbl.Clear();
            tbl = db.readData("select max(id) from sales", "");
            if (tbl.Rows.Count >= 0)
            {
                if (tbl.Rows[0][0].ToString() == lblFactNumAuto.Text)
                {
                    clearAll();
                    AutoNumber();
                }
            }
            else
            {
                MessageBox.Show("لم يتم تسجيل عملية البيع");
            }
            this.Hide();
            //if (edit) {
              
            //}
        }//dopaymentes
 
        double payo = 0;
        Boolean isZero = false;
        List<String> idToDeletes = new List<String>();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvBuy.SelectedRows[0];
            if (this.dgvBuy.SelectedRows.Count > 0)
            {
                if (edit)
                {
                   // MessageBox.Show(row.Cells[0].Value.ToString());
                    idToDeletes.Add(row.Cells[0].Value.ToString());
                }
                this.dgvBuy.Rows.RemoveAt(this.dgvBuy.SelectedRows[0].Index);
                refreche_Total();  
            }
        }
 
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //rpt_fact_sale rpt = new rpt_fact_sale();
            // crystalReportViewer1.ReportSource = rpt;

            //DataTable dt = ((DataView)this.dgvBuy.DataSource).Table;

            //frm_fact fact = new frm_fact();

            //tbl.Clear();
            //DataSet ds = new DataSet();
            //ds = db.getResults("SELECT reference1,name,remise,qty,total FROM  v_sales  WHERE sale_id='" + ( Convert.ToDecimal(lblFactNumAuto.Text))+ "'  ");
            //rpt_fact_sale cry = new rpt_fact_sale();


            // MessageBox.Show(Convert.ToString(ds.Tables[0].Rows[0][0]));
            //cry.SetDataSource(ds);

            //TextObject Text9 = (TextObject)cry.ReportDefinition.Sections["Section1"].ReportObjects["Text9"];
            //Text9.Text = clientName;
            //TextObject Text10 = (TextObject)cry.ReportDefinition.Sections["Section1"].ReportObjects["Text10"];
            //Text10.Text = lblFactNumAuto.Text;
            //fact.crystalReportViewer1.ReportSource = cry;
            //fact.crystalReportViewer1.Refresh();
            //fact.ShowDialog();
            WriteExcel();
        }
        public void WriteExcel()
        {
            //DataTable tblItems = new DataTable();
            //tblItems.Clear();
            //tblItems = db.readData("select max(id) from sales", "");
            //foreach (DataRow row in tblItems.Rows)
            //{
            //    int nc = dgvProduct.Rows.Add();
            //    dgvProduct.Rows[nc].Cells[0].Value = row["id"].ToString();
            //    dgvProduct.Rows[nc].Cells[1].Value = row["name"].ToString();
            //    dgvProduct.Rows[nc].Cells[2].Value = row["reference1"].ToString();
            //    dgvProduct.Rows[nc].Cells[3].Value = row["mark"].ToString();
            //    dgvProduct.Rows[nc].Cells[4].Value = row["pricesale"].ToString();
            //    dgvProduct.Rows[nc].Cells[5].Value = row["prix_grox"].ToString();
            //    dgvProduct.Rows[nc].Cells[6].Value = row["pricehelp"].ToString();
            //    dgvProduct.Rows[nc].Cells[7].Value = row["remise"].ToString();
            //}
            var memoryStream = new MemoryStream();

            using (var fs = new FileStream("Result.xlsx", FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet("Sheet1");

                List<String> columns = new List<string>();
                IRow row = excelSheet.CreateRow(0);
                int columnIndex = 0;
                for (int i = 1; i < dgvBuy.Columns.Count + 1; i++)
                {
                        row.CreateCell(i-1).SetCellValue(dgvBuy.Columns[i - 1].HeaderText);
                }
                //foreach (System.Data.DataColumn column in dgvBuy.Columns)
                //{
                //    columns.Add(column.ColumnName);
                //    row.CreateCell(columnIndex).SetCellValue(column.ColumnName);
                //    columnIndex++;
                //}
                for (int i = 0; i < dgvBuy.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvBuy.Columns.Count; j++)
                    { 
                        row.CreateCell(j+1).SetCellValue(dgvBuy.Rows[i].Cells[j].ToString());
                    }
                }
                //int rowIndex = 1;
                //foreach (DataRow dsrow in dgvBuy.Rows)
                //{
                //    row = excelSheet.CreateRow(rowIndex);
                //    int cellIndex = 0;
                //    foreach (String col in columns)
                //    {
                //        row.CreateCell(cellIndex).SetCellValue(dsrow[col].ToString());
                //        cellIndex++;
                //    }

                //    rowIndex++;
                //}
                workbook.Write(fs);
            }

        }
   
        private void btnProfrma_Click(object sender, EventArgs e)
        {
            String ClientNom = "";
            if (clientSelection)
            {
              //  ClientNom = txtBoxClientN.Text;
            }
            else
            {
                ClientNom = cbxForniss.SelectedValue.ToString();
            }
            db.executeData("TRUNCATE TABLE proforma", "");
            String Strquery = "";
            for (int dd = 0; dd <= dgvBuy.Rows.Count - 1; dd++)
            {
                
                Strquery = @"Insert into proforma  values (" 
                           + lblFactNumAuto.Text + ", '"
                           + dgvBuy.Rows[dd].Cells[1].Value + "', '"// pro id
                           + dgvBuy.Rows[dd].Cells[1].Value + "', '"// fact achat id
                           + dgvBuy.Rows[dd].Cells[2].Value + "', '"// nom 
                           + dgvBuy.Rows[dd].Cells[5].Value + "', '"// remise
                           + dgvBuy.Rows[dd].Cells[6].Value + "', '"// qtt
                           + dgvBuy.Rows[dd].Cells[7].Value  + "'  );";
            db.executeData(Strquery, "");
            }

            
            frm_fact fact = new frm_fact();

            tbl.Clear();
            DataSet ds = new DataSet();
            ds = db.getResults("SELECT reference1,name,remise,qty,total FROM  proforma   ");
            rpt_fact_sale cry = new rpt_fact_sale();


            // MessageBox.Show(Convert.ToString(ds.Tables[0].Rows[0][0]));
            cry.SetDataSource(ds);
            
             TextObject Text7 = (TextObject)cry.ReportDefinition.Sections["Section1"].ReportObjects["Text7"];
            Text7.Text = "Bon De Livraison";

            TextObject Text9 = (TextObject)cry.ReportDefinition.Sections["Section1"].ReportObjects["Text9"];
            Text9.Text = ClientNom;
            TextObject Text10 = (TextObject)cry.ReportDefinition.Sections["Section1"].ReportObjects["Text10"];
            Text10.Text = lblFactNumAuto.Text;
            fact.crystalReportViewer1.ReportSource = cry;
            fact.crystalReportViewer1.Refresh();
            fact.ShowDialog();
        }
        String clientName="";
        Boolean clientSelection = true;
        private void cbxClientN_CheckedChanged(object sender, EventArgs e)
        {
         //   txtBoxClientN.Enabled = true;
            cbxForniss.Enabled = false; clientSelection = true;
        }

        private void cbxClientS_CheckedChanged(object sender, EventArgs e)
        {
         //   txtBoxClientN.Enabled = false;
            cbxForniss.Enabled = true;
            clientSelection = false;
        }
 
        private void txtBarCode_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {
            LoadKeyboardLayout("00000409", 1);
            //LoadKeyboardLayout("00010409", 1);
        }

        private void cbxClientS_CheckedChanged_1(object sender, EventArgs e)
        {
            cbxForniss.Enabled = true;
          //  txtBoxClientN.Enabled = false;
            clientSelection = false;
        }

        private void cbxClientN_CheckedChanged_1(object sender, EventArgs e)
        {
            cbxForniss.Enabled = false;
           // txtBoxClientN.Enabled = true;
            clientSelection = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtApay.Text = Convert.ToString(TotalOrder);
        }

        private void cbxForniss_Click(object sender, EventArgs e)
        {

            FillClient();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_clients clint = new frm_clients();
            clint.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            dgvBuy.Rows.Clear(); clearAll(); 
        }
        private Double getDetteClient(String nomFr)
        {
            Double valDette = 0.0;
            tbl.Clear();
            tbl = db.readData("select Dette from clients where nomFr='" + nomFr + "'", "");
            if (tbl.Rows.Count >= 0)
            {
                valDette = Convert.ToDouble(tbl.Rows[0][0]);
            }
            else
            {
                valDette = 0.0;
            }
            return valDette;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (cbxForniss.SelectedValue != null)
            {
       
                try { 
            //WriteExcel();
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            xlApp = new Microsoft.Office.Interop.Excel.Application(); 
            string filePath = @"c:\Modele\model.xlsx";
            xlWorkBook = xlApp.Workbooks.Open(filePath);
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
            worksheet.Name = "Exported from gridview";
                    String clntPhone;

                    worksheet.Cells[7, 3] = cbxForniss.Text;
                    tbl.Clear();
                    tbl = db.readData("SELECT * FROM `clients` where nomFr = '" + cbxForniss.Text+"'", "");
                    if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
                    {
                        lblFactNumAuto.Text = "1"; 
                    }
                    else
                    {
                        worksheet.Cells[8, 3] = tbl.Rows[0][6].ToString();//address
                        worksheet.Cells[9, 3] = tbl.Rows[0][3].ToString()+" / " + tbl.Rows[0][4].ToString();//Telephone 
                        worksheet.Cells[10, 3] = tbl.Rows[0][12].ToString()+" - MF: "+tbl.Rows[0][13].ToString();
                        worksheet.Cells[11, 3] = tbl.Rows[0][14].ToString() + " - AI: " + tbl.Rows[0][15].ToString();
                    }

                    worksheet.Cells[5, 8] = lblFactNumAuto.Text;
                    worksheet.Cells[16, 4] = lblNombre.Text; ;
                    worksheet.Cells[18, 8] = getDetteClient(cbxForniss.Text);
                    //  worksheet.Cells[19, 8] = getDetteClient(cbxForniss.Text) - Convert.ToDouble(lblRest.Text);
                    worksheet.Cells[20, 8] = txtApay.Text;
                    // Insert five rows into the worksheet at the 9th position.
                    // worksheet.Rows.Insert(18, 10);
                    CopyRowsDown(worksheet, 14 , dgvBuy.Rows.Count);

                // storing header part in Excel  
                //for (int i = 1; i < dgvBuy.Columns.Count + 1; i++)
                //{

                //        worksheet.Cells[1, i] = dgvBuy.Columns[i - 1].HeaderText;

                //}
                // storing Each row and column value to excel sheet   

                for (int i = 0; i < dgvBuy.Rows.Count; i++)
            {
                  
                    int col = 0;
                for (int j = 0; j < dgvBuy.Columns.Count-3; j++)
                {
                        if (j!=4)
                        {
                                if (j==0) {
                                    worksheet.Cells[i + 14, col + 2] = i+1; col++;
                                } else {
                                    worksheet.Cells[i + 14, col + 2] = dgvBuy.Rows[i].Cells[j].Value.ToString(); col++;
                                }
                            
                        }
                }
                  
            }

                    // save the application  
                    xlWorkBook.SaveAs(@"D:\DR Rapports\Facture Le  " + DateTime.Now.ToString("d_M_yyyy hh_mm_ss") + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    // Exit from the application  
                    // app.Quit();
                }
                catch   { }
               // do_payement();
            }
            else
            {
                MessageBox.Show(" لم يتم تحديد زبون من القائمة  ");
            }
            
        }


        public static void CopyRowsDown(_Worksheet worksheet, int startRowIndex, int countToCopy)
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
                //lblRest.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(leRest));
                lblRest.Text =   Convert.ToString(leRest);
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

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBuy_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dgvBuy.SelectedRows.Count > 0)
            {

                DataGridViewRow row = this.dgvBuy.SelectedRows[0]; 
                txtQtt.Text = row.Cells[6].Value.ToString();
                txtQtt.Maximum= Convert.ToDecimal( row.Cells[6].Value) ;
                string Product_ID = row.Cells[1].Value.ToString();
                 
            }
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < idToDeletes.Count; i++)
        //        MessageBox.Show(idToDeletes[i]);
        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    if (TotalOrder > 0)
        //    {

        //        if (txtApay.Text == "" || txtApay.Text == null)
        //        {
        //            // txtApay.Text = "0";
        //            payo = 0;
        //        }
        //        else
        //        {
        //            payo = Convert.ToDouble(txtApay.Text);
        //        }
        //        double testvar = payo - TotalOrder;
        //        var number = double.Parse(testvar + "".Replace("−", "-"));
        //        if (number > 0)
        //        {
        //            txtApay.Text = "0";
        //        }


        //        leRest = TotalOrder - payo;
        //        lblRest.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(leRest));

        //    }
        //    else
        //    {
        //        MessageBox.Show("pas de Articles dans la liste");
        //    }

        //}
        private void txtApay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void showInTable( string sale_id)
        {
            this.dgvBuy.DataSource = null;
            this.dgvBuy.Rows.Clear();
            tbl.Clear();

 

                tbl = db.readData("SELECT * FROM v_sales_toupdate WHERE sale_id=" + sale_id, "");  // 

          
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
                        dgvBuy.Rows[nc].Cells[3].Value = row["type_pay"].ToString();
                        dgvBuy.Rows[nc].Cells[4].Value = row["price"].ToString();
                        dgvBuy.Rows[nc].Cells[5].Value = row["remise"].ToString();
                        dgvBuy.Rows[nc].Cells[6].Value = row["qty"].ToString();
                        dgvBuy.Rows[nc].Cells[7].Value = row["total"].ToString();
                        dgvBuy.Rows[nc].Cells[8].Value = row["buy_id"].ToString();
                        dgvBuy.Rows[nc].Cells[9].Value = row["prixAchat"].ToString();
                        dgvBuy.Rows[nc].Cells[10].Value = 1;
                        dgvBuy.Rows[nc].Cells[11].Value = 0;
                        dgvBuy.Rows[nc].Cells[12].Value = 0;
                    }

                }
                catch (Exception) { }

                Double TotalOrder = 0; Double Totalbenfice = 0;
                lblNombre.Text = dgvBuy.Rows.Count.ToString();
                for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                {
                    TotalOrder += Convert.ToDouble(dgvBuy.Rows[i].Cells[7].Value)- TotalReturn; 
                  //  Totalbenfice += Convert.ToDouble(dgvBuy.Rows[i].Cells[6].Value);
                }
                lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
              //  lblBenifice.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(Totalbenfice));

            }
        }
    }
}