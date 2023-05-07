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
    public partial class frm_Depnc_Mang : DevExpress.XtraEditors.XtraForm
    {
        public frm_Depnc_Mang()
        {
            InitializeComponent();
            showInTable(false);
        }


        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();

        DataTable tblItems = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from deponc_mang", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            //clearAllData();
            dtpDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            nudPrice.Text = "1";
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;

        } 

#pragma warning disable CS0649 // Field 'frm_Depnc_Mang.row' is never assigned to, and will always have its default value 0
        int row;
#pragma warning restore CS0649 // Field 'frm_Depnc_Mang.row' is never assigned to, and will always have its default value 0
        private void show()
        {
            tbl.Clear();
            tbl = db.readData("select * from deponc_mang", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                try
                {
                    txtID.Text = tbl.Rows[row][0].ToString();
                    nudPrice.Text =  tbl.Rows[row][1].ToString() ;

                    // this.Text = tbl.Rows[row][2].ToString();
                    // DateTime dt = DateTime.ParseExact(tbl.Rows[row][2].ToString(), "dd/MM/yyyy", null);
                    // dtpDate.Value = dt;
                    dtpDate.Text = tbl.Rows[row][2].ToString();


                    txtNote.Text = tbl.Rows[row][3].ToString();
                    cbxType.SelectedValue = Convert.ToDecimal(tbl.Rows[row][4]);
                }
                catch (Exception)
                {

                    throw;
                } 
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }


        public void showInTable(Boolean search)
        {
            this.dgvDeponce.DataSource = null;
            this.dgvDeponce.Rows.Clear();
            tblItems.Clear();


            if (search)
            {

              //  tblItems = db.readData("select * from deponc_mang where name like '%" + txtLook.Text + "%'", "");

            }
            else
            {

                tblItems = db.readData("select deponc_mang.id,deponc_mang.type_id,deponce.nom,deponc_mang.notes  ,deponc_mang.price ,deponc_mang.date ,deponc_mang.user_id  " +
                   " from deponc_mang inner join deponce on deponce.id=deponc_mang.type_id ", "");
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
                        int nc = dgvDeponce.Rows.Add();
                        dgvDeponce.Rows[nc].Cells[0].Value = row["id"].ToString();
                        dgvDeponce.Rows[nc].Cells[1].Value = row["type_id"].ToString();
                        dgvDeponce.Rows[nc].Cells[2].Value = row["nom"].ToString();
                        dgvDeponce.Rows[nc].Cells[3].Value = row["notes"].ToString();
                        dgvDeponce.Rows[nc].Cells[4].Value = row["price"].ToString();
                        dgvDeponce.Rows[nc].Cells[5].Value = Convert.ToDateTime( row["date"]).ToString("dd/MM/yyyy");
                        dgvDeponce.Rows[nc].Cells[6].Value = row["user_id"].ToString();
                        //dgvDeponce.Rows[nc].Cells[7].Value = row["timer"].ToString(); 
              
                    }


                }
                catch (Exception) { }
            }
        }
 

        private void FillType()
        {
            cbxType.DataSource = db.readData("SELECT * FROM deponce ", "");
            cbxType.DisplayMember = "nom";
            cbxType.ValueMember = "id";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxType.Items.Count <= 0)
            {
                MessageBox.Show("Please fill the Dereved Types befor", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                String d = dtpDate.Value.ToString("yyyy-MM-dd");
                db.executeData("insert into deponc_mang values (null," + cbxType.SelectedValue + ",'" + txtNote.Text + "','" + nudPrice.Text + "','" + d + "',"+ Properties.Settings.Default.userID+", null)", "Row Inserted Succesfuly");
                AutoNumber();
                showInTable(false);
            }
        }

        
        private void showInTable()
        {
            dtbl.Clear();

            dtbl = db.readData("select * from deponc_mang inner join deponce  on deponc_mang.type_id =  deponce.id ", "");
            dgvDeponce.DataSource = dtbl;

        }
        public void clearAllData()
        {
            txtID.Clear();
            cbxType.Text = "";
            nudPrice.Text = "";
            txtNote.Clear();
            dtpDate.Value = DateTime.Now;


        }




        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAllData();
            AutoNumber();
            // FillType();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32( nudPrice.Text) <= 0)
            {
                MessageBox.Show("Please insert a value bigger than 1");
                return;
            }
            else
            {
                String d = dtpDate.Value.ToString("yyyy-MM-dd");
                db.readData("update deponc_mang set price='" + nudPrice.Text + "' , date='" + d + "' ,notes='" + txtNote.Text + "' , type_id='" + cbxType.SelectedValue + "', user_id=" + Properties.Settings.Default.userID + "  where id='" + txtID.Text + "'", "Data Updated successfully");
                AutoNumber();
                showInTable(false);
            }
            ;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this one!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from deponc_mang where id='" + txtID.Text + "'", "Data Deleted successfully");
                AutoNumber();

                showInTable(false);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete All Data !", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("TRUNCATE TABLE deponc_mang  ", "Data Deleted successfully");
                AutoNumber();

                showInTable();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Are you sure to delete All Data ! num : " + dataGridView1.CurrentRow.Cells[0].Value.ToString(), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //  MessageBox.Show("Are you sure to delete All Data ! num : " + comboBox1.SelectedValue  , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
         //   (dgvDeponce.DataSource as DataTable).DefaultView.RowFilter = string.Format(" 	notes   LIKE '%{0}%' or 	name  LIKE '%{0}%'", txtSearch.Text);
        }

        private void dgvDepon_MouseClick(object sender, MouseEventArgs e)
        {
            fillAlldata();
            enableAllButtons();
            btnAdd.Enabled = false;
        }
        public void fillAlldata()
        {
            if (this.dgvDeponce.SelectedRows.Count > 0)
            {
                txtID.Text = dgvDeponce.CurrentRow.Cells[0].Value.ToString();
            cbxType.Text = dgvDeponce.CurrentRow.Cells[2].Value.ToString();
            txtNote.Text = dgvDeponce.CurrentRow.Cells[3].Value.ToString();
            nudPrice.Text = dgvDeponce.CurrentRow.Cells[4].Value.ToString();
            dtpDate.Text = dgvDeponce.CurrentRow.Cells[5].Value.ToString();

                //dtpDate.Text = Convert.ToDateTime( dgvDeponce.CurrentRow.Cells[4].Value.ToString()).ToString();


            }

        }
        public void enableAllButtons()
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_Depnc_Mang_Load(object sender, EventArgs e)
        { 
            AutoNumber();
        }

        private void cbxType_Click(object sender, EventArgs e)
        {
            FillType();
        }
    }
}
 