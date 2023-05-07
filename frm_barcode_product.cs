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
    public partial class frm_barcode_product : DevExpress.XtraEditors.XtraForm
    {
        public int PgSize = 0;
        public int TotalPage = 0;
        public frm_products allProducts = new frm_products();
        public frm_barcode_product(String article, String prix, String barcode, String id)
        {
            InitializeComponent();
            showInTable(id);
            this.article = article;
            this.prix = prix;
            this.barcode = barcode;
            this.id = id;
            initFrame();
        }
        public void showInTable(string product_id)
        {
            this.dgvBarcode.DataSource = null;
            this.dgvBarcode.Rows.Clear();
            tbl.Clear();

            tbl = db.readData("SELECT * FROM barcode_product WHERE id_product=" + product_id, "");  //  

            if (tbl.Rows.Count >= 0)
            {
                try
                { 
                    foreach (DataRow row in tbl.Rows)
                    {
                        int nc = dgvBarcode.Rows.Add();
                        dgvBarcode.Rows[nc].Cells[0].Value = row["id"].ToString();
                        dgvBarcode.Rows[nc].Cells[1].Value = row["barcode"].ToString(); 
                    }

                }
                catch (Exception) { }
 
            }
        }
        void initFrame()
        {
            lblArticle.Text = article;
            lblPrix.Text = prix;
            txtBarcode.Text = barcode;
            lblShow.Text = barcode;

        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        public String article="", prix="", barcode = "", id = "";

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Barcode حل حقا تريد حذف ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from barcode_product where id='" + dgvBarcode.CurrentRow.Cells[0].Value.ToString() + "'", ""); 
                showInTable(id);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("SELECT barcode FROM  products where barcode=" + txtCadbarAdd.Text, "");
            if (tbl.Rows.Count > 0)
            {
                MessageBox.Show("Ce code bare exicte déja !");
            }else
            {
                db.executeData("insert into barcode_product values (null,"+ id+","+ txtCadbarAdd.Text+ " )", "");
            }
            showInTable(id);
        }

        private void btnRandBarCode_Click(object sender, EventArgs e)
        {
            tbl = db.readData("SELECT barcode FROM  barcode where id=1", "");
            if (tbl.Rows.Count > 0)
            {
                txtBarcode.Text =( Convert.ToDouble( tbl.Rows[0][0].ToString())+1).ToString();
                lblShow.Text = txtBarcode.Text;
            }
            else
            {
                db.executeData("insert into barcode values (1, 10000000 )", "");
                txtBarcode.Text = "10000000";
                lblShow.Text = "10000000";
            } 

        }

        private void btnSaveBar_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("SELECT barcode FROM  products where barcode="+ txtBarcode.Text, "");
            if (tbl.Rows.Count > 0)
            {
                MessageBox.Show("Ce code bare exicte déja !");
                db.executeData("update barcode set  barcode='" + txtBarcode.Text + "' where id=1", "");
                txtBarcode.Text = (Convert.ToDouble(txtBarcode.Text) + 1).ToString();
                lblShow.Text = txtBarcode.Text;
                
            }
            else
            {
                db.executeData("update barcode set  barcode='" + txtBarcode.Text + "' where id=1", "");

                db.executeData("update products set  barcode='" + txtBarcode.Text + "' where id=" + id, "");
                allProducts.showInTable(false, TotalPage, PgSize);
            }
           
        }

    }
}