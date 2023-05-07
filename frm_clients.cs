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
    public partial class frm_clients : DevExpress.XtraEditors.XtraForm
    {
        public frm_clients()
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
            tbl = db.readData("select max(id) from clients", "");
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
            btnDelete.Enabled = false;
            btnSave.Enabled = false; 
        }
        private Boolean getBoolFromSTR(string word)
        {
            if (word == "True") { return true; } else { return false; }

        }
        public void fillAlldata()
        {
            txtNum.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtNomAr.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtNomFr.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtPhone1.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            txtPhone2.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            txtAdress.Text = dgvCustomer.CurrentRow.Cells[6].Value.ToString();
            txtCCP.Text = dgvCustomer.CurrentRow.Cells[7].Value.ToString();
            txtCpmtBank.Text = dgvCustomer.CurrentRow.Cells[8].Value.ToString();
            txtBankAgnc.Text = dgvCustomer.CurrentRow.Cells[6].Value.ToString();
            cbxTypePay.Text = dgvCustomer.CurrentRow.Cells[10].Value.ToString(); 
            ckekPersone.Checked = getBoolFromSTR(dgvCustomer.CurrentRow.Cells[11].Value.ToString());
            txtRc.Text = dgvCustomer.CurrentRow.Cells[12].Value.ToString();
            txtMatFisc.Text = dgvCustomer.CurrentRow.Cells[13].Value.ToString();
            txtArt.Text = dgvCustomer.CurrentRow.Cells[14].Value.ToString();
            txtAi.Text = dgvCustomer.CurrentRow.Cells[15].Value.ToString();
            txtDette.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);0}", Convert.ToDouble(dgvCustomer.CurrentRow.Cells[16].Value));  
        }
        public void enableAllButtons()
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAllData();
            AutoNumber();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (Convert.ToBoolean(ckekPersone.Checked)) { i = 1; };
            if (txtNomFr.Text != "")
            {
                db.executeData("insert into clients values (null,'" +
                    txtNomAr.Text + "','" +
                    txtNomFr.Text + "','" +
                    txtPhone1.Text + "','" +
                    txtPhone2.Text + "','" +
                    txtEmail.Text + "','" +
                    txtAdress.Text + "','" +
                    txtCCP.Text + "','" +
                    txtCpmtBank.Text + "','" +
                    txtBankAgnc.Text + "','" +
                    cbxTypePay.Text + "','" +
                    i + "','" +
                    txtRc.Text + "','" +
                    txtMatFisc.Text + "','" +
                    txtArt.Text + "','" +
                    txtAi.Text + "','" +
                    txtDette.Text + "'," +
                    Properties.Settings.Default.userID + ",null)", "");
                AutoNumber();
                showInTable(false);
            }
            else
            {
                MessageBox.Show("Please fill the Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        int row; 
        private void show()
        {
            tbl.Clear();
            tbl = db.readData("select * from clients", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                txtNum.Text = tbl.Rows[row][0].ToString();
                txtNomAr.Text = tbl.Rows[row][1].ToString();
                txtNomFr.Text = tbl.Rows[row][2].ToString();
                txtPhone1.Text = tbl.Rows[row][3].ToString();
                txtPhone2.Text = tbl.Rows[row][4].ToString();
                txtEmail.Text = tbl.Rows[row][5].ToString();
                txtAdress.Text = tbl.Rows[row][6].ToString();
                txtCCP.Text = tbl.Rows[row][7].ToString();
                txtCpmtBank.Text = tbl.Rows[row][8].ToString();
                txtBankAgnc.Text = tbl.Rows[row][9].ToString();
                cbxTypePay.Text = tbl.Rows[row][10].ToString();
                ckekPersone.Checked = getBoolFromSTR(tbl.Rows[row][11].ToString());
                txtRc.Text = tbl.Rows[row][12].ToString();
                txtMatFisc.Text = tbl.Rows[row][13].ToString();
                txtArt.Text = tbl.Rows[row][14].ToString();
                txtAi.Text = tbl.Rows[row][15].ToString();
                txtDette.Text = String.Format("{0: #,##0.00 DA;(#,##0.00 DA);0}", Convert.ToDouble(tbl.Rows[row][16].ToString()));  





                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }
        public void showInTable()
        {
            dtbl.Clear();

            dtbl = db.readData("select * from clients  ", "");
            dgvCustomer.DataSource = dtbl;

        }


        public void showInTable(Boolean search)
        {
            this.dgvCustomer.DataSource = null;
            this.dgvCustomer.Rows.Clear();
            tblItems.Clear();
            

            if (search)
            {

                tblItems = db.readData("select * from clients where nomFr like '%" + txtSearch.Text + "%'", "");

            }
            else
            {

                tblItems = db.readData("SELECT * FROM `clients` ", "");
            }
           // MessageBox.Show(" tblItems.Rows.Count " + tblItems.Rows.Count);


            if (tblItems.Rows.Count > 0)
            {
                try
                {

#pragma warning disable CS0219 // The variable 'j' is assigned but its value is never used
                    int j = 0;
#pragma warning restore CS0219 // The variable 'j' is assigned but its value is never used
                    foreach (DataRow row in tblItems.Rows)
                    {
                        int nc = dgvCustomer.Rows.Add();
                        //MessageBox.Show(" dgvCustomer.Rows.Add " + nc);

                        dgvCustomer.Rows[nc].Cells[0].Value = row["id"].ToString();
                        dgvCustomer.Rows[nc].Cells[1].Value = row["nomAr"].ToString();
                        dgvCustomer.Rows[nc].Cells[2].Value = row["nomFr"].ToString();
                        dgvCustomer.Rows[nc].Cells[3].Value = row["phone1"].ToString();
                        dgvCustomer.Rows[nc].Cells[4].Value = row["phone2"].ToString();
                        dgvCustomer.Rows[nc].Cells[5].Value = row["email"].ToString();
                        dgvCustomer.Rows[nc].Cells[6].Value = row["adress"].ToString();
                        dgvCustomer.Rows[nc].Cells[7].Value = row["ccp"].ToString();
                        dgvCustomer.Rows[nc].Cells[8].Value = row["cmptBank"].ToString();
                        dgvCustomer.Rows[nc].Cells[9].Value = row["agence"].ToString();
                        dgvCustomer.Rows[nc].Cells[10].Value = row["typePaymnt"].ToString();
                        dgvCustomer.Rows[nc].Cells[11].Value = row["isPersone"].ToString();
                        dgvCustomer.Rows[nc].Cells[12].Value = row["numRC"].ToString();
                        dgvCustomer.Rows[nc].Cells[13].Value = row["matFisc"].ToString();
                        dgvCustomer.Rows[nc].Cells[14].Value = row["numArt"].ToString();
                        dgvCustomer.Rows[nc].Cells[15].Value = row["numAi"].ToString();
                        dgvCustomer.Rows[nc].Cells[16].Value = row["Dette"].ToString();
                        dgvCustomer.Rows[nc].Cells[17].Value = row["userID"].ToString();
                        //dgvCustomer.Rows[nc].Cells[18].Value = row["timer"].ToString();

                    }


                }
                catch (Exception) { }
            }
        }

        public void clearAllData()
        {
             
            txtNomAr.Clear();
            txtNomFr.Clear();
            txtPhone1.Clear();
            txtPhone2.Clear();
            txtEmail.Clear();
            txtAdress.Clear();
            txtCCP.Clear();
            txtCpmtBank.Clear();
            txtBankAgnc.Clear();
            //cbxTypePay.Clear();
            ckekPersone.Checked=true;
            txtRc.Clear();
            txtMatFisc.Clear();
            txtArt.Clear();
            txtAi.Clear();
            txtDette.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (Convert.ToBoolean(ckekPersone.Checked)) { i = 1; };
            db.readData("update clients set " +
               "   nomAr='" + txtNomAr.Text +
               "', nomFr='" + txtNomFr.Text +
               "', phone1='" + txtPhone1.Text +
               "', phone2='" + txtPhone2.Text +
               "', email='" + txtEmail.Text +
               "', adress='" + txtAdress.Text +
               "', ccp='" + txtCCP.Text +
               "', cmptBank='" + txtCpmtBank.Text +
               "', agence='" + txtBankAgnc.Text +
               "', typePaymnt='" + cbxTypePay.Text +
               "', isPersone='" + i +
               "', numRC='" + txtRc.Text +
               "', matFisc='" + txtMatFisc.Text +
               "', numArt='" + txtArt.Text +
               "', numAi='" + txtAi.Text +
               //"', Dette='" + txtDette.Text +
               "',  userID="+ Properties.Settings.Default.userID + ",timer=null where id='" + txtNum.Text + "'", "");
            AutoNumber();
            showInTable(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this one!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from clients where id='" + txtNum.Text + "'", "");
                AutoNumber();
                showInTable(false);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showInTable(true);
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
 

        }

        private void frm_clients_Load(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            fillAlldata();
            enableAllButtons();
            btnAdd.Enabled = false;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                showInTable(true);
        
            }
        }

        private void ckekPersone_Click(object sender, EventArgs e)
        {
            if (ckekPersone.Checked) { panel6.Enabled = true; }else { panel6.Enabled = false; }
        }


    }
}