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
    public partial class frm_products : DevExpress.XtraEditors.XtraForm
    {
        private int PgSize = 31;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0;
        public frm_products()
        {
            InitializeComponent();
        showInTable(false,0, PgSize);
            CalculateTotalPages();
            
        }
        private void CalculateTotalPages()
        {
            tblItems.Clear();
               tblItems = db.readData("select id from  products ", "");
            int rowCount = tblItems.Rows.Count;
            lblTotalArticles.Text = tblItems.Rows.Count.ToString();
            TotalPage = rowCount / PgSize;
            // if any row left after calculated pages, add one more page 
            if (rowCount % PgSize > 0)
                TotalPage += 1;
        }
        /// ////////////////////////////////
        private void frm_products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'desertridersDataSet1.products_plus' table. You can move, or remove it, as needed.
          //  this.products_plusTableAdapter.Fill(this.desertridersDataSet1.products_plus);

        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();
 
DataTable tblItems = new DataTable();
 
        public void showInTable(Boolean search,int start, int end)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            tblItems.Clear();
 

            if (search)
            {
               
                tblItems = db.readData("select * from products left join barcode_product on products.id = barcode_product.id_product where products.name like '%" + txtLook.Text + "%' or products.barcode = '" + txtLook.Text + "' or barcode_product.barcode = '" + txtLook.Text + "'", "");
                
            }
            else
            {
                tblItems = db.readData("select * from products order by name LIMIT " + start + ", " + end, "");
                //tblItems = db.readData("SELECT * FROM `v_sales_no_clients` WHERE `v_sales_no_clients`.`date` between '2021-03-27' AND '2021-03-27'" + start +", "+ end, "");

                lblIndex.Text = start + "";
                lblSart.Text = CurrentPageIndex + "";
                lblEnd.Text = TotalPage + "";
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
                        dataGridView1.Rows[nc].Cells[0].Value = row["id"];
                        dataGridView1.Rows[nc].Cells[1].Value = row["name"].ToString();
                        dataGridView1.Rows[nc].Cells[2].Value = row["barcode"].ToString();
                        dataGridView1.Rows[nc].Cells[3].Value = row["reference1"].ToString();
                        dataGridView1.Rows[nc].Cells[4].Value = row["NumFacture"].ToString();
                        dataGridView1.Rows[nc].Cells[5].Value = row["quantity_actuel"].ToString();
                        dataGridView1.Rows[nc].Cells[6].Value = row["description"].ToString();
                        dataGridView1.Rows[nc].Cells[7].Value = row["mark"].ToString();
                        dataGridView1.Rows[nc].Cells[8].Value = row["model"].ToString();
                        dataGridView1.Rows[nc].Cells[9].Value = row["quality"].ToString();
                        dataGridView1.Rows[nc].Cells[10].Value = row["color"].ToString();
                        dataGridView1.Rows[nc].Cells[11].Value = row["pricesale"];
                        dataGridView1.Rows[nc].Cells[12].Value = row["prix_grox"].ToString();
                        dataGridView1.Rows[nc].Cells[13].Value = row["pricehelp"].ToString();
                        dataGridView1.Rows[nc].Cells[14].Value = row["remise"].ToString();
                        dataGridView1.Rows[nc].Cells[15].Value = row["min_demande"].ToString();
                        dataGridView1.Rows[nc].Cells[16].Value = row["max_demande"].ToString();
                        dataGridView1.Rows[nc].Cells[17].Value = row["id_supplier"].ToString();
                        dataGridView1.Rows[nc].Cells[18].Value = row["id_category"].ToString();
                        dataGridView1.Rows[nc].Cells[19].Value = row["id_magasin"].ToString();
                        dataGridView1.Rows[nc].Cells[20].Value = row["id_emplacement"].ToString();
                        dataGridView1.Rows[nc].Cells[21].Value = row["quantity_min"].ToString();
                        dataGridView1.Rows[nc].Cells[22].Value = row["quantity_max"].ToString();
                        dataGridView1.Rows[nc].Cells[23].Value = row["active"].ToString();
                        dataGridView1.Rows[nc].Cells[24].Value = row["enstock"].ToString();
                        dataGridView1.Rows[nc].Cells[25].Value = row["image1"].ToString();
                        dataGridView1.Rows[nc].Cells[26].Value = row["image2"].ToString(); 
                        dataGridView1.Rows[nc].Cells[27].Value =  Convert.ToDateTime(row["date"]).ToString("dd/MM/yyyy");
                        dataGridView1.Rows[nc].Cells[28].Value = row["timer"].ToString();
                        dataGridView1.Rows[nc].Cells[29].Value = null;
                        dataGridView1.Rows[nc].Cells[30].Value = null;
                        dataGridView1.Rows[nc].Cells[31].Value = null;  
                    }

                  
                }
                catch (Exception) { }
            }
            }
 
        private void btnAdd_Click(object sender, EventArgs e)
        {


         

        }

 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.SelectedRows[0];
            //tbl.Clear();
            //tbl = db.readData("SELECT id FROM  buy_details where pro_id=" + row.Cells[0].Value.ToString(), "");
            if (Convert.ToInt32(row.Cells[0].Value) == 1)
            {
                MessageBox.Show("لا يمكن حذف هاته السلعة لأنها مسجلة للبيع");
                
            }
            else
            {
                if (MessageBox.Show("حل حقا تريد حذف هاته السلعة", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from products where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", "");
               // AutoNumber();

                showInTable(false, Convert.ToInt32(lblIndex.Text), PgSize);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)////Save
        {
            frm_AddUpdateProduct addUpdateProdcts = new frm_AddUpdateProduct();
            addUpdateProdcts.TotalPage = this.TotalPage; 
            addUpdateProdcts.PgSize = this.PgSize;
            addUpdateProdcts.allProducts = this;
            addUpdateProdcts.btnSave.Visible = true;
            addUpdateProdcts.btnUpdate.Visible = false;
            addUpdateProdcts.SelectedID = 0;
            addUpdateProdcts.AutoNumber();
            addUpdateProdcts.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)////Update
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm_AddUpdateProduct addUpdateProdcts = new frm_AddUpdateProduct();
            addUpdateProdcts.TotalPage = Convert.ToInt32(lblIndex.Text); 
            addUpdateProdcts.PgSize = this.PgSize;
            addUpdateProdcts.allProducts = this;
            addUpdateProdcts.leBarcode=  dataGridView1.CurrentRow.Cells[2].Value.ToString();
            addUpdateProdcts.btnSave.Visible = false;
            addUpdateProdcts.btnUpdate.Visible = true;
            addUpdateProdcts.fillAlldata();
            addUpdateProdcts.SelectedID= Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString());
            addUpdateProdcts.ShowDialog();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bare Code " + dataGridView1.CurrentRow.Cells[2].Value.ToString());
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[25].Value.ToString() != "")
            {
                pictureBox1.Image = new Bitmap(dataGridView1.CurrentRow.Cells[25].Value.ToString()); pictureBox1.Refresh();
            }
            else
            {
                pictureBox1.Image = null; pictureBox1.Refresh();
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(" Nom  LIKE '%{0}%'  ", txtLook.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showInTable(true,0,0);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm_barcode_product  barFrm = new frm_barcode_product(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[12].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //MessageBox.Show(" Article : "+ dataGridView1.CurrentRow.Cells[1].Value.ToString()); 

                barFrm.TotalPage = Convert.ToInt32(lblIndex.Text);
                barFrm.PgSize = this.PgSize;
                barFrm.allProducts = this;
                barFrm.ShowDialog();
            }else
            {
                MessageBox.Show("Selectionner un Article" );
            }
             
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm_Barcode barFrm = new frm_Barcode(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[11].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //MessageBox.Show(" Article : "+ dataGridView1.CurrentRow.Cells[1].Value.ToString());
                barFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selectionner un Article");
            }
        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            tblItems.Clear();
           tblItems = db.readData("select * from products order by name ", ""); 
            var lines = new List<string>();

            string[] columnNames = tblItems.Columns
                .Cast<DataColumn>()
                .Select(column => column.ColumnName)
                .ToArray();

            var header = string.Join(";", columnNames.Select(name => $"\"{name}\""));
            lines.Add(header);

            var valueLines = tblItems.AsEnumerable()
                .Select(row => string.Join(";", row.ItemArray.Select(val => $"\"{val}\"")));

            lines.AddRange(valueLines);

            //File.WriteAllLines("excel.xls", lines);
            File.WriteAllLines(@"D:\Rapports\Tous Les Articles.xls", lines, Encoding.UTF8);
            //**************************************************************************************************************************//
            // // creating Excel Application  
            // Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // // creating new WorkBook within Excel application  
            // Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // // creating new Excelsheet in workbook  
            // Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // // see the excel sheet behind the program  
            // app.Visible = true;
            // // get the reference of first sheet. By default its name is Sheet1.  
            // // store its reference to worksheet  
            // worksheet = workbook.Sheets["Sheet1"];
            // worksheet = workbook.ActiveSheet;
            // // changing the name of active sheet  
            // worksheet.Name = "Exported from gridview";
            // tblItems.Clear();
            // tblItems = db.readData("select * from products order by name ", ""); 
            // // storing header part in Excel  
            // for (int j = 1; j < dataGridView1.Columns.Count + 1; j++)
            // {
            //     // if ( i != 28 && i != 29 && i != 30 && i != 31 && i != 32 && i != 33 && i != 34)
            //     if (j != 11 && j != 20 && j != 28 && j != 29 & j != 30 && j != 31 && j != 32 && j != 33 && j != 34)
            //     {
            //         worksheet.Cells[1, j] = dataGridView1.Columns[j - 1].HeaderText;
            //     }
            // }
            // // storing Each row and column value to excel sheet  
            // for (int i = 0; i < tblItems.Rows.Count ; i++)
            // {
            //     for (int j = 0; j < tblItems.Columns.Count-1; j++)
            //     {
            //         if (j != 11 && j != 20 && j != 28 && j != 29 & j != 30 && j != 31 && j != 32 && j != 33 && j != 34)
            //         {
            //             worksheet.Cells[i + 2, j + 1] = tblItems.Rows[i][j].ToString();
            //     }
            // }
            // }
            // // save the application  
            // workbook.SaveAs("D:\\DR Rapports\\Liste des articles  " + DateTime.Now.ToString("d_M_yyyy hh_mm_ss") + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // // Exit from the application  
            //// app.Quit();
            //*************************************************************
        }

        private void txtLook_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showInTable(true,0,0);
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = 1;
            //this.dataGridView1.DataSource = 
                GetCurrentRecords(this.CurrentPageIndex); 
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
               // this.dataGridView1.DataSource =
            GetCurrentRecords(this.CurrentPageIndex ); 
            }
        }

        private void btnNxtPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex < this.TotalPage)
            {
                this.CurrentPageIndex++;
              //  this.dataGridView1.DataSource =
            GetCurrentRecords(this.CurrentPageIndex ); 
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = TotalPage;
            // this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex );
            GetCurrentRecords(this.CurrentPageIndex); 
        }
        private void GetCurrentRecords(int page)
        {
            DataTable dt = new DataTable();

            if (page == 1)
            {

                //dt = db.readData("SELECT DISTINCT * FROM products ORDER BY id LIMIT  0," + PgSize , ""); // 0-3
                showInTable(false, 0, PgSize);
            }
            else
            {
                int PreviousPageOffSet = (page - 1) * PgSize;
                showInTable(false, PreviousPageOffSet, PgSize);
              //  dt = db.readData("SELECT DISTINCT * FROM products ORDER BY id LIMIT  "+ PreviousPageOffSet+", " + PgSize, "");
                //dt = db.readData("SELECT DISTINCT * FROM products "+
                //    "  WHERE id  NOT IN " +
                //    "(SELECT DISTINCT id FROM products ORDER BY id LIMIT " + PreviousPageOffSet + "   ) ORDER BY id LIMIT " + PgSize  , "");
            }
             
          //  return dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            frm_AddUpdateProduct addUpdateProdcts = new frm_AddUpdateProduct();
            addUpdateProdcts.TotalPage = Convert.ToInt32(lblIndex.Text);
            addUpdateProdcts.PgSize = this.PgSize;
            addUpdateProdcts.allProducts = this;
            addUpdateProdcts.leBarcode = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            addUpdateProdcts.btnSave.Visible = false;
            addUpdateProdcts.btnUpdate.Visible = true;
            addUpdateProdcts.fillAlldata();
            addUpdateProdcts.SelectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            addUpdateProdcts.ShowDialog();
        }
        //private void dgvDepon_MouseClick(object sender, MouseEventArgs e)
        //{
        //    fillAlldata();
        //    enableAllButtons();
        //    btnAdd.Enabled = false;
        //}


    }
}