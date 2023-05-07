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
// Use EasyTabs
using EasyTabs;
namespace Disdriver
{
    public partial class frm_Cashier : TitleBarTabs
    {
        public frm_Cashier()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

       // int tabs = 0;
        // Handle the method CreateTab that allows the user to create a new Tab
        // on your app when clicking
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                // The content will be an instance of another Form
                // In our example, we will create a new instance of the Form1
                Content = new frm_sales_cash
                {
                    Text = "عملية بيع جديدة" 
                }
             
        };

        }

        
    }
}