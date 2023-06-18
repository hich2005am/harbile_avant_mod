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
using System.Xml;
using System.IO;
using FlyoutDialogExample;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraReports.UI;
using DSM.Model;
using System.IO.Ports;
using DSM.Controle;

namespace DSM
{
    public partial class MDI : DevExpress.XtraEditors.XtraForm
    {
       public Operateur operateur;
       private int xpos = 0, ypos = 0;
        public View.Pesage_view ps = new View.Pesage_view();
        //static int  vittesse=0;
        public MDI(Operateur operateur)
        {
            InitializeComponent();

            this.operateur=operateur;
            //xuiObjectAnimator1.FormAnimate(this, XanderUI.XUIObjectAnimator.FormAnimation.FadeIn, 1);
        }

        public static void Ex()
        {
            
            //navigationFrame.SelectedPage = customersNavigationPage;
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            //navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tileBar.SaveLayoutToXml("EX.xml");
        }
        string file = "layout.xml";
        string workspaceName1 = "MyLayout";
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show( (DateTime.Now.Day * DateTime.Now.Month * DateTime.Now.Year * 9).ToString());
              //  workspaceManager1.TargetControl = this;

                // Save & restore the form's size, position and state along with DevExpress controls' layouts.
                //workspaceManager1.SaveTargetControlSettings = true;

                // Disable layout load animation effects 
                //workspaceManager1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
                //if (workspaceManager1.LoadWorkspace(workspaceName1, file, true))
                //    workspaceManager1.ApplyWorkspace(workspaceName1);
                //******Role ************
                // Supper
                if (operateur.Etat_Op == true && operateur.Type_Op == 3)
            {
                timer1.Enabled = false;
                lblTitre.Visible = false;
                bar2.Visible = true;
               
                ps.layoutControl_privee.AllowCustomization = true;
                ps.lytImpression.AllowCustomization = true;
                ps.layoutControl1.AllowCustomization = true;
                ps.lblNumOrderP.AllowCustomization = true;
              
            } // Admin
            else if (operateur.Etat_Op == true && operateur.Type_Op == 1)
            
            {
                lblTitre.Location= new Point(0, 0);
                xpos = lblTitre.Location.X;

                ypos = lblTitre.Location.Y;
                ps.gcPoid.MouseDown -= new System.Windows.Forms.MouseEventHandler(ps.Poid_MouseDown);
                ps.GcNet.MouseDown -= new System.Windows.Forms.MouseEventHandler(ps.poidNet_MouseDown);
                ps.gcEntree.MouseDown -= new System.Windows.Forms.MouseEventHandler(ps.poidEntree_MouseDown);
            }//consulation
                if (operateur.Etat_Op == true && operateur.Type_Op == 5)

                {
                    navigationFrame.SelectedPage = Navhistorique;
                    lblTitre.Location = new Point(0, 0);
                    xpos = lblTitre.Location.X;
                    bar2.Visible = false;
                    ypos = lblTitre.Location.Y;
                    ps.gcPoid.MouseDown -= new System.Windows.Forms.MouseEventHandler(ps.Poid_MouseDown);
                    ps.GcNet.MouseDown -= new System.Windows.Forms.MouseEventHandler(ps.poidNet_MouseDown);
                    ps.gcEntree.MouseDown -= new System.Windows.Forms.MouseEventHandler(ps.poidEntree_MouseDown);
                }
                 //Operater

                else if (operateur.Etat_Op == true && operateur.Type_Op == 2)
            {
                    BtnOperateur.Visible = false;
                    BtnJournal_Supp.Visible = false;
                    xpos = lblTitre.Location.X;

                ypos = lblTitre.Location.Y;
                ps.gcPoid.MouseDown -= new System.Windows.Forms.MouseEventHandler(ps.Poid_MouseDown);
                ps.GcNet.MouseDown -= new System.Windows.Forms.MouseEventHandler(ps.poidNet_MouseDown);
                ps.gcEntree.MouseDown -= new System.Windows.Forms.MouseEventHandler(ps.poidEntree_MouseDown);
            }
                if (operateur.Etat_Op == true && operateur.Type_Op == 4)  {
                    timer1.Enabled = false;
                    lblTitre.Visible = false;
                    tileBar.Visible = false;
                   
                    ps.tbLayout.SelectedTabPageIndex = 1;
                    ps.tbLayout.TabPages[0].PageVisible = false; }

