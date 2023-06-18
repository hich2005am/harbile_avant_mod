﻿using System;
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
    public partial class Transporteur_view : DevExpress.XtraEditors.XtraUserControl
    {
      Transporteur_ctr    cs = new Transporteur_ctr();
       public   BindingSource bdi = new BindingSource();
        MDI f = (MDI)Application.OpenForms["MDI"];
        public Transporteur_view()
        {
            InitializeComponent();
            bdi.DataSource = cs.Select();
            gdClient.DataSource = bdi;
        }

        public void Client_view_Load(object sender, EventArgs e)
        {
            bdi.DataSource = cs.Select();
            gdClient.DataSource = bdi;
        }
     
      

        private void gdClient_Load(object sender, EventArgs e)
        {
            gvClient.BestFitColumns();
        }

        private void gvClient_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
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
                if (gvClient.DataRowCount == 0) return;
                CustomFlyoutDialog.ShowForm(f, action, new View.Client.Transporteur_update("V", int.Parse(gvClient.GetFocusedRowCellDisplayText(ColID_CL))));
            }
            if (e.Button.Properties.Caption == "NOUVEAU")
            {
                DialogResult result = CustomFlyoutDialog.ShowForm(f, action, new View.Client.Transporteur_update("N", -1));
                if(result==DialogResult.OK) Client_view_Load(sender, e);
               
            }
            if (e.Button.Properties.Caption == "SUPRIMER")
            {
                if (gvClient.DataRowCount == 0) return;
                cs.delete(int.Parse(gvClient.GetFocusedRowCellDisplayText(ColID_CL)));
                Client_view_Load(sender, e);
            }
            if (e.Button.Properties.Caption == "MODIFIER")
            {
                if (gvClient.DataRowCount == 0) return;
                DialogResult result = CustomFlyoutDialog.ShowForm(f, action, new View.Client.Transporteur_update("M", int.Parse(gvClient.GetFocusedRowCellDisplayText(ColID_CL))));
                if (result == DialogResult.OK) Client_view_Load(sender, e);
            }
            if (e.Button.Properties.Caption == "EXPORTER")
            {
                if (gvClient.DataRowCount == 0) return;
                gvClient.ShowRibbonPrintPreview();
            }
            if (e.Button.Properties.Caption == "IMPRIMER")
            {
                if (gvClient.DataRowCount == 0) return;
                gvClient.ShowRibbonPrintPreview();
            }
            if (e.Button.Properties.Caption == "FILTRE")
            {
                if (gvClient.DataRowCount == 0) return;
                gvClient.ShowFilterPopup(colNom);
            }
        }

    
    }
}