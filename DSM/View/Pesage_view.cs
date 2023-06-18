using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DSM.Controle;
using DSM.Model;
using DevExpress.XtraLayout;
using DSM.Properties;
using System.Xml.Serialization;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors.Repository;
using FlyoutDialogExample;
using System.IO;
using System.IO.Ports;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System.Text.RegularExpressions;
using DevExpress.XtraBars.Docking2010.Customization;

namespace DSM.View
{
    public partial class Pesage_view : DevExpress.XtraEditors.XtraUserControl
    {
        FlyoutAction action = new FlyoutAction();
        public  static int vettesse=300;
        const string poid_ = @"design\pesage\poid.xml";
        const string poid_Entree = @"design\pesage\poid_Entree.xml";
        const string poid_net = @"design\pesage\poid_Net.xml";
        Port_ctr port_ = new Port_ctr();
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
        order or = new order();
        XmlSerializer xs = new XmlSerializer(typeof(order));
        int poid_Entrees;
        bool tare=true;
        List<Pesage> Attente;
        MDI f = (MDI)Application.OpenForms["MDI"];
        int id_op;
        string nom_op;
        public Pesage_view()
        {
            InitializeComponent();
        }
       
        List<Vehcule> Vc;
        List<PesageP> Mat;
        List<TypVehcule> typVeh;
        List<Produit> pr;
        string regKey = "DevExpress\\Layout Control\\Layouts";
     public   string prancipale = @"design\pesage\principale.xml";
        private void Pesage_view_Load(object sender, EventArgs e)
        {
            try {
                //MDI Main = (MDI)Application.OpenForms["MDI"];
                //id_op = Main.operateur.ID_Op;
                //bool etat = Main.operateur.Etat_Op;
                //restauration();
                //if (System.IO.File.Exists(prancipale))
                //    layoutControl1.RestoreLayoutFromXml(prancipale);
                //System.Xml.Linq.XDocument xdoc = System.Xml.Linq.XDocument.Load("order");
                //var orderId = xdoc.Descendants("prixUn").FirstOrDefault().Value;
                //orderIndex();
                //-------Role------------
                HelperFunctions.image(imageSlider1);
                tbLayout.ShowTabHeader = DevExpress.Utils.DefaultBoolean.Default;
            
         //------------------------------
               Ini_ENTRIE();
                cbxMat_p.Focus();
                port();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //gaugeControl2.RestoreLayoutFromXml("style.xml");
            //searchLookUpEdit1.Properties.DataSource = Ps.ATTENTE();
        }
        private void Log(string msg)
        {
            rtfTerminal1.Invoke(new EventHandler(delegate
            {
                //rtfTerminal.SelectedText = string.Empty;

                rtfTerminal1.Text = msg;
                //msg = System.Text.RegularExpressions.Regex.Match(msg, @"\d+\s*").NextMatch().Value;
                //msg = System.Text.RegularExpressions.Regex.Match(msg, @"\d+\s*").Value;
                //string[] operands = Regex.Split(msg, @"\s+");
                //msg = operands[1];
                rtfTerminal1.Text = msg;
                msg = System.Text.RegularExpressions.Regex.Match(msg, @"\d+\s*").Value;
                //Form form = this.ActiveMdiChild;
                //if (this.ActiveMdiChild == null)
                //{
                //    return;
                //}
                psPoid.Text = msg;
                //if (this.ActiveMdiChild.Name == "pageSaisez_view")
                //{

                //    pageSaisez_view passageLocal = (pageSaisez_view)this.ActiveMdiChild;

                //    passageLocal.cBrut.Text = msg;

                //}
                //if (this.ActiveMdiChild.Name == "Sorties_view")
                //{
                ////    Sorties_view passageLocal = (Sorties_view)this.ActiveMdiChild;

                ////    if (passageLocal.chManual.Checked == false)
                ////        passageLocal.poid.Text = msg;

                //}
            }));

        }
        private void port()
        {
            sp.BaudRate = 9600;
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
            sp.DataBits = 8;
            sp.Handshake = Handshake.None;

            bool erreur = false;

            // Si le port est ouvert, il faut le fermer
            if (sp.IsOpen) sp.Close();
            else
            {
                // Réglage paramètre du port
                sp.PortName = "Com1";

                try
                {
                    // Ouvrir le port
                    sp.Open();
                }
                catch (UnauthorizedAccessException) { erreur = true; }
                catch (IOException) { erreur = true; }
                catch (ArgumentException) { erreur = true; }

                //if (erreur)
                //    MessageBox.Show("Impossible d'ouvrir le port COM. Très probablement, il est déjà en cours d'utilisation, a été supprimé, ou n'est pas disponible.", "COM Port indisponible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //  else
                //  MessageBox.Show("Connexion réussi", "Port disponible");
            }
        }
        //private void port()
        //{
        //    Port port = port_.GetPort(@"design\port\update.xml"); ;
        //    //Port port = port_.GetPort(@"design\port\update.xml");
        //    if (System.IO.File.Exists(@"design\port\update.xml"))
        //    {



        //    sp.BaudRate =port.BaudRate ;
        //    sp.DataBits =port.Databit;
        //    sp.Parity = (Parity) Enum.Parse(typeof(Parity), port.Parity);
        //    sp.StopBits = (StopBits)Enum.Parse(typeof(StopBits), port.StopBit);

        //    sp.Handshake = (Handshake) Enum.Parse(typeof(Handshake), port.flux);
        //        vettesse = port.vitesse;

        //    }


        //    bool erreur = false;

        //    // Si le port est ouvert, il faut le fermer
        //    if (sp.IsOpen) sp.Close();
        //    else
        //    {
        //        //
        //        //sp.PortName = port_conf.
        //        // Réglage paramètre du port
        //        sp.PortName = port.com;

        //        try
        //        {
        //            // Ouvrir le port
        //            sp.Open();
        //        }
        //        catch (UnauthorizedAccessException) { erreur = true; }
        //        catch (IOException) { erreur = true; }
        //        catch (ArgumentException) { erreur = true; }

        //        //if (erreur)
        //        //    MessageBox.Show("Impossible d'ouvrir le port COM. Très probablement, il est déjà en cours d'utilisation, a été supprimé, ou n'est pas disponible.", "COM Port indisponible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //        //else
        //        //    MessageBox.Show("Connexion réussi", "Port disponible");
        //    }
        //}


        private void orderIndex()
        {
            using (var sr = new System.IO.StreamReader(@"Serialization.xml"))
            {
                or = (order)xs.Deserialize(sr);
            }
            cbxVehcule_code.TabIndex = or.Matricuel;
            cbxClient_code.TabIndex = or.Client;
            cbxFournisseur_code.TabIndex = or.Fournisseur;
            cbxTransporteur_code.TabIndex = or.Transporteur;
            cbxPdt_code.TabIndex =or.Produit;
            cbxChefr_code.TabIndex = or.Chauffeur;
            cbxDest_code.TabIndex = or.Destination;
            txtBon.TabIndex = or.Bon;txtNB_Caisse.TabIndex = or.NbCaisse;
            mNote.TabIndex = or.Note;txtPrix.TabIndex = or.prixUn;
            txtNB_Palette.TabIndex = or.NbPalette;
            txtUniteC.TabIndex = or.UnCaisse;txtUniteP.TabIndex = or.UnPalette;
            BtnPese.TabIndex = or.poid;BtnSave.TabIndex = or.valide;
        }
        List<Produit> pro;
        List<Transporteur> trs;
        List<Chauffeur> ch;
         List<Model.Destination> Dst;
        List<Fournisseur> Frs;
        List<Model.Client> cls;
     
       

       

        private void gvMat_EditValueChanged(object sender, EventArgs e)
        {
           
           if(gvMat.Text!="") Ini_SORTIE();
        }

      

        private void gaugeControl2_Click(object sender, EventArgs e)
        {
         
            if (Sortie.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
                txtPoidSortie.EditValue = psPoid.Text;
            else txtPoid_E.EditValue = psPoid.Text;
           
        }

        private void cbxClient_code_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
        private void cbxPdt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPdt.SelectedIndex != -1) { cbxPdt_code.SelectedIndex = cbxPdt.SelectedIndex; txtPrix.EditValue = produit.Prix(int.Parse(cbxPdt_code.EditValue.ToString())); }
            else { cbxPdt_code.Text = ""; txtPrix.EditValue = 0; }
        }

        private void cbxPdt_cbxPdt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPdt.SelectedIndex = cbxPdt_code.SelectedIndex;
        }
    
