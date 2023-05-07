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
    public partial class frm_caisses : DevExpress.XtraEditors.XtraForm
    {
        public frm_caisses()
        {
            InitializeComponent();
            showInTable();
        }

        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();

        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from deponce", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtNom.Text = "1";
            }
            else
            {
                txtNom.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            clearAllData();
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;


        }
        public void clearAllData()
        {
            txtNom.Clear(); txtType.Clear();
        }
        public void enableAllButtons()
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
        }

        public void showInTable()
        {
            this.dgvCaisse.DataSource = null;
            this.dgvCaisse.Rows.Clear();
            dtbl.Clear();

            dtbl = db.readData("select * from caisse  ", ""); 
            try
            {
                
                foreach (DataRow row in dtbl.Rows)
                {
                    int nc = dgvCaisse.Rows.Add(); 
                    dgvCaisse.Rows[nc].Cells[0].Value = row["id"].ToString();
                    dgvCaisse.Rows[nc].Cells[1].Value = row["nom"].ToString();
                    dgvCaisse.Rows[nc].Cells[2].Value = row["type"].ToString();
                    dgvCaisse.Rows[nc].Cells[3].Value = row["solde"].ToString();
                    dgvCaisse.Rows[nc].Cells[4].Value = row["time"].ToString();
                    dgvCaisse.Rows[nc].Cells[5].Value = row["id_user"].ToString();
                }

            }
            catch (Exception) { }
        }

        public void fillAlldata()
        {
            if (this.dgvCaisse.SelectedRows.Count > 0)
            {
                txtNom.Text = dgvCaisse.CurrentRow.Cells[1].Value.ToString();
                txtType.Text = dgvCaisse.CurrentRow.Cells[2].Value.ToString();
            }
        }
        int row;
        private void show()
        {
            tbl.Clear();
            tbl = db.readData("select nom from caisse", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                txtNom.Text = tbl.Rows[row][1].ToString();
                txtType.Text = tbl.Rows[row][2].ToString();

                btnAdd.Enabled = true;
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void frm_caisses_Load(object sender, EventArgs e)
        {
            AutoNumber();
            showInTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "")
            {
                db.executeData("insert into caisse values (null,'" + txtNom.Text + "','" + txtType.Text + "','" + 0.0 + "',null,"+ Properties.Settings.Default.userID+")", "");
                AutoNumber();
                showInTable();
            }
            else
            {
                MessageBox.Show("Please fill the Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAllData();
            AutoNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvCaisse.SelectedRows[0];
            db.readData("update caisse set nom='" + txtNom.Text + "',type='" + txtType.Text + "' ,time=null,id_user= "+ Properties.Settings.Default.userID + " where id='" + row.Cells[0].Value.ToString() + "'", "");
            AutoNumber();
            showInTable();
         
    }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            DataGridViewRow row = this.dgvCaisse.SelectedRows[0]; 
            if (MessageBox.Show("Are you sure to delete this one!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Convert.ToDouble(row.Cells[3].Value) > 0)
                {

                }else
                {
                    db.readData("delete from caisse where id='" + row.Cells[0].Value.ToString() + "'", "");
                    AutoNumber();
                    showInTable();
                }
                
            }
        }

        private void dgvCaisse_MouseClick(object sender, MouseEventArgs e)
        {
            fillAlldata();
            enableAllButtons();
            btnAdd.Enabled = false;
        }
    }
}