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
    public partial class frm_cloture : DevExpress.XtraEditors.XtraForm
    {
        public frm_cloture()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        DateTime now = DateTime.Now;
        public frm_home homy = new frm_home();
        String idRec = "";  Double total_day = 0;


        private void frm_cloture_Load(object sender, EventArgs e)
        { 
            lblDateTime.Text = now.ToString();
            //panel6.Enabled = false;
            //panel7.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //  if (Convert.ToBoolean(isZero)) { payedAll = 1; } else { payedAll = 0; }
            //if (Convert.ToBoolean(chxDette.Checked)) { j = 1; };
            
            db.executeData("insert into cloture values (null,'" +  false +
                            "'," +  0 +
                            ",'" + txtMontStrt.Text +
                            "','" + 0 +//clot
                            "','" + 0 +//diff
                            "','" + 0 +//ret
                            "','" + "" +//rais
                            "','" + "" +//remq
                            "','" + 0 +//retour
                            "','" + DateTime.Now.ToString("yyyy-MM-dd") +
                            "'," + DateTime.Now.ToString("yyyy-MM-dd")+
                            "," + Properties.Settings.Default.userID +
                            ",null )", "");

            homy.getStatus(Properties.Settings.Default.userID);
            homy.btnOpenCloture.Enabled = false;
            homy.btnCloseCloture.Enabled = true;
            homy.tileItem4.Enabled = true; homy.tileItem5.Enabled = true; homy.tileItem7.Enabled = true;
            this.Hide();
        }
        public void open_Close_Caisse(Boolean order)
        {
            lblT1.Visible = order;
            lblT2.Visible = order;
            panel6.Visible = order;
            panel7.Visible = order;
            btn_open.Visible = !order;
            btn_close.Visible = order;
            if (order)
            {
                label17.Text = "ادخال رصيد الصندوق عند نهاية المبيعات";
                tbl.Clear();
                tbl = db.readData("SELECT * FROM cloture ORDER BY id DESC LIMIT 1", "");
                if (tbl.Rows.Count > 0)
                {
                    txtMontStrt.Text = tbl.Rows[0][3].ToString();
                    txtMontEnd.Text = tbl.Rows[0][4].ToString();
                    txtRetrait.Text = tbl.Rows[0][6].ToString();
                    txtRaison.Text = tbl.Rows[0][7].ToString();
                    txtRemq.Text = tbl.Rows[0][8].ToString();
                }
            }
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            tbl.Clear(); 
            tbl = db.readData("SELECT id FROM cloture ORDER BY id DESC LIMIT 1", "");
            if (tbl.Rows.Count > 0)
            {
                idRec = tbl.Rows[0][0].ToString();
            }

            tbl.Clear();
            tbl = db.readData("SELECT SUM(apay) FROM `sales` WHERE date ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString()) 
            {
                total_day = 0;
            }
            else
            {
                total_day = Convert.ToDouble(tbl.Rows[0][0].ToString());
            }
            tbl.Clear();Double valueRetour;
            tbl = db.readData("SELECT sum(payed) FROM returns where date='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", "");
            if (tbl.Rows.Count > 0)
            {
                if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
                {
                    valueRetour = 0;
                }else
                {
                    valueRetour = Convert.ToDouble(tbl.Rows[0][0].ToString());
                }
                
            }
            else { valueRetour = 0; }
            if (MessageBox.Show("Voulez-vous confirmer l'opération ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("update cloture set clotured =" + true +
                     ", total_day =" + total_day +
                     ", sold_ouvert =" + txtMontStrt.Text +
                     ", sold_cloture =" + txtMontEnd.Text +
                     ", differnce =" + (Convert.ToDouble(txtMontEnd.Text) - Convert.ToDouble(txtMontStrt.Text)) +
                     ", retrait =" +   txtRetrait.Text +
                     ", raison ='" +   txtRaison.Text +
                    "', remarque ='" + txtRemq.Text +
                    "', retour ='" + valueRetour +
                    "', date_fin ='" + DateTime.Now.ToString("yyyy-MM-dd") +
                    "', user_id =" + Properties.Settings.Default.userID +
                     ", timer = null   where id='" + idRec + "'", "");
                homy.getStatus(Properties.Settings.Default.userID);
                homy.btnOpenCloture.Enabled = true;
                homy.btnCloseCloture.Enabled = false;
                homy.tileItem4.Enabled = false; homy.tileItem5.Enabled = false; homy.tileItem7.Enabled = false;
            }
        }
         

    }
}