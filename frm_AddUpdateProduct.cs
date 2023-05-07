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

namespace Disdriver
{
    public partial class frm_AddUpdateProduct : DevExpress.XtraEditors.XtraForm
    {
        public int PgSize = 0;
        public int TotalPage = 0;
        public frm_AddUpdateProduct()
        {
            InitializeComponent(); FillMagas(); FillEmpl();
            //FillFourn();
            Fillcategr(); FillMagas(); FillMagas(); 
        }
            Database db = new Database();
            DataTable tbl = new DataTable();
            DataTable dtbl = new DataTable();
        public String leBarcode;
        public frm_products allProducts = new frm_products();
        public int SelectedID=1;

        //private void FillFourn()
        //{
        //    cbxFourn.DataSource = db.readData("SELECT * FROM fournisseur ", "");
        //    cbxFourn.DisplayMember = "nomFr";
        //    cbxFourn.ValueMember = "id";
        //}
     
        private void Fillcategr()
        {
            cbxCateg.DataSource = db.readData("SELECT * FROM category  ORDER BY name", "");
            cbxCateg.DisplayMember = "name";
            cbxCateg.ValueMember = "id";
        }
        private void FillMagas()
        {
            cbxMags.DataSource = db.readData("SELECT * FROM magasins  ORDER BY name", "");
            cbxMags.DisplayMember = "name";
            cbxMags.ValueMember = "id";
        }
        private void FillEmpl()
        {
            if (cbxMags.SelectedValue!= null)
            {
            cbxEmpl.DataSource = db.readData("SELECT * FROM emplacements where id_magasin ="+ cbxMags.SelectedValue, "");
            cbxEmpl.DisplayMember = "name";
            cbxEmpl.ValueMember = "id";
            }
            
        }

        private void frm_AddUpdateProduct_Load(object sender, EventArgs e)
        {
            
        }
        public void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from products", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                lbShowlID.Text = "1";
            }
            else
            {
                lbShowlID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            


            btnSave.Enabled = true;
            btnUpdate.Enabled = true; 
        }
        //   Product_Name, txtBarcode, txtRef1, txtNumFact, txtDesc, txtMark, txtModel, txtQulty, txtColor, txtAchat, txtVent, txtGros, textPrixSpec, txtRemis, txtCmdMin, txtCmdMax, cbxFourn;
        //   cbxCateg, cbxMags, cbxEmpl, txtQuantMin, txtQuantMax, checkAcitve, checkStock, txtshowImage1, txtshowImage2, dpDateEnter;
        private Boolean getBoolFromSTR(string word)
        {
            if (word == "1") { return true; }else { return false; }

        }
        public void fillAlldata()
        { 
            lbShowlID.Text =        allProducts.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text =          allProducts.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBarcode.Text =       allProducts.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtRef1.Text =          allProducts.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //txtNumFact.Text =       allProducts.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDesc.Text =          allProducts.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtMark.Text =          allProducts.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtModel.Text =         allProducts.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtQulty.Text =         allProducts.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtColor.Text =         allProducts.dataGridView1.CurrentRow.Cells[9].Value.ToString();
           // txtAchat.Text =         allProducts.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtVent.Text =          allProducts.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtGros.Text =          allProducts.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textPrixSpec.Text =     allProducts.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtRemis.Text =         allProducts.dataGridView1.CurrentRow.Cells[14].Value.ToString();
           // txtQuantMin.Text =        allProducts.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            //txtCmdMax.Text =        allProducts.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            //cbxFourn.SelectedValue =allProducts.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            cbxCateg.SelectedValue =allProducts.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            cbxMags.SelectedValue = allProducts.dataGridView1.CurrentRow.Cells[19].Value.ToString();
            cbxEmpl.SelectedValue = allProducts.dataGridView1.CurrentRow.Cells[20].Value.ToString();
            txtQuantMin.Text =      allProducts.dataGridView1.CurrentRow.Cells[21].Value.ToString();
            //txtQuantMax.Text =      allProducts.dataGridView1.CurrentRow.Cells[22].Value.ToString();
          //  checkAcitve.Checked = getBoolFromSTR( allProducts.dataGridView1.CurrentRow.Cells[23].Value.ToString());
         //   checkStock.Checked = getBoolFromSTR( allProducts.dataGridView1.CurrentRow.Cells[24].Value.ToString());
            txtshowImage1.Text =         allProducts.dataGridView1.CurrentRow.Cells[25].Value.ToString();
            txtshowImage2.Text = allProducts.dataGridView1.CurrentRow.Cells[26].Value.ToString();
            if (@allProducts.dataGridView1.CurrentRow.Cells[25].Value.ToString() != "") { pictureBox1.Image = new Bitmap(@allProducts.dataGridView1.CurrentRow.Cells[25].Value.ToString()); pictureBox1.Refresh(); }
            if (@allProducts.dataGridView1.CurrentRow.Cells[26].Value.ToString()!="") { pictureBox2.Image = new Bitmap(@allProducts.dataGridView1.CurrentRow.Cells[26].Value.ToString()); pictureBox2.Refresh(); }
           
          
        }

