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
using DevExpress.Utils.Menu;
using DSM.Model;
using DevExpress.XtraEditors.Filtering;

namespace DSM.View.Client
{
    public partial class Journal : DevExpress.XtraEditors.XtraUserControl
    {
        
        Client_ctr client = new Client_ctr();
        Fournisseur_ctr fournisseur = new Fournisseur_ctr();
        Transporteur_ctr transporteur = new Transporteur_ctr();
        Chauffeur_ctr chauffeur = new Chauffeur_ctr();
        Vehcule_ctr vehcule = new Vehcule_ctr();
        Produit_ctr produit = new Produit_ctr();
        Destination_ctr destination = new Destination_ctr();
        Controle.Pesage_ctr pesage = new Controle.Pesage_ctr();
        Controle.PesageP_ctr pesageP = new Controle.PesageP_ctr();
        MDI f = (MDI)Application.OpenForms["MDI"];
        public Journal()
        {
            InitializeComponent();
        }
        List<Vehcule> Vc;
        List<Transporteur> trs;
        List<Chauffeur> ch;
        List<Destination> Dst;
        List<Fournisseur> Frs;
        List<Model.Client> cls;
        public void Client_view_Load(object sender, EventArgs e)
        {
            reflish();
        }
     
      

        private void gdClient_Load(object sender, EventArgs e)
        {
           
        }

        private void gvClient_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            PrintingSystemBase pb = e.PrintingSystem as PrintingSystemBase;
            pb.PageSettings.LeftMargin = 5; 
            pb.PageSettings.RightMargin = 5;
            pb.PageSettings.Landscape = true;

        }
              

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
          if(e.Button.Properties.Caption== "Bon")
            {
                if (gdJournal.MainView == gvJournal)
                {
                    if (gvJournal.GetFocusedRowCellDisplayText(coltype_MV) == "E") Controle.HelperFunctions.print_fr(gvJournal.GetFocusedRowCellDisplayText(colNum));
                    else Controle.HelperFunctions.print_cl(gvJournal.GetFocusedRowCellDisplayText(colNum));

                }
                else
                {
                    Controle.HelperFunctions.print_public(gvPublic.GetFocusedRowCellDisplayText(colNumP));
                }
            }



