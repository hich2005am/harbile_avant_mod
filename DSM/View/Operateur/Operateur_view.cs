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
    public partial class Operateur_view : DevExpress.XtraEditors.XtraUserControl
    {
        Operateur_ctr    cs = new Operateur_ctr();
        public   BindingSource bdi = new BindingSource();
        MDI f = (MDI)Application.OpenForms["MDI"];
        public Operateur_view()
        {
            InitializeComponent();
        }
        int Type_Op;
        int ID_Op;
        public void Client_view_Load(object sender, EventArgs e)
        {
             Type_Op=f.operateur.Type_Op;
             ID_Op = f.operateur.ID_Op;
            bdi.DataSource = cs.Aff( Type_Op,  ID_Op);
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

        FlyoutAction action = new FlyoutAction();
        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
          if(e.Button.Properties.Caption== "VUE")
            {
               
                CustomFlyoutDialog.ShowForm(f, action, new View.Client.Operateur_update("V", int.Parse(gvFournisseur.GetFocusedRowCellDisplayText(ColID_FR))));
            }
            if (e.Button.Properties.Caption == "NOUVEAU")
            {
                if (Type_Op == 2) { XtraMessageBox.Show("l'option était désactivée"); return; }
                DialogResult result = CustomFlyoutDialog.ShowForm(f, action, new View.Client.Operateur_update("N", -1));
                if(result==DialogResult.OK) Client_view_Load(sender, e);
               
            }
            if (e.Button.Properties.Caption == "SUPRIMER")
            {
                if(Type_Op==2 || Type_Op == 1) { XtraMessageBox.Show("l'option était désactivée"); return; }
                cs.delete(int.Parse(gvFournisseur.GetFocusedRowCellDisplayText(ColID_FR)));
                Client_view_Load(sender, e);
            }
            if (e.Button.Properties.Caption == "MODIFIER")
            {
                DialogResult result = CustomFlyoutDialog.ShowForm(f, action, new View.Client.Operateur_update("M", int.Parse(gvFournisseur.GetFocusedRowCellDisplayText(ColID_FR))));
                if (result == DialogResult.OK) Client_view_Load(sender, e);
            }
            if (e.Button.Properties.Caption == "EXPORTER")
            {
                    gvFournisseur.ShowRibbonPrintPreview();
            }
            if (e.Button.Properties.Caption == "IMPRIMER")
            {
                gvFournisseur.ShowRibbonPrintPreview();
            }
            if (e.Button.Properties.Caption == "FILTRE")
            {
                gvFournisseur.ShowFilterPopup(colNom);
            }
        }

    
    }
}