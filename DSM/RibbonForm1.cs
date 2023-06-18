using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using FlyoutDialogExample;

namespace DSM
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (DevExpress.XtraEditors.ColorWheel.ColorWheelForm f = new DevExpress.XtraEditors.ColorWheel.ColorWheelForm())
            {
                f.ShowDialog(this);
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomFlyoutDialog.ShowForm(this, null, new View.Client.Client_update("N", -1));
        }
    }
}