        private void gvMat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind.ToString() == "Delete")
            {
                gvMat.Text = "";
                Ini_ENTRIE();
            }
            if (e.Button.Caption.ToString() == "SUPPRIMER")
            {
                if (XtraMessageBox.Show("vous voudrais supprimer cette pesage ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Ps.delete(int.Parse(lblNumOrder.Text));
                    Ini_ENTRIE();
                }
            }
        }

        private void Manual_Toggled(object sender, EventArgs e)
        {
            if (Manual.IsOn) {
                int motPasse = DateTime.Now.Day * DateTime.Now.Year ;
                XtraInputBoxArgs arg = new  XtraInputBoxArgs();
                TextEdit editor = new TextEdit();
                
                editor.Properties.UseSystemPasswordChar = true;
                arg.Editor = editor;
                arg.Caption = "Mot de passe";
                arg.Prompt = "Entrez votre mot de passe ?";
                arg.DefaultResponse = "";
                arg.DefaultButtonIndex =0;
                //arg.Buttons[0] = DialogResult.OK;

                var passkey = XtraInputBox.Show(arg);
                if (passkey == null) { Manual.IsOn = false; return; } 
               if ( passkey.ToString().Trim()!=motPasse.ToString())
                {
                    XtraMessageBox.Show("mot passe incorrect", "Message d'erreur");
                    Manual.IsOn = false;
                    return;
                }
                pnlManual.Visible = true;
                pnlManual.Dock = DockStyle.Top;
                gcPoid.Visible = !pnlManual.Visible;
                txtPoid.EditValue = 0;
               
            }
            else
            { 
            
                pnlManual.Visible = false;
                pnlManual.Dock = DockStyle.None;
                gcPoid.Visible = !pnlManual.Visible;
                 txtPoid.EditValue = 0;
               
            }
        }

        private void txtTara_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                //txtTara.Properties.Buttons[0].
                if (e.Button.Caption == "PESAGE AVEC TARE") { e.Button.Image = DSM.Properties.Resources.WeightedPies_32x32___Copie;
                    e.Button.Caption ="PESAGE SANS Tare"; tare = false;
                    txtTara.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                    GcNet.Visible = false;
                }
                else
                if (e.Button.Caption == "PESAGE SANS Tare") { e.Button.Image = DSM.Properties.Resources.WeightedPies_32x32;
                    e.Button.Caption = "PESAGE AVEC TARE"; tare = true;
                    txtTara.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    GcNet.Visible = true;
                }
            }
        }

        private void choixType_Toggled(object sender, EventArgs e)
        {
            if (choixType.IsOn && choixPosage.EditValue.ToString() == "D")
            {
                cbxClient.SelectedIndex = -1;
                cbxFournisseur.SelectedIndex = -1;
                L_Poid.Text = "Tare :";
                L_poidDeux.Text = "Brut :";
                //cbxClient_code.TabIndex = 3;
                //cbxFournisseur_code.TabIndex = 1000;
               
                G_Client.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                G_Fournisseur.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else if (choixType.IsOn == false && choixPosage.EditValue.ToString() == "D")
            {
                cbxClient.SelectedIndex = -1;
                cbxFournisseur.SelectedIndex = -1;
                // cbxClient_code.TabIndex = 1000;
                //cbxFournisseur_code.TabIndex = 3;
              
                L_Poid.Text = "Brut :";
                L_poidDeux.Text = "Tera :";
                G_Client.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                G_Fournisseur.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            if (choixPosage.EditValue.ToString() == "S" && choixType.IsOn)
            {
                G_Client.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                G_Fournisseur.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else if(choixPosage.EditValue.ToString() == "S" && choixType.IsOn==false)
            {
                G_Client.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                G_Fournisseur.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }
        private void BtnPese_Click(object sender, EventArgs e)
        {
            try { 
            int poidE;
            if (pnlManual.Visible == true) poidE = int.Parse(txtPoid.EditValue.ToString());
            else poidE = int.Parse(psPoid.Text);
            //       txtPoid_E.EditValue = txtPoid.EditValue;
            //else  txtPoid_E.EditValue = psPoid.Text;
            if (poidE <  int.Parse(txtTara.EditValue.ToString()) && choixPosage.EditValue.ToString() == "S") { XtraMessageBox.Show("Imposible la tare plus grand de brut?!!", "Message erreur");BtnPese.Focus(); return;}
            txtPoid_E.EditValue = poidE;
            if (choixPosage.EditValue.ToString()=="S")// pesage simple
            {
                SomTareAcc();
            int TotalTare = int.Parse(txtTotAcc.EditValue.ToString()) + int.Parse(txtTara.EditValue.ToString());
            poid(TotalTare, int.Parse(txtPoid_E.EditValue.ToString()));
            }
            else
            {
                int total = int.Parse(txtPoid_E.EditValue.ToString());
                poidRusltat.Text = total.ToString();
            }
        //    clcPrix(decimal.Parse(txtPrix.EditValue.ToString()),decimal.Parse(poidNet.Text) * ((decimal) 0.001), decimal.Parse(rdTVA.EditValue.ToString()));
            BtnSave.Focus();
            }
            catch
            {
                return;
            }
        }

        private void cbxVehcule_code_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                //txtDate.Focus();
            }
            //if (e.KeyCode == Keys.Enter)
            //{
            //cbxVehcule.TabStop=true;

            //}
        }

        private void Pesage_view_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Tab))
            {
                //Save_ENTRIE();
                MessageBox.Show("Save");
            }
        }

       
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try {
                MDI Main = (MDI)Application.OpenForms["MDI"];
                id_op = Main.operateur.ID_Op;
                nom_op = Main.operateur.Nom_Op;
                if (tbLayout.SelectedTabPageIndex == 0)
            { 
            if (cbxVehcule.Text == "") {XtraMessageBox.Show("Matricule champ obligatoir."); return; }
            if (int.Parse(txtPoid_E.EditValue.ToString())  == 0) { XtraMessageBox.Show("Lire le poid SVP ?!"); return; }
           
                if (choixPosage.EditValue.ToString() == "S" && int.Parse(txtTara.EditValue.ToString()) == 0)
                {
                    if (XtraMessageBox.Show("Tare est null  vous voudrais contenu ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                   
                        return;
                    }
                };
                    BtnPese.PerformClick();
                  if (choixPosage.EditValue.ToString() == "S") { Ps_Simple_Save();return; }
                if (gvMat.Text == "") Save_ENTRIE(); else Save_SORTIE();
                    System.Threading.Thread.Sleep(500);
                    Ini_ENTRIE();
                    //System.Threading.Thread.Sleep(500);
                    //BtnFermer.PerformClick();
            }
            else

                {
                //********************* pesage public*******************

                int i = 0;
                if (cbxMat_p.Text == "") { XtraMessageBox.Show("Matricule champ obligatoir."); return; }
                if (int.Parse(txtPoid_public.EditValue.ToString()) == 0) { XtraMessageBox.Show("Lire Poid SVP ?"); return; }
                if (attente_public == false)
                { 

                PesageP pesageP = new PesageP();
                        pesageP.ID_PS = int.Parse(lblNum_public.Text.Split('/')[0]);
                        pesageP.anne_PS = int.Parse(lblNum_public.Text.Split('/')[1]);
                        pesageP.Num_PS = int.Parse(lblNumOrderP.Text);
                        pesageP.ID_Op = id_op;
                        pesageP.Nom_Op = nom_op;
                        pesageP.MAT = cbxMat_p.Text;
                pesageP.Dt_PS = DateTime.Parse(DateTime.Now.ToShortDateString());
                pesageP.Ht_PS = DateTime.Parse(DateTime.Now.ToShortTimeString());
                pesageP.Nom_Type = cbxType.Text;

                pesageP.Prix_Type =decimal.Parse( cbxPrix_public.EditValue.ToString());
                        if (int.Parse(txtPoid2.EditValue.ToString()) == 0) pesageP.attente_PS = true;
                        else {
                            pesageP.attente_PS = false;
                            pesageP.Dts_PS = pesageP.Dt_PS;
                            pesageP.Hts_PS = pesageP.Ht_PS;
                        }
                pesageP.Tare = int.Parse(txtPoid2.EditValue.ToString());
                pesageP.Brut= int.Parse(txtPoid_public.EditValue.ToString());
                pesageP.Net = int.Parse(poidRusltat.Text) ;
                i=  Ps_P.ADD(pesageP);
                if (int.Parse(txtPoid2.EditValue.ToString()) != 0)  Controle.HelperFunctions.print_public(lblNumOrderP.Text);

                }
                else
                {
                    PesageP pesageP = new PesageP();
                  
                    pesageP.ID_PS = int.Parse(lblNum_public.Text.Split('/')[0]);
                    pesageP.anne_PS = int.Parse(lblNum_public.Text.Split('/')[1]);
                    pesageP.Num_PS = int.Parse(lblNumOrderP.Text);
                    pesageP.MAT = cbxMat_p.Text;
                    pesageP.Dts_PS = DateTime.Parse(DateTime.Now.ToShortDateString());
                    pesageP.Hts_PS = DateTime.Parse(DateTime.Now.ToShortTimeString());

                    pesageP.attente_PS = false;
                    int poid2=   int.Parse(txtPoid_public.EditValue.ToString());
                    int   poid1 = int.Parse(txtPoid2.EditValue.ToString());
                    if (poid1 > poid2) {
                        pesageP.Tare = poid2;
                        pesageP.Brut = poid1;
                    }
                    else
                    {
                        pesageP.Tare = poid1;
                        pesageP.Brut = poid2;
                    }
                       
                    pesageP.Net = int.Parse(poidRusltat.Text);
                    i=  Ps_P.update(pesageP);
                    if (i > 0) Controle.HelperFunctions.print_public(lblNumOrderP.Text);
                }
                if (i > 0) InitalPublic();
            }
            }
            catch (Exception ex)
            {
                var lineNumber = new System.Diagnostics.StackTrace(ex, true).GetFrame(0).GetFileLineNumber();
                MessageBox.Show(lineNumber.ToString());
            }
        }
     
            private void BtnNouveu_Click(object sender, EventArgs e)
        {
            
            if (tbLayout.SelectedTabPageIndex == 0)
                Ini_ENTRIE();
            else InitalPublic();        
            
        }
        

        private void txtNB_Palette_EditValueChanged(object sender, EventArgs e)
        {
            txtSomP.EditValue = clcTot(int.Parse(txtNB_Palette.EditValue.ToString()),int.Parse(txtUniteP.EditValue.ToString()));
        }
       private int clcTot(int Nb,int unit )
        {
            int som = Nb * unit;
            return som;
        }

        private void txtNB_Caisse_EditValueChanged(object sender, EventArgs e)
        {
         txtSomC.EditValue = clcTot(int.Parse(txtNB_Caisse.EditValue.ToString()), int.Parse(txtUniteC.EditValue.ToString()));
        }

        private void choixPosage_Toggled(object sender, EventArgs e)
        {
            if (choixPosage.IsOn)
            {
                lblTitre2.Text = "PESEE SIMPLE";
                PrixUni.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                Montant.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                TVA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                MontantTTC.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                tare_Simple.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
               
                //GcNet.Visible = true;
                vehculeAttente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                txtTara.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            }
            else
            {
               
                lblTitre2.Text = "1er PESEE";
                //GcNet.Visible = false;
                //Pnl_Net.Visible = false;
                PrixUni.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                Montant.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                TVA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                MontantTTC.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                tare_Simple.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                vehculeAttente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            cbxVehcule.Focus();
            
        }

       

        private void SomTareAcc()
        {
            try { 
            txtTotAcc.EditValue = int.Parse(txtSomC.EditValue.ToString()) + int.Parse(txtSomP.EditValue.ToString());
           
                //if (choixPosage.EditValue.ToString() == "S" && txtTara.Properties.TextEditStyle == DevExpress.XtraEditors.Controls.TextEditStyles.Standard)
                //{
                //    int poidNET = int.Parse(poidRusltat.Text) - int.Parse(txtTara.EditValue.ToString());
                //    poidNet.Text = poidNET.ToString();
                //    }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSomC_EditValueChanged(object sender, EventArgs e)
        {
           SomTareAcc();
        }

        private void poid(int Tare, int poid)
        {
            poidRusltat.Text = (poid - Tare).ToString();
        }

        private void choixPosage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrix_EditValueChanged(object sender, EventArgs e)
        {
            clcPrix(decimal.Parse(txtPrix.EditValue.ToString()), decimal.Parse(poidNet.Text) * ((decimal)0.001), decimal.Parse( rdTVA.EditValue.ToString()));
           
        }
        private decimal Montant_tot(decimal prix,decimal poid)
        {
            return prix * poid;
        }

       
        private void poidRusltat_Changed(object sender, EventArgs e)
        {
            //if (txtPoid_E.EditValue == 0)
                poidNet.Text = (Math.Abs(poid_Entrees - int.Parse(poidRusltat.Text))).ToString();
               clcPrix(decimal.Parse(txtPrix.EditValue.ToString()), decimal.Parse(poidNet.Text) * ((decimal)0.001), decimal.Parse(rdTVA.EditValue.ToString()));
            //txtMontantHT.EditValue = Montant_tot(decimal.Parse(txtPrix.EditValue.ToString()), int.Parse(poidNet.Text)/1000);
        }

        private void cbxFournisseur_code_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void writeXml()
        {
            System.IO.TextWriter txtWriter = new System.IO.StreamWriter(@"Serialization.xml");

            xs.Serialize(txtWriter, or);

            txtWriter.Close();
        }

        private void txtPrix_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }


        private void txtTara_EditValueChanged(object sender, EventArgs e)
        {
            //if (txtTara.Properties.TextEditStyle == DevExpress.XtraEditors.Controls.TextEditStyles.Standard) SomTareAcc();
        }
      public void client_R()
        {
            cls = client.aff();
            cbxClient.Properties.Items.Clear();
            cbxClient_code.Properties.Items.Clear();
            foreach (var s in cls.OfType<Model.Client>()) { cbxClient.Properties.Items.Add(s.Nom_CL); cbxClient_code.Properties.Items.Add(s.Code_CL); }
        }
        public void veh_R()
        {
            cbxVehcule_code.EditValue = "";
                Vc = vehcule.aff();
                cbxVehcule_code.Properties.Items.Clear();
                cbxVehcule.Properties.Items.Clear();
                //cbxVehcule_code.EditValue = "";

                foreach (var s in Vc.OfType<Vehcule>()) { cbxVehcule_code.Properties.Items.Add(s.ID_VEH); cbxVehcule.Properties.Items.Add(s.MAT_VEH); }
        }
        public void fournisseur_R()
        {
            Frs = fournisseur.aff();
                cbxFournisseur.Properties.Items.Clear();
                cbxFournisseur_code.Properties.Items.Clear();
                foreach (var s in Frs.OfType<Fournisseur>())
                {
                    cbxFournisseur.Properties.Items.Add(s.Nom_FR);
                    cbxFournisseur_code.Properties.Items.Add(s.Code_FR);
                }

}
        public void chauffeur_R()
        {
            cbxChefr.Properties.Items.Clear();
            cbxChefr_code.Properties.Items.Clear();
            ch = chauffeur.aff();
            foreach (var s in ch.OfType<Chauffeur>()) { cbxChefr_code.Properties.Items.Add(s.ID_CH); cbxChefr.Properties.Items.Add(s.Nom_CH); }
        }
         public void produit_R()
        {
            cbxPdt.Properties.Items.Clear();
            cbxPdt_code.Properties.Items.Clear();
            HelperFunctions.combox(cbxPdt, cbxPdt_code, HelperFunctions.Rempli("select * from Produit"), "Designe_PDT", "ID_PDT");
        }
        private void ADD(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            SimpleButton btn =     sender as SimpleButton;
            if (e.Button.Tag == null) return;
            if(e.Button.Tag.ToString()=="v")
            {
                var v = new View.Client.Vehcule_update("N", -1);
                DialogResult result = FlyoutDialog.Show(f, action, v);
           
                if (result == DialogResult.OK) { veh_R(); cbxVehcule.Text = v.txtMAT_VEH.Text; cbxVehcule_code.Focus(); }


            }
            if (e.Button.Tag.ToString() == "f")
            {
                var frs = new View.Client.Fournisseur_update("N", -1);
                DialogResult result = FlyoutDialog.Show(f, action, frs);

               
                if (result == DialogResult.OK) {  fournisseur_R();  cbxFournisseur.Text = frs.txtNom.Text; cbxFournisseur_code.Focus(); }

            }
            if (e.Button.Tag.ToString() == "c")
            {
                var Cls = new View.Client.Client_update("N", -1);
                DialogResult result = CustomFlyoutDialog.ShowForm(f, action, Cls);
                
                if (result == DialogResult.OK) {
                    client_R();
                    cbxClient.Text = Cls.txtNom.Text;cbxClient_code.Focus();
                }
            }
            if (e.Button.Tag.ToString() == "ch")
            {
                var Ch = new View.Client.Chauffeur_update("N", -1);
                DialogResult result = FlyoutDialog.Show(f, action,Ch);
                
                if (result == DialogResult.OK) { chauffeur_R(); cbxChefr.Text = Ch.txtNom.Text; cbxChefr_code.Focus(); }
            }
            if (e.Button.Tag.ToString() == "t")
            {
                DialogResult result = CustomFlyoutDialog.ShowForm(f, action, new View.Client.Transporteur_update("N", -1));
                 trs = transporteur.aff();
                cbxTransporteur.Properties.Items.Clear();
                cbxTransporteur_code.Properties.Items.Clear();
                foreach (var s in trs.OfType<Transporteur>()) { cbxTransporteur.Properties.Items.Add(s.Nom_TR); cbxTransporteur_code.Properties.Items.Add(s.ID_TR); }
            }
            if (e.Button.Tag.ToString() == "P")
            {
                var pr = new View.Client.Produit_update("N", -1);
                DialogResult result = FlyoutDialog.Show(f, action, pr);
               
                if (result == DialogResult.OK) { produit_R(); cbxPdt.Text = pr.txtDesigne_PDT.Text; cbxPdt_code.EditValue =int.Parse(pr.lblNum.Text.Trim()); cbxPdt_code.Focus(); }
            }
            if (e.Button.Tag.ToString() == "d")
            {
                //DialogResult result = CustomFlyoutDialog.ShowForm(f, action, new View.Client.Transporteur_update("N", -1));
            }
            if (e.Button.Tag.ToString() == "D")
            {
                View.type_update destination2 = new type_update();
                destination2.Show();
                //---------DISTINATION--------
                Dst = destination.aff();
                cbxDest.Properties.Items.Clear();
                cbxDest_code.Properties.Items.Clear();
                foreach (var s in Dst.OfType<Destination>()) { cbxDest.Properties.Items.Add(s.Nom_DS); cbxDest_code.Properties.Items.Add(s.ID_DS); }
                //DialogResult result = CustomFlyoutDialog.ShowForm(f, action, new View.Client.Transporteur_update("N", -1));
            }
            if (e.Button.Tag.ToString() == "1")
            {

                Ajout_Vehcule();


            }
           
      

        }
        private void Ajout_Vehcule()
        {

            string VEC = cbxVehcule.Text.Trim();
            Vehcule veh = new Vehcule();
            veh.ID_VEH = vehcule.Max();
            veh.MAT_VEH = cbxVehcule.Text.Trim();
            vehcule.ADD(veh);
            Ps.updateVh(veh.ID_VEH, veh.MAT_VEH);
            cbxVehcule_code.Properties.Items.Clear();
            cbxVehcule.Properties.Items.Clear();
            Vc = vehcule.aff();
            foreach (var s in Vc.OfType<Vehcule>()) { cbxVehcule_code.Properties.Items.Add(s.ID_VEH); cbxVehcule.Properties.Items.Add(s.MAT_VEH); }
            cbxVehcule_code.Text = veh.ID_VEH.ToString();
            cbxVehcule.Text = veh.MAT_VEH;
            //if (gvMat.Text != "")
            //{ 
            Attente = Ps.ATTENTE();
                //Pesage pesage = new Pesage();
                //pesage.ID_PS = int.Parse(txtNumro.Text);
                //pesage.ID_VEH= veh.ID_VEH;
                //pesage.MAT_VEH = veh.MAT_VEH;
                //Ps.update(pesage);
                gvMat.Properties.DataSource = Attente;
            gvMat.Properties.DisplayMember = "MAT_VEH";
            gvMat.Properties.ValueMember = "MAT_VEH";
        //}
        }
        private void cbxVehcule_TextChanged(object sender, EventArgs e)
        {
            try {
                if (gvMat.Text != "") return;
                if (cbxVehcule.Text != "" && cbxVehcule_code.Text == "") cbxVehcule.Properties.Buttons[2].Visible = true; 
            else cbxVehcule.Properties.Buttons[2].Visible = false;


            if (Attente.Any(Pesage => Pesage.MAT_VEH == cbxVehcule.Text.Trim()) && gvMat.Visible==true)
            {
                    //gvMat.EditValue = ;
                    gvMat.Text = cbxVehcule.Text;
                    Ini_SORTIE();
                    ///cbxVehcule.Properties.ReadOnly = true;
                    //cbxVehcule.Properties.Items.Clear();

                    //foreach (var s in Attente.OfType<Pesage>()) { cbxVehcule.Properties.Items.Add(s.MAT_VEH); }



                    txtNB_Caisse.Focus();
                    //return;
                
                }
            else {
                   
                    gvMat.Text = "";
                    //cbxVehcule_code.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    //cbxVehcule.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                    cbxVehcule_code.ReadOnly = false;
                    cbxVehcule.ReadOnly = false;
                    cbxVehcule_code.SelectedIndex = cbxVehcule.SelectedIndex;
                    //cbxVehcule.Properties.ReadOnly = false;
                    //if (cbxVehcule.SelectedIndex != -1) cbxVehcule_code.SelectedIndex = cbxVehcule.SelectedIndex;
                    //               else { cbxVehcule_code.Text = ""; }
                }
                if (cbxVehcule_code.SelectedIndex != -1) txtTara.EditValue = vehcule.Tare(int.Parse(cbxVehcule_code.Text)).ToString(); else txtTara.EditValue =0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           

        }

           
        //1er
        public void Poid_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Right)
            {
                property.SelectedObject = psPoid;
                //menu.Location = e.Location;
                //menu.Show();
                
                menu.ShowPopup(Control.MousePosition);
            }
               
        }
        //2eme
        public void poidEntree_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Right)
            {
                property.SelectedObject = poidRusltat;

                menu.ShowPopup(Control.MousePosition);
            }
        }//3eme
        public void poidNet_MouseDown(object sender, MouseEventArgs e)
        {

            if (f.operateur.Type_Op != 3) return;
            if (e.Button == MouseButtons.Right)
            {
                property.SelectedObject = poidNet;
                menu.ShowPopup(Control.MousePosition);
            }
        }

        private void property_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e)
        {
           //poid 1er
            if (property.SelectedObject == psPoid)
            {
                gcPoid.SaveLayoutToXml(poid_);
            }//poid 2eme
            if (property.SelectedObject == poidRusltat)
            {
               gcEntree.SaveLayoutToXml(poid_Entree);
            }//pod 3eme
            if (property.SelectedObject == poidNet)
            {
               GcNet.SaveLayoutToXml(poid_net);
            }
        }

        

        private void layoutControlGroup2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                property.SelectedObject = layoutControlGroup2;
                menu.ShowPopup(Control.MousePosition);
            }
        }

      
        private void layoutControlGroup1_DoubleClick(object sender, EventArgs e)
        {
       
                property.SelectedObject = layoutControlGroup1;
                menu.ShowPopup(Control.MousePosition);
           
        }

        private void restauration()
        {
            
            ////----- 
            if (File.Exists(poid_)) gcPoid.RestoreLayoutFromXml(poid_);
            if (File.Exists(poid_Entree)) gcEntree.RestoreLayoutFromXml(poid_Entree);
            if (File.Exists(poid_net)) GcNet.RestoreLayoutFromXml(poid_net);
        }

       
        private void cbxVehcule_code_TextChanged(object sender, EventArgs e)
      {
            try
            {
                if (gvMat.Text != "") return;
                if (cbxVehcule.Text != "" && cbxVehcule_code.Text == "") cbxVehcule.Properties.Buttons[2].Visible = true; else cbxVehcule.Properties.Buttons[2].Visible = false; ;
               
                if (cbxVehcule_code.Text == "0")
                {
                    cbxVehcule_code.Text = "";

                    return;
                }
                if (cbxVehcule_code.Text.Trim() == "" && cbxVehcule.Text.Trim() != "")
                {
                    if (Vc.Find(vc => vc.MAT_VEH == cbxVehcule.Text.Trim()).ID_VEH > 0) cbxVehcule.SelectedIndex = -1;
                }
                if (((cbxVehcule_code.Text.Trim() != "" && cbxVehcule.Text.Trim() != "") || (cbxVehcule_code.Text.Trim() != "" && cbxVehcule.Text.Trim() == ""))  )
                {
                    cbxVehcule.SelectedIndex = cbxVehcule_code.SelectedIndex;
                }
            }
            catch (Exception ex)
            {

            }
            
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
                


            }

        private void cbxTransporteur_TextChanged(object sender, EventArgs e)
        {
                if (cbxTransporteur.SelectedIndex != -1) cbxTransporteur_code.SelectedIndex = cbxTransporteur.SelectedIndex;
                else { cbxTransporteur_code.Text = ""; }

                
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
        }

        private void cbxFournisseur_TextChanged(object sender, EventArgs e)
        {
            if (cbxFournisseur.SelectedIndex != -1) cbxFournisseur_code.SelectedIndex = cbxFournisseur.SelectedIndex;
            else { cbxFournisseur_code.Text = ""; }
        }

        private void cbxChefr_TextChanged(object sender, EventArgs e)
        {
            if (cbxChefr.SelectedIndex != -1) cbxChefr_code.SelectedIndex = cbxChefr.SelectedIndex;
            else { cbxChefr_code.Text = ""; }
        }

        private void cbxDest_TextChanged(object sender, EventArgs e)
        {
            if (cbxDest.SelectedIndex != -1) cbxDest_code.SelectedIndex = cbxDest.SelectedIndex;
            else { cbxDest_code.Text = ""; }
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
        }

        private void cbxClient_TextChanged(object sender, EventArgs e)
        {
            if (cbxClient.SelectedIndex != -1) cbxClient_code.SelectedIndex = cbxClient.SelectedIndex;
            else { cbxClient_code.Text = ""; }
        }

       

        private void txtMontantHT_EditValueChanged(object sender, EventArgs e)
        {
            clcPrix(decimal.Parse(txtPrix.EditValue.ToString()), decimal.Parse(poidNet.Text) * ((decimal)0.001), decimal.Parse(rdTVA.EditValue.ToString()));
           
        }

        private void rdTVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            clcPrix(decimal.Parse(txtPrix.EditValue.ToString()), decimal.Parse(poidNet.Text) * ((decimal)0.001), decimal.Parse(rdTVA.EditValue.ToString()));
            
        }

        private void privee_Toggled(object sender, EventArgs e)
        {
            if (privee.IsOn == false) tbLayout.SelectedTabPageIndex = 1;
            else tbLayout.SelectedTabPageIndex = 0;
        }
        List<PesageP> attente_p;
        private void InitalPublic()


        {
            cbxType.Properties.DataSource = null;

            //cbxType.Text = "";
            txtPoid_public.EditValue = 0;
            Manual.IsOn = false;
            //
            lblNum_public.Text = Ps_P.Max().ToString();
            Mat = Ps_P.Mat();
            string annee = (DateTime.Now.Year % 100).ToString();
            lblNum_public.Text = Ps_P.Max().ToString() + "/" + annee;

            lblNumOrderP.Text = Ps_P.MaxOrder().ToString();
            cbxMat_p.Properties.Items.Clear();

            //cbxType.Properties.Items.Clear();
            foreach (var s in Mat.OfType<PesageP>()) { cbxMat_p.Properties.Items.Add(s.MAT); }
            TypVehcule typVehcule = new TypVehcule();
            typVehcule.ID_Type = 0; typVehcule.Nom_Type = ""; typVehcule.Prix_Type = 0;

            typVeh = type.Select();
            typVeh.Add(typVehcule);
            cbxType.Properties.DataSource = typVeh;
            cbxType.Properties.DisplayMember = "Nom_Type";
            cbxType.Properties.ValueMember = "ID_Type";
            //cbxPrix_public.Properties.DataSource = typVeh;
            //cbxPrix_public.Properties.DisplayMember = "Prix_Type";
            //cbxPrix_public.Properties.ValueMember = "Prix_Type";
            //foreach (var s in typVeh.OfType<TypVehcule>()) { cbxType.Properties.Items.Add(s.Nom_Type); cbxCodeType.Properties.Items.Add(s.ID_Type); cbxPrix_public.Properties.Items.Add(s.Prix_Type); }
            attente_p = Ps_P.ATTENTE();
            gdAttente_public.DataSource = attente_p;
            cbxMat_p.EditValue = "";
            //cbxCodeType.se.SelectedIndex = 0;
            txtPoid2.EditValue = 0;
            //cbxPrix_public.SelectedIndex = 0;
            //txtPoid_public.EditValue = 0;
            cbxMat_p.Focus();
            attente_public = false;
            poidRusltat.Text = "0";
            cbxCodeType.EditValue = "";
            cbxType.Text = "";
            cbxPrix_public.EditValue = 0;
        }
        public void refrechi_combox()
        {
            cbxType.Properties.DataSource = null;
            foreach (var s in Mat.OfType<PesageP>()) { cbxMat_p.Properties.Items.Add(s.MAT); }
            TypVehcule typVehcule = new TypVehcule();
            typVehcule.ID_Type = 0; typVehcule.Nom_Type = ""; typVehcule.Prix_Type = 0;

            typVeh = type.Select();
            typVeh.Add(typVehcule);
            cbxType.Properties.DataSource = typVeh;
            cbxType.Properties.DisplayMember = "Nom_Type";
            cbxType.Properties.ValueMember = "ID_Type";
        }

        //private void InitalPublic()


        //{
        //    lblNum_public.Text = Ps_P.Max().ToString();
        //    Mat = Ps_P.Mat();
        //    string annee = (DateTime.Now.Year % 100).ToString();
        //    lblNum_public.Text = Ps_P.Max().ToString() + "/" + annee;

        //    lblNumOrderP.Text = Ps_P.MaxOrder().ToString();
        //    cbxMat_p.Properties.Items.Clear();

        //    //cbxType.Properties.Items.Clear();
        //    foreach (var s in Mat.OfType<PesageP>()) { cbxMat_p.Properties.Items.Add(s.MAT); }
        //    TypVehcule typVehcule = new TypVehcule();
        //    typVehcule.ID_Type = 0; typVehcule.Nom_Type = ""; typVehcule.Prix_Type = 0;

        //    typVeh = type.Select();
        //    typVeh.Add(typVehcule);
        //    typVeh = type.Select();
        //    //cbxCodeType.Properties.DataSource = typVeh;
        //    //cbxCodeType.Properties.DisplayMember = "ID_Type";
        //    //cbxCodeType.Properties.ValueMember= "ID_Type";
        //    cbxType.Properties.DataSource = typVeh;
        //    cbxType.Properties.DisplayMember = "Nom_Type";
        //    cbxType.Properties.ValueMember = "ID_Type";
        //    //cbxPrix_public.Properties.DataSource = typVeh;
        //    //cbxPrix_public.Properties.DisplayMember = "Prix_Type";
        //    //cbxPrix_public.Properties.ValueMember = "Prix_Type";
        //    //foreach (var s in typVeh.OfType<TypVehcule>()) { cbxType.Properties.Items.Add(s.Nom_Type); cbxCodeType.Properties.Items.Add(s.ID_Type); cbxPrix_public.Properties.Items.Add(s.Prix_Type); }
        //    attente_p = Ps_P.ATTENTE();
        //    gdAttente_public.DataSource = attente_p;
        //    cbxMat_p.EditValue = "";
        //    //cbxCodeType.se.SelectedIndex = 0;
        //    txtPoid2.EditValue = 0;
        //    //cbxPrix_public.SelectedIndex = 0;
        //    txtPoid_public.EditValue = 0;
        //    cbxMat_p.Focus();
        //    attente_public = false;
        //    poidRusltat.Text = "0";
        //}
        private void tbLayout_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (tbLayout.SelectedTabPageIndex == 1)
            {
                InitalPublic();
            }
            else
            {
             cbxVehcule.Focus();
            }
        }

        private void txtType_EditValueChanged(object sender, EventArgs e)
        {
            if (cbxCodeType.EditValue.ToString() == "") return;
            var item = typVeh.FirstOrDefault(i => i.ID_Type == int.Parse(cbxCodeType.EditValue.ToString()));

            if (item != null)
            {
                cbxPrix_public.EditValue = item.Prix_Type.ToString();
                cbxType.Text = item.Nom_Type;
            }
            else
            {
                cbxPrix_public.EditValue = 0;
                cbxType.EditValue = 0;
            }

        }

        private void btnValidePoidPublic_Click(object sender, EventArgs e)
        {
            try
            {

                int poid;


                if (Manual.IsOn) poid = int.Parse(txtPoid.Text);
                else poid = int.Parse(psPoid.Text);
                txtPoid_public.EditValue = poid;

                poidRusltat.Text = Math.Abs(int.Parse(txtPoid_public.EditValue.ToString()) - int.Parse(txtPoid2.EditValue.ToString())).ToString();
                BtnSave.Focus();
            }
            catch
            {
                return;
            }
        }
        bool attente_public = false;
        private void cbxMat_p_TextChanged(object sender, EventArgs e)
        {
            if (attente_p.Any(Pesage => Pesage.MAT == cbxMat_p.Text.Trim()))
            {
                PesageP pe = attente_p.Find(pesageP => pesageP.MAT == cbxMat_p.Text.Trim());
                lblNum_public.Text = pe.ID_PS.ToString() + "/" + pe.anne_PS;
               
                lblNumOrderP.Text = pe.Num_PS.ToString();
                cbxType.Text = pe.Nom_Type;
                txtPrix.EditValue = pe.Prix_Type;
                cbxCodeType.EditValue = cbxType.EditValue;
                poid2.Text = "1er Poids";
                txtPoid2.Text = pe.Brut.ToString();
                attente_public = true;
                cbxType.ReadOnly = true;
                cbxCodeType.ReadOnly = true;
                cbxPrix_public.ReadOnly = true;
                txtPoid2.ReadOnly = true;
            }
            else
            {
                string annee = (DateTime.Now.Year % 100).ToString();
                lblNum_public.Text = Ps_P.Max().ToString() + "/" + annee;

                lblNumOrderP.Text = Ps_P.MaxOrder().ToString();
                //refrechi_combox();
                cbxType.Text = string.Empty;
                cbxType.EditValue = 0;



                cbxCodeType.EditValue = string.Empty;
                cbxPrix_public.EditValue = 0;
                txtPoid2.EditValue = 0;
                poid2.Text = "Tare";
                attente_public = false;
                cbxType.ReadOnly = false;
                cbxCodeType.ReadOnly = false;
                cbxPrix_public.ReadOnly = false;
                txtPoid2.ReadOnly = false;
            }
                
            }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbxCodeType.SelectedIndex = cbxType.SelectedIndex;
        }

        

        private void txtPoid2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          //if ((e.KeyData == Keys.Enter))
          //  {
          //      BtnSave.Text = "SAVE";
          //      BtnSave.Focus();
          //  }
        }

        #region
        // 
        // initiale
        public void Ini_ENTRIE()
        {
            cbxVehcule_code.ReadOnly = false;
            cbxVehcule.ReadOnly = false;
            //cbxClient_code.TabIndex = 31;
            //cbxFournisseur_code.TabIndex = 2;
            try
            {
               
                //privee.IsOn = false;
                Manual.IsOn = false;
                tbLayout.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False; ;
                gvMat.Text = "";
                choixType.ReadOnly = false;
                choixPosage.EditValue = "D";
                lblTitre2.Text = "1er PESEE";
                cbxVehcule.Focus();
                PrixUni.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                Montant.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                TVA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                MontantTTC.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                //Sortie.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                ChoixPesage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                impression.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                //BindingSource cls = new BindingSource();
                string annee = (DateTime.Now.Year % 100).ToString();
                txtNumro.Text = Ps.Max().ToString() + "/" + annee;

                lblNumOrder.Text = Ps.MaxOrder().ToString();
                Attente = Ps.ATTENTE();
                gvMat.Properties.DataSource = Attente;
                gvMat.Properties.DisplayMember = "MAT_VEH";
                gvMat.Properties.ValueMember = "MAT_VEH";
                gvMat.Properties.Buttons[1].Visible = false;
                gvMat.Properties.Buttons[2].Visible = false;


                // -----VEHCULE--------
                cbxVehcule_code.EditValue = "";
                Vc = vehcule.aff();
                cbxVehcule_code.Properties.Items.Clear();
                cbxVehcule.Properties.Items.Clear();
                //cbxVehcule_code.EditValue = "";
                foreach (var s in Vc.OfType<Vehcule>()) { cbxVehcule_code.Properties.Items.Add(s.ID_VEH); cbxVehcule.Properties.Items.Add(s.MAT_VEH); }

                //----FOURNISSEUR-----
                cbxFournisseur_code.EditValue = "";
                Frs = fournisseur.aff();
                cbxFournisseur_code.Properties.Items.Clear();
                cbxFournisseur.Properties.Items.Clear();
                
                foreach (var s in Frs.OfType<Fournisseur>())
                {
                    cbxFournisseur.Properties.Items.Add(s.Nom_FR);
                    cbxFournisseur_code.Properties.Items.Add(s.Code_FR);
                }

                //----CLIENT-----
                cbxClient.EditValue = "";
                cls = client.aff();
                cbxClient.Properties.Items.Clear();
                cbxClient_code.Properties.Items.Clear();
                foreach (var s in cls.OfType<Model.Client>()) { cbxClient.Properties.Items.Add(s.Nom_CL); cbxClient_code.Properties.Items.Add(s.Code_CL); }

                //-------TRANSPORTEUR------


                //---------Chauffeur--------1170
                cbxChefr.EditValue = "";
                cbxChefr.Properties.Items.Clear();
                cbxChefr_code.Properties.Items.Clear();
                //cbxChefr_code.EditValue = "";
                ch = chauffeur.aff();
                foreach (var s in ch.OfType<Chauffeur>()) { cbxChefr_code.Properties.Items.Add(s.ID_CH); cbxChefr.Properties.Items.Add(s.Nom_CH); }
                //---------DISTINATION--------
                cbxDest.EditValue = "";
                Dst = destination.aff();
                cbxDest.Properties.Items.Clear();
                cbxDest_code.Properties.Items.Clear();
                foreach (var s in Dst.OfType<Destination>()) { cbxDest.Properties.Items.Add(s.Nom_DS); cbxDest_code.Properties.Items.Add(s.ID_DS); }
                //---------Produit--------
               
                cbxPdt_code.EditValue = "" ;
                cbxPdt.Properties.Items.Clear();
                cbxPdt_code.Properties.Items.Clear();
                 pro =  produit.Select();
                foreach (var s in pro.OfType<Produit>()) { cbxPdt.Properties.Items.Add(s.Designe_PDT); cbxPdt_code.Properties.Items.Add(s.ID_PDT); }
                //HelperFunctions.combox(cbxPdt, cbxPdt_code, HelperFunctions.Rempli("select * from Produit"), "Designe_PDT", "ID_PDT");
                cbxTransporteur.EditValue = "";
                cbxTransporteur.Properties.Items.Clear();
                cbxTransporteur_code.Properties.Items.Clear();
                //cbxTransporteur_code.EditValue = "";
                //cbxTransporteur_code.Text = "";
                trs = transporteur.aff();
               
                foreach (var s in trs.OfType<Transporteur>()) { cbxTransporteur.Properties.Items.Add(s.Nom_TR); cbxTransporteur_code.Properties.Items.Add(s.ID_TR); }
                txtBon.Text = "";
                mNote.Text = "";
                choixType.IsOn = false;

                txtPoid_E.EditValue = 0;
                L_poidDeux.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                txtNB_Caisse.EditValue = 0;
                txtNB_Palette.EditValue = 0;
                txtUniteC.EditValue = 3;
                txtUniteP.EditValue = 30;
                GcNet.Visible = false;
                //cbxClient_code.Text = ""; cbxFournisseur_code.Text = "";
               
              
                //cbxChefr_code.Text = ""; cbxDest_code.Text = "";
              // cbxPdt_code.Text = "";
                ////
                cbxClient.Text = ""; cbxFournisseur.Text = "";
                cbxVehcule.Text = ""; cbxVehcule_code.Text = "";
                //cbxTransporteur.Text = "";
                ////cbxPdt.Text = "";
                cbxChefr.Text = ""; //cbxDest.Text = "";
                txtPrix.EditValue = 0;
                txtMontantHT.EditValue = 0;
                poidRusltat.Text = "0";
                poidNet.Text = "0";
                cbxMat_p.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Save_ENTRIE()
        {
           
            if (cbxVehcule_code.Text.Trim() == "")
            {
                if (XtraMessageBox.Show("vous voudrais ajouter nouveau matricule ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Ajout_Vehcule();
                }
            }

            Pesage pesageDouble = new Pesage();
            int poid;
            if (Manual.IsOn) poid = int.Parse(txtPoid.Text);
            else poid = int.Parse(psPoid.Text);
         
            //------- poid auto ou manual txtPoid
            if (Manual.IsOn) { pesageDouble.Manual = true; }
        
            gvMat.Text = "";
            Attente = Ps.ATTENTE();
            gvMat.Properties.DataSource = Attente;
            gvMat.Properties.DisplayMember = "MAT_VEH";
            //gvMat.Properties.ValueMember = "ID_PS";
            //if (cbxClient.SelectedItem as ComboboxItem).Value.ToString()

            pesageDouble.ID_PS = int.Parse(txtNumro.Text.Split('/')[0]);
            pesageDouble.anne_PS = int.Parse(txtNumro.Text.Split('/')[1]);
            pesageDouble.Num_PS = int.Parse(lblNumOrder.Text);
            pesageDouble.MAT_VEH = cbxVehcule.Text;
            pesageDouble.Nom_FR = cbxFournisseur.Text;
            pesageDouble.Dt_PS = DateTime.Now.Date;
            pesageDouble.Ht_PS = DateTime.Parse(DateTime.Now.ToShortTimeString());
            pesageDouble.Nom_DS = cbxDest.Text;
            pesageDouble.Nom_CL = cbxClient.Text;
            pesageDouble.Nom_TR = cbxTransporteur.Text;
            pesageDouble.Designe_PDT = cbxPdt.Text;
            pesageDouble.Nom_CH = cbxChefr.Text;
            
            pesageDouble.obsevation = mNote.Text;

            pesageDouble.Bon = txtBon.Text;
            pesageDouble.ID_Op = id_op;
            pesageDouble.Nom_Op = nom_op;
            //
            pesageDouble.attente_PS = true;


            if (cbxFournisseur_code.SelectedIndex != -1) pesageDouble.Code_FR = int.Parse(cbxFournisseur_code.EditValue.ToString());
            if (cbxClient_code.SelectedIndex != -1) pesageDouble.Code_CL = int.Parse(cbxClient_code.EditValue.ToString()); ;
            if (cbxVehcule_code.SelectedIndex != -1) pesageDouble.ID_VEH = int.Parse(cbxVehcule_code.EditValue.ToString()); ;
            if (cbxChefr_code.SelectedIndex != -1) pesageDouble.ID_CH = int.Parse(cbxChefr_code.EditValue.ToString());
            if (cbxPdt_code.SelectedIndex != -1) pesageDouble.ID_PDT = int.Parse(cbxPdt_code.EditValue.ToString());
            if (cbxTransporteur_code.SelectedIndex != -1) pesageDouble.ID_TR = int.Parse(cbxTransporteur_code.EditValue.ToString());
            if (cbxDest_code.SelectedIndex != -1) pesageDouble.ID_DS = int.Parse(cbxDest_code.EditValue.ToString());
            pesageDouble.type_Ps = choixPosage.EditValue.ToString();
            pesageDouble.type_MV = choixType.EditValue.ToString();
            pesageDouble.tara_M = false;
            pesageDouble.champ1 = txtChamp1.EditValue.ToString();

            pesageDouble.champ2 = txtChamp2.EditValue.ToString();
            if (choixType.EditValue.ToString() == "E" )
            {
                pesageDouble.Brut = int.Parse(poidRusltat.Text);
                pesageDouble.ACC_Brut = int.Parse(txtTotAcc.EditValue.ToString());
                pesageDouble.Caisse_Brut = int.Parse(txtSomC.EditValue.ToString());
                pesageDouble.Palette_Brut = int.Parse(txtSomP.EditValue.ToString());

                pesageDouble.Caisse_NB_Brut = int.Parse(txtNB_Caisse.EditValue.ToString());
                pesageDouble.Palette_NB_Brut = int.Parse(txtNB_Palette.EditValue.ToString());
                pesageDouble.Caisse_Un_Brut = int.Parse(txtUniteC.EditValue.ToString());
                pesageDouble.Palette_Un_Brut = int.Parse(txtUniteP.EditValue.ToString());
                Ps.ADD_Brut(pesageDouble);
                    }
            else if(choixType.EditValue.ToString() == "S")  {
                pesageDouble.Tare = int.Parse(poidRusltat.Text);
                pesageDouble.ACC_Tare = int.Parse(txtTotAcc.EditValue.ToString());
                pesageDouble.Caisse_Tare = int.Parse(txtSomC.EditValue.ToString());
                pesageDouble.Palette_Tare = int.Parse(txtSomP.EditValue.ToString());

                pesageDouble.Caisse_NB_Tare = int.Parse(txtNB_Caisse.EditValue.ToString());
                pesageDouble.Palette_NB_Tare = int.Parse(txtNB_Palette.EditValue.ToString());
                pesageDouble.Caisse_Un_Tare = int.Parse(txtUniteC.EditValue.ToString());
                pesageDouble.Palette_Un_Tare = int.Parse(txtUniteP.EditValue.ToString());
                Ps.ADD_Tare(pesageDouble);
            }
            
        

         
           


        }

        public void Ini_SORTIE()
        {
            cbxVehcule_code.ReadOnly = true;
            cbxVehcule.ReadOnly = true;
            txtNB_Caisse.Focus();
            GcNet.Visible = true;
            lblTitre2.Text = "2eme PESEE";
            L_poidDeux.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            Sortie.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            ChoixPesage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            impression.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            gvMat.Properties.Buttons[1].Visible = true;
            gvMat.Properties.Buttons[2].Visible = true;
            //Pesage pesage = new Pesage();
            //pesage = Ps.Select(int.Parse(gvMat.EditValue.ToString()));
            Pesage pesage = Attente.FirstOrDefault(x => x.MAT_VEH ==gvMat.EditValue.ToString().Trim());
            //BindingSource cls = new BindingSource();
            gvMat.EditValue = pesage.MAT_VEH;
            gvMat.Text = pesage.MAT_VEH;
            txtNumro.Text = pesage.ID_PS.ToString() + "/" + pesage.anne_PS;
            lblNumOrder.Text = pesage.Num_PS.ToString();
            //lblACC1.Text = pesage.TarAcc_1.ToString();
            choixType.EditValue = pesage.type_MV;
           
           
            choixType.ReadOnly = true;
            //DataTable dt_cls = HelperFunctions.Rempli("select * from Client");
            cbxVehcule.Text = pesage.MAT_VEH;

            if (pesage.Code_CL > 0) cbxClient_code.EditValue = pesage.Code_CL.ToString();

            //if (pesage.ID_TR > 0) cbxTransporteur_code.Text = pesage.ID_TR.ToString(); else cbxTransporteur_code.Text = "";
            //if (pesage.ID_VEH > 0) cbxVehcule_code.Text = pesage.ID_VEH.ToString(); else cbxVehcule_code.Text = "";

            if (pesage.ID_CH > 0) cbxChefr_code.Text = pesage.ID_CH.ToString(); else cbxChefr_code.Text = "";
            //if (pesage.ID_DS > 0) cbxDest_code.Text = pesage.ID_DS.ToString(); else cbxDest_code.Text = "";
            if (pesage.Code_FR > 0) cbxFournisseur_code.Text = pesage.Code_FR.ToString(); else cbxFournisseur_code.Text = "";
            cbxFournisseur.Text = pesage.Nom_FR.Trim();

            //cbxFournisseur_SelectedIndexChanged( cbxFournisseur,  e);
            cbxClient.Text = pesage.Nom_CL.Trim();

            cbxVehcule.EditValue = pesage.MAT_VEH;
            if (pesage.ID_VEH > 0) cbxVehcule_code.EditValue = pesage.ID_VEH.ToString(); else cbxVehcule_code.Text = "";

            //
            cbxTransporteur.Text = pesage.Nom_TR;
            cbxPdt.Text = pesage.Designe_PDT;
            //if (pesage.ID_PDT > 0) cbxPdt_code.EditValue = pesage.ID_PDT.ToString(); else cbxPdt_code.Text = "";
            cbxChefr.Text = pesage.Nom_CH;
            txtBon.Text = pesage.Bon;
            mNote.Text = pesage.obsevation;
            cbxDest.Text = pesage.Nom_DS;
            cbxDest_code.EditValue = pesage.ID_DS;
            txtDeux.EditValue = pesage.Brut.ToString();

            //poid_Entrees = pesage.Brut;

            //
            //prix et montant
            PrixUni.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            Montant.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            TVA.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            MontantTTC.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            txtPrix.EditValue = produit.Prix(pesage.ID_PDT);
            //
            //txtNB_Caisse.EditValue = 0;
            //txtNB_Palette.EditValue = 0;
            //txtUniteC.EditValue = 3;
            //txtUniteP.EditValue = 30;

            poid_Entrees = pesage.Brut + pesage.Tare;
            //txtSomC.EditValue=0;
            //txtSomC.EditValue=0;
            //txtTotAcc.EditValue.ToString());
        }

        private void Save_SORTIE()
        {
            int poid;
            //------- poid auto ou manual

            if (Manual.IsOn) poid = int.Parse(txtPoid.Text);
            else poid = int.Parse(psPoid.Text);
            ///------------------
            Pesage pesageDouble = new Pesage();
            pesageDouble.ID_PS = int.Parse(txtNumro.Text.Split('/')[0]);
            pesageDouble.anne_PS = int.Parse(txtNumro.Text.Split('/')[1]);
            pesageDouble.Num_PS = int.Parse(lblNumOrder.Text);
            pesageDouble.MAT_VEH = cbxVehcule.Text;
            pesageDouble.Nom_FR = cbxFournisseur.Text;
            pesageDouble.Dts_PS = DateTime.Now.Date;
            pesageDouble.Hts_PS = DateTime.Parse(DateTime.Now.ToShortTimeString());
            pesageDouble.Nom_DS = cbxDest.Text;
            pesageDouble.Nom_CL = cbxClient.Text;
            pesageDouble.Nom_CH = cbxChefr.Text;
            pesageDouble.Nom_TR = cbxTransporteur.Text;
            pesageDouble.Designe_PDT = cbxPdt.Text;
            pesageDouble.obsevation = mNote.Text;
            pesageDouble.prix_un =Math.Round( decimal.Parse(txtPrix.EditValue.ToString()),2);
            pesageDouble.Montant = Math.Round(decimal.Parse(txtMontantHT.EditValue.ToString()),2);
            pesageDouble.tva = Math.Round(decimal.Parse(rdTVA.EditValue.ToString()),2);
            pesageDouble.ttc = Math.Round(decimal.Parse(txtMontantTTC.EditValue.ToString()),2);
            //if (choixType.EditValue.ToString() == "E")
            //{
            //    pesageDouble.Tare = int.Parse(poidRusltat.Text);
            //    pesageDouble.Brut = poid_Entrees;
            //    pesageDouble.ACC_Tare = int.Parse(lblACC1.Text);
            //    pesageDouble.ACC_Brut = int.Parse(txtTotAcc.EditValue.ToString());
            //}
            //else if(choixType.EditValue.ToString() == "S")
            //{
            //    pesageDouble.Brut = int.Parse(poidRusltat.Text);
            //    pesageDouble.Tare = poid_Entrees;
            //    pesageDouble.ACC_Brut = int.Parse(lblACC1.Text);
            //    pesageDouble.ACC_Tare = int.Parse(txtTotAcc.EditValue.ToString());
            //}
            //pesage.Brut = poid;
            //    pesage.Tare = poid_Entrees;
            //    pesage.type_MV = "S";

            //}
            //else
            //{
            //  pesage.Tare = int.Parse(psPoid.Text);
            //  pesage.Brut= poid_Entrees;

            //}
            pesageDouble.type_MV = choixType.EditValue.ToString();
            pesageDouble.attente_PS = false;
            pesageDouble.Bon = txtBon.Text;
            pesageDouble.ID_Op = id_op;
            pesageDouble.Nom_Op = nom_op;
            if (cbxFournisseur_code.EditValue.ToString().Trim() != "") pesageDouble.Code_FR = int.Parse(cbxFournisseur_code.EditValue.ToString());
            if (cbxClient_code.EditValue.ToString().Trim() != "") pesageDouble.Code_CL = int.Parse(cbxClient_code.EditValue.ToString()); ;
            if (cbxVehcule_code.EditValue.ToString().Trim()!="") pesageDouble.ID_VEH = int.Parse(cbxVehcule_code.EditValue.ToString()); ;
            if (cbxChefr_code.EditValue.ToString().Trim() != "") pesageDouble.ID_CH = int.Parse(cbxChefr_code.EditValue.ToString());
            if (cbxPdt_code.SelectedIndex != -1)                 pesageDouble.ID_PDT = int.Parse(cbxPdt_code.EditValue.ToString());
            if (cbxTransporteur_code.EditValue.ToString().Trim() != "") pesageDouble.ID_TR = int.Parse(cbxTransporteur_code.EditValue.ToString());
            if (cbxDest_code.EditValue.ToString().Trim() != "") pesageDouble.ID_DS = int.Parse(cbxDest_code.EditValue.ToString());
            //------------

            //PS.type_Ps =  choixPosage.EditValue.ToString();
            //PS.Manual = Manual.IsOn;
            //PS.tara_M = choixTara.IsOn;

            pesageDouble.Net = int.Parse(poidNet.Text);
            pesageDouble.Manual = Manual.IsOn;
            if (choixType.EditValue.ToString() == "S")
            {
                pesageDouble.Brut = int.Parse(poidRusltat.Text);
                pesageDouble.ACC_Brut = int.Parse(txtTotAcc.EditValue.ToString());
                pesageDouble.Caisse_Brut = int.Parse(txtSomC.EditValue.ToString());
                pesageDouble.Palette_Brut = int.Parse(txtSomP.EditValue.ToString());

                pesageDouble.Caisse_NB_Brut = int.Parse(txtNB_Caisse.EditValue.ToString());
                pesageDouble.Palette_NB_Brut = int.Parse(txtNB_Palette.EditValue.ToString());
                pesageDouble.Caisse_Un_Brut = int.Parse(txtUniteC.EditValue.ToString());
                pesageDouble.Palette_Un_Brut = int.Parse(txtUniteP.EditValue.ToString());
                Ps.update_Brut(pesageDouble);
            }
            else if (choixType.EditValue.ToString() == "E")
            {
                pesageDouble.Tare = int.Parse(poidRusltat.Text);
                pesageDouble.ACC_Tare = int.Parse(txtTotAcc.EditValue.ToString());
                pesageDouble.Caisse_Tare = int.Parse(txtSomC.EditValue.ToString());
                pesageDouble.Palette_Tare = int.Parse(txtSomP.EditValue.ToString());

                pesageDouble.Caisse_NB_Tare = int.Parse(txtNB_Caisse.EditValue.ToString());
                pesageDouble.Palette_NB_Tare = int.Parse(txtNB_Palette.EditValue.ToString());
                pesageDouble.Caisse_Un_Tare = int.Parse(txtUniteC.EditValue.ToString());
                pesageDouble.Palette_Un_Tare = int.Parse(txtUniteP.EditValue.ToString());
                Ps.update_Tare(pesageDouble);
            }
            //pesage.Caisse_NB_2 = int.Parse(txtNB_Caisse.EditValue.ToString());
            //pesage.Palette_NB_2 = int.Parse(txtNB_Palette.EditValue.ToString());
            //pesage.Caisse_Un_2 = int.Parse(txtUniteC.EditValue.ToString());
            //pesage.Palette_Un_2 = int.Parse(txtUniteP.EditValue.ToString());
            //pesage.TarAcc_2 = int.Parse(txtTotAcc.EditValue.ToString());
            //pesage.Tare_Caisse_2 = int.Parse(txtSomC.EditValue.ToString());
            //pesage.Tare_Palette_2 = int.Parse(txtSomP.EditValue.ToString());
            //pesage.champ1 = txtChamp1.EditValue.ToString();
            //pesage.champ2 = txtChamp2.EditValue.ToString();
            //Ps.update(pesage);

         if(choixType.EditValue.ToString()=="E")     Controle.HelperFunctions.print_fr(lblNumOrder.Text);
         else Controle.HelperFunctions.print_cl(lblNumOrder.Text);
            BtnFermer.PerformClick();
        }


        private void clcPrix(decimal prixUntaire,decimal poid_tonne,decimal TVA )
        {
            decimal HT,  TTC;
            HT = prixUntaire * poid_tonne;
            TTC = HT * TVA + HT;
            txtMontantHT.EditValue = HT;
            txtMontantTTC.EditValue = TTC;

        }








        #endregion

        private void txtPoid2_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void gvAttente_public_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           if( e.Column.ColumnEditName== "rpSup")
            {
                if (XtraMessageBox.Show("  vous voudrais  supprimer pesage ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    PesageP pesageP = new PesageP();
                    pesageP.attente_PS = false;
                    pesageP.ID_PS = int.Parse(gvAttente_public.GetFocusedRowCellDisplayText(colNum).ToString());
                    int index = Ps_P.updateAttente(pesageP);
                    if (index == 1) XtraMessageBox.Show("N° "+ pesageP.ID_PS.ToString()+" est Supprime la liste Attente");
                    attente_p = Ps_P.ATTENTE();
                    gdAttente_public.DataSource = attente_p;
                }
            }
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }

        private void sp_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (!sp.IsOpen) return;
                sp.DiscardOutBuffer();
                System.Threading.Thread.Sleep(vettesse);
                string data = sp.ReadExisting();

                // Display the text to the user in the terminal
                Log(data);
            }
            catch (Exception ex)
            {

                return;
            }
        }

        private void Pesage_view_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pnlPrincipal_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void gcPoid_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
         private void Ps_Simple_Save()
        {

            Pesage pesage = new Pesage();
            int poid;
           


            if (Manual.IsOn) poid = int.Parse(txtPoid.Text);
            else poid = int.Parse(psPoid.Text);
            //------- poid auto ou manual txtPoid
            if (Manual.IsOn) { pesage.Manual = true; }
     
            pesage.ID_PS = int.Parse(txtNumro.Text.Split('/')[0]);
            pesage.anne_PS = int.Parse(txtNumro.Text.Split('/')[1]);
            pesage.Num_PS = int.Parse(lblNumOrder.Text);
            pesage.MAT_VEH = cbxVehcule.Text;
            pesage.Nom_FR = cbxFournisseur.Text;
            pesage.Dt_PS = DateTime.Now.Date;
            pesage.Ht_PS = DateTime.Parse(DateTime.Now.ToShortTimeString());
            pesage.Nom_DS = cbxDest.Text;
            pesage.Nom_CL = cbxClient.Text;
            pesage.Nom_TR = cbxTransporteur.Text;
            pesage.Designe_PDT = cbxPdt.Text;
            pesage.Nom_CH = cbxChefr.Text;

            pesage.obsevation = mNote.Text;

            pesage.Bon = txtBon.Text;
            pesage.ID_Op = id_op;
            pesage.Nom_Op = nom_op;
            //



            if (cbxFournisseur_code.SelectedIndex != -1) pesage.Code_FR = int.Parse(cbxFournisseur_code.EditValue.ToString());
            if (cbxClient_code.SelectedIndex != -1) pesage.Code_CL = int.Parse(cbxClient_code.EditValue.ToString()); ;
            if (cbxVehcule_code.SelectedIndex != -1) pesage.ID_VEH = int.Parse(cbxVehcule_code.EditValue.ToString()); ;
            if (cbxChefr_code.SelectedIndex != -1) pesage.ID_CH = int.Parse(cbxChefr_code.EditValue.ToString());
            if (cbxPdt_code.SelectedIndex != -1) pesage.ID_PDT = int.Parse(cbxPdt_code.EditValue.ToString());
            if (cbxTransporteur_code.SelectedIndex != -1) pesage.ID_TR = int.Parse(cbxTransporteur_code.EditValue.ToString());
            if (cbxDest_code.SelectedIndex != -1) pesage.ID_DS = int.Parse(cbxDest_code.EditValue.ToString());
            pesage.type_Ps = choixPosage.EditValue.ToString();
            pesage.type_MV = choixType.EditValue.ToString();
           
             pesage.attente_PS = false;
          
                //if (cbxVehcule.Text == "") { XtraMessageBox.Show("Matricule champ obligatoir."); return; }
                pesage.attente_PS = false;
                pesage.Hts_PS = pesage.Ht_PS;
                pesage.Dts_PS = pesage.Dt_PS;
                pesage.Tare = int.Parse(txtTara.EditValue.ToString());
                 pesage.Brut = poid;
                pesage.Net =int.Parse(poidRusltat.Text) ;
                pesage.prix_un = decimal.Parse(txtPrix.EditValue.ToString());
                pesage.Montant = decimal.Parse(txtMontantHT.EditValue.ToString());
                pesage.ACC_Brut = int.Parse(txtTotAcc.EditValue.ToString());
           

            //
            pesage.tara_M = true;
            pesage.Caisse_NB_Brut = int.Parse(txtNB_Caisse.EditValue.ToString());
            pesage.Palette_NB_Brut = int.Parse(txtNB_Palette.EditValue.ToString());
            pesage.Caisse_Un_Brut = int.Parse(txtUniteC.EditValue.ToString());
            pesage.Palette_Un_Brut = int.Parse(txtUniteP.EditValue.ToString());
            pesage.ACC_Brut = int.Parse(txtTotAcc.EditValue.ToString());
            pesage.Caisse_Brut = int.Parse(txtSomC.EditValue.ToString());
            pesage.Palette_Brut = int.Parse(txtSomP.EditValue.ToString());
            //pesage.Caisse_Un_Tare=
            pesage.champ1 = txtChamp1.EditValue.ToString();
            pesage.champ2 = txtChamp2.EditValue.ToString();
            pesage.tva = decimal.Parse(rdTVA.EditValue.ToString());
            pesage.ttc = decimal.Parse(txtMontantTTC.EditValue.ToString());
            Ps.ADD_Simple(pesage);

            if (choixType.EditValue.ToString() == "E") Controle.HelperFunctions.print_fr(lblNumOrder.Text);
            else Controle.HelperFunctions.print_cl(lblNumOrder.Text);
            Ini_ENTRIE();
        }

        private void cbxType_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           if(e.Button.Index == 1)
            {
                type_update2 veh = new type_update2();
                veh.Show();
            }
        }

        private void cbxCodeType_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void cbxCodeType_Enter(object sender, EventArgs e)
        {
           
        }

        private void cbxCodeType_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void cbxType_EditValueChanged(object sender, EventArgs e)
        {

            var item = typVeh.FirstOrDefault(i => i.ID_Type == int.Parse(cbxType.EditValue.ToString()));

            if (item != null)
            {
                if (item.ID_Type == 0) { cbxCodeType.EditValue = ""; return; }
                cbxPrix_public.EditValue = item.Prix_Type;
                cbxCodeType.EditValue = item.ID_Type;
            }
        }

        private void cbxPrix_public_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxCodeType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPoid2.Focus();
            }
        }

        private void cbxType_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                type_update2 veh = new type_update2();
                veh.Show();
            }
        }

        private void BtnImpression_Click(object sender, EventArgs e)
        {
            if (choixType.EditValue.ToString() == "E") Controle.HelperFunctions.print_fr_Att(lblNumOrder.Text);
            else Controle.HelperFunctions.print_cl_Att(lblNumOrder.Text);
        }
    }
}
            
    
    

