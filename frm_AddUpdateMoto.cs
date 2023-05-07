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
    public partial class frm_AddUpdateMoto : DevExpress.XtraEditors.XtraForm
    {
        string dest1 = ""; string dest2 = "";
        public frm_AddUpdateMoto()
        {
            InitializeComponent();
            FillFourn(); Fillcategr(); FillMagas(); FillEmpl();
            panel7.Enabled = false;
        }

        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();

        public frm_motos allMotos = new frm_motos();
        public int SelectedID = 1;

        private void FillFourn()
        {
            cbxFourn.DataSource = db.readData("SELECT * FROM fournisseur ", "");
            cbxFourn.DisplayMember = "name";
            cbxFourn.ValueMember = "id";
        }

        private void Fillcategr()
        {
            cbxCateg.DataSource = db.readData("SELECT * FROM category ", "");
            cbxCateg.DisplayMember = "name";
            cbxCateg.ValueMember = "id";
        }
        private void FillMagas()
        {
            cbxMags.DataSource = db.readData("SELECT * FROM magasins ", "");
            cbxMags.DisplayMember = "name";
            cbxMags.ValueMember = "id";
        }
        private void FillEmpl()
        {
            cbxEmpl.DataSource = db.readData("SELECT * FROM emplacements ", "");
            cbxEmpl.DisplayMember = "name";
            cbxEmpl.ValueMember = "id";
        }
        public void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from motos", "");
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
        private Boolean getBoolFromSTR(string word)
        {
            if (word == "1") { return true; } else { return false; }

        }

        public void fillAlldata()
        {
            lbShowlID.Text = allMotos.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtRef1.Text = allMotos.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = allMotos.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNumFact.Text = allMotos.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMark.Text = allMotos.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtType.Text = allMotos.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtNumSerie.Text = allMotos.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textPuiss.Text = allMotos.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //textMatric.Text = allMotos.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textTypMtr.Text = allMotos.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtPoid.Text = allMotos.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textCylndr.Text = allMotos.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtColor.Text = allMotos.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            cbxComd.Text = allMotos.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtAnne.Text = allMotos.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            txtAchat.Text = allMotos.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            txtVent.Text = allMotos.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            txtGros.Text = allMotos.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textPrixSpec.Text = allMotos.dataGridView1.CurrentRow.Cells[19].Value.ToString();
            txtRemis.Text = allMotos.dataGridView1.CurrentRow.Cells[20].Value.ToString();
            txtCmdMin.Text = allMotos.dataGridView1.CurrentRow.Cells[21].Value.ToString();
            txtCmdMax.Text = allMotos.dataGridView1.CurrentRow.Cells[22].Value.ToString();  
            cbxFourn.SelectedValue = allMotos.dataGridView1.CurrentRow.Cells[23].Value.ToString();
            cbxCateg.SelectedValue = allMotos.dataGridView1.CurrentRow.Cells[24].Value.ToString();
            cbxMags.SelectedValue = allMotos.dataGridView1.CurrentRow.Cells[25].Value.ToString();
            cbxEmpl.SelectedValue = allMotos.dataGridView1.CurrentRow.Cells[26].Value.ToString();
            txtQuantMin.Text = allMotos.dataGridView1.CurrentRow.Cells[27].Value.ToString();
            txtQuantMax.Text = allMotos.dataGridView1.CurrentRow.Cells[28].Value.ToString();
            checkAcitve.Checked = getBoolFromSTR(allMotos.dataGridView1.CurrentRow.Cells[29].Value.ToString());
            checkStock.Checked = getBoolFromSTR(allMotos.dataGridView1.CurrentRow.Cells[30].Value.ToString());
            txtshowImage1.Text = allMotos.dataGridView1.CurrentRow.Cells[31].Value.ToString();
            txtshowImage2.Text = allMotos.dataGridView1.CurrentRow.Cells[32].Value.ToString();
            if (@allMotos.dataGridView1.CurrentRow.Cells[31].Value.ToString() != "") { pictureBox1.Image = new Bitmap(@allMotos.dataGridView1.CurrentRow.Cells[31].Value.ToString()); pictureBox1.Refresh(); }
            if (@allMotos.dataGridView1.CurrentRow.Cells[32].Value.ToString() != "") { pictureBox2.Image = new Bitmap(@allMotos.dataGridView1.CurrentRow.Cells[32].Value.ToString()); pictureBox2.Refresh(); }

            dpDateEnter.Text = allMotos.dataGridView1.CurrentRow.Cells[33].Value.ToString();
        }
        public void clearAllData()
        {
            txtRef1.Clear();
            txtName.Clear();
            txtNumFact.Clear();
            //txtMark.Clear();
            txtType.Clear();
            //txtNSerie.Clear();
            textPuiss.Clear();
            txtNumSerie.Clear();
            //textMatric.Clear();
            textTypMtr.Clear();
            txtPoid.Clear();
            textCylndr.Clear();
            txtColor.Clear();
            //cbxComd.Clear();
            txtAnne.Clear();
            txtAchat.Clear();
            txtVent.Clear();
            txtGros.Clear();
            textPrixSpec.Clear();
            txtRemis.Clear();
            txtCmdMin.Clear();
            txtCmdMax.Clear();

            txtQuantMin.Clear();
            txtQuantMax.Clear();
            checkAcitve.Checked = false;
            checkStock.Checked = false;
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
        private void btnSave_Click(object sender, EventArgs e)
        {       //   Product_Name, txtBarcode, txtRef1, txtNumFact, txtDesc, txtMark, txtModel, txtQulty, txtColor, txtAchat, txtVent, txtGros, textPrixSpec, txtRemis, txtCmdMin, txtCmdMax, cbxFourn;
                //   cbxCateg, cbxMags, txtEmpl, txtQuantMin, txtQuantMax, checkAcitve, checkStock, txtshowImage1, txtshowImage2, dpDateEnter;
#pragma warning disable CS0219 // The variable 'j' is assigned but its value is never used
#pragma warning disable CS0219 // The variable 'i' is assigned but its value is never used
            int i = 0, j = 0;
#pragma warning restore CS0219 // The variable 'i' is assigned but its value is never used
#pragma warning restore CS0219 // The variable 'j' is assigned but its value is never used
            if (Convert.ToBoolean(checkAcitve.Checked)) { i = 1; };
            if (Convert.ToBoolean(checkStock.Checked)) { j = 1; };
            db.executeData("insert into motos values (null,'" +
                        txtRef1.Text +
                "','" + txtName.Text +
                "','" + txtNumFact.Text +
                "','" + txtMark.Text +
                "','" + txtType.Text +
                "','0"   +
                "','" + txtNumSerie.Text +"" +
                "','" + textPuiss.Text +
                "','" + txtEnergie.Text +
                "','" + textTypMtr.Text +
                "','" + txtPoid.Text +
                "','" + textCylndr.Text +
                "','" + txtColor.Text +
                "','" + cbxComd.SelectedItem +
                "','" + txtAnne.Text +
                "','" + txtAchat.Text +
                "','" + txtVent.Text +
                "','" + txtGros.Text +
                "','" + textPrixSpec.Text +
                "','" + txtRemis.Text +
                "','" + txtCmdMin.Text +
                "','" + txtCmdMax.Text +
                "','" + cbxFourn.SelectedValue +
                "','" + cbxCateg.SelectedValue +
                "','" + cbxMags.SelectedValue +
                "','" + cbxEmpl.SelectedValue +
                "','" + 0 +
                "','" + 0 +
                //"'," + checkAcitve.Checked +
                "'," + 0 +
                "," + checkStock.Checked +
                ",'" + dest1.Replace("\\", "\\\\") +
                "','" + dest2.Replace("\\", "\\\\") +
                "','" + dpDateEnter.Value.ToString("yyyy-MM-dd") + "',null )", "");
            clearAllData();
            AutoNumber();
            allMotos.showInTable(false);

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (nudPrice.Value <= 0)
            //{

            //    return;
            //}
            //else
            //{
            int i = 0, j = 0;
            if (Convert.ToBoolean(checkAcitve.Checked)) { i = 1; };
            if (Convert.ToBoolean(checkStock.Checked)) { j = 1; };
            //db.readData("update products set
            db.executeData("update motos set " + 
                " reference='" + txtRef1.Text +
                "',nom='" + txtName.Text +
                "',NumFacture='" + txtNumFact.Text +
                "',marque='" + txtMark.Text +
                "',type='" + txtType.Text + 
                "',quantity_actuel='" + "" +
                "',puissance_mtr='" + textPuiss.Text +
                "',n_serie='" + txtNumSerie.Text +
                "',matricule_p='" + txtEnergie.Text + 
                "',type_mtr='" + textTypMtr.Text +
                "',poid='" + txtPoid.Text +
                "',cylender='" + textCylndr.Text +
                "',color='" + txtColor.Text +
                "',cmd='" + cbxComd.SelectedItem +
                "',annee='" + txtAnne.Text +
                "',pricebuy='" + txtAchat.Text +
                "',pricesale='" + txtVent.Text +
                "',prix_grox='" + txtGros.Text +
                "',pricehelp='" + textPrixSpec.Text +
                "',remise='" + txtRemis.Text +
                "',min_demande='" + txtCmdMin.Text +
                "',max_demande='" + txtCmdMax.Text +
                "',id_supplier='" + cbxFourn.SelectedValue +
                "',id_category='" + cbxCateg.SelectedValue +
                "',id_magasin='" + cbxMags.SelectedValue +
                "',id_emplacement='" + cbxEmpl.SelectedValue +
                "',quantity_min='" + txtQuantMin.Text +
                "',quantity_max='" + txtQuantMax.Text +
                "',active='" + i +
                "',enstock='" + j +
                "',image1='" + dest1.Replace("\\", "\\\\") +
                "',image2='" + dest2.Replace("\\", "\\\\") +
                "',date= '" + dpDateEnter.Value.ToString("yyyy-MM-dd") + "' where id= '" + lbShowlID.Text + "'", "");


            //    "' , 	sale_price='" + numPrixV.Text + "' ,barcode='" + txtCodBar.Text + "' ,remise='" + numRem.Text + "'  where  	pro_id='" + txtID.Text + "'", "Data Updated successfully");

            //}
            AutoNumber();
            allMotos.showInTable(false);
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
                    if (!Directory.Exists(Environment.CurrentDirectory + @"\Images\"))
                    {
                        // Try to create the directory.
                        DirectoryInfo di = Directory.CreateDirectory(Environment.CurrentDirectory + @"\Images\");
                    }
                    else
                    {
                        // MessageBox.Show("path destination " +  Environment.CurrentDirectory +  @"\Images\".ToString());
                        dest1 = "";
                         dest1 = Environment.CurrentDirectory + @"\Images\" + Path.GetFileName(source);
                        File.Copy(source, dest1);
                        txtshowImage1.Text = dest1;
                        pictureBox1.Image = new Bitmap(dest1); pictureBox1.Refresh();
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
                        dest2 = "";
                       dest2 = Environment.CurrentDirectory + @"\Images\" + Path.GetFileName(source);
                        File.Copy(source, dest2);
                        txtshowImage2.Text = dest2;
                        pictureBox2.Image = new Bitmap(dest2); pictureBox2.Refresh();
                    }

                }
                catch (IOException ioex)
                {
                    MessageBox.Show("Error " + ioex.Message);
                }
                // pictureBox1.ImageLocation = of.FileName;
            }

        }

        private void toggleSwitch1_Click(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn == true)
            {
               
                 panel7.Enabled = false;
            }
            else
            {
                 panel7.Enabled = true;
            }
        }

        private void frm_AddUpdateMoto_Load(object sender, EventArgs e)
        {

        }
    }
}