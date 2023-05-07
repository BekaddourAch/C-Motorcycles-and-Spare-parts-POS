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
    public partial class Return_Qtty : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        DataTable tbl = new DataTable();
        String iddetail;
        String buy_id;
        Boolean sales_et_updated;
        String numArt;
        public Return_Qtty(String iddetail, String buy_id, String numFact, String name,  String numArt, String codbar, String qttSale)
        {
            InitializeComponent();
            this.iddetail = iddetail;
            this.buy_id = buy_id;
            txt1.Text = numFact;
            textBox1.Text = name;
            this.numArt = numArt;
            textBox2.Text = numArt;
            textBox5.Text = codbar;
            textBox3.Text = qttSale;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numericUpDown1.Value) == Convert.ToInt32(textBox3.Text))
            {
                if (MessageBox.Show("هل تريد إرجاع هاته السلعة إلى المخزون ؟", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.readData("delete from sales_details  where id='" + iddetail + "'", "");
                    //this.dgvReport.Rows.RemoveAt(this.dgvReport.SelectedRows[0].Index);
                }
            }
            else if (Convert.ToInt32(numericUpDown1.Value) < Convert.ToInt32(textBox3.Text))
            {
                if (MessageBox.Show("هل تريد إرجاع هاته السلعة إلى المخزون ؟", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    sales_et_updated = db.executeData("update sales_details set qty=" +textBox3.Text+"-"+ numericUpDown1.Value + " , total=(" + textBox3.Text + "-" + numericUpDown1.Value + ")*remise,benifice=(benifice /" + textBox3.Text + ")*(" + textBox3.Text + "-" + numericUpDown1.Value + ") where id=" + iddetail, "");
                    if (sales_et_updated)
                    {
                        db.executeData("UPDATE buy_details SET qtt_rest = qtt_rest + " + numericUpDown1.Value + "  WHERE buy_id = " + buy_id + " and  pro_id = " + numArt + ";", "");
                       // db.executeData("UPDATE sales SET totalsale = totalsale - " + salesPrice + ",apay =apay -"++"  WHERE buy_id = " + buy_id + " and  pro_id = " + numArt + ";", "");
                    }
                }
            }
            else if (Convert.ToInt32(numericUpDown1.Value) < Convert.ToInt32(textBox3.Text))
            {
                numericUpDown1.Value = Convert.ToInt32(textBox3.Text);
            }
                // AutoNumber();
                // this.dgvReport.Rows.RemoveAt(this.dgvReport.SelectedRows[0].Index);
            }
    }
}