                // **********************
                if (File.Exists(@"design\Menu\Menu.xml"))      tileBar.RestoreLayoutFromXml(@"design\Menu\Menu.xml");
            BtnMenuPrincipale.Checked = true;
            BtnSeconde.Checked = false;
            MenuScondaire.Visible = false;
            MenuPara.Visible = false;
                //------------------
            }catch(Exception ex)
            {
                
            }





            //navigationFrame.SelectedPage = NavPesage;
            //propertyGridControl1.SelectedObject = BuildDataTableFromXml("ex", "xx.xml");
        }


        private void tileBar_Click(object sender, EventArgs e)
        {

        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileBarItem11_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
          

            navigationFrame.SelectedPage = NavFournisseur;
        }

        private void client_view1_Load(object sender, EventArgs e)
        {

        }

        private void accordionContentContainer1_Click(object sender, EventArgs e)
        {

        }
        View.Client.Journal journal= new View.Client.Journal();
        public  View.Client.Client_view client_=new View.Client.Client_view();
        public View.Client.Fournisseur_view fournisseur_ = new View.Client.Fournisseur_view();
        bool trouver = false;
        View.Client.Journal_sup sup= new View.Client.Journal_sup();
        View.Client.Produit_view produit= new View.Client.Produit_view();
        View.Client.Vehcule_view Veh=new View.Client.Vehcule_view();
         View.Client.Chauffeur_view ch =new View.Client.Chauffeur_view();
        private void navigationFrame_QueryControl(object sender, DevExpress.XtraBars.Navigation.QueryControlEventArgs e)
        {
            trouver = true;
            if (e.Page == NavPesage) e.Control =ps ;
            if (e.Page == NavClient) e.Control = client_;
            if (e.Page == NavFournisseur) e.Control = fournisseur_;
            if (e.Page == NavTransporteur) e.Control = new View.Client.Transporteur_view();
            if (e.Page == NavChauffeur) e.Control = ch;
            if (e.Page == NavVehcule) e.Control = Veh;
            if (e.Page == NavProduit) e.Control = produit;
            if (e.Page == NavOperateur) e.Control = new View.Client.Operateur_view();
            if (e.Page == Navhistorique) e.Control = journal;
            if (e.Page == NavSupp) e.Control = sup;
        }

        private void BtnClient_ItemClick(object sender, TileItemEventArgs e)
        {
            
            navigationFrame.SelectedPage = NavClient;
          




    }

       

        private void BtnFournisseur_ItemClick_1(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPage = NavFournisseur;
        }

        private void tileBarItem2_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void officeNavigationBar1_Click(object sender, EventArgs e)
        {
          
        }

        private void officeNavigationBar1_ItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            if (e.Item.Text == "MENU PRANCIPALE") { Menu_Principal(); }
            if (e.Item.Text == "MENU SECONDAIRE") { navigationFrame.SelectedPage = NavTransporteur; }
            if (e.Item.Text == "MENU PARAMETRAGE") { navigationFrame.SelectedPage = NavChauffeur; }
            //if (e.Item.Text == "OPERATEUR") { navigationFrame.SelectedPage = NavOperateur; }
            //if (e.Item.Text == "THEME")
            //{
            //    View.Theme theme = new View.Theme();
            //    theme.ShowDialog(this);
            //}
            //if (e.Item.Text == "COULEUR") 
            //{
            //    DevExpress.XtraEditors.ColorWheel.ColorWheelForm f = new DevExpress.XtraEditors.ColorWheel.ColorWheelForm();
            //    f.StartPosition= System.Windows.Forms.FormStartPosition.CenterScreen;
            //    f.ShowDialog(this);
                
            //}
        }

        private void BtnVehcule_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPage = NavVehcule;
        }

        private void BtnProduit_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPage = NavProduit;
        }

        private void tileBarItem5_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void BtnOperateur_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPage = NavOperateur;
        }

        private void BtnTransporteu_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPage = NavTransporteur;
        }

        private void BtnChauffeur_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPage = NavChauffeur;
        }
        private void BtnJournal_Supp_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPage = NavSupp;
        }
        private void tileBarItem2_ItemClick_1(object sender, TileItemEventArgs e)
        {

        }

        public void Menu_Principal()
        {
            MenuPrincipale.Visible = true;
            MenuScondaire.Visible = false;
            MenuPara.Visible = false;
          BtnMenuPrincipale.Checked=true;
        }
        public void Menu_Secondaire()
        {
            MenuPrincipale.Visible = false;
            MenuScondaire.Visible = true;
            MenuPara.Visible = false;
        }
        public void Menu_Parametre()
        {
            
            MenuScondaire.Visible = false;
            MenuPara.Visible = true;
        }

        private void BtnMenuPrincipale_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(BtnMenuPrincipale.Checked==true) MenuPrincipale.Visible = true;else MenuPrincipale.Visible = false;
        }

        private void BtnSeconde_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BtnSeconde.Checked == true) MenuScondaire.Visible = true; else MenuScondaire.Visible = false;
        }

        private void btnPara_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void BtnPara_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (BtnPara.Checked == true) MenuPara.Visible = true; else MenuPara.Visible = false;
        }

        private void btnCouleur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.XtraEditors.ColorWheel.ColorWheelForm f = new DevExpress.XtraEditors.ColorWheel.ColorWheelForm();
            f.StartPosition= System.Windows.Forms.FormStartPosition.CenterScreen;
            f.SkinMaskColor = Properties.Settings.Default.SkinMaskColor;
            f.SkinMaskColor2 = Properties.Settings.Default.SkinMaskColor2;
            f.ShowDialog(this);
        }

        private void BtnPesage_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPage = NavPesage;
         
        }

        private void BtnHistorique_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPage = Navhistorique;
        }

        private void MDI_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void MDI_KeyDown(object sender, KeyEventArgs e)

        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    SendKeys.Send("{TAB}");
            //}

        }


        private void BtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Controle.HelperFunctions.print();
         
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void skinBarSubItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void MDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                //workspaceManager1.CaptureWorkspace(workspaceName1, true);
                //workspaceManager1.SaveWorkspace(workspaceName1, file, true);
                ////splashScreenManager2.ShowWaitForm();
                //ps.layoutControl1.SaveLayoutToXml(ps.prancipale);
                //DSM.Properties.Settings.Default["ApplicationSkinName"] = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName;
                //DSM.Properties.Settings.Default["SkinMaskColor"] = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinMaskColor;
                //DSM.Properties.Settings.Default["SkinMaskColor2"] = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinMaskColor2;
                //DSM.Properties.Settings.Default.Save();
                //string source = DSM.Properties.Settings.Default.BD;
                //string destination = DSM.Properties.Settings.Default.Sauvgarde;



                //if (File.Exists(source) == false || Directory.Exists(destination) == false)
                //{
                //    Path path = new Path();
                //    path.ShowDialog();
                //}
                //else
                //{
                  
                    if (ps.sp.IsOpen == true)
                    {
                        ps.sp.DiscardInBuffer();
                        ps.sp.DiscardOutBuffer();
                      
                        ps.sp.Close();
                  
                    }
                    //System.IO.File.Copy(source, destination + "//" + "MyAccessDb.bk", true);
                    //splashScreenManager2.CloseWaitForm();
                    Application.ExitThread();
                    Application.Exit();
                //}
                //ribbonControl1.SaveLayoutToXml("menu.xml");
               
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          


        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BtnHistorique.Visible = false;
        }

        private void BtnSauvgarde_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Path path = new Path();
            path.ShowDialog();
        }

        private void BtnPort_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ports_view view = new Ports_view();
            view.ShowDialog();


        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Controle.HelperFunctions.print_public();
        }

        private void BtnImpression_poid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Controle.HelperFunctions.print_Poid(int.Parse(ps.psPoid.Text));
        }

        private void btnPrint_1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Controle.HelperFunctions.print_Poid(-1);
            //XtraReport report = new XtraReport();
            //report.CreateDocument();
            //report.LoadLayout("poid.repx");
            //report.DisplayName = "poid";
            //report.ShowDesignerDialog();
            //ReportPrintTool pt = new ReportPrintTool(report);
            //pt.sh.ShowPreviewDialog();
            // Save the document to a file. 
            //report.SaveLayout("poid.repx");

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void MDI_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void MDI_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void NavPesage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tileBar_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnViderData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Pesage_ctr Ps = new Pesage_ctr();
            TypVehcule_ctr type = new TypVehcule_ctr();
            PesageP_ctr Ps_P = new PesageP_ctr();
            Client_ctr client = new Client_ctr();
            Fournisseur_ctr fournisseur = new Fournisseur_ctr();
            Transporteur_ctr transporteur = new Transporteur_ctr();
            Chauffeur_ctr chauffeur = new Chauffeur_ctr();
            Vehcule_ctr vehcule = new Vehcule_ctr();
            Produit_ctr produit = new Produit_ctr();
            Destination_ctr destination = new Destination_ctr();
            Operateur_ctr op = new Operateur_ctr();
            Ps.delete();
            Ps_P.delete();
            client.delete();
            fournisseur.delete();
            transporteur.delete();
            chauffeur.delete();
            vehcule.delete();
            produit.delete();
            destination.delete();
            op.delete();
            type.delete();
            XtraMessageBox.Show("l'opération est terminée");
            
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {
                    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width == xpos)

            {

                this.lblTitre.Location = new System.Drawing.Point(0, ypos);

                xpos = 0;



            }

            else

            {

                this.lblTitre.Location = new System.Drawing.Point(xpos, ypos);

                xpos += 2;

            }
        }

        private void BtnSerial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            proctection proctection = new proctection();
            proctection.ShowDialog();
        }

        private void IMPR_CL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             Controle.HelperFunctions.print_cl(); 
        }

        private void BtnImpFR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          Controle.HelperFunctions.print_fr();
        }

        private void navigationFrame_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
           
            if (e.Page.Caption == "NavFournisseur")fournisseur_.refresh(); 
            if (e.Page.Caption == "NavVehcule") Veh.refresh();
            if (e.Page.Caption == "NavProduit") produit.refresh();
            if (e.Page.Caption == "NavChauffeur") ch.refresh();
            //if (e.OldPage.Caption == "Navhistorique") ps.client_R();
            if (e.Page.Caption == "NavClient") client_.refresh();
            //    if (e.Page.Caption == "Navhistorique" && trouver == false) journal.Client_view_Load(sender, e);
            //    if (e.Page.Caption == "NavClient" && trouver == false) client_.Client_view_Load(sender, e);
            //    if (e.Page.Caption == "NavFournisseur" && trouver == false) fournisseur_.Client_view_Load(sender, e);
            //    if (e.Page.Caption == "NavSupp" && trouver == false) sup.Client_view_Load(sender, e);
            //    if (e.Page.Caption == "NavChauffeur")  ch.Client_view_Load(sender, e);
            //    if (e.Page.Caption == "NavVehcule")  Veh.Client_view_Load(sender, e);
            //    if (e.Page.Caption == "NavProduit") produit.Client_view_Load(sender, e);
            if (e.OldPage.Caption == "NavClient") ps.client_R();
            if (e.OldPage.Caption == "NavFournisseur") ps.fournisseur_R();
            if (e.OldPage.Caption == "NavVehcule") ps.veh_R();
            if (e.OldPage.Caption == "NavProduit") ps.produit_R();
            if (e.OldPage.Caption == "NavChauffeur") ps.chauffeur_R();
            if (e.OldPage.Caption == "Navhistorique") journal.reflish();
            if (e.Page.Caption == "NavClient")  client_.refresh();
        }

        private void btnImp_att_FR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Controle.HelperFunctions.print_cl_Att();
        }

        private void btnImp_att_CL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Controle.HelperFunctions.print_fr_Att();
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }
    }
}
