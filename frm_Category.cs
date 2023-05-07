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
    public partial class frm_Category : DevExpress.XtraEditors.XtraForm
    {
        public frm_Category()
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
            tbl = db.readData("select max(id) from category ", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtNum.Text = "1";
            }
            else
            {
                txtNum.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            clearAllData();
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
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
            dtbl.Clear();

            dtbl = db.readData("select id,name from category  ORDER BY name ", "");
            dgvDeponce.DataSource = dtbl;

        }
        public void fillAlldata()
        {
            if (this.dgvDeponce.SelectedRows.Count > 0)
            {
                txtNum.Text = dgvDeponce.CurrentRow.Cells[0].Value.ToString();
                txtNomAr.Text = dgvDeponce.CurrentRow.Cells[1].Value.ToString();
            }
        }
        int row;
        private void show()
        {
            tbl.Clear();
            tbl = db.readData("select id,name from category  ORDER BY name", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                txtNum.Text = tbl.Rows[row][0].ToString();
                txtNomAr.Text = tbl.Rows[row][1].ToString();

                btnAdd.Enabled = true;
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        public void clearAllData()
        {
            txtNomAr.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNomAr.Text != "")
            {
                db.executeData("insert into category values (null,'" + txtNomAr.Text + "',"+ Properties.Settings.Default.userID + ",null)", "");
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
            db.readData("update category set name='" + txtNomAr.Text + "',user_id="+ Properties.Settings.Default.userID + " where id='" + txtNum.Text + "'", "");
            AutoNumber();
            showInTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this one!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from category where id='" + txtNum.Text + "'", "");
                AutoNumber();
                showInTable();
            }
        }


        private void dgvDesrves_MouseClick(object sender, MouseEventArgs e)
        {
            fillAlldata();
            enableAllButtons();
            btnAdd.Enabled = false;
        }





    }
}