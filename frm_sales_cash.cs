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

using Microsoft.Office.Interop.Excel;
using CrystalDecisions.CrystalReports.Engine;
using System.Runtime.InteropServices;

// 1. Use Easy Tabs
using EasyTabs; 

namespace Disdriver
{
    public partial class frm_sales_cash : DevExpress.XtraEditors.XtraForm
    {
        [DllImport("user32.dll")]
        static extern IntPtr LoadKeyboardLayout(string pwszKLID, uint Flags);

        double payo = 0;
        Boolean isZero = false;
        String clientName = "";

        // 2. Important: Declare ParentTabs
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        Database db = new Database();
        System.Data.DataTable tbl = new System.Data.DataTable();
        System.Data.DataTable dtbl = new System.Data.DataTable();
        String typePay = "";

        public frm_sales_cash()
        {

            LoadKeyboardLayout("00000409", 1);
            InitializeComponent();
            dpFactDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dpToDette.Text = DateTime.Now.ToString("yyyy-MM-dd");
            // AutoNumber();
            //  txtBarCode.Focus();
        }
        private String getLastId()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from sales", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {

                return  "0";
            }
            else
            {
                return (Convert.ToInt32(tbl.Rows[0][0]) ).ToString();
            }
            //clearAllData();
          
           
            //clearAll();
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
            cbxForniss.Text = "choisissez un Client";
            //btnPrint.Enabled = false;
            txtSearch.Clear();
            //dgvProduct.Clear();
            dgvBuy.Rows.Clear();
            //txtFactNum.Clear();
            //txtFactNum.Focus();
            txtPrixAchat.Clear();
            txtApay.Text = "0";
            lblRest.Text = "";
            lblNombre.Text = "00";  
            lblTotal.Text = "0,00 DA";
        }

        private void FillClient()
        {
            cbxForniss.DataSource = db.readData("SELECT * FROM clients ", "");
            cbxForniss.DisplayMember = "nomFr";
            cbxForniss.ValueMember = "id";
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvProduct.Visible = true;
            if (txtSearch.Text != "" && txtSearch.Text != null)
            {
                this.dgvProduct.DataSource = null;
                this.dgvProduct.Rows.Clear();

                System.Data.DataTable tblItems = new System.Data.DataTable();
                tblItems.Clear();
                tblItems = db.readData("select products.id  ,products.name  ,products.reference1  ,products.mark  ,products.pricesale,products.prix_grox, products.pricehelp,products.remise from products inner join buy_details on products.id=buy_details.pro_id where name  LIKE '" + txtSearch.Text + "%'    or reference1 LIKE '" + txtSearch.Text + "%' ", "");
                //  dgvProduct.DataSource = tblItems.Rows;
                foreach (DataRow row in tblItems.Rows)
                {
                    int nc = dgvProduct.Rows.Add();
                    dgvProduct.Rows[nc].Cells[0].Value = row["id"].ToString();
                    dgvProduct.Rows[nc].Cells[1].Value = row["name"].ToString();
                    dgvProduct.Rows[nc].Cells[2].Value = row["reference1"].ToString();
                    dgvProduct.Rows[nc].Cells[3].Value = row["mark"].ToString();
                    dgvProduct.Rows[nc].Cells[4].Value = row["pricesale"].ToString();
                    dgvProduct.Rows[nc].Cells[5].Value = row["prix_grox"].ToString();
                    dgvProduct.Rows[nc].Cells[6].Value = row["pricehelp"].ToString();
                    dgvProduct.Rows[nc].Cells[7].Value = row["remise"].ToString();
                }
            }
            else
            {
                this.dgvProduct.DataSource = null;
                this.dgvProduct.Rows.Clear();
            }
        }
        double TotalOrder = 0.0, leRest = 0.0; double Discount = 0;
        private void btnAdd_Click(object sender, EventArgs e)/////////////////////
        {

            if ((Convert.ToDecimal(lblQTT.Text) >= Convert.ToDecimal(txtQtt.Text) ) && ((Convert.ToDecimal(lblQTT.Text) !=0) && (Convert.ToDecimal(txtPrixAchat.Text) != 0)) )
            {
                if (fromBuy)
                {
                    DataGridViewRow row = this.dgvBuy.SelectedRows[0];
                    String Product_ID =  row.Cells[1].Value.ToString();
                    int IndexRowde = 0;
                    foreach (DataGridViewRow rowede in dgvBuy.Rows)
                    {
                        if (rowede.Cells[1].Value.ToString().Equals(Product_ID))
                        {

                            IndexRowde = rowede.Index;
                        }
                        //rowede.Cells[Product_ID].Style.BackColor = Color.Yellow;
                        //row.Cells[Product_ID].Style.ForeColor = Color.Black;
                    }
                    dgvBuy.Rows[IndexRowde].Cells[3].Value = typePay;
                    dgvBuy.Rows[IndexRowde].Cells[5].Value = txtPrixAchat.Text;
                    if (togswRemise.IsOn)
                    {
                        dgvBuy.Rows[IndexRowde].Cells[5].Value = Convert.ToDouble(txtPrixAchat.Text) - Convert.ToDouble(txtDiscount.Text);
                    }
                    dgvBuy.Rows[IndexRowde].Cells[6].Value = txtQtt.Text;

                    dgvBuy.Rows[IndexRowde].Cells[7].Value = Convert.ToDouble(dgvBuy.Rows[IndexRowde].Cells[6].Value) * Convert.ToDouble(dgvBuy.Rows[IndexRowde].Cells[5].Value);
                    dgvBuy.Refresh();
                    Discount = 0;
                    dgvBuy.Refresh();
                }//fromBuy
                else { //start from products
                    try
                    {
                        Discount = 0;
                        DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                        String Product_ID = row.Cells[0].Value.ToString();
                        String Product_Name = row.Cells[1].Value.ToString();
                        Double Product_Qty = Convert.ToDouble(txtQtt.Text);
                        String Product_Price = txtPrixAchat.Text;
                        //decimal total = Product_Qty * Convert.ToDecimal(txtPrixAchat.Text);
                        Double total = Product_Qty * (Convert.ToDouble(txtPrixAchat.Text) - Convert.ToDouble(txtDiscount.Text));
                        Boolean existedIdProduct = false; int IndexRow = 0;
                        foreach (DataGridViewRow rowede in dgvBuy.Rows)
                        {
                            if (rowede.Cells[1].Value.ToString().Equals(Product_ID))
                            {
                                existedIdProduct = true;
                                IndexRow = rowede.Index;
                            }
                            //    rowede.Cells["chat1"].Style.ForeColor = Color.Red;
                            //    row.Cells["chat1"].Style.ForeColor = Color.CadetBlue;
                        }

                        if (dgvBuy.Rows.Count == 0 || existedIdProduct == false)
                        {
                            int n = dgvBuy.Rows.Add();

                            dgvBuy.Rows[n].Cells[0].Value  = oo++;
                            dgvBuy.Rows[n].Cells[1].Value  = Product_ID;
                            dgvBuy.Rows[n].Cells[2].Value  = Product_Name;
                            dgvBuy.Rows[n].Cells[3].Value  = typePay;
                            dgvBuy.Rows[n].Cells[4].Value  = Product_Price;
                            dgvBuy.Rows[n].Cells[5].Value  = Convert.ToDouble(Product_Price) - Convert.ToDouble(txtDiscount.Text);
                            dgvBuy.Rows[n].Cells[6].Value  = Product_Qty;
                            dgvBuy.Rows[n].Cells[7].Value  = total;
                            dgvBuy.Rows[n].Cells[8].Value  = lblFactNum.Text;
                            dgvBuy.Rows[n].Cells[9].Value  = prixAchat;
                            dgvBuy.Rows[n].Cells[10].Value = txtPrixAchat.Text;
                            dgvBuy.Rows[n].Cells[11].Value = txtDiscount.Text;
                        }
                        else
                        {
                            if (existedIdProduct)
                            {
                                dgvBuy.Rows[IndexRow].Cells[6].Value = Convert.ToDouble(dgvBuy.Rows[IndexRow].Cells[6].Value) + Product_Qty;

                                dgvBuy.Rows[IndexRow].Cells[7].Value = Convert.ToDecimal(dgvBuy.Rows[IndexRow].Cells[6].Value) * Convert.ToDecimal(dgvBuy.Rows[IndexRow].Cells[5].Value);
                                dgvBuy.Refresh();
                            }

                        }
                    }
                    catch (Exception) {
                    } //end from products
                }
                refreche_Total();
            }
            else
            {
                    MessageBox.Show("Quantité supperieur !");
                }
            txtBarCode.Focus();
        }
        public void refreche_Total()
        {
            dgvBuy.Refresh();
            try
            {

                TotalOrder = 0;
                for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                {

                    TotalOrder += Convert.ToDouble(dgvBuy.Rows[i].Cells[7].Value);
                }
                lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                txtApay.Text = Convert.ToString(TotalOrder);
               // lblRest.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                lblRest.Text = "0";
                lblNombre.Text = (dgvBuy.Rows.Count).ToString();
                dgvBuy.ClearSelection();
               // dgvBuy.FirstDisplayedScrollingColumnIndex = dgvBuy.Rows.Count - 1;
                dgvBuy.Rows[dgvBuy.Rows.Count - 1].Selected = true;

            }
            catch
            {

            }
        }
        int payedAll = 0, payDette = 0;


        private void btnSaveFact_Click(object sender, EventArgs e)
        {
            btnSaveFact.Enabled = false;
            String ClientNom = "Client";
            if (clientSelection)
            {
                ClientNom = txtBoxClientN.Text;
            }
            else
            {
                ClientNom = cbxForniss.SelectedValue.ToString();
            }
            if (txtApay.Text == "" || txtApay.Text == null) { MessageBox.Show("أدخل المبلغ "); txtApay.Text = "0"; txtApay.Focus(); }
            else
            {
                btnPrint.Enabled = true;
                if (Convert.ToBoolean(isZero)) { payedAll = 1; } else { payedAll = 0; };
                //MessageBox.Show("insert into sales values !"+" - "+ dpFactDate.Value.ToString("yyyy-MM-dd")+ " - " + ClientNom + " - " + TotalOrder + " - " + txtApay.Text + " - " + txtApay.Text + " - " + 
                    //leRest + " - " + dpToDette.Value.ToString("yyyy-MM-dd") + " - " + payedAll + " - " + Properties.Settings.Default.userID);
                //if (Convert.ToBoolean(chxDette.Checked)) { j = 1; };
                db.executeData("insert into sales values (null,'" +
                                  //     txtFactNum.Text +
                                  "','" + dpFactDate.Value.ToString("yyyy-MM-dd") +
                                "','" + ClientNom +
                                "','" + TotalOrder +
                                "','" + txtApay.Text +
                                "','" + leRest +
                                "','" + dpToDette.Value.ToString("yyyy-MM-dd") +
                                "','" + payedAll +
                                "',null" + 
                                ",null" +
                                ","+ Properties.Settings.Default.userID+")", "");
                String Strquery = "";
                for (int dd = 0; dd <= dgvBuy.Rows.Count - 1; dd++)
                {
                    Double benifice = Convert.ToDouble(dgvBuy.Rows[dd].Cells[7].Value) - (Convert.ToDouble(dgvBuy.Rows[dd].Cells[9].Value) * Convert.ToDouble(dgvBuy.Rows[dd].Cells[6].Value));

                    //MessageBox.Show("insert into sales_details values !");
                    Strquery = @"Insert into sales_details  values ("
                                + "null" + ", '"
                                + getLastId() + "', '"
                                + dgvBuy.Rows[dd].Cells[1].Value + "', '"// pro id
                                + dgvBuy.Rows[dd].Cells[8].Value + "', '"// fact achat id
                                + dgvBuy.Rows[dd].Cells[3].Value + "', '"// type
                                + dgvBuy.Rows[dd].Cells[4].Value + "', '"// prix
                                + dgvBuy.Rows[dd].Cells[5].Value + "', '"// remise
                                + dgvBuy.Rows[dd].Cells[6].Value + "', '"// qtt
                                + dgvBuy.Rows[dd].Cells[7].Value + "', '"// total
                                + benifice + "', "// total + "', '"// total/////////////////////////////////////////////////////////////// catastrophe
                                 + "null" + "  );";
                    db.executeData(Strquery, "");
                    if (Convert.ToDecimal(lblQttFact.Text) >= Convert.ToDecimal(txtQtt.Text))
                    {
                        db.executeData(@"update buy_details set " +
                        " qtt_rest=qtt_rest-" + dgvBuy.Rows[dd].Cells[6].Value +
                        " where buy_id =" + dgvBuy.Rows[dd].Cells[8].Value + " AND pro_id=" + dgvBuy.Rows[dd].Cells[1].Value + " ", "");
                    }
                    else
                    {
                        //100
                        //63-33=30
                        Decimal qttTest = Convert.ToDecimal(dgvBuy.Rows[dd].Cells[6].Value);// 63
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
                if (payedAll == 0)
                {
                    Strquery = @"update clients  SET Dette =Dette+ " + leRest +
                       " where id=" + cbxForniss.SelectedValue + "    ;";
                    db.executeData(Strquery, "");
                    Strquery = "";
                    Strquery = @"Insert into dettes_clients  values ("
                                + "null" + ", "
                                + cbxForniss.SelectedValue + ", '"
                                + getLastId() + "', '"
                                + leRest + "', '"
                                + dpToDette.Value.ToString("yyyy-MM-dd") + "',  "
                                 + 0 + " , null," + Properties.Settings.Default.userID + " ,  null);";
                    db.executeData(Strquery, "");
                }



            }
            tbl.Clear(); clearAll();
            //tbl = db.readData("select max(id) from sales", "");
            //if (tbl.Rows.Count >= 0)
            //{
            //    if (tbl.Rows[0][0].ToString() == lblFactNumAuto.Text)
            //    {
            //        clearAll();
            //       // AutoNumber();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("لم يتم تسجيل عملية البيع");
            //}
            cbxClientN.Visible = true; txtBoxClientN.Visible = true;
            txtBoxClientN.Enabled = true;
            cbxForniss.Enabled = false; clientSelection = true; cbxForniss.Text = null;
            btnSaveFact.Enabled = true;
        }
        private void togswRemise_Click(object sender, EventArgs e)
        {
            try
            {
                if (fromBuy)
                {
                if (this.dgvBuy.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dgvBuy.SelectedRows[0];
                    txtDiscount.Text = row.Cells[11].Value.ToString();
                    if (togswRemise.IsOn == false)
                    {
                        Discount = Convert.ToDouble(txtDiscount.Text);
                    }
                    else
                    {
                        txtDiscount.Text = "0";
                        Discount = 0;
                    }
                }
            }
                else
                {if (this.dgvProduct.SelectedRows.Count > 0)
                    { 
                    DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                    txtDiscount.Text = row.Cells[7].Value.ToString();
                    if (togswRemise.IsOn == false)
                    {
                        Discount = Convert.ToDouble(txtDiscount.Text);
                    }
                    else
                    {
                        txtDiscount.Text = "0";
                        Discount = 0;
                    }
                }
               
                
            }
        }
                catch { }
        }
        private void togswRemise_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                txtDiscount.Text = row.Cells[11].Value.ToString();
                if (togswRemise.IsOn == false)
                {
                    Discount = Convert.ToDouble(txtDiscount.Text);
                }
                else
                {
                    txtDiscount.Text = "0";
                    Discount = 0;
                }
            }
            }
            catch { }
        }

        Double prixAchat = 0;
        private void dgvProduct_MouseClick(object sender, MouseEventArgs e)
        {
            fromBuy = false;
            if (this.dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                string Product_ID = row.Cells[0].Value.ToString();
                tbl.Clear();
                tbl = db.readData("SELECT buy_id,qtt_rest,price,SUM(qtt_rest)  FROM buy_details WHERE pro_id=" + Product_ID + " and qtt_rest>0   ORDER BY buy_id  ASC ", "");
                if (tbl.Rows.Count == 0 || tbl.Rows[0][1] == DBNull.Value)
                {
                    lblQTT.Text = "0"; lblFactNum.Text = "0"; prixAchat = 0; lblQttFact.Text = "0";
                }
                else
                {
                    lblQttFact.Text = (Convert.ToInt32(tbl.Rows[0][1])).ToString();
                    lblFactNum.Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString();

                    prixAchat = Convert.ToDouble(tbl.Rows[0][2]); lblQTT.Text = (Convert.ToInt32(tbl.Rows[0][3])).ToString();
                }
                txtPrixAchat.Text = row.Cells[4].Value.ToString();   txtDiscount.Text = "0"; togswRemise.IsOn = false;
                typePay = "Vente";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (this.dgvBuy.SelectedRows.Count > 0)
            {
                this.dgvBuy.Rows.RemoveAt(this.dgvBuy.SelectedRows[0].Index);
                refreche_Total();txtBarCode.Text = ""; txtQtt.Value = 1;
            }
            else
            {
                MessageBox.Show("Selectionner un Article");
            }
            txtBarCode.Focus();
        }
        //private void radioButton2_Click(object sender, EventArgs e)
        //{
        //    radioButton1.Checked = false;
        //    cbxForniss.Enabled = false;
        //    clientName = txtBoxClientN.Text;
        //}

        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {
            LoadKeyboardLayout("00000409", 1);
            // LoadKeyboardLayout("00010409", 1);

        }
        String Product_ID = "";

        private void txtBarCode_KeyUp(object sender, KeyEventArgs e)
        {
            //txtBarCode.Clear();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // txtBarCode.Clear();

            dgvProduct.Visible = false;
            if (e.KeyCode == Keys.Enter)
            {

                //this.dgvProduct.DataSource = null;
                //this.dgvProduct.Rows.Clear();

                System.Data.DataTable tblItems = new System.Data.DataTable();
                tblItems.Clear();
                tblItems = db.readData("select products.id  ,name  ,reference1  , mark  ,pricesale,prix_grox, pricehelp,remise from products  left join barcode_product on products.id=barcode_product.id_product   where products.barcode = '"+ txtBarCode.Text +"'  or barcode_product.barcode = '"+txtBarCode.Text+"'", "");
                
                //  dgvProduct.DataSource = tblItems.Rows;
                Product_ID = "";
                if (tblItems.Rows.Count == 0)
                {
                    txtBarCode.Text = "";
                    MessageBox.Show("رقم الكودبار خاطئ"); 
                    txtBarCode.Focus();
                }
                else
                {
              /////////////////////////////////
                    lblAricl.Text = tblItems.Rows[0][1].ToString();
                    Product_ID = tblItems.Rows[0][0].ToString();
                    //if (Product_ID == null || Product_ID == "")
                    //{
                    //    txtBarCode.Text = "";
                    //    MessageBox.Show("لم يتم شراء هاته السلعة وإدخالها للمخزو بعد");
                    //    txtBarCode.Focus();
                    //}
                    //else { 
                tbl.Clear();
                tbl = db.readData("SELECT buy_id,qtt_rest,price,SUM(qtt_rest)  FROM buy_details WHERE pro_id=" + Product_ID + " and qtt_rest>0   ORDER BY buy_id  ASC ", "");
                    //if (tbl.Rows[0][0] != System.DBNull.Value && tbl.Rows.Count > 0 && tbl.Rows[0][0] != null) DBNull.Value
                    if (tbl.Rows[0][0].ToString() != DBNull.Value.ToString() ) 
                    {
                    lblQttFact.Text = (Convert.ToInt32(tbl.Rows[0][1])).ToString(); lblFactNum.Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString();
                    prixAchat = Convert.ToDouble(tbl.Rows[0][2]); lblQTT.Text = (Convert.ToInt32(tbl.Rows[0][3])).ToString();

                        txtPrixAchat.Text = "0"; txtDiscount.Text = "0"; togswRemise.IsOn = false;
                        try
                        {
                            String Product_Name = tblItems.Rows[0][1].ToString();
                            Double Product_Qty = Convert.ToDouble(txtQtt.Text);
                            String Product_Price = tblItems.Rows[0][4].ToString();
                            Double total = Product_Qty * (Convert.ToDouble(txtPrixAchat.Text));

                            Double priceHelp = Convert.ToDouble(tblItems.Rows[0][6].ToString());
                            Double remise = Convert.ToDouble(tblItems.Rows[0][7].ToString());
                            Boolean existedIdProduct = false; int IndexRow = 0;
                            foreach (DataGridViewRow rowede in dgvBuy.Rows)
                            {
                                if (rowede.Cells[1].Value.ToString().Equals(Product_ID))
                                {
                                    existedIdProduct = true;
                                    IndexRow = rowede.Index;
                                }

                            }

                            if (dgvBuy.Rows.Count == 0 || existedIdProduct == false)
                            {
                                int n = dgvBuy.Rows.Add();

                                dgvBuy.Rows[n].Cells[0].Value = oo++;
                                dgvBuy.Rows[n].Cells[1].Value = Product_ID;
                                dgvBuy.Rows[n].Cells[2].Value = Product_Name;
                                dgvBuy.Rows[n].Cells[3].Value = "Vente";
                                dgvBuy.Rows[n].Cells[4].Value = Product_Price;
                                dgvBuy.Rows[n].Cells[5].Value = Convert.ToDouble(Product_Price)  ; 
                                dgvBuy.Rows[n].Cells[6].Value = Product_Qty;
                                dgvBuy.Rows[n].Cells[7].Value = Product_Qty * (Convert.ToDouble(Product_Price));
                                dgvBuy.Rows[n].Cells[8].Value = lblFactNum.Text;
                                dgvBuy.Rows[n].Cells[9].Value = prixAchat; 
                                dgvBuy.Rows[n].Cells[10].Value = priceHelp;
                                dgvBuy.Rows[n].Cells[11].Value = remise;

                            }
                            else
                            {
                                if (existedIdProduct)
                                {
                                    dgvBuy.Rows[IndexRow].Cells[6].Value = Convert.ToDouble(dgvBuy.Rows[IndexRow].Cells[6].Value) + Product_Qty;

                                    dgvBuy.Rows[IndexRow].Cells[7].Value = Convert.ToDouble(dgvBuy.Rows[IndexRow].Cells[6].Value) * Convert.ToDouble(dgvBuy.Rows[IndexRow].Cells[5].Value);
                                    dgvBuy.Refresh();
                                }

                            }
                            //  txtBarCode.SelectAll();

                        }
                        catch (Exception) { }
                    }
                else
                {
                    lblQTT.Text = "0"; lblFactNum.Text = "0"; prixAchat = 0; lblQttFact.Text = "0";
                }


                dgvBuy.Refresh();
                try
                {
                    TotalOrder = 0;
                    //  decimal TotalOrder = 0;
                    for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                    {

                        TotalOrder += Convert.ToDouble(dgvBuy.Rows[i].Cells[7].Value);
                        //dgvBuy.ClearSelection();
                        //dgvBuy.FirstDisplayedScrollingColumnIndex = dgvBuy.Rows.Count - 1;
                        //dgvBuy.Rows[dgvBuy.Rows.Count - 1].Selected = true;
                        // MessageBox.Show("" + TotalOrder);Math.Round(TotalOrder, 2).ToString() ; 
                    }
                    lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                        txtApay.Text = Convert.ToString(TotalOrder);
                       // lblRest.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                        lblRest.Text = "0";
                        lblNombre.Text = (dgvBuy.Rows.Count).ToString();
                    dgvBuy.ClearSelection();
                    //dgvBuy.FirstDisplayedScrollingColumnIndex = dgvBuy.Rows.Count - 1;
                    dgvBuy.Rows[dgvBuy.Rows.Count - 1].Selected = true;

                }
                catch
                {

                    }
                //}
                /////////////////////////////////
            }
                txtBarCode.SelectAll(); txtQtt.Value = 1;
            }
            
        }
        Boolean clientSelection = true;
        private void cbxClientN_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxClientN.Enabled = true;
            cbxForniss.Enabled = false; clientSelection = true; cbxForniss.Text = null;
        }

        private void cbxClientS_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxClientN.Enabled = false;
            cbxForniss.Enabled = true;
            clientSelection = false;

        }

        private void txtApay_TextChanged(object sender, EventArgs e)
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
                lblRest.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(leRest));
                if (leRest == 0) // payed all
                {
                    isZero = true;
                    dpToDette.Enabled = false; label22.Enabled = false;
                    cbxClientN.Visible = true; txtBoxClientN.Visible = true;

                }
                else
                {
                    isZero = false;
                    dpToDette.Enabled = true; label22.Enabled = true;
                    cbxClientN.Visible = false; txtBoxClientN.Visible = false;
                    
                }

            }
            //else
            //{
            //    MessageBox.Show("pas de Articles dans la liste");
            //}
          
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //String ClientNom = "";
            //if (clientSelection)
            //{
            //    ClientNom = txtBoxClientN.Text;
            //}
            //else
            //{
            //    ClientNom = cbxForniss.Text;
            //}
            //db.executeData("TRUNCATE TABLE proforma", "");
            //String Strquery = "";
            //for (int dd = 0; dd <= dgvBuy.Rows.Count - 1; dd++)
            //{

            //    Strquery = @"Insert into proforma  values ("
            //               + lblFactNumAuto.Text + ", '"
            //               + dgvBuy.Rows[dd].Cells[1].Value + "', '"// pro id
            //               + dgvBuy.Rows[dd].Cells[1].Value + "', '"// fact achat id
            //               + dgvBuy.Rows[dd].Cells[2].Value + "', '"// nom 
            //               + dgvBuy.Rows[dd].Cells[5].Value + "', '"// remise
            //               + dgvBuy.Rows[dd].Cells[6].Value + "', '"// qtt
            //               + dgvBuy.Rows[dd].Cells[7].Value + "'  );";
            //    db.executeData(Strquery, "");
            //}


            //frm_fact fact = new frm_fact();

            //tbl.Clear();
            //DataSet ds = new DataSet();
            //ds = db.getResults("SELECT reference1,name,remise,qty,total FROM  proforma   ");
            //rpt_fact_sale cry = new rpt_fact_sale();
            
            //// MessageBox.Show(Convert.ToString(ds.Tables[0].Rows[0][0]));
            //cry.SetDataSource(ds);

            //TextObject Text7 = (TextObject)cry.ReportDefinition.Sections["Section1"].ReportObjects["Text7"];
            //Text7.Text = "Bon de Livraison";

            //TextObject Text9 = (TextObject)cry.ReportDefinition.Sections["Section1"].ReportObjects["Text9"];
            //Text9.Text = ClientNom;
            //TextObject Text10 = (TextObject)cry.ReportDefinition.Sections["Section1"].ReportObjects["Text10"];
            //Text10.Text = lblFactNumAuto.Text;
            //fact.crystalReportViewer1.ReportSource = cry;
            //fact.crystalReportViewer1.Refresh();
            //fact.ShowDialog();
        }
        Boolean fromBuy;
        private void dgvBuy_MouseClick(object sender, MouseEventArgs e)
        {
            fromBuy = true;
            dgvProduct.Visible = false;
            btnAdd.Text = "تعديل Modifier ";
            //txtPrixAchat
            //    txtDiscount
            //    txtQtt
            if (this.dgvBuy.SelectedRows.Count > 0)
            {
                
                DataGridViewRow row = this.dgvBuy.SelectedRows[0];
                lblAricl.Text= row.Cells[2].Value.ToString();
                txtPrixAchat.Text = row.Cells[4].Value.ToString();
                txtQtt.Text = row.Cells[6].Value.ToString();
                string Product_ID = row.Cells[1].Value.ToString();
                tbl.Clear();
                tbl = db.readData("SELECT buy_id,qtt_rest,price,SUM(qtt_rest)  FROM buy_details WHERE pro_id=" + Product_ID + " and qtt_rest>0   ORDER BY buy_id  ASC ", "");
                if (tbl.Rows.Count == 0 || tbl.Rows[0][1] == DBNull.Value)
                {
                    lblQTT.Text = "0"; lblFactNum.Text = "0"; prixAchat = 0; lblQttFact.Text = "0";
                }
                else
                {
                    lblQttFact.Text = (Convert.ToInt32(tbl.Rows[0][1])).ToString(); lblFactNum.Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString();

                    prixAchat = Convert.ToDouble(tbl.Rows[0][2]); lblQTT.Text = (Convert.ToInt32(tbl.Rows[0][3])).ToString();
                }
                //txtPrixAchat.Text = "0"; txtDiscount.Text = "0"; togswRemise.IsOn = false;
            }
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (fromBuy)
            {
                if (this.dgvBuy.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dgvBuy.SelectedRows[0];
                    txtPrixAchat.Text = row.Cells[4].Value.ToString();
                    typePay = "Special";
                }
                else
                {
                    txtPrixAchat.Text = "0";
                }
            }
            else
            {
                if (this.dgvProduct.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                    txtPrixAchat.Text = row.Cells[4].Value.ToString();
                    typePay = "Special";
                }
                else
                {
                    txtPrixAchat.Text = "0";
                }
                
            }
        }

        private void frm_sales_cash_Click(object sender, EventArgs e)
        {
            txtBarCode.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Clear();

        }

        private void btnBarcod_Click(object sender, EventArgs e)
        {
            txtBarCode.Focus();
            //txtSearch
            //    dgvProduct
        }

        private void frm_sales_cash_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                txtBarCode.Focus();
            }
            if (e.KeyCode == Keys.F3)
            {
                txtSearch.Focus(); txtSearch.Clear();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtApay.Text = Convert.ToString(TotalOrder) ;
            lblRest.Text = "0";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_clients clint = new frm_clients();
            clint.ShowDialog();
        }

        private void cbxForniss_Click(object sender, EventArgs e)
        {
            clientSelection = false;
            FillClient();
        }

        private void checkButton3_CheckedChanged(object sender, EventArgs e)
        {
            
           
           if (fromBuy)
             {
                   if (this.dgvBuy.SelectedRows.Count > 0)
                    {
                            DataGridViewRow row = this.dgvBuy.SelectedRows[0];
                            txtPrixAchat.Text = row.Cells[10].Value.ToString();
                            typePay = "Special";
                    }
                    else
                    {
                        txtPrixAchat.Text = "0";
                    }
              }
                else
                { if (this.dgvProduct.SelectedRows.Count > 0)
            {
                    DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                    txtPrixAchat.Text = row.Cells[6].Value.ToString();
                    typePay = "Special";
            }
            else
            {
                txtPrixAchat.Text = "0";
            }


            }
                
           
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            txtBarCode.Focus();
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
        private void simpleButton4_Click(object sender, EventArgs e)
        {

            
                try
                {
                    //WriteExcel();
                    Microsoft.Office.Interop.Excel.Application xlApp;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                string filePath = "";
                if (cbxForniss.SelectedValue != null)
                {

                      filePath = @"c:\Modele\model.xlsx";
                }
                else
                {
                      filePath = @"c:\Modele\modelBon.xlsx";
                }
               
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


                if (cbxForniss.SelectedValue != null)
                {

                    worksheet.Cells[7, 3] = cbxForniss.Text;
                    worksheet.Cells[18, 8] = getDetteClient(cbxForniss.Text);
                }
                else
                {
                    worksheet.Cells[7, 3] = txtBoxClientN.Text;
                    worksheet.Cells[14, 8] = 0.00;
                }

if (cbxForniss.SelectedValue != null)
                        {
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
                    }

                if (cbxForniss.SelectedValue != null)
                {
                    worksheet.Cells[5, 8] = lblFactNumAuto.Text;
                    worksheet.Cells[16, 4] = lblNombre.Text; 
                    worksheet.Cells[20, 8] = txtApay.Text; 
                    CopyRowsDown(worksheet, 14, dgvBuy.Rows.Count);
                 
                    for (int i = 0; i < dgvBuy.Rows.Count; i++)
                    {

                        int col = 0;
                        for (int j = 0; j < dgvBuy.Columns.Count - 4; j++)
                        {
                            if (j != 4)
                            {
                                if (j == 0)
                                {
                                    worksheet.Cells[i + 14, col + 2] = i + 1; col++;
                                }
                                else
                                {
                                    worksheet.Cells[i + 14, col + 2] = dgvBuy.Rows[i].Cells[j].Value.ToString(); col++;
                                }

                            }
                        }

                    }
                }
                else
                {
                    worksheet.Cells[5, 8] = lblFactNumAuto.Text;
                    worksheet.Cells[12, 4] = lblNombre.Text;
                    worksheet.Cells[16, 8] = txtApay.Text;
                    CopyRowsDown(worksheet, 10, dgvBuy.Rows.Count);

                    for (int i = 0; i < dgvBuy.Rows.Count; i++)
                    {

                        int col = 0;
                        for (int j = 0; j < dgvBuy.Columns.Count - 4; j++)
                        {
                            if (j != 4)
                            {
                                if (j == 0)
                                {
                                    worksheet.Cells[i + 10, col + 2] = i + 1; col++;
                                }
                                else
                                {
                                    worksheet.Cells[i + 10, col + 2] = dgvBuy.Rows[i].Cells[j].Value.ToString(); col++;
                                }

                            }
                        }

                    }
                }
                // save the application  
                xlWorkBook.SaveAs(@"D:\DR Rapports\Facture Le  " + DateTime.Now.ToString("d_M_yyyy hh_mm_ss") + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    // Exit from the application  
                    // app.Quit();
                }
                catch { }
                // do_payement();
           

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
        // 
        private void btndeleteAll_Click(object sender, EventArgs e)
        {
            dgvBuy.Rows.Clear(); clearAll(); refreche_Total(); txtBarCode.Focus(); lblRest.Text = "0";
        }
        private void frm_sales_cash_Load(object sender, EventArgs e)
        {
            txtBarCode.Focus();
        }
    }}