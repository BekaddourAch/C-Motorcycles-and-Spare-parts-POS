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
    public partial class frm_total_Report : DevExpress.XtraEditors.XtraForm
    {
        public frm_total_Report()
        {
            InitializeComponent(); getStatistics();
        }
        DataTable tbl = new DataTable();
        DataTable tbl1 = new DataTable();
        Database db = new Database();
        private void frm_total_Report_Load(object sender, EventArgs e)
        {
           
        }
        public void getStatistics()
        {// String.Format("{0: #,##0.00 DA;(#,##0.00 DA);Zero}"
            tbl.Clear();
            tbl = db.readData("select SUM(benifice) from sales_details where timmer like'" + DateTime.Now.ToString("yyyy-MM-dd") + "%' ", "");
            if (tbl.Rows.Count > 0 &&  tbl.Rows[0][0] != DBNull.Value)
            { lblTotalSale.Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString(); }
            else { lblTotalSale.Text = 0 + ""; }

            tbl.Clear();
            tbl = db.readData("SELECT COUNT(*) FROM `sales_details` where timmer like '"+DateTime.Now.ToString("yyyy-MM-dd") + "%' ", "");
            if (tbl.Rows.Count > 0 && tbl.Rows[0][0] != DBNull.Value)
            {  lblNbrSales.Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString(); }
            else {  lblNbrSales.Text = 0 + "";}

            tbl.Clear();
            tbl = db.readData("SELECT COUNT(*) FROM `returns_details` where timmer like '" + DateTime.Now.ToString("yyyy-MM-dd") + "%' ", "");
            if (tbl.Rows.Count > 0 && tbl.Rows[0][0] != DBNull.Value)
            {   lblTotalRet.Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString(); }
            else {lblTotalRet.Text = 0 + "";}
            //tileVentes
            tbl.Clear();
            tbl = db.readData("select COUNT(id) from returns_details", "");
            if (tbl.Rows.Count > 0 && tbl.Rows[0][0] != DBNull.Value)
            { lblNbrRet.Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString(); }
            else {  lblNbrRet.Text = 0 + ""; }

            tbl.Clear();
            tbl = db.readData("SELECT COUNT(id) FROM `v_etat_rup_stock` ", "");
            if (tbl.Rows.Count > 0 && tbl.Rows[0][0] != DBNull.Value)
            {   lblNbrArtfin.Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString();}
            else { lblNbrArtfin.Text = 0 + "";}

            tbl.Clear();
            tbl = db.readData("select count(DISTINCT pro_id) FROM `buy_details`", "");
            if (tbl.Rows.Count > 0 && tbl.Rows[0][0] != DBNull.Value)
            {  lblNbrTot.Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString(); }
            else {lblNbrTot.Text = 0 + ""; }
            //tileVentes
            tbl.Clear();
            tbl = db.readData("SELECT SUM(Dette) FROM `fournisseur`", "");
            if (tbl.Rows.Count > 0 && tbl.Rows[0][0] != DBNull.Value)
            { lblTotaldetF.Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString(); }
            else { lblTotaldetF.Text = 0 + ""; }

            tbl.Clear();
            tbl = db.readData("SELECT SUM(Dette) FROM `clients` ", "");
            if (tbl.Rows.Count > 0 && tbl.Rows[0][0] != DBNull.Value)
            {   lblTotDetC.Text = (Convert.ToInt32(tbl.Rows[0][0])).ToString(); }
            else {lblTotDetC.Text = 0 + "";}
        }
    }
}