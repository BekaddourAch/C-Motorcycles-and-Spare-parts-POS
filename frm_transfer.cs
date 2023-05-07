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
    public partial class frm_transfer : DevExpress.XtraEditors.XtraForm
    {
        public frm_transfer()
        {
            InitializeComponent();
            FillCaisse();
        }
        Double solde = 0.0;
        int num = 0;
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable dtbl = new DataTable();
        private void FillCaisse()
        {
            cbxCaise.DataSource = db.readData("SELECT * FROM caisse ", "");
            cbxCaise.DisplayMember = "nom";
            cbxCaise.ValueMember = "id";
        }
        private void FillCaisse2()
        {
            cbxCaise2.DataSource = db.readData("SELECT * FROM caisse where id != "+ cbxCaise.SelectedValue, "");
            cbxCaise2.DisplayMember = "nom";
            cbxCaise2.ValueMember = "id";
        }
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max(id) from transfert", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                num = 1;
            }
            else
            {
                num = Convert.ToInt32(tbl.Rows[0][0]) + 1;
            }
            clearAllData();
        }
        public void clearAllData()
        {
            lblMont.Text = ""; txtMont.Clear(); txtRemq.Clear(); txtNom.Clear(); cbxCaise.SelectedText = ""; cbxCaise2.SelectedText = ""; solde = 0.0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMont.Text != "" && txtNom.Text != "")
            {
                db.executeData("insert into transfert values (" + num + "," + txtMont.Text + ",'" + dtpDate.Value.ToString("yyyy-MM-dd") + "','" + txtNom.Text + "','" + txtRemq.Text + "','" + cbxCaise.SelectedValue + "','" + cbxCaise2.SelectedValue + "',,null,"+ Properties.Settings.Default.userID+")", "");
                db.executeData("update caisse set solde=" + (solde - Convert.ToDouble(txtMont.Text)) + "  where id='" + cbxCaise.SelectedValue + "'", "");
                AutoNumber();
            }
            else
            {
                MessageBox.Show("Please fill the Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbxCaise_DropDownClosed(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select solde from caisse where id=" + cbxCaise.SelectedValue + " ", "");
            solde = Convert.ToDouble(tbl.Rows[0][0]);

            lblMont.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}", solde);
            FillCaisse2();
        }
    }
}