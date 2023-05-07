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
    public partial class frm_agenda : DevExpress.XtraEditors.XtraForm
    {
        public frm_agenda()
        {
            InitializeComponent();
        }
        public frm_home the_home_object;
        Database db = new Database();
        DataTable tbl = new DataTable();
        public void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from agenda ", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtNum.Text = "1";
            }
            else
            {
                txtNum.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }


             
            btnSave.Enabled = false;
        }
        public void clearAllData()
        {
            txtActivit.Clear(); 
        }
        private void btnSaveFact_Click(object sender, EventArgs e)
        {
            if (txtActivit.Text != "")
            {
                db.executeData("insert into agenda values (null,'" + dpDate.Value.ToString("yyyy-MM-dd") + "','" + timeEdit1.Time.ToString("HH:mm") + "','" + txtActivit.Text + "',"+ Properties.Settings.Default.userID+")", "");
                AutoNumber();
                the_home_object.showInTable();
                //showInGroupsTable(dgvData.CurrentRow.Cells[0].Value.ToString());

            }
            else
            {
                MessageBox.Show("Please fill the Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNum_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timeEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtActivit_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}