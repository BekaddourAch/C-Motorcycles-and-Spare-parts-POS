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
    public partial class frmAddEmlace : DevExpress.XtraEditors.XtraForm
    {
        public frmAddEmlace()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();
        private void frmAddEmlace_Load(object sender, EventArgs e)
        {
            showInTable();
            FillMagas();
        }

        private void FillMagas()
        {
            cbxMags.DataSource = db.readData("SELECT * FROM magasins ", "");
            cbxMags.DisplayMember = "name";
            cbxMags.ValueMember = "id";
        }

        public void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from products", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtNum.Text = "1";
            }
            else
            {
                txtNum.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
             

             btnAdd.Enabled = true;
             btnSave.Enabled = false;
        }
        public void clearAllData()
        {
            txtNum.Clear(); txtCodeEmp.Clear(); txtNomEmp.Clear(); 
        }
        public void fillAlldata()
        {
            txtNum.Text = dgvEmpl.CurrentRow.Cells[0].Value.ToString();
            txtNomEmp.Text = dgvEmpl.CurrentRow.Cells[1].Value.ToString();
            txtCodeEmp.Text = dgvEmpl.CurrentRow.Cells[2].Value.ToString();
            cbxMags.Text = dgvEmpl.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
            txtNomEmp.Text = "";
            txtCodeEmp.Text = "";
        }
        public void showInTable()
        {
            dtbl.Clear();

            dtbl = db.readData("select emplacements.id as num, emplacements.name as Nom, emplacements.arrangement as Code ,magasins.name as Magasain from emplacements inner join magasins where emplacements.id_magasin= magasins.id ", "");
            dgvEmpl.DataSource = dtbl;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNomEmp.Text != "")
            {
                db.executeData("insert into emplacements values (null,'" + txtNomEmp.Text + "','" + txtCodeEmp.Text + "','" + cbxMags.SelectedValue + "',null,"+ Properties.Settings.Default.userID+")", "");
                showInTable();
                //showInGroupsTable(dgvData.CurrentRow.Cells[0].Value.ToString());
                // AutoNumber();
            }
            else
            {
                MessageBox.Show("Please fill the Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNomEmp.Text != "")
            {
                db.readData("update emplacements set  name='" + txtNomEmp.Text + "' , arrangement='" + txtCodeEmp.Text + "' ,id_magasin='" + cbxMags.SelectedValue + "'  " +
              ", timer=null,agent="+ Properties.Settings.Default.userID+ " where id=" + txtNum.Text+"", "");
                //AutoNumber();
                showInTable();
            }
            else
            {
                MessageBox.Show("Please fill the Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment le supprimer !", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from emplacements where  id='" + txtNum.Text + "'", "il a été supprimé avec succès");
                // AutoNumber();
                clearAllData();
                showInTable();
            }
        }

        private void dgvEmpl_MouseClick(object sender, MouseEventArgs e)
        {
            fillAlldata();
        }
    }
}