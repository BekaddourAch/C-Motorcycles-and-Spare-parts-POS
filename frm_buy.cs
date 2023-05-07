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
using System.Threading;

namespace Disdriver
{
    public partial class frm_buy : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();
        public Boolean edit;
        public frm_buy(Boolean edit)
        {
            this.edit = edit;
            InitializeComponent();
            if (edit == null)
            {

                AutoNumber();
                title1.Text = "إدارة المشتريات";
            }
            if (!edit)
            {
                AutoNumber();
                title1.Text = "إدارة المشتريات";
            }
            else
            {
                title1.Text = "تعديل المشتريات";
            }
        }

        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select  max(id) from buy", "");
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
                cbxForniss.SelectedIndex = 0;
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
             oo = 1;
            cbxForniss.Text = "choisissez un Fournisseur";
            txtSearch.Clear();
            dgvProduct.Rows.Clear();
            dgvBuy.Rows.Clear();
             
            txtFactNum.Clear();
            txtFactNum.Focus(); 
            txtPrixAchat.Text = "0";
            txtApay.Clear();
            lblRest.Text="";
            lblNombre.Text = "00"; 
            txtRemrq.Clear();
            lblTotal.Text = "0,00 DA";
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
           // AutoNumber();
        }
        private void FillSupplier()
        {
            cbxForniss.DataSource = db.readData("SELECT * FROM fournisseur ", "");
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
            tblItems = db.readData("select id  ,name  ,reference1  , mark  ,pricesale,prix_grox, pricehelp,remise from products where name  LIKE '%" + txtSearch.Text + "%'  or barcode='" + txtSearch.Text + "'  or reference1 LIKE '" + txtSearch.Text + "%' ", "");
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
        double TotalOrder = 0.0, leRest = 0.0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if ( (Convert.ToDecimal(txtVente.Text) <= Convert.ToDecimal(txtPrixAchat.Text)) ||  (Convert.ToDecimal(txtSpecial.Text) <= Convert.ToDecimal(txtPrixAchat.Text))
                || (Convert.ToDecimal(txtgros.Text) <= Convert.ToDecimal(txtPrixAchat.Text)))

            {
                txtPrixAchat.Text = "0";
            }
            else {
            //if (dgvProduct.SelectedRows.Count > 0)
            //{
            try
            {
                    DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                     
                    string Product_ID = row.Cells[0].Value.ToString();  
                    string Product_Name = row.Cells[1].Value.ToString();
                    decimal Product_Qty = txtQtt.Value;
                    string Product_Price = txtPrixAchat.Text;
                    decimal Discount = 0;
                    decimal total = Product_Qty * Convert.ToDecimal(txtPrixAchat.Text);
                //    MessageBox.Show(total + "   واحد", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.dgvBuy.Rows.Add();
                //int rowindex = this.dgvBuy.Rows.Count - 1;

                // dgvBuy.Rows.Add(1);
                //int rowindex =  dgvBuy.Rows.Count - 1;

                /////////Filter
                //(dgvBuy.DataSource as DataTable).DefaultView.RowFilter = "Num = '" + Product_ID + "'";
                //dgvBuy.Refresh();
                ////////// Colored search
                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    if (row.Cells[1].Value.ToString().Contains("test"))
                //        row.Cells["chat1"].Style.ForeColor = Color.Red;
                //    //row.Cells["chat1"].Style.ForeColor = Color.CadetBlue;
                //}
                Boolean existedIdProduct=false;int IndexRow = 0;
                foreach (DataGridViewRow rowede in dgvBuy.Rows)
                {
                        //if (rowede.Cells[1].Value.ToString().Contains(Product_ID))
                        if (rowede.Cells[1].Value.ToString()==Product_ID) //correction
                        {
                        existedIdProduct = true;
                        IndexRow = rowede.Index;
                    }
                    //    rowede.Cells["chat1"].Style.ForeColor = Color.Red;
                    //row.Cells["chat1"].Style.ForeColor = Color.CadetBlue;
                }

                if (dgvBuy.Rows.Count==0 || existedIdProduct==false) {
                    int n = dgvBuy.Rows.Add();

                    dgvBuy.Rows[n].Cells[0].Value = oo++;
                    dgvBuy.Rows[n].Cells[1].Value = Product_ID;
                    dgvBuy.Rows[n].Cells[2].Value = Product_Name;
                    dgvBuy.Rows[n].Cells[3].Value = Product_Price;
                    dgvBuy.Rows[n].Cells[4].Value = Product_Qty;
                    dgvBuy.Rows[n].Cells[5].Value = total;
                    dgvBuy.Rows[n].Cells[6].Value = txtVente.Text;
                    dgvBuy.Rows[n].Cells[7].Value = txtgros.Text;
                    dgvBuy.Rows[n].Cells[8].Value = txtSpecial.Text;
                    dgvBuy.Rows[n].Cells[9].Value = txtRemise.Text;

                } else
                {if (existedIdProduct) {
                        dgvBuy.Rows[IndexRow].Cells[4].Value = Convert.ToDecimal(dgvBuy.Rows[IndexRow].Cells[4].Value) + Product_Qty;
                         
                        dgvBuy.Rows[IndexRow].Cells[5].Value = Convert.ToDecimal(dgvBuy.Rows[IndexRow].Cells[3].Value)* Convert.ToDecimal(dgvBuy.Rows[IndexRow].Cells[4].Value);
                        dgvBuy.Refresh();
                    } 

                }
                  
                
                }
                catch (Exception) { }

                refreche_Total();
        }
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
                lblRest.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(0));
                lblNombre.Text = (dgvBuy.Rows.Count).ToString();
                dgvBuy.ClearSelection();
                dgvBuy.FirstDisplayedScrollingColumnIndex = dgvBuy.Rows.Count - 1;
                dgvBuy.Rows[dgvBuy.Rows.Count - 1].Selected = true;

            }
            catch
            {

            }
        }
        int payedAll = 0,payDette=0;

        private void btnSaveFact_Click(object sender, EventArgs e)
        {
            if (cbxForniss.SelectedValue != null)
            { doPayments(); }
            else
            {
                cbxForniss.BackColor = Color.Red;
                MessageBox.Show(" لم يتم تحديد مورد من القائمة  ");
                cbxForniss.BackColor = Color.Red; Thread.Sleep(550);
                cbxForniss.BackColor = Color.White; Thread.Sleep(550);
                cbxForniss.BackColor = Color.Red; Thread.Sleep(550);
                cbxForniss.BackColor = Color.White; Thread.Sleep(550);
                cbxForniss.Focus();
            }
        }
        public void doPayments()
        {
            if (btnNew.Visible == false)
            {

                // db.executeData(" TRUNCATE TABLE agenda; TRUNCATE TABLE returns_details;  TRUNCATE TABLE returns;  TRUNCATE TABLE caisse;"
                //+ "TRUNCATE TABLE cloture; TRUNCATE TABLE deponc_mang; TRUNCATE TABLE dettes_clients; TRUNCATE TABLE dettes_clients_payed; TRUNCATE TABLE dettes_fournisseur;"
                //+ "TRUNCATE TABLE sales_moto;  TRUNCATE TABLE sales_details;  TRUNCATE TABLE sales;  TRUNCATE TABLE buy_details;   TRUNCATE TABLE buy; TRUNCATE TABLE transactions;"
                //+ "TRUNCATE TABLE transfert;  ", "");

                Boolean a = false, b = false;
                db.executeData("TRUNCATE TABLE agenda ", "");
                db.executeData("TRUNCATE TABLE returns_details ", "");
                db.executeData("TRUNCATE TABLE returns ", "");
                db.executeData("TRUNCATE TABLE caisse ", "");
                db.executeData("TRUNCATE TABLE cloture ", "");
                db.executeData("TRUNCATE TABLE deponc_mang ", "");
                db.executeData("TRUNCATE TABLE dettes_clients ", "");
                // db.executeData("TRUNCATE TABLE dettes_clients_payed ", "");
                db.executeData("TRUNCATE TABLE dettes_fournisseur  ", "");
                db.executeData("TRUNCATE TABLE sales_moto ", "");


                db.executeData("DROP TABLE sales_details ", "");
                db.executeData("DROP TABLE sales ", "");
                db.executeData("CREATE TABLE `sales` (  `id` int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,  `code_fact` varchar(20) DEFAULT NULL,  `date` date NOT NULL,  `client_id` int(11) NOT NULL,"
  + " `totalsale` double NOT NULL,  `apay` double NOT NULL,  `lereste` double NOT NULL,  `detteDate` date NOT NULL,  `payed_all` tinyint(1) NOT NULL,  `Remarque` varchar(255) DEFAULT NULL,"
  + " `timer` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),  `user_id` int(11) NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = utf8; ", "");

                db.executeData("CREATE TABLE `sales_details` (  `id` int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,  `sale_id` int(11) NOT NULL,  `pro_id` int(11) NOT NULL,  `buy_id` int(11) NOT NULL,"
  + " `type_pay` varchar(30) NOT NULL,  `price` double NOT NULL,  `remise` double NOT NULL,  `qty` int(11) NOT NULL,  `total` double NOT NULL,  `benifice` double NOT NULL,"
  + " `timmer` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()) ENGINE = InnoDB DEFAULT CHARSET = utf8;", "");

                db.executeData("DROP TABLE buy_details ", "");
                db.executeData("DROP TABLE buy ", "");
                db.executeData(" CREATE TABLE `buy` (  `id` int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,  `code_fact` varchar(20) NOT NULL,  `date` date NOT NULL,  `sup_id` int(11) NOT NULL,  `totalOrder` double NOT NULL,  `apay` double NOT NULL,"
  + " `lereste` double NOT NULL,  `detteDate` date NOT NULL,  `payed_all` tinyint(1) NOT NULL,  `Remarque` varchar(255) DEFAULT NULL,  `timer` timestamp NOT NULL DEFAULT current_timestamp()"
 + " ON UPDATE current_timestamp(),  `user_id` int(11) NOT NULL) ENGINE = InnoDB DEFAULT CHARSET = utf8;", "");


                db.executeData("CREATE TABLE `buy_details` (  `id` int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,  `buy_id` int(11) NOT NULL,  `pro_id` int(11) NOT NULL,  `price` double NOT NULL,  `qty` int(11) NOT NULL,"
  + " `qtt_rest` int(11) NOT NULL,  `total` double NOT NULL,  `timmer` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()) ENGINE = InnoDB DEFAULT CHARSET = utf8; ", "");

                db.executeData("ALTER TABLE `sales_details`  ADD CONSTRAINT `rel_sales` FOREIGN KEY(`sale_id`) REFERENCES `sales` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION;", "");
                db.executeData("ALTER TABLE `buy_details`  ADD CONSTRAINT `rel_buy` FOREIGN KEY(`buy_id`) REFERENCES `buy` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION;", "");

                db.executeData("DROP TRIGGER  IF EXISTS  `cancel_buy_fact`;", "");
                db.executeData("CREATE TRIGGER `cancel_buy_fact` BEFORE DELETE ON `buy` FOR EACH ROW BEGIN"
                + " UPDATE fournisseur SET Dette = Dette - old.lereste  WHERE id = old.sup_id; DELETE FROM dettes_fournisseur WHERE num_fact = old.id;  DELETE FROM buy_details WHERE buy_id = old.id;"
                + " END; ", "");

                db.executeData("DROP TRIGGER  IF EXISTS  `cancel_sale_fact`; ", "");
                db.executeData("CREATE TRIGGER `cancel_sale_fact` BEFORE DELETE ON `sales` FOR EACH ROW BEGIN "
                + " UPDATE clients SET Dette = Dette - old.lereste  WHERE id = old.client_id; DELETE FROM dettes_clients WHERE num_fact = old.id;  DELETE FROM sales_details WHERE sale_id = old.id;"
                + " END ; ", "");

                db.executeData("DROP TRIGGER  IF EXISTS  `cancel_sale`;", "");
                db.executeData("CREATE TRIGGER `cancel_sale` AFTER DELETE ON `sales_details` FOR EACH ROW BEGIN"
                + " UPDATE buy_details"
                + " SET qtt_rest = qtt_rest + old.qty  WHERE buy_id = old.buy_id and  pro_id = old.pro_id;"
                   + " END; "
                   + " ", "");

                // db.executeData("TRUNCATE TABLE buy_details", "");
                // db.executeData("TRUNCATE TABLE buy", "");

                //a =db.executeData("TRUNCATE TABLE sales ", "");
                //if (a) { db.executeData("TRUNCATE TABLE sales_details ", ""); }
                //b=db.executeData("TRUNCATE TABLE buy ", "");
                //if (b) { db.executeData("TRUNCATE TABLE buy_details ", ""); }
                db.executeData("TRUNCATE TABLE transactions ", "");
                db.executeData("TRUNCATE TABLE transfert ", "");

            }









            btnSaveFact.Enabled = false;
            //if (cbxForniss.SelectedValue!=null )
            //{
            if (Convert.ToBoolean(isZero)) { payedAll = 1; } else { payedAll = 0; }
            //if (Convert.ToBoolean(chxDette.Checked)) { j = 1; };
            Boolean isbuyCreated = true;
            if (!edit)
            {
                String STRquery = "";


                STRquery = @"insert into buy values (" +
                       lblFactNumAuto.Text +//id 
                   ",'" + txtFactNum.Text +//code_fact
                 "','" + dpFactDate.Value.ToString("yyyy-MM-dd") +//date
                 "','" + cbxForniss.SelectedValue +//sup_id
                 "','" + TotalOrder +// totalOrder
                 "','" + txtApay.Text +//apay
                 "','" + leRest +//lereste
                 "','" + dpToDette.Value.ToString("yyyy-MM-dd") +//detteDate
                 "','" + payedAll +//payed_all
                 "','" + txtRemrq.Text +//Remarque
                 "',null" +//timer
                 "," + Properties.Settings.Default.userID + ") ;";//user_id
                //MessageBox.Show(STRquery);

                db.executeData(STRquery, "");

                if (isbuyCreated)
                {
                    for (int dd = 0; dd <= dgvBuy.Rows.Count - 1; dd++)
                    {

                        if (Convert.ToInt32(dgvBuy.Rows[dd].Cells[4].Value) >= 0)
                        {
                            STRquery = "";
                            STRquery = @"insert into buy_details values (null" +//id
                                        "," + lblFactNumAuto.Text +//buy_id 
                                       ",'" + dgvBuy.Rows[dd].Cells[1].Value +//pro_id
                                    "','" + dgvBuy.Rows[dd].Cells[3].Value + // price
                                    "','" + dgvBuy.Rows[dd].Cells[4].Value +//qty
                                    "','" + dgvBuy.Rows[dd].Cells[4].Value +//qtt_rest
                                    "','" + dgvBuy.Rows[dd].Cells[5].Value +//total 
                                     "',null);";//timmer
                            db.executeData(STRquery, "");
                            STRquery = "";
                            STRquery = @"update products  SET pricesale ='" + dgvBuy.Rows[dd].Cells[6].Value +
                                "', 	prix_grox = '" + dgvBuy.Rows[dd].Cells[7].Value +
                                "', pricehelp ='" + dgvBuy.Rows[dd].Cells[8].Value +
                                "', remise = '" + dgvBuy.Rows[dd].Cells[9].Value +
                                "' where id=" + dgvBuy.Rows[dd].Cells[1].Value + " ;";
                            db.executeData(STRquery, "");
                        }
                        //+ lblFactNumAuto.Text + "', '"
                        //                + dgvBuy.Rows[dd].Cells[1].Value + "', '"
                        //                + dgvBuy.Rows[dd].Cells[3].Value + "', '"
                        //                + dgvBuy.Rows[dd].Cells[4].Value + "', '"
                        //                + dgvBuy.Rows[dd].Cells[4].Value + "', '"
                        //                + dgvBuy.Rows[dd].Cells[5].Value + "', '"
                        //                 + dpFactDate.Value.ToString("yyyy-MM-dd") + "' "+
                        //                  "' where id  =" + dgvBuy.Rows[dd].Cells[1].Value + "    ;"; 


                    }
                }
            }
            else  // if (edit)
            {

                db.executeData("update  buy SET code_fact  ='" + txtFactNum.Text +
                                "',date='" + dpFactDate.Value.ToString("yyyy-MM-dd") +
                                "',sup_id='" + cbxForniss.SelectedValue +
                                "',totalOrder='" + TotalOrder +
                                "',apay='" + txtApay.Text +
                                "',lereste='" + leRest +
                                "',detteDate='" + dpToDette.Value.ToString("yyyy-MM-dd") +
                                "',payed_all='" + payedAll +
                                "',Remarque='" + txtRemrq.Text +
                                "',timer=null" +
                                ",user_id=" + Properties.Settings.Default.userID +
                                " where id=" + lblFactNumAuto.Text + "    ;", "");
                db.executeData("DELETE FROM buy_details WHERE buy_id= " + lblFactNumAuto.Text, "");
                String Stttrquery = "";
                for (int dd = 0; dd <= dgvBuy.Rows.Count - 1; dd++)
                {
                    Stttrquery = @"insert into buy_details values (null" +//id
                                   "," + lblFactNumAuto.Text +//buy_id 
                                  ",'" + dgvBuy.Rows[dd].Cells[1].Value +//pro_id
                               "','" + dgvBuy.Rows[dd].Cells[3].Value + // price
                               "','" + dgvBuy.Rows[dd].Cells[4].Value +//qty
                               "','" + dgvBuy.Rows[dd].Cells[4].Value +//qtt_rest
                               "','" + dgvBuy.Rows[dd].Cells[5].Value +//total 
                                "',null);";//timmer

                    //Stttrquery = @"update  buy_details  SET pro_id='" + dgvBuy.Rows[dd].Cells[1].Value +
                    //        "',price='" + dgvBuy.Rows[dd].Cells[3].Value +
                    //        "',qty='" + dgvBuy.Rows[dd].Cells[4].Value +
                    //        "',qtt_rest='" + dgvBuy.Rows[dd].Cells[4].Value +
                    //        "',total='" + dgvBuy.Rows[dd].Cells[5].Value +
                    //         "',null" +
                    //        "' where buy_id =" + lblFactNumAuto.Text + "and id=" + dgvBuy.Rows[dd].Cells[1].Value + "    ;";


                    //+ lblFactNumAuto.Text + "', '"
                    //                + dgvBuy.Rows[dd].Cells[1].Value + "', '"
                    //                + dgvBuy.Rows[dd].Cells[3].Value + "', '"
                    //                + dgvBuy.Rows[dd].Cells[4].Value + "', '"
                    //                + dgvBuy.Rows[dd].Cells[4].Value + "', '"
                    //                + dgvBuy.Rows[dd].Cells[5].Value + "', '"
                    //                 + dpFactDate.Value.ToString("yyyy-MM-dd") + "' "+
                    //                  "' where id  =" + dgvBuy.Rows[dd].Cells[1].Value + "    ;"; 
                    db.executeData(Stttrquery, "");
                    Stttrquery = "";
                    Stttrquery = @"update products  SET pricesale ='" + dgvBuy.Rows[dd].Cells[6].Value +
                    "', 	prix_grox = '" + dgvBuy.Rows[dd].Cells[7].Value +
                    "', pricehelp ='" + dgvBuy.Rows[dd].Cells[8].Value +
                    "', remise = '" + dgvBuy.Rows[dd].Cells[9].Value +
                    "' where id=" + dgvBuy.Rows[dd].Cells[1].Value + "    ;";
                    db.executeData(Stttrquery, "");

                }
            }
            String Strquery = "";
            if (payedAll == 0)
            {

                Strquery = @"update fournisseur  SET Dette =Dette+ " + leRest +
               " where id=" + cbxForniss.SelectedValue + "    ;";
                db.executeData(Strquery, "");
                if (!edit)
                {
                    Strquery = "";

                    Strquery = @"update dettes_fournisseur  set total_dette='" + leRest
                               + "' ,date_to_pay='" + dpToDette.Value.ToString("yyyy-MM-dd") + "' " +
                              " where id_fourniss=" + cbxForniss.SelectedValue + " and num_fact=" + lblFactNumAuto.Text + ";";
                }
                else
                {
                    Strquery = "";
                    Strquery = @"Insert into dettes_fournisseur  values ("
                            + "null" + ", '"
                            + cbxForniss.SelectedValue + "', '"
                            + lblFactNumAuto.Text + "', '"
                            + leRest + "', '"
                            + dpToDette.Value.ToString("yyyy-MM-dd") + "',  "
                            + 0 + " , null ," + Properties.Settings.Default.userID + ",  null);";
                }


                db.executeData(Strquery, "");
            }

            tbl.Clear();
            tbl = db.readData("select max(id) from buy", "");
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
            //}
            //else
            //{
            //    MessageBox.Show("Fournisseur لم يتم اختيار  ");
            //}
            this.Hide();
            //if (edit)
            //{
            //    this.Hide();
            //}
        }
        //private void btnSaveFact_Click(object sender, EventArgs e)
        //{
        //    btnSaveFact.Enabled = false;
        //    //if (cbxForniss.SelectedValue!=null )
        //    //{
        //    if (Convert.ToBoolean(isZero)) { payedAll = 1; } else { payedAll = 0; }
        //        //if (Convert.ToBoolean(chxDette.Checked)) { j = 1; };
        //        if (edit)
        //        {
        //            db.executeData("DELETE FROM buy WHERE id= " + lblFactNumAuto.Text, "");
        //        }
        //        db.executeData("insert into buy values ("+ lblFactNumAuto.Text + ",'" +
        //                                txtFactNum.Text +
        //                        "','" + dpFactDate.Value.ToString("yyyy-MM-dd") +
        //                        "','" + cbxForniss.SelectedValue +
        //                        "','" + TotalOrder +
        //                        "','" + txtApay.Text +
        //                        "','" + leRest +
        //                        "','" + dpToDette.Value.ToString("yyyy-MM-dd") +
        //                        "','" + payedAll +
        //                        "','" + txtRemrq.Text +
        //                        "',null" +
        //                        "," + Properties.Settings.Default.userID + " )", "");
        //        String Strquery = "";
        //        for (int dd = 0; dd <= dgvBuy.Rows.Count - 1; dd++)
        //        {
        //            Strquery = @"Insert into buy_details  values ("
        //                        + "null" + ", '"
        //                        + lblFactNumAuto.Text + "', '"
        //                        + dgvBuy.Rows[dd].Cells[1].Value + "', '"
        //                        + dgvBuy.Rows[dd].Cells[3].Value + "', '"
        //                        + dgvBuy.Rows[dd].Cells[4].Value + "', '"
        //                        + dgvBuy.Rows[dd].Cells[4].Value + "', '"
        //                        + dgvBuy.Rows[dd].Cells[5].Value + "', '"
        //                         + dpFactDate.Value.ToString("yyyy-MM-dd") + " ' );";
        //            db.executeData(Strquery, "");
        //            Strquery = "";
        //            Strquery = @"update products  SET pricesale ='" + dgvBuy.Rows[dd].Cells[6].Value +
        //                "', 	prix_grox = '" + dgvBuy.Rows[dd].Cells[7].Value +
        //                "', pricehelp ='" + dgvBuy.Rows[dd].Cells[8].Value +
        //                "', remise = '" + dgvBuy.Rows[dd].Cells[9].Value +
        //                "' where id=" + dgvBuy.Rows[dd].Cells[1].Value + "    ;";
        //            db.executeData(Strquery, "");

        //        }
        //        if (payedAll == 0)
        //        {
        //            Strquery = @"update fournisseur  SET Dette =Dette+ " + leRest +
        //               " where id=" + cbxForniss.SelectedValue + "    ;";
        //            db.executeData(Strquery, "");
        //            Strquery = "";
        //            Strquery = @"Insert into dettes_fournisseur  values ("
        //                        + "null" + ", '"
        //                        + cbxForniss.SelectedValue + "', '"
        //                        + lblFactNumAuto.Text + "', '"
        //                        + leRest + "', '"
        //                        + dpToDette.Value.ToString("yyyy-MM-dd") + "',  "
        //                        + 0 + " , null ," + Properties.Settings.Default.userID + ",  null);";
        //            db.executeData(Strquery, "");
        //        }

        //        tbl.Clear();
        //        tbl = db.readData("select max(id) from buy", "");
        //        if (tbl.Rows.Count >= 0)
        //        {
        //            if (tbl.Rows[0][0].ToString() == lblFactNumAuto.Text)
        //            {
        //                clearAll();
        //                AutoNumber();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("لم يتم تسجيل عملية البيع");
        //        }
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("Fournisseur لم يتم اختيار  ");
        //    //}
        //    this.Hide();
        //    //if (edit)
        //    //{
        //    //    this.Hide();
        //    //}
        //}

        double payo=0;
        private void txtApay_KeyUp(object sender, KeyEventArgs e)
        {
            //if (txtApay.Text == "" || txtApay.Text == null)
            //{
            //    // txtApay.Text = "0";
            //    payo = 0;
            //}
           
        }
        Boolean isZero = false;

        private void txtApay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.dgvBuy.Rows.RemoveAt(this.dgvBuy.SelectedRows[0].Index);
            refreche_Total();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //
        }

        private void cbxForniss_Click(object sender, EventArgs e)
        {

            FillSupplier();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_Fourns fourn = new frm_Fourns();
            fourn.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            refreche_Total();
            txtApay.Text = Convert.ToString(TotalOrder);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBarCode.Text != "" && txtBarCode.Text != null)
                {
                    this.dgvProduct.DataSource = null;
                    this.dgvProduct.Rows.Clear();

                    DataTable tblItems = new DataTable();
                    tblItems.Clear();
                    tblItems = db.readData("select id  ,name  ,reference1  , mark  ,pricesale,prix_grox, pricehelp,remise from products where barcode  LIKE '" + txtBarCode.Text + "' ", "");
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
                txtBarCode.SelectAll();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            dgvBuy.Rows.Clear(); clearAll();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //frm_AddUpdateProduct addUpdateProdcts = new frm_AddUpdateProduct(); 
            //addUpdateProdcts.btnSave.Visible = true;
            //addUpdateProdcts.btnUpdate.Visible = false;
            //addUpdateProdcts.SelectedID = 0;
            //addUpdateProdcts.AutoNumber();
            //addUpdateProdcts.ShowDialog();
            //this.panel1.Controls.Clear();
            frm_products home = new frm_products() ;
            home.Show(); home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

       
        private void textBox2_TextChanged(object sender, EventArgs e) 
        {  
           if (TotalOrder>0){

            if (txtApay.Text == "" || txtApay.Text == null)
            {
                // txtApay.Text = "0";
                payo = 0;
                }else
                {
                    payo =  Convert.ToDouble(txtApay.Text);
                }
            double testvar =  payo  - TotalOrder;
            var number = double.Parse(testvar + "".Replace("−", "-"));
            if (number > 0)
            {
                txtApay.Text = "0";
            }
            

                leRest = TotalOrder - payo;
                //MessageBox.Show("leRest = "+ leRest+ " ; TotalOrder = "+ TotalOrder+ " ; payo = "+ payo);
                lblRest.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(leRest));
                if (leRest==0)
                {
                    isZero = true;
                    dpToDette.Enabled = false; label22.Enabled = false;
                }else
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAll();
            AutoNumber();
        }

        private void dgvProduct_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                //MessageBox.Show(row.Cells[0].Value.ToString());
                txtVente.Text = row.Cells[4].Value.ToString(); txtgros.Text = row.Cells[5].Value.ToString();
                txtSpecial.Text = row.Cells[6].Value.ToString();  txtRemise.Text = row.Cells[7].Value.ToString();
                
                if (tbl.Rows.Count == 0)
                {
                    txtVente.Text = "0"; txtSpecial.Text = "0"; txtgros.Text = "0"; txtRemise.Text = "0";
                }
                 
             //   txtVente.Text = "0"; txtSpecial.Text = "0"; txtgros.Text = "0"; txtRemise.Text = "0";
            }
        }

       

        public void showInTable(string sale_id)
        {
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
                        dgvBuy.Rows[nc].Cells[7].Value = row["prix_grox"].ToString();
                        dgvBuy.Rows[nc].Cells[8].Value = row["pricehelp"].ToString();
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
                tbl.Clear();
                tbl = db.readData("SELECT Remarque FROM buy WHERE id=" + sale_id, "");
                if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
                {
                    txtRemrq.Text = "";
                }
                else
                {
                    txtRemrq.Text = tbl.Rows[0][0].ToString();
                }
            }
        }


        public void showEtatStockInTable()
        {
            lblFactNumAuto.Text = "1";
            this.dgvBuy.DataSource = null;
            this.dgvBuy.Rows.Clear();
            tbl.Clear();

           

                tbl = db.readData("SELECT   prid as pro_id , name , price  ,  rest2 as qty,(rest2*price) as total,pricesale,prix_grox,pricehelp,remise FROM  v_etat_stock", "");

            if (tbl.Rows.Count >= 0)
            {
                try
                {
                    //  MessageBox.Show("tblItems.Rows.Count = "+ tblItems.Rows.Count);
                    int jj = 1;
                    foreach (DataRow row in tbl.Rows)
                    {
                        int nc = dgvBuy.Rows.Add();

                        dgvBuy.Rows[nc].Cells[0].Value = jj;
                        dgvBuy.Rows[nc].Cells[1].Value = row["pro_id"].ToString();
                        dgvBuy.Rows[nc].Cells[2].Value = row["name"].ToString();
                        dgvBuy.Rows[nc].Cells[3].Value = row["price"].ToString();
                        dgvBuy.Rows[nc].Cells[4].Value = row["qty"].ToString();
                        dgvBuy.Rows[nc].Cells[5].Value = row["total"].ToString();
                        dgvBuy.Rows[nc].Cells[6].Value = row["pricesale"].ToString();
                        dgvBuy.Rows[nc].Cells[7].Value = row["prix_grox"].ToString();
                        dgvBuy.Rows[nc].Cells[8].Value = row["pricehelp"].ToString();
                        dgvBuy.Rows[nc].Cells[9].Value = row["remise"].ToString();
                        // dgvBuy.Rows[nc].Cells[10].Value = 1;
                        jj++;
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
                tbl.Clear();
                tbl = db.readData("SELECT Remarque FROM buy WHERE id=" + 1, "");
                if (tbl.Rows.Count == 0)
                {
                    txtRemrq.Text = "";
                }
                else
                {
                    txtRemrq.Text = tbl.Rows[0][0].ToString();
                }
            }
        }
    }
}