        public void clearAllData()
        {
         txtName.Clear();
         txtBarcode.Clear();
            txtRef1.Clear();
           // txtNumFact.Clear();
            txtDesc.Clear();
            txtMark.Clear();
            txtModel.Clear();
            txtQulty.Clear();
            txtColor.Clear();
           // txtAchat.Clear();
            txtVent.Clear();
            txtGros.Clear();
            textPrixSpec.Clear();
            txtRemis.Clear();
            txtQuantMin.Clear();
          //  txtCmdMax.Clear();
            
          //  txtQuantMin.Clear();
          //  txtQuantMax.Clear();
          //  checkAcitve.Checked = false;
          //  checkStock.Checked = false;
            txtshowImage1.Clear();
            txtshowImage2.Clear();
            //dpDateEnter.Clear();

            //txtID.Clear();
            //txtNom1.Clear();
            //dpQuant.Text = "1";
            //dpMax.Text = "1";
            //numPrixA.Text = "1";
            //numPrixV.Text = "1";
            //txtCodBar.Clear();
            //numRem.Text = "1";


        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cbxCateg.Text != null && cbxMags.Text != null && cbxEmpl.Text != null)
            {
                int i = 0, j = 0;
            // if (Convert.ToBoolean(checkAcitve.Checked)) { i = 1; };

            //if (Convert.ToBoolean(checkStock.Checked)) { j = 1; };
            if (!test_is_barcode_existe(txtBarcode.Text))
            {
                db.executeData("insert into products values (null,'" +
                        txtName.Text +
                "','" + txtBarcode.Text +
                "','" + txtRef1.Text +
                "',null" + 
                ",'" + txtDesc.Text +
                "','" + txtMark.Text +
                "','" + txtModel.Text +
                "','" + txtQulty.Text +
                "','" + txtColor.Text +
                  "',null" + 
                ",'" + txtVent.Text +
                "','" + txtGros.Text +
                "','" + textPrixSpec.Text +
                "','" + txtRemis.Text +
                 "',null" +
                 ",null" +
                ",0" +
                ",'" + cbxCateg.SelectedValue +
                "','" + cbxMags.SelectedValue +
                "','" + cbxEmpl.SelectedValue +
                "','" + txtQuantMin.Text +
                 "',null" +
                ",null" + 
                 ",null" +   
                ",'" +  txtshowImage1.Text.Replace("\\", "\\\\") +
                "','" + txtshowImage2.Text .Replace("\\", "\\\\") +
                "','0000-00-00" +   "',null ,"+0+","+ Properties.Settings.Default.userID + ")", "");
            clearAllData();
            AutoNumber();
            allProducts.showInTable(false, TotalPage, PgSize);
            }
            else
            {
                MessageBox.Show("Ce Barcode Existe dijà "); txtBarcode.Text = "";
                }
            }
            else
            {
                    MessageBox.Show(" الصنف او المخزان او مكان التخزين غير مسجل ");
                }
            }
        private Boolean test_is_barcode_existe(String baecode)
        {
            Boolean is_exist = false;
             tbl.Clear();
            tbl = db.readData("select barcode from products where barcode='"+ baecode+"'", "");
            if (tbl.Rows.Count > 0)
            {
                is_exist=true;
            }
            else
            {
                is_exist = false;
            }
        return is_exist ;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbxCateg.SelectedValue != null && cbxMags.SelectedValue != null && cbxEmpl.SelectedValue != null )
            { 
                if (leBarcode== txtBarcode.Text)
                 {

                int i = 0, j = 0;
                db.executeData("update products set " +
                    " name='" + txtName.Text + 
                    "',reference1='" + txtRef1.Text +
                    //"',NumFacture='" + txtNumFact.Text +
                    "',description='" + txtDesc.Text +
                    "',mark='" + txtMark.Text +
                    "',model='" + txtModel.Text +
                    "',quality='" + txtQulty.Text +
                    "',color='" + txtColor.Text +
                    //"',pricebuy='" + txtAchat.Text +
                    "',pricesale='" + txtVent.Text +
                    "',prix_grox='" + txtGros.Text +
                    "',pricehelp='" + textPrixSpec.Text +
                    "',remise='" + txtRemis.Text +
                    // "',min_demande='" + txtQuantMin.Text +
                    // "',max_demande='" + txtCmdMax.Text +
                    "',id_category='" + cbxCateg.SelectedValue +
                    "',id_magasin='" + cbxMags.SelectedValue +
                    "',id_emplacement='" + cbxEmpl.SelectedValue +
                    "',quantity_min='" + txtQuantMin.Text +
                    //"',quantity_max='" + txtQuantMax.Text +
                    "',active=null" +
                    ",enstock='" + j +
                    "',image1='" + txtshowImage1.Text.Replace("\\", "\\\\") +
                    "',image2='" + txtshowImage2.Text.Replace("\\", "\\\\") +
                    "',date= '0000-00-00" + 
                    "',user_id = " + Properties.Settings.Default.userID + " where id= '" + lbShowlID.Text + "'", "");
                AutoNumber();
                    allProducts.showInTable(false, TotalPage, PgSize);
                }
            else
            { 
                if (!test_is_barcode_existe(txtBarcode.Text)&&(txtBarcode.Text!=""))
                { 
                    int i = 0, j = 0; 
                    db.executeData("update products set " +
                        " name='" + txtName.Text +
                        "',barcode ='" + txtBarcode.Text +
                        "',reference1='" + txtRef1.Text +
                        //"',NumFacture='" + txtNumFact.Text +
                        "',description='" + txtDesc.Text +
                        "',mark='" + txtMark.Text +
                        "',model='" + txtModel.Text +
                        "',quality='" + txtQulty.Text +
                        "',color='" + txtColor.Text +
                        //"',pricebuy='" + txtAchat.Text +
                        "',pricesale='" + txtVent.Text +
                        "',prix_grox='" + txtGros.Text +
                        "',pricehelp='" + textPrixSpec.Text +
                        "',remise='" + txtRemis.Text +
                        // "',min_demande='" + txtQuantMin.Text +
                        // "',max_demande='" + txtCmdMax.Text +
                        "',id_category='" + cbxCateg.SelectedValue +
                        "',id_magasin='" + cbxMags.SelectedValue +
                        "',id_emplacement='" + cbxEmpl.SelectedValue +
                        "',quantity_min='" + txtQuantMin.Text +
                        //"',quantity_max='" + txtQuantMax.Text +
                        "',active=null" +
                        ",enstock='" + j +
                        "',image1='" + txtshowImage1.Text.Replace("\\", "\\\\") +
                        "',image2='" + txtshowImage2.Text.Replace("\\", "\\\\") +
                        "',date= '0000-00-00" +
                        "',user_id = " + Properties.Settings.Default.userID + " where id= '" + lbShowlID.Text + "'", ""); 
                    AutoNumber();
                        allProducts.showInTable(false, TotalPage, PgSize);
                    }
                else
                {
                    MessageBox.Show("Ce Barcode Existe dijà "); txtBarcode.Text = "";
                }
            }
            this.Hide();
                //
            }
            else
            {
                MessageBox.Show(" الصنف او المخزان او مكان التخزين غير مسجل ");  
            }
        }

        private void btnGetImage1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                
                string source = of.FileName;
                 
                try
                {
                    if (!Directory.Exists(Environment.CurrentDirectory +@"\Images\"))
                    {
                        // Try to create the directory.
                        DirectoryInfo di = Directory.CreateDirectory(Environment.CurrentDirectory +@"\Images\");
                    }else
                    {
                   // MessageBox.Show("path destination " +  Environment.CurrentDirectory +  @"\Images\".ToString());
                    string dest = Environment.CurrentDirectory+ @"\Images\" + Path.GetFileName(source);
                    File.Copy(source, dest);
                    txtshowImage1.Text = dest;
                    pictureBox1.Image = new Bitmap(dest); pictureBox1.Refresh();
                    }
                   
                }
                catch (IOException ioex)
                {
                    MessageBox.Show("Error " + ioex.Message);
                }
                // pictureBox1.ImageLocation = of.FileName;
            }
        
        }

        private void btnGetImage2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {

                string source = of.FileName;

                try
                {
                    if (!Directory.Exists(Environment.CurrentDirectory + @"\Images\"))
                    {
                        // Try to create the directory.
                        DirectoryInfo di = Directory.CreateDirectory(Environment.CurrentDirectory + @"\Images\");
                    }
                    else
                    {
                      //  MessageBox.Show("path destination " + Environment.CurrentDirectory + @"\Images\".ToString());
                        string dest = Environment.CurrentDirectory + @"\Images\" + Path.GetFileName(source);
                        File.Copy(source, dest);
                        txtshowImage2.Text = dest;
                        pictureBox2.Image = new Bitmap(dest); pictureBox2.Refresh();
                    }

                }
                catch (IOException ioex)
                {
                    MessageBox.Show("Error " + ioex.Message);
                }
                // pictureBox1.ImageLocation = of.FileName;
            }

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

        }

      

        private void cbxCateg_Click(object sender, EventArgs e)
        {
            Fillcategr();
        }

        private void cbxMags_Click(object sender, EventArgs e)
        {
            FillMagas();
        }

        private void cbxEmpl_Click(object sender, EventArgs e)
        {
            FillEmpl();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_Fourns fourn = new frm_Fourns();
            fourn.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_Category categ = new frm_Category();
            categ.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_Magazin mag = new frm_Magazin();
            mag.ShowDialog();
        }

       
    }
}
//SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.InitialDirectory =   @"D:\"; 
            //saveFileDialog1.Title = "Save images Files";
            //saveFileDialog1.CheckFileExists = true;
            //saveFileDialog1.CheckPathExists = true;
            //saveFileDialog1.DefaultExt = "txt";
            //saveFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //saveFileDialog1.FilterIndex = 2;
            //saveFileDialog1.RestoreDirectory = true;
            //saveFileDialog1.
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    txtshowImage1.Text = saveFileDialog1.FileName;
            //}