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
    public partial class frm_motos : DevExpress.XtraEditors.XtraForm
    {
        public frm_motos()
        {
            InitializeComponent();
            showInTable(false);
            showSaledInTable(false);
            coloring();
            timer1.Start();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();
        DataTable tblItems = new DataTable();

        public void RowsColor()
        {
            for (int i = 0; i < dgvSaled.Rows.Count; i++)
            {
                int val = Int32.Parse(dgvSaled.Rows[i].Cells[15].Value.ToString());
                if (val ==0)
                {
                    dgvSaled.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                     
                }

                else if (val ==1)
                {
                    dgvSaled.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }
                else if (val ==2)
                {
                    dgvSaled.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (val == 3)
                {
                    dgvSaled.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }
        public void coloring()
        {
            foreach (DataGridViewRow row in dgvSaled.Rows) { 
                if (Convert.ToInt32(row.Cells[15].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (Convert.ToInt32(row.Cells[15].Value) == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }   
                if (Convert.ToInt32(row.Cells[15].Value) == 2)
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen;
                }
                if (Convert.ToInt32(row.Cells[15].Value) == 3)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
        }
        }

public void showSaledInTable(Boolean search)
        {
            this.dgvSaled.DataSource = null;
            this.dgvSaled.Rows.Clear();
            tblItems.Clear();
            //dtbl.Clear(); 
            //dtbl = db.readData("select * from products ", "");
            //dataGridView1.DataSource = dtbl;

            if (search)
            {

                tblItems = db.readData("select * from  v_saled_motos where nom like '%" + txtLook.Text + "%'", "");

            }
            else
            {

                tblItems = db.readData("select * from  v_saled_motos", "");
            }



            if (tblItems.Rows.Count >= 1)
            {
                try
                {

#pragma warning disable CS0219 // The variable 'j' is assigned but its value is never used
                    int j = 0;
#pragma warning restore CS0219 // The variable 'j' is assigned but its value is never used
                    foreach (DataRow row in tblItems.Rows)
                    {
                        int nc = dgvSaled.Rows.Add();
                        dgvSaled.Rows[nc].Cells[0].Value = row["id_moto"].ToString();
                        dgvSaled.Rows[nc].Cells[1].Value = row["reference"].ToString();
                        dgvSaled.Rows[nc].Cells[2].Value = row["nom"].ToString();
                        dgvSaled.Rows[nc].Cells[3].Value = row["NumFacture"].ToString();
                        dgvSaled.Rows[nc].Cells[4].Value = row["n_serie"].ToString();
                        dgvSaled.Rows[nc].Cells[5].Value = row["cylender"].ToString();
                        dgvSaled.Rows[nc].Cells[6].Value = row["color"].ToString();
                        dgvSaled.Rows[nc].Cells[7].Value = row["annee"].ToString();//////
                        dgvSaled.Rows[nc].Cells[8].Value = row["num_vente"].ToString();
                        dgvSaled.Rows[nc].Cells[9].Value = row["nom_ar"].ToString();
                        dgvSaled.Rows[nc].Cells[10].Value = row["nom_fr"].ToString();
                        dgvSaled.Rows[nc].Cells[11].Value = row["num_tel"].ToString();
                        dgvSaled.Rows[nc].Cells[12].Value = row["dnaiss"].ToString();
                        dgvSaled.Rows[nc].Cells[13].Value = row["adresse"].ToString();
                        dgvSaled.Rows[nc].Cells[14].Value = row["status"].ToString();
                        dgvSaled.Rows[nc].Cells[15].Value = row["status_val"].ToString();

                    }


                }
                catch (Exception) { }
            }
        }
        public void showInTable(Boolean search)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            tblItems.Clear();
            //dtbl.Clear(); 
            //dtbl = db.readData("select * from products ", "");
            //dataGridView1.DataSource = dtbl;

            if (search)
            {

                tblItems = db.readData("select * from motos_plus WHERE NOT EXISTS (SELECT sales_moto.id FROM sales_moto WHERE motos_plus.id = sales_moto.moto_id) AND nom like '%" + txtLook.Text + "%'", "");

            }
            else
            {

                tblItems = db.readData("select * from motos_plus WHERE NOT EXISTS (SELECT sales_moto.id FROM sales_moto WHERE motos_plus.id = sales_moto.moto_id); ", "");
            }



            if (tblItems.Rows.Count >= 1)
            {
                try
                {

#pragma warning disable CS0219 // The variable 'j' is assigned but its value is never used
                    int j = 0;
#pragma warning restore CS0219 // The variable 'j' is assigned but its value is never used
                    foreach (DataRow row in tblItems.Rows)
                    {
                        int nc = dataGridView1.Rows.Add();
                        dataGridView1.Rows[nc].Cells[0].Value = row["id"].ToString();
                        dataGridView1.Rows[nc].Cells[1].Value = row["reference"].ToString();
                        dataGridView1.Rows[nc].Cells[2].Value = row["nom"].ToString();
                        dataGridView1.Rows[nc].Cells[3].Value = row["NumFacture"].ToString();
                        dataGridView1.Rows[nc].Cells[4].Value = row["marque"].ToString();
                        dataGridView1.Rows[nc].Cells[5].Value = row["type"].ToString();
                        dataGridView1.Rows[nc].Cells[6].Value = row["quantity_actuel"].ToString();//////
                        dataGridView1.Rows[nc].Cells[7].Value = row["n_serie"].ToString();
                        dataGridView1.Rows[nc].Cells[8].Value = row["puissance_mtr"].ToString();
                        dataGridView1.Rows[nc].Cells[9].Value = row["matricule_p"].ToString();
                        dataGridView1.Rows[nc].Cells[10].Value = row["type_mtr"].ToString();
                        dataGridView1.Rows[nc].Cells[11].Value = row["poid"].ToString();
                        dataGridView1.Rows[nc].Cells[12].Value = row["cylender"].ToString();
                        dataGridView1.Rows[nc].Cells[13].Value = row["color"].ToString();
                        dataGridView1.Rows[nc].Cells[14].Value = row["cmd"].ToString();
                        dataGridView1.Rows[nc].Cells[15].Value = row["annee"].ToString();
                        dataGridView1.Rows[nc].Cells[16].Value = row["pricebuy"].ToString();
                        dataGridView1.Rows[nc].Cells[17].Value = row["pricesale"].ToString();
                        dataGridView1.Rows[nc].Cells[18].Value = row["prix_grox"].ToString();
                        dataGridView1.Rows[nc].Cells[19].Value = row["pricehelp"].ToString();
                        dataGridView1.Rows[nc].Cells[20].Value = row["remise"].ToString();
                        dataGridView1.Rows[nc].Cells[21].Value = row["min_demande"].ToString();
                        dataGridView1.Rows[nc].Cells[22].Value = row["max_demande"].ToString();
                        dataGridView1.Rows[nc].Cells[23].Value = row["id_supplier"].ToString();
                        dataGridView1.Rows[nc].Cells[24].Value = row["id_category"].ToString();
                        dataGridView1.Rows[nc].Cells[25].Value = row["id_magasin"].ToString();
                        dataGridView1.Rows[nc].Cells[26].Value = row["id_emplacement"].ToString();
                        dataGridView1.Rows[nc].Cells[27].Value = row["quantity_min"].ToString();
                        dataGridView1.Rows[nc].Cells[28].Value = row["quantity_max"].ToString();
                        dataGridView1.Rows[nc].Cells[29].Value = row["active"].ToString();
                        dataGridView1.Rows[nc].Cells[30].Value = row["enstock"].ToString();
                        dataGridView1.Rows[nc].Cells[31].Value = row["image1"].ToString();
                        dataGridView1.Rows[nc].Cells[32].Value = row["image2"].ToString();
                        dataGridView1.Rows[nc].Cells[33].Value = row["date"].ToString();
                        dataGridView1.Rows[nc].Cells[34].Value = row["timer"].ToString(); 
                        dataGridView1.Rows[nc].Cells[35].Value = row["fornisseur"].ToString();
                        dataGridView1.Rows[nc].Cells[36].Value = row["catigorie"].ToString();
                        dataGridView1.Rows[nc].Cells[37].Value = row["magasin"].ToString();
                        dataGridView1.Rows[nc].Cells[38].Value = row["emplacements"].ToString();

                    }


                }
                catch (Exception) { }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من عملية الحذف", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from motos_plus where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", "تم الحذف بنجاح");
                // AutoNumber();

                showInTable(false);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            showInTable(true);
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(dataGridView1.CurrentRow.Cells[25].Value.ToString()); pictureBox1.Refresh();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_AddUpdateMoto addUpdateMoto = new frm_AddUpdateMoto();
            addUpdateMoto.allMotos = this;
            addUpdateMoto.btnSave.Visible = true;
            addUpdateMoto.btnUpdate.Visible = false;
            addUpdateMoto.SelectedID = 0;
            addUpdateMoto.AutoNumber();
            addUpdateMoto.ShowDialog();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frm_AddUpdateMoto addUpdateMoto = new frm_AddUpdateMoto();
            addUpdateMoto.allMotos = this;
            addUpdateMoto.btnSave.Visible = false;
            addUpdateMoto.btnUpdate.Visible = true;
            addUpdateMoto.fillAlldata();
            addUpdateMoto.SelectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            addUpdateMoto.ShowDialog();

        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[31].Value.ToString()!="")
            {
                pictureBox1.Image = new Bitmap(dataGridView1.CurrentRow.Cells[31].Value.ToString()); pictureBox1.Refresh();
            }
            else
            {
                pictureBox1.Image = null; pictureBox1.Refresh();
            }
            

            lblMatr.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            lblTypeMtr.Text= dataGridView1.CurrentRow.Cells[10].Value.ToString();
            lblCMD.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            //lblPrxiAch.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble( dataGridView1.CurrentRow.Cells[16].Value ));
            lblPrixVent.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(dataGridView1.CurrentRow.Cells[17].Value));  
            lblPrixGros.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(dataGridView1.CurrentRow.Cells[18].Value)); 

            lblSpecial.Text = String.Format("{0:#,##0.00 DA;(#,##0.00 DA);Zero}", Convert.ToDouble(dataGridView1.CurrentRow.Cells[19].Value));  
            lblCategorie.Text = dataGridView1.CurrentRow.Cells[36].Value.ToString();
            lblMagasin.Text = dataGridView1.CurrentRow.Cells[37].Value.ToString();
             if (dataGridView1.CurrentRow.Cells[29].Value.ToString()=="True") { lblActiv.Text = "Oui"; } else { lblActiv.Text = "Non"; }
            //if (dataGridView1.CurrentRow.Cells[30].Value.ToString() == "True") { lblStock.Text = "Oui"; } else { lblStock.Text = "Non"; }
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs(@"D:\\Rapports\Motos.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void frm_motos_Load(object sender, EventArgs e)
        {
           // dataGridView1.FirstDisplayedScrollingRowIndex = 0;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm_sales_motos sales_motos = new frm_sales_motos();
            sales_motos.allMotos = this;
                sales_motos.lblMoto_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); 
                sales_motos.prixachat = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            sales_motos.prixNormal = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            sales_motos.prixVGros = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            sales_motos.prixhelp = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            sales_motos.laRemise = dataGridView1.CurrentRow.Cells[20].Value.ToString();
                sales_motos.lblMotoNom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                sales_motos.lblPiston.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                sales_motos.lblNbrPlaces.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                sales_motos.lblAnne.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                sales_motos.lblType.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                sales_motos.lblEnregie.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                sales_motos.txtNSerie.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString(); 


                sales_motos.SelectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            sales_motos.ShowDialog();
             }
}

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد إلغاء عملية البيع", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from  sales_moto where id='" + dgvSaled.CurrentRow.Cells[8].Value.ToString() + "'", "تم إلغاء عملية البيع");
                // AutoNumber();
                showInTable(false);
                showSaledInTable(false);
            }
        }

         

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            {
                if (tabControl1.SelectedTab.Name == "tabPage1")
                {
                    showInTable(false);
                }
                if (tabControl1.SelectedTab.Name == "tabPage2")
                {
                    showSaledInTable(false);
                }

            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (dgvSaled.SelectedRows.Count > 0)
            { 
                tblItems.Clear();
                tblItems = db.readData("select * from motos inner join sales_moto on motos.id = sales_moto.moto_id  where motos.id=" + dgvSaled.CurrentRow.Cells[0].Value.ToString(), "");
                
                if (tblItems.Rows.Count >=0)
                {
                    frm_sales_motos sales_motos = new frm_sales_motos();
                sales_motos.allMotos = this;
                sales_motos.lblMoto_id.Text = tblItems.Rows[0][0].ToString();
                sales_motos.prixachat = tblItems.Rows[0][16].ToString();
                sales_motos.prixNormal = tblItems.Rows[0][17].ToString();
                sales_motos.prixVGros = tblItems.Rows[0][18].ToString();
                sales_motos.prixhelp =  tblItems.Rows[0][19].ToString();
                sales_motos.laRemise =  tblItems.Rows[0][20].ToString();
                sales_motos.lblMotoNom.Text =  tblItems.Rows[0][2].ToString();
                sales_motos.lblPiston.Text =  tblItems.Rows[0][12].ToString();
                sales_motos.lblNbrPlaces.Text =tblItems.Rows[0][4].ToString();
                    sales_motos.lblAnne.Text = tblItems.Rows[0][15].ToString();
                    sales_motos.txtNSerie.Text = tblItems.Rows[0][7].ToString();
                    
                    sales_motos.txtNomAr.Text = tblItems.Rows[0][37].ToString();
                    sales_motos.txtNomFr.Text = tblItems.Rows[0][38].ToString();
                    sales_motos.txtPhone1.Text = tblItems.Rows[0][39].ToString();
                    sales_motos.txtPhone2.Text = tblItems.Rows[0][40].ToString();
                    sales_motos.dateTimePicker1.Text = tblItems.Rows[0][41].ToString();
                    sales_motos.txtlieu.Text = tblItems.Rows[0][42].ToString();
                    sales_motos.txtAdresse.Text = tblItems.Rows[0][43].ToString();
                    sales_motos.txtNumCart.Text = tblItems.Rows[0][44].ToString();
                    sales_motos.dpDateCartN.Text = tblItems.Rows[0][45].ToString();
                    sales_motos.txtLieuCart.Text = tblItems.Rows[0][46].ToString();
                    sales_motos.dpFactDate.Text = tblItems.Rows[0][53].ToString();
                    sales_motos.panel6.Visible = false;
                    sales_motos.panel8.Visible = false;
                    sales_motos.panel11.Visible = false;
                    sales_motos.btnSaveFact.Visible = false;
                    sales_motos.simpleButton2.Visible = false;
                    sales_motos.Height= 605;
                    sales_motos.ShowDialog();
                }
               


               
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (dgvSaled.SelectedRows.Count > 0)
            {
                tblItems.Clear();
                tblItems = db.readData("select * from motos inner join sales_moto on motos.id = sales_moto.moto_id  where motos.id=" + dgvSaled.CurrentRow.Cells[0].Value.ToString(), "");

                if (tblItems.Rows.Count >= 0)
                {
                    frm_edit_status frm_edit = new frm_edit_status();
                    frm_edit.allMotos = this;
                    frm_edit.lblMoto_id.Text = tblItems.Rows[0][0].ToString();
                    frm_edit.txtNSerie.Text = tblItems.Rows[0][7].ToString();
                    frm_edit.txtNomAr.Text = tblItems.Rows[0][37].ToString();

                    frm_edit.cbx_file_state.Text = tblItems.Rows[0][51].ToString();
                    frm_edit.txt_infos.Text = tblItems.Rows[0][53].ToString();

                    frm_edit.ShowDialog();
                }




            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSaled.Rows)
            {
                if (Convert.ToInt32(row.Cells[15].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (Convert.ToInt32(row.Cells[15].Value) == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                if (Convert.ToInt32(row.Cells[15].Value) == 2)
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen;
                }
                if (Convert.ToInt32(row.Cells[15].Value) == 3)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }
    }
}