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
    public partial class frm_edit_status : DevExpress.XtraEditors.XtraForm
    {

        Database db = new Database();
        public frm_motos allMotos = new frm_motos();
        public frm_edit_status()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.executeData("update sales_moto set status='" + cbx_file_state.SelectedItem + "',status_val='" + cbx_file_state.SelectedIndex + "',infos='" + txt_infos.Text+ "'  where moto_id=" + lblMoto_id.Text, "");
            allMotos.showSaledInTable(false); 
        }
    }
}