            if (e.Button.Properties.Caption == "EXPORTER")
            {
                SaveFileDialog saveFileDialogExcel = new SaveFileDialog();
                saveFileDialogExcel.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (saveFileDialogExcel.ShowDialog() == DialogResult.OK)
                {
                    string exportFilePath = saveFileDialogExcel.FileName;

                    gdJournal.ExportToXlsx(exportFilePath);
                }
            }
            if (e.Button.Properties.Caption == "IMPRIMER")
            {
                if (gdJournal.MainView == gvJournal)
                {
                    gvJournal.ShowRibbonPrintPreview();
                }
                else
                {
                    gvPublic.ShowRibbonPrintPreview();
                }
            }
            if (e.Button.Properties.Caption == "FILTRE")
            {
                //gvClient./*ShowFilterPopup*/(colNom);
            }
            if (e.Button.Properties.Caption == "JOURNAL")
            {
                if (gdJournal.MainView == gvJournal)
                {
                    gdJournal.MainView = gvPublic;
                    gdJournal.DataSource = pesageP.Select_Attente();
                    gvPublic.BestFitColumns();
                    PnlRechechePrivee.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                    pnlRecherchePublic.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
                }
                else
                {
                    gdJournal.MainView = gvJournal;
                    gdJournal.DataSource = pesage.Select();
                    gvJournal.BestFitColumns();

                    PnlRechechePrivee.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
                    pnlRecherchePublic.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                }
            }
        }

       

        private void txtPesage_EditValueChanged(object sender, EventArgs e)
        {
            rechercher("ID_PS", "ID_PS =", txtPesage.Text.Trim(), " ");
        }
        private void rechercher(string champs, string Recherche, string valeur, string final)
        {
            if (valeur != "")
            {
              gvJournal.Columns[champs].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(Recherche + valeur + final);
            }
            else
            {
                gvJournal.Columns[champs].ClearFilter();
            }
        }
        //private void cbxVehcule_code_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //cbxVehcule.SelectedIndex = cbxVehcule_code.SelectedIndex;
        //    //rechercher("ID_VEH", "ID_VEH =", cbxVehcule_code.Text.Trim(), " ");
        //}

        //private void cbxClient_code_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //cbxClient.SelectedIndex = cbxClient_code.SelectedIndex;
        //    //rechercher("ID_CL", "ID_CL =", cbxClient_code.Text.Trim(), " ");
        //}

        //private void cbxFournisseur_code_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //cbxFournisseur.SelectedIndex = cbxFournisseur_code.SelectedIndex;
        //    //rechercher("ID_FR", "ID_FR =", cbxFournisseur_code.Text.Trim(), " ");
        //}

       

        private void lblDt_Click(object sender, EventArgs e)
        {

        }
        private void rechercherEnterrDate(string champs, string Recherche)
        {
         gvJournal.Columns[champs].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(Recherche);
        }
        private void rechercherEnterrDate2(string champs, string Recherche)
        {

          gvPublic.Columns[champs].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(Recherche);


        }
        private void date()
        {

            var FromDate = DateTime.Parse(dtDu.Text).Date;
            var ToDate = DateTime.Parse(dtAu.Text).Date;
            //if(FromDate>ToDate) {MessageBox.Show("e")
            rechercherEnterrDate("Dt_PS", String.Format("[Dt_PS]>=#{0:MM/dd/yyyy}#  and [Dt_PS]<=#{1:MM/dd/yyyy}# ", FromDate, ToDate));
           
        }
        private void dateP()
        {

            var FromDate = DateTime.Parse(dtDuP.Text).Date;
            var ToDate = DateTime.Parse(dtAuP.Text).Date;
            //if(FromDate>ToDate) {MessageBox.Show("e")
            rechercherEnterrDate2("Dt_PS", String.Format("[Dt_PS]>=#{0:MM/dd/yyyy}#  and [Dt_PS]<=#{1:MM/dd/yyyy}# ", FromDate, ToDate));

        }
        private void dtDu_EditValueChanged(object sender, EventArgs e)
        {
             date();
        }

        private void dtDu_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
           
        }

        

        private void gvClient_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Column)
            {
                DXMenuItem item = new DXMenuItem("Renommer cette colonne");
                item.Click += (o, args) =>
                {

                    string nom = XtraInputBox.Show("Saisez nom SVP", "Renommer la colonne", e.HitInfo.Column.Caption);
                    if (nom != "")
                    {
                        e.HitInfo.Column.Caption = nom;
                    }
                };
                e.Menu.Items.Add(item);
            }
        }

        private void gdClient_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void gvClient_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

             menu.ShowPopup(Control.MousePosition);
            }
        }

        private void chDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chDate.Checked)
            {
                pnlDateR.Visible = true;
                date();
            }
            else {
                pnlDateR.Visible = false;
                ColDateS.ClearFilter();
            }
        }

        private void pnlDateR_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxPdt_code_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPdt.SelectedIndex = cbxPdt_code.SelectedIndex;
            rechercher("ID_PDT", "ID_PDT =", cbxPdt_code.Text.Trim(), " ");
        }    

        

        

        private void chTara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdTara.SelectedIndex == 1)
            {
                rechercher("tara_M", "tara_M ='", rdTara.EditValue.ToString(), "' ");
            }      
            else
            {
              colTareM.ClearFilter();
            }
        }

        private void ChManual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdManual.SelectedIndex == 1)
            {
                rechercher("Manual", "Manual ='", rdManual.EditValue.ToString(), "' ");

            }
            else if (rdManual.SelectedIndex == 2)
            {
                rechercher("Manual", "Manual ='", rdManual.EditValue.ToString(), "' ");
            }
            else
            {
             colManual.ClearFilter();
            }
        }

        private void rdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdType.SelectedIndex == 1)
            {
                rechercher("type_MV", "type_MV ='",rdType.EditValue.ToString(), "' ");
                colClient.Visible = false;
                ColFournisseur.Visible = true;
            }
            else if (rdType.SelectedIndex == 2)
            {
                rechercher("type_MV", "type_MV ='", rdType.EditValue.ToString(), "' ");
               
                ColFournisseur.Visible = false;
                colClient.Visible = true;
            }
            else
            {
                coltype_MV.ClearFilter();
                colClient.Visible = true;
                ColFournisseur.Visible = true;
            }
        }
        private void cbxVehcule_TextChanged(object sender, EventArgs e)
        {
           

            if (cbxVehcule.SelectedIndex != -1) cbxVehcule_code.SelectedIndex = cbxVehcule.SelectedIndex;
            else { cbxVehcule_code.Text = ""; }
            rechercher("MAT_VEH", "MAT_VEH ='", cbxVehcule.Text.Trim(), "' ");


        }
        private void cbxVehcule_code_TextChanged(object sender, EventArgs e)
        {
            if (cbxVehcule_code.Text == "0")
            {
                cbxVehcule_code.Text = "";

                return;
            }
            if (cbxVehcule_code.Text.Trim() == "" && cbxVehcule.Text.Trim() != "")
            {
                if (Vc.Find(vc => vc.MAT_VEH == cbxVehcule.Text.Trim()).ID_VEH > 0) cbxVehcule.SelectedIndex = -1;
            }
            if ((cbxVehcule_code.Text.Trim() != "" && cbxVehcule.Text.Trim() != "") || (cbxVehcule_code.Text.Trim() != "" && cbxVehcule.Text.Trim() == ""))
            {
                cbxVehcule.SelectedIndex = cbxVehcule_code.SelectedIndex;
            }
            rechercher("ID_VEH", "ID_VEH =", cbxVehcule_code.Text.Trim(), " ");
        }
        private void cbxTransporteur_code_TextChanged(object sender, EventArgs e)
        {
            if (cbxTransporteur_code.Text == "0")
            {
                cbxTransporteur_code.Text = "";

                return;
            }
            if (cbxTransporteur_code.Text.Trim() == "" && cbxTransporteur.Text.Trim() != "")
            {
                if (trs.Find(trs => trs.Nom_TR == cbxTransporteur.Text.Trim()).ID_TR > 0) cbxTransporteur.SelectedIndex = -1;
            }
            if ((cbxTransporteur_code.Text.Trim() != "" && cbxTransporteur.Text.Trim() != "") || (cbxTransporteur_code.Text.Trim() != "" && cbxTransporteur.Text.Trim() == ""))
            {
                cbxTransporteur.SelectedIndex = cbxTransporteur_code.SelectedIndex;
                //trs.

            }
            rechercher("ID_TR", "ID_TR =",cbxTransporteur_code.Text.Trim(), " ");


        }
        private void cbxTransporteur_TextChanged(object sender, EventArgs e)
        {
            if (cbxTransporteur.SelectedIndex != -1) cbxTransporteur_code.SelectedIndex = cbxTransporteur.SelectedIndex;
            else { cbxTransporteur_code.Text = ""; }
            rechercher("Nom_TR", "Nom_TR ='", cbxTransporteur.Text.Trim(), "' ");


        }

        private void cbxFournisseur_code_TextChanged(object sender, EventArgs e)
        {
            if (cbxFournisseur_code.Text == "0")
            {
                cbxFournisseur_code.Text = "";

                return;
            }
            if (cbxFournisseur_code.Text.Trim() == "" && cbxFournisseur.Text.Trim() != "")
            {
                if (Frs.Find(vc => vc.Nom_FR == cbxFournisseur.Text.Trim()).ID_FR > 0) cbxFournisseur.SelectedIndex = -1;
            }
            if ((cbxFournisseur_code.Text.Trim() != "" && cbxFournisseur.Text.Trim() != "") || (cbxFournisseur_code.Text.Trim() != "" && cbxFournisseur.Text.Trim() == ""))
            {
                cbxFournisseur.SelectedIndex = cbxFournisseur_code.SelectedIndex;
            }
            rechercher("ID_FR", "ID_FR =", cbxFournisseur_code.Text.Trim(), " ");

        }
        private void cbxChefr_code_TextChanged(object sender, EventArgs e)
        {
            if (cbxChefr_code.Text == "0")
            {
                cbxChefr_code.Text = "";

                return;
            }
            if (cbxChefr_code.Text.Trim() == "" && cbxChefr.Text.Trim() != "")
            {
                if (ch.Find(ch => ch.Nom_CH == cbxChefr.Text.Trim()).ID_CH > 0) cbxChefr.SelectedIndex = -1;
            }
            if ((cbxChefr_code.Text.Trim() != "" && cbxChefr.Text.Trim() != "") || (cbxChefr_code.Text.Trim() != "" && cbxChefr.Text.Trim() == ""))
            {
                cbxChefr.SelectedIndex = cbxChefr_code.SelectedIndex;
            }
            rechercher("ID_CH", "ID_CH =", cbxChefr_code.Text.Trim(), " ");

        }

        private void cbxDest_code_TextChanged(object sender, EventArgs e)
        {
            if (cbxDest_code.Text == "0")
            {
                cbxDest_code.Text = "";

                return;
            }
            if (cbxDest_code.Text.Trim() == "" && cbxDest.Text.Trim() != "")
            {
                if (Dst.Find(Dst => Dst.Nom_DS == cbxDest.Text.Trim()).ID_DS > 0) cbxDest.SelectedIndex = -1;
            }
            if ((cbxDest_code.Text.Trim() != "" && cbxDest.Text.Trim() != "") || (cbxDest_code.Text.Trim() != "" && cbxDest.Text.Trim() == ""))
            {
                cbxDest.SelectedIndex = cbxDest_code.SelectedIndex;
            }
            rechercher("ID_DS", "ID_DS =", cbxDest_code.Text.Trim(), " ");

        }

        private void cbxFournisseur_TextChanged(object sender, EventArgs e)
        {
            if (cbxFournisseur.SelectedIndex != -1) cbxFournisseur_code.SelectedIndex = cbxFournisseur.SelectedIndex;
            else { cbxFournisseur_code.Text = ""; }
            rechercher("Nom_FR", "Nom_FR ='", cbxFournisseur.Text.Trim(), "' ");

        }

        private void cbxChefr_TextChanged(object sender, EventArgs e)
        {
            if (cbxChefr.SelectedIndex != -1) cbxChefr_code.SelectedIndex = cbxChefr.SelectedIndex;
            else { cbxChefr_code.Text = ""; }
            rechercher("Nom_CH", "Nom_CH ='", cbxChefr.Text.Trim(), "' ");
        }

        private void cbxDest_TextChanged(object sender, EventArgs e)
        {
            if (cbxDest.SelectedIndex != -1) cbxDest_code.SelectedIndex = cbxDest.SelectedIndex;
            else { cbxDest_code.Text = ""; }
            rechercher("Nom_DS", "Nom_DS ='", cbxDest.Text.Trim(), "' ");

        }

        private void cbxClient_code_TextChanged(object sender, EventArgs e)
        {
            if (cbxClient_code.Text == "0")
            {
                cbxClient_code.Text = "";

                return;
            }
            if (cbxClient_code.Text.Trim() == "" && cbxClient.Text.Trim() != "")
            {
                if (cls.Find(cls => cls.Nom_CL == cbxClient.Text.Trim()).ID_CL > 0) cbxClient.SelectedIndex = -1;
            }
            if ((cbxClient_code.Text.Trim() != "" && cbxClient.Text.Trim() != "") || (cbxClient_code.Text.Trim() != "" && cbxClient.Text.Trim() == ""))
            {
                cbxClient.SelectedIndex = cbxClient_code.SelectedIndex;
            }
            rechercher("ID_CL", "ID_CL =", cbxClient_code.Text.Trim(), " ");

        }

        private void cbxClient_TextChanged(object sender, EventArgs e)
        {
            if (cbxClient.SelectedIndex != -1) cbxClient_code.SelectedIndex = cbxClient.SelectedIndex;
            else { cbxClient_code.Text = ""; }
            rechercher("Nom_CL", "Nom_CL ='", cbxClient.Text.Trim(), "' ");

        }

        private void txtAnne_EditValueChanged(object sender, EventArgs e)
        {
            rechercher("anne_PS", "anne_PS =", txtPesage.Text.Trim(), " ");
        }

        private void PnlRECHERCHE_CustomButtonChecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {

        }

        private void RechNum_QueryIsSearchColumn(object sender, QueryIsSearchColumnEventArgs args)
        {
           
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        private void Rech_N_QueryIsSearchColumn(object sender, QueryIsSearchColumnEventArgs args)
        {
            FilterColumn column = sender as FilterColumn;
            args.IsSearchColumn = column.FieldName == "ID_PS";
        }

        private void Rech_Matricule_QueryIsSearchColumn(object sender, QueryIsSearchColumnEventArgs args)
        {
            FilterColumn column = sender as FilterColumn;
            args.IsSearchColumn = column.FieldName == "MAT";
        }

        private void dtDuP_EditValueChanged(object sender, EventArgs e)
        {
            dateP();
        }

        private void gdJournal_Click(object sender, EventArgs e)
        {

        }

        private void gvPublic_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.Column.FieldName == "tare")
            //{
            //    if (int.e.CellValue.ToString() == "01/01/0001") e.CellValue = ""; ;
            //   //if( e.CellValue.ToStrin()==
            //    //e.Appearance.BackColor = _mark ? Color.LightGreen : Color.LightSalmon;
            //    //e.Appearance.TextOptions.HAlignment = _mark ? HorzAlignment.Far : HorzAlignment.Near;
            //}
        }
       public void reflish()
        {
            // -----VEHCULE--------
            Vc = vehcule.aff();
            foreach (var s in Vc.OfType<Vehcule>()) { cbxVehcule_code.Properties.Items.Add(s.ID_VEH); cbxVehcule.Properties.Items.Add(s.MAT_VEH); }

            //----FOURNISSEUR-----
            Frs = fournisseur.aff();
            foreach (var s in Frs.OfType<Fournisseur>()) { cbxFournisseur.Properties.Items.Add(s.Nom_FR); cbxFournisseur_code.Properties.Items.Add(s.ID_FR); }

            //----CLIENT-----
            cls = client.aff();
            foreach (var s in cls.OfType<Model.Client>()) { cbxClient.Properties.Items.Add(s.Nom_CL); cbxClient_code.Properties.Items.Add(s.ID_CL); }

            //-------TRANSPORTEUR------


            //---------Chauffeur--------
            ch = chauffeur.aff();
            foreach (var s in ch.OfType<Chauffeur>()) { cbxChefr_code.Properties.Items.Add(s.ID_CH); cbxChefr.Properties.Items.Add(s.Nom_CH); }

            //---------DISTINATION--------
            Dst = destination.aff();
            foreach (var s in Dst.OfType<Destination>()) { cbxDest.Properties.Items.Add(s.Nom_DS); cbxDest_code.Properties.Items.Add(s.ID_DS); }


            HelperFunctions.combox(cbxPdt, cbxPdt_code, HelperFunctions.Rempli("select * from Produit"), "Designe_PDT", "ID_PDT");
            trs = transporteur.aff();
            foreach (var s in trs.OfType<Transporteur>()) { cbxTransporteur.Properties.Items.Add(s.Nom_TR); cbxTransporteur_code.Properties.Items.Add(s.ID_TR); }

            gdJournal.MainView = gvJournal;
            gdJournal.DataSource = pesage.Select();
            gvJournal.BestFitColumns();
            dtDu.EditValue = DateTime.Now.Date;
            dtAu.EditValue = DateTime.Now.Date;
            dtDuP.EditValue = DateTime.Now.Date;
            dtAuP.EditValue = DateTime.Now.Date;
            pnlRecherchePublic.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }
    }
    }
