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
using System.Runtime.InteropServices;
namespace Disdriver
{
    public partial class frm_returns : DevExpress.XtraEditors.XtraForm
    {
        public frm_returns()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern IntPtr LoadKeyboardLayout(string pwszKLID, uint Flags);


        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();

        private void frm_returns_Load(object sender, EventArgs e)
        {
            AutoNumber();
            FillClient();
        }

        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from returns", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                lblFactNumAuto.Text = "1";
            }
            else
            {
                lblFactNumAuto.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            dpFactDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dpToDette.Text = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                cbxForniss.SelectedIndex = 0;
            }
            catch (Exception) { }
            clearAll();

        }
        public int oo = 1;
        public void clearAll()
        {
            db.executeData("TRUNCATE TABLE proforma", "");
            oo = 1;
            cbxForniss.Text = "choisissez un Client";
            txtSearch.Clear();
            //dgvProduct.Clear();
            dgvBuy.Rows.Clear();
            //txtFactNum.Clear();
            //txtFactNum.Focus();
            txtPrixAchat.Clear();
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
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearch.Text != "" && txtSearch.Text != null)
            {
                this.dgvProduct.DataSource = null;
            this.dgvProduct.Rows.Clear();

            DataTable tblItems = new DataTable();
            tblItems.Clear();
            tblItems = db.readData("select products.id  ,products.name  ,products.reference1  , products.mark  ,products.pricesale,products.prix_grox, products.pricehelp,products.remise,buy_details.price from products inner join  buy_details  on products.id  =	buy_details.pro_id  where name  LIKE '" + txtSearch.Text + "%'    or reference1 LIKE '" + txtSearch.Text + "%' ", "");
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
                dgvProduct.Rows[nc].Cells[8].Value = row["price"].ToString();
                }
            }
            else
            {
                this.dgvProduct.DataSource = null;
                this.dgvProduct.Rows.Clear();
            }
        }
        double TotalOrder = 0.0, leRest = 0.0; double Discount = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (Convert.ToDecimal(txtQtt.Text) >= 1)
            {
                try
                {
                    DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                    string Product_ID = row.Cells[0].Value.ToString();
                    string Product_Name = row.Cells[1].Value.ToString();
                    Double Product_Qty = Convert.ToDouble(txtQtt.Value);
                    string Product_Price = txtPrixAchat.Text;
                    Double total = Product_Qty * Convert.ToDouble(txtPrixAchat.Text);

                    Boolean existedIdProduct = false; int IndexRow = 0;
                    foreach (DataGridViewRow rowede in dgvBuy.Rows)
                    {
                        if (rowede.Cells[1].Value.ToString()==Product_ID)
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

                        dgvBuy.Rows[n].Cells[0].Value = oo++;
                        dgvBuy.Rows[n].Cells[1].Value = Product_ID;
                        dgvBuy.Rows[n].Cells[2].Value = Product_Name;
                        dgvBuy.Rows[n].Cells[3].Value = Product_Price;
                        dgvBuy.Rows[n].Cells[4].Value = Product_Qty;
                        dgvBuy.Rows[n].Cells[5].Value = total;
                        dgvBuy.Rows[n].Cells[6].Value = lblFactNumAuto.Text;
                        dgvBuy.Rows[n].Cells[7].Value = total-(prixAchat * Product_Qty);
                        dgvBuy.Rows[n].Cells[8].Value = num_las_fact;
                    }
                    else
                    {
                        if (existedIdProduct)
                        {
                            dgvBuy.Rows[IndexRow].Cells[4].Value = Convert.ToDouble(dgvBuy.Rows[IndexRow].Cells[4].Value) + Product_Qty;

                            dgvBuy.Rows[IndexRow].Cells[5].Value = Convert.ToDecimal(dgvBuy.Rows[IndexRow].Cells[3].Value) * Convert.ToDecimal(dgvBuy.Rows[IndexRow].Cells[4].Value);
                            dgvBuy.Refresh();
                        }

                    } 
                }
                catch (Exception) { }
                refreche_Total();
            }
            else
            {
                // MessageBox.Show("Quantité supperieur !");
                txtQtt.Text = "1";
            }
            txtBarCode.Clear();
        }
        public void refreche_Total()
        {
            dgvBuy.Refresh();
            try
            {

                TotalOrder = 0;
                for (int i = 0; i <= dgvBuy.Rows.Count - 1; i++)
                {

                    TotalOrder += Convert.ToDouble(dgvBuy.Rows[i].Cells[5].Value);
                }
                lblTotal.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
                txtApay.Text = Convert.ToString(TotalOrder);
                lblRest.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(TotalOrder));
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
        int num_las_fact;
        Double prixAchat = 0;
        private void dgvProduct_MouseClick(object sender, MouseEventArgs e)
        {
            num_las_fact = 0;
            if (this.dgvProduct.Rows.Count > 0)
            {
                DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                string Prod_ID = this.dgvProduct[0, 0].Value.ToString();
                //string Product_ID = row.Cell[0][0].Value.ToString();
                tbl.Clear();
                tbl = db.readData("SELECT buy_id,price  FROM buy_details WHERE pro_id=" + Prod_ID + " and qtt_rest>=0   ORDER BY buy_id  ASC ", "");
                if (tbl.Rows.Count >=0)
                {
                    num_las_fact= Convert.ToInt32(tbl.Rows[0][0]);
                    prixAchat = Convert.ToDouble(tbl.Rows[0][1]);
                }

                txtPrixAchat.Text = row.Cells[4].Value.ToString();
            }
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {


            if (this.dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                txtPrixAchat.Text = row.Cells[4].Value.ToString();
                //   typePay = "Vente";
            }
            else
            {
                txtPrixAchat.Text = "0";
            }

        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {


            if (this.dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                txtPrixAchat.Text = row.Cells[5].Value.ToString();
                //   typePay = "Special";
            }
            else
            {
                txtPrixAchat.Text = "0";
            }
        }

        private void checkButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (this.dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                txtPrixAchat.Text = row.Cells[6].Value.ToString();
                //  typePay = "gros";
            }
            else
            {
                txtPrixAchat.Text = "0";
            }
        }

        double payo = 0;
        Boolean isZero = false;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvProduct.SelectedRows.Count > 0)
            {
                this.dgvBuy.Rows.RemoveAt(this.dgvBuy.SelectedRows[0].Index); lblNombre.Text = (dgvBuy.Rows.Count).ToString();
                refreche_Total();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAll();
            AutoNumber();
        }


        String clientName = "";
        Boolean clientSelection = true;
        private void cbxClientN_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxClientN.Enabled = true;
            cbxForniss.Enabled = false; clientSelection = true;
        }

        private void cbxClientS_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxClientN.Enabled = false;
            cbxForniss.Enabled = true;
            clientSelection = false;
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.dgvProduct.DataSource = null;
                this.dgvProduct.Rows.Clear();

                DataTable tblItems = new DataTable();
                tblItems.Clear();
                tblItems = db.readData("select products.id  ,products.name  ,products.reference1  , products.mark  ,products.pricesale,products.prix_grox, products.pricehelp,products.remise from products  inner join barcode_product on products.id=barcode_product.id_product  inner join  buy_details  on products.id  =	buy_details.pro_id  where barcode  = '%" + txtBarCode.Text + "%'   or barcode_product.barcode  = '%" + txtBarCode.Text + "%'" , "");
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
                txtBarCode.SelectAll();
            } // txtBarCode.SelectAll();
        }
      private void txtBarCode_TextChanged(object sender, EventArgs e)
        {
            LoadKeyboardLayout("00010409", 1);
        }

        private void btnSaveFact_Click(object sender, EventArgs e)
        {
            btnSaveFact.Enabled = false;
            String ClientNom = "";
            if (clientSelection)
            {
                ClientNom = txtBoxClientN.Text;
            }
            else
            {
                ClientNom = cbxForniss.Text;
            }
            if (txtApay.Text == "" || txtApay.Text == null) { MessageBox.Show("أدخل المبلغ "); txtApay.Text = "0"; txtApay.Focus(); }
            else
            {
                
                //if (cbxClientS.Enabled) { ClientNom = cbxForniss.SelectedItem.ToString(); } else { ClientNom = txtBoxClientN.Text; };
                //if (Convert.ToBoolean(chxDette.Checked)) { j = 1; };
                db.executeData("insert into returns values (null" +
                                ",'" + dpFactDate.Value.ToString("yyyy-MM-dd") +
                                "'," +  TotalOrder +
                                "," + txtApay.Text +
                                ",'" + ClientNom +
                                "','" + txtRemrq.Text +   
                                "'," + Properties.Settings.Default.userID+
                                ",null )", "");
                String Strquery = "";
                for (int dd = 0; dd <= dgvBuy.Rows.Count - 1; dd++)
                {
                    //   Double benifice = Convert.ToDouble(dgvBuy.Rows[dd].Cells[7].Value) - (Convert.ToDouble(dgvBuy.Rows[dd].Cells[9].Value) * Convert.ToDouble(dgvBuy.Rows[dd].Cells[6].Value));

                    Strquery = @"Insert into returns_details  values ("
                                + "null" + ", "
                                + lblFactNumAuto.Text + ", "
                                + dgvBuy.Rows[dd].Cells[1].Value + ", "// pro id 
                                + dgvBuy.Rows[dd].Cells[3].Value + ", "// prix
                                + dgvBuy.Rows[dd].Cells[4].Value + ", "// qtt
                                + dgvBuy.Rows[dd].Cells[5].Value + ", "// total 
                                + dgvBuy.Rows[dd].Cells[7].Value  + ", "// total qchqt
                                 + "null" + "  );";
                    db.executeData(Strquery, "");

                    db.executeData(@"update buy_details set " +
                    " qtt_rest=qtt_rest+" + dgvBuy.Rows[dd].Cells[4].Value +
                    " where buy_id =" + dgvBuy.Rows[dd].Cells[8].Value + " AND pro_id=" + dgvBuy.Rows[dd].Cells[1].Value + " ", "");
                    //  if (Convert.ToDecimal(lblQttFact.Text) >= Convert.ToDecimal(txtQtt.Text))
                    //{ }
                    //else
                    //{
                    //    //100
                    //    //63-33=30
                    //    Decimal qttTest = Convert.ToDecimal(dgvBuy.Rows[dd].Cells[6].Value);// 63
                    //    Decimal qttRestTest;
                    //    Boolean isEnded = false;
                    //    while (!isEnded)
                    //    {
                    //        // 
                    //        tbl = db.readData("SELECT buy_id,qtt_rest,price  FROM buy_details WHERE pro_id=" + dgvBuy.Rows[dd].Cells[1].Value + " and qtt_rest>0   ORDER BY buy_id  ASC ", "");

                    //        if (tbl.Rows.Count > 0)
                    //        {
                    //            qttRestTest = Convert.ToDecimal(tbl.Rows[0][1]);// 33
                    //            Decimal result = qttTest - qttRestTest;// 36-35=1  ....  1-33
                    //            if (result >= 0)
                    //            {
                    //                db.executeData(@"update buy_details set " +
                    //                " qtt_rest=0" +
                    //                " where buy_id =" + Convert.ToDecimal(tbl.Rows[0][0]) + " AND pro_id=" + dgvBuy.Rows[dd].Cells[1].Value + " ", "");
                    //                qttTest = result;//=1
                    //            }

                    //            else
                    //            {
                    //                db.executeData(@"update buy_details set " +
                    //                " qtt_rest=" + (qttRestTest - qttTest) +//33-1=32
                    //                " where buy_id =" + Convert.ToDecimal(tbl.Rows[0][0]) + " AND pro_id=" + dgvBuy.Rows[dd].Cells[1].Value + " ", "");
                    //                isEnded = true;
                    //            }
                    //        }
                    //        else
                    //        {
                    //            isEnded = true;
                    //        } 
                    //    } 
                    //}


                }
                //if (payedAll == 0)
                //{
                //    Strquery = @"update clients  SET Dette =Dette+ " + leRest +
                //       " where id=" + cbxForniss.SelectedValue + "    ;";
                //    db.executeData(Strquery, "");
                //    Strquery = "";
                //    Strquery = @"Insert into dettes_clients  values ("
                //                + "null" + ", "
                //                + cbxForniss.SelectedValue + ", '"
                //                + lblFactNumAuto.Text + "', '"
                //                + leRest + "', '"
                //                + dpToDette.Value.ToString("yyyy-MM-dd") + "',  "
                //                 + 0 + " , null ,  null);";
                //    db.executeData(Strquery, "");
                //}


              
            }
            tbl.Clear();
            this.Hide();
            //tbl = db.readData("select max(id) from returns", "");
            //if (tbl.Rows.Count >= 0)
            //{
            //    if (tbl.Rows[0][0].ToString() == lblFactNumAuto.Text)
            //    {
            //        clearAll();
            //        AutoNumber();
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("لم يتم تسجيل عملية الارجاع ");
            //}

        }

        private void txtBarCode_TextChanged_1(object sender, EventArgs e)
        {
            LoadKeyboardLayout("00000409", 1);
            //LoadKeyboardLayout("00010409", 1);
        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.dgvProduct.DataSource = null;
                this.dgvProduct.Rows.Clear();

                DataTable tblItems = new DataTable();
                tblItems.Clear();
 
                tblItems = db.readData("select products.id  ,products.name  ,products.reference1  , products.mark  ,products.pricesale,products.prix_grox, products.pricehelp,products.remise from products  left join barcode_product on products.id=barcode_product.id_product  inner join  buy_details  on products.id  =	buy_details.pro_id   where products.barcode  = '" + txtBarCode.Text + "'   or barcode_product.barcode  = '" + txtBarCode.Text + "'", "");
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
                txtBarCode.SelectAll();
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            dgvBuy.Rows.Clear(); clearAll();
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



    }
}