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
    public partial class frm_deponc_Report : DevExpress.XtraEditors.XtraForm
    {
        public frm_deponc_Report()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void frm_deponc_Report_Load(object sender, EventArgs e)
        {
            dtpFrom.Text = DateTime.Now.ToShortDateString();
            dtpTo.Text = DateTime.Now.ToShortDateString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string dateFrom = dtpFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dtpTo.Value.ToString("yyyy-MM-dd");
            if (MessageBox.Show("Are you sure to delete this one!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from deponc_mang where  deserved.date BETWEEN '" + dateFrom + "'  and '" + dateTo + "' ;", "Data Deleted successfully");

                // showInTable();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string dateFrom = dtpFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dtpTo.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            //MessageBox.Show(dtpFrom.Value.ToString("yyyy-MM-dd"));

            tbl = db.readData("select deponc_mang.id as Num	,deponc_mang.price as Montant,	deponc_mang.date as Date,	deponc_mang.notes as Notes, deponce.nom as Type " +
               " from deponc_mang inner join deponce on deponc_mang.type_id = deponce.id and deponc_mang.date BETWEEN '" + dateFrom + "'  and '" + dateTo + "' ORDER BY `date` ASC ;", "");
            if (tbl.Rows.Count >= 1)
            {
                dgvSearch.DataSource = tbl;
                decimal Sum = 0;
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    Sum += Convert.ToDecimal(tbl.Rows[i][1]);
                }
                dgvSearch.DataSource = tbl;
                txtTotal.Text = Convert.ToString(Sum);
            }


        }

    }
}