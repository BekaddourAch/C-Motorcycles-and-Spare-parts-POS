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
    public partial class frm_Users : DevExpress.XtraEditors.XtraForm
    {
        public frm_Users()
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
            tbl = db.readData("select max(id) from users", "");
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
            dpDateN.Text =  Convert.ToDateTime(dgvCustomer.CurrentRow.Cells[3].Value.ToString()).ToString("dd/MM/yyyy");
            txtFonction.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            txtRemq.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            txtPhone1.Text = dgvCustomer.CurrentRow.Cells[6].Value.ToString();
            txtPhone2.Text = dgvCustomer.CurrentRow.Cells[7].Value.ToString();
            txtPhone3.Text = dgvCustomer.CurrentRow.Cells[8].Value.ToString();
            txtEmail.Text = dgvCustomer.CurrentRow.Cells[9].Value.ToString();
            txtAdress.Text = dgvCustomer.CurrentRow.Cells[10].Value.ToString();

            txtUserN.Text = dgvCustomer.CurrentRow.Cells[11].Value.ToString();
           // txtPwd.Text = dgvCustomer.CurrentRow.Cells[12].Value.ToString();
            cbxType.Text = dgvCustomer.CurrentRow.Cells[13].Value.ToString();
            ckekActive.Checked = getBoolFromSTR(dgvCustomer.CurrentRow.Cells[14].Value.ToString());

            cbxAchat.Checked = getBoolFromSTR(dgvCustomer.CurrentRow.Cells[15].Value.ToString());
            cbxArticl.Checked = getBoolFromSTR(dgvCustomer.CurrentRow.Cells[16].Value.ToString());
            cbxVent.Checked = getBoolFromSTR(dgvCustomer.CurrentRow.Cells[17].Value.ToString());
            cbxFourn.Checked = getBoolFromSTR(dgvCustomer.CurrentRow.Cells[18].Value.ToString());
            cbxClient.Checked = getBoolFromSTR(dgvCustomer.CurrentRow.Cells[19].Value.ToString());
            cbxCaiss.Checked = getBoolFromSTR(dgvCustomer.CurrentRow.Cells[20].Value.ToString());
            cbxSauv.Checked = getBoolFromSTR(dgvCustomer.CurrentRow.Cells[21].Value.ToString());
            cbxReglg.Checked = getBoolFromSTR(dgvCustomer.CurrentRow.Cells[22].Value.ToString());
            cbxReports.Checked = getBoolFromSTR(dgvCustomer.CurrentRow.Cells[23].Value.ToString()); 

        }
        private Boolean passTest()
        { Boolean testo = false;
            if (txtPwd.Text==txtpwd2.Text) {
                testo = true;

            } else
            {
                testo = false;
                MessageBox.Show("Le mot de passe est incorrect");
                txtPwd.Text = ""; txtpwd2.Text = "";
            }

            return testo;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(passTest()) { 
            if (txtNomFr.Text != "")
            {
                db.executeData("insert into users values (null,'" +
                    txtNomAr.Text + "','" +
                    txtNomFr.Text + "','" +
                    dpDateN.Value.ToString("yyyy-MM-dd") + "','" +
                    txtFonction.Text + "','" +
                    txtRemq.Text + "','" +
                    txtPhone1.Text + "','" +
                    txtPhone2.Text + "','" +
                    txtPhone3.Text + "','" +
                    txtEmail.Text + "','" +
                    txtAdress.Text + "','" +
                    txtUserN.Text + "','" +
                   CreateMD5(txtPwd.Text)  + "','" +
                    cbxType.Text + "'," +
                    ckekActive.Checked + "," +
                    cbxAchat.Checked + "," +
                     cbxArticl.Checked + "," +
                     cbxVent.Checked + "," +
                     cbxFourn.Checked + "," +
                     cbxClient.Checked + "," +
                     cbxCaiss.Checked + "," +
                     cbxSauv.Checked + "," +
                     cbxReglg.Checked + "," +
                     cbxReports.Checked + ","  
                       + "null,"+ Properties.Settings.Default.userID + ")", "");
                AutoNumber();
                showInTable(false);
            }
            else
            {
                MessageBox.Show("Veuillez remplir le nom", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            }
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

        int row;
        private void show()
        {
            tbl.Clear();
            tbl = db.readData("select * from users", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("Aucune donnée disponible");
            }
            else
            {
                txtNum.Text = tbl.Rows[row][0].ToString();
                txtNomAr.Text = tbl.Rows[row][1].ToString();
                txtNomFr.Text = tbl.Rows[row][2].ToString();
                dpDateN.Text =   Convert.ToDateTime(tbl.Rows[row][3].ToString()).ToString("dd/MM/yyyy");
                txtFonction.Text = tbl.Rows[row][4].ToString();
                txtRemq.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
                txtPhone1.Text = dgvCustomer.CurrentRow.Cells[6].Value.ToString();
                txtPhone2.Text = dgvCustomer.CurrentRow.Cells[7].Value.ToString();
                txtPhone3.Text = dgvCustomer.CurrentRow.Cells[8].Value.ToString();
                txtEmail.Text = dgvCustomer.CurrentRow.Cells[9].Value.ToString();
                txtAdress.Text = dgvCustomer.CurrentRow.Cells[10].Value.ToString();

                txtUserN.Text = dgvCustomer.CurrentRow.Cells[11].Value.ToString();
                txtPwd.Text = dgvCustomer.CurrentRow.Cells[12].Value.ToString();
                cbxType.Text = dgvCustomer.CurrentRow.Cells[13].Value.ToString();
                ckekActive.Checked = getBoolFromSTR(tbl.Rows[row][14].ToString());
                
                cbxAchat.Checked = getBoolFromSTR(tbl.Rows[row][15].ToString());
                cbxArticl.Checked = getBoolFromSTR(tbl.Rows[row][16].ToString());
                cbxVent.Checked = getBoolFromSTR(tbl.Rows[row][17].ToString());
                cbxFourn.Checked = getBoolFromSTR(tbl.Rows[row][18].ToString());
                cbxClient.Checked = getBoolFromSTR(tbl.Rows[row][19].ToString());
                cbxCaiss.Checked = getBoolFromSTR(tbl.Rows[row][20].ToString());
                cbxSauv.Checked = getBoolFromSTR(tbl.Rows[row][21].ToString());
                cbxReglg.Checked = getBoolFromSTR(tbl.Rows[row][22].ToString());

                cbxReports.Checked = getBoolFromSTR(tbl.Rows[row][23].ToString());
                
                btnAdd.Enabled = false;
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = true;
            }
        }
        public void showInTable()
        {
            dtbl.Clear();

            dtbl = db.readData("select * from users  ", "");
            dgvCustomer.DataSource = dtbl;

        }

        public void showInTable(Boolean search)
        {
            this.dgvCustomer.DataSource = null;
            this.dgvCustomer.Rows.Clear();
            tbl.Clear();


            if (search)
            {

                tbl = db.readData("select * from users where nomFr like '%" + txtSearch.Text + "%'", "");

            }
            else
            {

                tbl = db.readData("SELECT * FROM users ", "");
            }
            // MessageBox.Show(" tblItems.Rows.Count " + tblItems.Rows.Count);


            if (tbl.Rows.Count > 0)
            {
                try
                {

#pragma warning disable CS0219 // The variable 'j' is assigned but its value is never used
                    int j = 0;
#pragma warning restore CS0219 // The variable 'j' is assigned but its value is never used
                    foreach (DataRow row in tbl.Rows)
                    {
                        int nc = dgvCustomer.Rows.Add();

                        dgvCustomer.Rows[nc].Cells[0].Value = row["id"].ToString();
                        dgvCustomer.Rows[nc].Cells[1].Value = row["Name"].ToString();
                        dgvCustomer.Rows[nc].Cells[2].Value = row["LastName"].ToString();
                        dgvCustomer.Rows[nc].Cells[3].Value = row["Naiss"].ToString();
                        dgvCustomer.Rows[nc].Cells[4].Value = row["Role"].ToString();
                        dgvCustomer.Rows[nc].Cells[5].Value = row["Description"].ToString();
                        dgvCustomer.Rows[nc].Cells[6].Value = row["Phone1"].ToString();
                        dgvCustomer.Rows[nc].Cells[7].Value = row["Phone2"].ToString();
                        dgvCustomer.Rows[nc].Cells[8].Value = row["Phone3"].ToString();
                        dgvCustomer.Rows[nc].Cells[9].Value = row["EmailAddress"].ToString();
                        dgvCustomer.Rows[nc].Cells[10].Value = row["Address"].ToString();
                        dgvCustomer.Rows[nc].Cells[11].Value = row["UsrName"].ToString();
                        dgvCustomer.Rows[nc].Cells[12].Value = row["Password"].ToString();
                        dgvCustomer.Rows[nc].Cells[13].Value = row["Type"].ToString();
                        dgvCustomer.Rows[nc].Cells[14].Value = row["Status"].ToString();
                        dgvCustomer.Rows[nc].Cells[15].Value = row["alow_achat"].ToString();
                        dgvCustomer.Rows[nc].Cells[16].Value = row["alow_article"].ToString();
                        dgvCustomer.Rows[nc].Cells[17].Value = row["alow_vente"].ToString();
                        dgvCustomer.Rows[nc].Cells[18].Value = row["alow_fournisseur"].ToString();
                        dgvCustomer.Rows[nc].Cells[19].Value = row["alow_client"].ToString();
                        dgvCustomer.Rows[nc].Cells[20].Value = row["alow_caisse"].ToString();
                        dgvCustomer.Rows[nc].Cells[21].Value = row["alow_sauvgard"].ToString();
                        dgvCustomer.Rows[nc].Cells[22].Value = row["alow_reglage"].ToString();
                        dgvCustomer.Rows[nc].Cells[23].Value = row["alow_reports"].ToString();
                        dgvCustomer.Rows[nc].Cells[24].Value = row["Date"].ToString();
                        dgvCustomer.Rows[nc].Cells[25].Value = row["CreatorId"].ToString();

                    }


                }
                catch (Exception) { }
            }
        }

        public void clearAllData()
        {
            //txtNum.Clear();
            txtNomAr.Clear();
            txtNomFr.Clear();
           // dpDateN.Clear(); 
            txtFonction.Clear();
            txtRemq.Clear();
            txtPhone1.Clear();
            txtPhone2.Clear();
            txtPhone3.Clear();
            txtEmail.Clear();
            txtAdress.Clear();

            txtUserN.Clear();
            txtPwd.Clear();
            //cbxType.Clear();
            ckekActive.Checked = false;

            cbxAchat.Checked = false;
            cbxArticl.Checked = false;
            cbxVent.Checked = false;
            cbxFourn.Checked = false;
            cbxClient.Checked = false;
            cbxCaiss.Checked = false;
            cbxSauv.Checked = false;
            cbxReglg.Checked = false;

            cbxReports.Checked = false;

            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn==true) {
                if (passTest())
                {
                    int i = 0;
                    if (Convert.ToBoolean(ckekActive.Checked)) { i = 1; };
                    db.readData("update users set " +
                       "   Name='" + txtNomAr.Text +
                       "', LastName='" + txtNomFr.Text +
                       "', Naiss='" + dpDateN.Value.ToString("yyyy-MM-dd") +
                       "', Role='" + txtFonction.Text +
                       "', Description='" + txtRemq.Text +
                       "', Phone1='" + txtPhone1.Text +
                       "', Phone2='" + txtPhone2.Text +
                       "', Phone3='" + txtPhone3.Text +
                       "', EmailAddress='" + txtEmail.Text +
                       "', Address='" + txtAdress.Text +
                       "', UsrName='" + txtUserN.Text +
                       "', Password='" + CreateMD5(txtPwd.Text) +
                       "', Type='" + cbxType.Text +
                       "', Status=" + ckekActive.Checked +
                       ", alow_achat=" + cbxAchat.Checked +
                       ", alow_article=" + cbxArticl.Checked +
                       ", alow_vente=" + cbxVent.Checked +
                       ", alow_fournisseur=" + cbxFourn.Checked +
                       ", alow_client=" + cbxClient.Checked +
                       ", alow_caisse=" + cbxCaiss.Checked +
                       ", alow_sauvgard=" + cbxSauv.Checked +
                       ", alow_reglage=" + cbxReglg.Checked +
                       ", alow_reports=" + cbxReports.Checked +
                       ", Date=null, CreatorId=" + Properties.Settings.Default.userID +
                       " where id='" + txtNum.Text + "'", "");
                    AutoNumber();
                    showInTable(false);
                }
            }
            else
            {
                int i = 0;
                if (Convert.ToBoolean(ckekActive.Checked)) { i = 1; };
                db.readData("update users set " +
                   "   Name='" + txtNomAr.Text +
                   "', LastName='" + txtNomFr.Text +
                   "', Naiss='" + dpDateN.Value.ToString("yyyy-MM-dd") +
                   "', Role='" + txtFonction.Text +
                   "', Description='" + txtRemq.Text +
                   "', Phone1='" + txtPhone1.Text +
                   "', Phone2='" + txtPhone2.Text +
                   "', Phone3='" + txtPhone3.Text +
                   "', EmailAddress='" + txtEmail.Text +
                   "', Address='" + txtAdress.Text + 
                   "', Status=" + ckekActive.Checked +
                   ", alow_achat=" + cbxAchat.Checked +
                   ", alow_article=" + cbxArticl.Checked +
                   ", alow_vente=" + cbxVent.Checked +
                   ", alow_fournisseur=" + cbxFourn.Checked +
                   ", alow_client=" + cbxClient.Checked +
                   ", alow_caisse=" + cbxCaiss.Checked +
                   ", alow_sauvgard=" + cbxSauv.Checked +
                   ", alow_reglage=" + cbxReglg.Checked +
                   ", alow_reports=" + cbxReports.Checked +
                   ", Date=null, CreatorId=" + Properties.Settings.Default.userID +
                   " where id='" + txtNum.Text + "'", "");
                AutoNumber();
                showInTable(false);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this one!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from users where id='" + txtNum.Text + "'", "");
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
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                showInTable(true);

            }
        }
        private void frm_Users_Load(object sender, EventArgs e)
        {
            AutoNumber();

        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            fillAlldata();
            enableAllButtons();
            btnAdd.Enabled = false;
        }


        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void toggleSwitch1_Click(object sender, EventArgs e)
        {
            if (this.dgvCustomer.SelectedRows.Count > 0)
            {
                if (toggleSwitch1.IsOn == false)
                {
                    txtUserN.Enabled = true;
                        txtPwd.Enabled = true;
                    txtpwd2.Enabled = true;


                }
                else
                {
                    txtUserN.Enabled = false;
                    txtPwd.Enabled = false;
                    txtpwd2.Enabled = false;
                }
            }
        }
    }
}