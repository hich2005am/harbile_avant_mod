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
using DSM.Controle;
using DevExpress.XtraPrinting;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Customization;
using FlyoutDialogExample;

namespace DSM.View.Client
{
    public partial class Fournisseur_view : DevExpress.XtraEditors.XtraUserControl
    {
        FlyoutAction action = new FlyoutAction();
        Fournisseur_ctr cs = new Fournisseur_ctr();
        public   BindingSource bdi = new BindingSource();
        MDI f2 = (MDI)Application.OpenForms["MDI"];
        public Fournisseur_view()
        {
            InitializeComponent();
        }
        bool arret = false;
        public void Client_view_Load(object sender, EventArgs e)
        {
            bdi.DataSource = cs.Select();
            gdFournisseur.DataSource = bdi;
            arret = true;
        }
        public void refresh()
        {
            if (arret == true) { arret = false; return; }
            bdi.DataSource = cs.Select();
            gdFournisseur.DataSource = bdi;

        }


        private void gdFournisseur_Load(object sender, EventArgs e)
        {
            gvFournisseur.BestFitColumns();
        }

        private void gvFournisseur_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            PrintingSystemBase pb = e.PrintingSystem as PrintingSystemBase;
            pb.PageSettings.LeftMargin = 5; 
            pb.PageSettings.RightMargin = 5;
            pb.PageSettings.Landscape = true;

        }
              

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
          if(e.Button.Properties.Caption== "VUE")
            {
                if (gvFournisseur.DataRowCount == 0) return;
                CustomFlyoutDialog.ShowForm(f2, action, new View.Client.Fournisseur_update("V", int.Parse(gvFournisseur.GetFocusedRowCellDisplayText(ColID_FR))));
            }
            if (e.Button.Properties.Caption == "NOUVEAU")

            {
                DialogResult result = CustomFlyoutDialog.ShowForm(f2, action, new View.Client.Fournisseur_update("N", -1));
                if(result==DialogResult.OK) Client_view_Load(sender, e);
               
            }
            if (e.Button.Properties.Caption == "SUPRIMER")
            {
                if (gvFournisseur.DataRowCount == 0) return;
                cs.delete(int.Parse(gvFournisseur.GetFocusedRowCellDisplayText(ColID_FR)));
                Client_view_Load(sender, e);
            }
            if (e.Button.Properties.Caption == "MODIFIER")
            {
                if (gvFournisseur.DataRowCount == 0) return;
                DialogResult result = CustomFlyoutDialog.ShowForm(f2, action, new View.Client.Fournisseur_update("M", int.Parse(gvFournisseur.GetFocusedRowCellDisplayText(ColID_FR))));
                if (result == DialogResult.OK) Client_view_Load(sender, e);
            }
            if (e.Button.Properties.Caption == "EXPORTER")
            {
                if (gvFournisseur.DataRowCount == 0) return;
                gvFournisseur.ShowRibbonPrintPreview();
            }
            if (e.Button.Properties.Caption == "IMPRIMER")
            {
                if (gvFournisseur.DataRowCount == 0) return;
                gvFournisseur.ShowRibbonPrintPreview();
            }
            if (e.Button.Properties.Caption == "FILTRE")
            {
                if (gvFournisseur.DataRowCount == 0) return;
                gvFournisseur.ShowFilterPopup(colNom);
            }
        }

    
    }
}