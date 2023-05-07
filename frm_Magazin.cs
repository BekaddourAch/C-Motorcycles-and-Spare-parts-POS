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
    public partial class frm_Magazin : DevExpress.XtraEditors.XtraForm
    {
        public frm_Magazin()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();
        DataTable dtblr = new DataTable();
        private void frm_Magazin_Load(object sender, EventArgs e)
        {
            showInTable();
        }

        public void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from magasins", "");
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
            txtNum.Clear(); txtNomMag.Clear(); textMagDesc.Clear();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
            txtNomMag.Text = "";
            textMagDesc.Text = "";
        }
        public void fillAlldata()
        {
            txtNum.Text = dgvMag.CurrentRow.Cells[0].Value.ToString();
            txtNomMag.Text = dgvMag.CurrentRow.Cells[1].Value.ToString();
            textMagDesc.Text = dgvMag.CurrentRow.Cells[2].Value.ToString(); 
        }
        public void showInTable()
        {
            dtblr.Clear();

            dtblr = db.readData("select id as Num, name as Nom,description as Description from magasins  ORDER BY name", "");
            dgvMag.DataSource = dtblr;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNomMag.Text != "")
            {
                db.executeData("insert into magasins values (null,'" + txtNomMag.Text + "','" + textMagDesc.Text + "',null,"+ Properties.Settings.Default.userID+")", "");
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
            if (txtNomMag.Text != "")
            {
                db.readData("update magasins set  name='" + txtNomMag.Text + "' , arrangement='" + textMagDesc.Text + "'  " +
              ", timer=null,agent="+ Properties.Settings.Default.userID+"", "");
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
                db.readData("delete from magasins where  id='" + txtNum.Text + "'", "il a été supprimé avec succès");
                // AutoNumber();
                clearAllData();
                showInTable();
            }
        }

        private void dgvMag_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvMag.Rows.Count>0)
            {
                fillAlldata();
                showInEmplacelntsTable(dgvMag.CurrentRow.Cells[0].Value.ToString());
            }
            
        }
        private void showInEmplacelntsTable(string var)
        {
            tbl.Clear();
            dtbl = db.readData("select * FROM emplacements WHERE emplacements.id_magasin = " + var, "");
            if (dtbl.Rows.Count>0) {
                
                tbl = db.readData("SELECT emplacements.name  Nom,emplacements.arrangement Arrangement  FROM emplacements INNER JOIN magasins ON" +
                             " emplacements.id_magasin = magasins.id  WHERE magasins.id = " + var, "");
               dgvEmpl.DataSource = tbl;
            } else
            {
                //MessageBox.Show("Voulez-vous vraiment le supprimer !", "Warning");
                tbl.Clear(); dgvEmpl.DataSource = null;
            }
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmAddEmlace frmEmpl = new frmAddEmlace();
            frmEmpl.ShowDialog();
        }
    }
}