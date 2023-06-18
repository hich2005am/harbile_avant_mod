using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSM.Controle
{
    public static class HelperFunctions
    {
        static XRDesignMdiController mdiController;


        public static string MachineGUID
        {
            get
            {
                Guid guidMachineGUID;
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32))
                using (var key = hklm.OpenSubKey(@"Software\DSM"))
                {
                    // key now points to the 64-bit key
                }
                //if (Environment.Is64BitOperatingSystem)

                    if (Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Wow6432node\\" + Application.ProductName.ToUpper()) != null)
                {
                    if (Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\" + Application.ProductName.ToUpper()).GetValue("key") != null)
                    {
                        guidMachineGUID = new Guid(Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\" + Application.ProductName.ToUpper()).GetValue("key").ToString());
                        return guidMachineGUID.ToString();
                    }
                }
                return null;
            }
        }
        //public static string cle_permanente(string RequestCode)
        //{

        //    //return ;
        //}


        public static void image(DevExpress.XtraEditors.Controls.ImageSlider imageSlider)
        {
            //imageSlider1.AllowLooping = true;
            //imageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Backward;
            //System.Drawing.Image img;
            //if (File.Exists(@"design\img\Slider\1.jpg"))
            //    img.ft.Save()
            //imageSlider1.Images.Add(img.)
            string[] files = Directory.GetFiles(@"img\Slider\", "*.jpg");

            for (int i = 0; i < files.Length; i++)
            {
                imageSlider.Images.Add(System.Drawing.Image.FromFile(files[i]));
            }
            //string[] files1 = Directory.GetFiles(@"img\img_1\", "*.jpg");
            //string[] files2 = Directory.GetFiles(@"img\img_2\", "*.jpg");

            // if (files1.Length!=0)     pc_pub_1.Image = System.Drawing.Image.FromFile(files1[0]);
            //if (files2.Length != 0) pc_pub_2.Image = System.Drawing.Image.FromFile(files2[0]);
        }

        //}


        public static string GetHDDSerialNumber()
        {
            string outs = "";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                string a = queryObj["PNPDeviceID"].ToString();

                if (a.Substring(0, 3) != "USB")
                    outs = (queryObj["PNPDeviceID"]).ToString();
            }

            string s = "";
            foreach (char t in outs)
            {
                int i;
                if (int.TryParse(t.ToString(), out i))
                    s += t.ToString();
            }

            return s;
        }



        public static string Read(string keyName)
        {
            try
            {

            
            string subKey;
            RegistryKey sk;

            subKey = "SOFTWARE\\" + Application.ProductName.ToUpper();
            if (Environment.Is64BitOperatingSystem)
            {
                var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                sk = hklm.OpenSubKey(subKey);
            }
            else sk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subKey);





            if (sk == null)
                return null;
            else
                return sk.GetValue(keyName.ToUpper()).ToString();

        }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void Write(string keyName, string value)
        {
            string subKey = "SOFTWARE\\" + Application.ProductName.ToUpper();

            RegistryKey sk1 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
            sk1.SetValue(keyName.ToUpper(), value);
        }
        public static void combox(ComboBoxEdit cbx1, ComboBoxEdit cbx2, DataTable liste, string ChampNom, string champValue)
        {

            for (int i = 0; i < liste.Rows.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = liste.Rows[i][ChampNom].ToString();
                item.Value = liste.Rows[i][champValue].ToString();
                cbx1.Properties.Items.Add(item);

                cbx2.Properties.Items.Add(liste.Rows[i][champValue].ToString());
            }


        }


        public static DataTable Rempli(string sql)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                DataTable table = new DataTable();

                var list = con.ExecuteReader(sql);
                table.Load(list);
                return table;
            }
            catch
            {
                throw;
            }
        }
        static string pathImpresion = @"design\impression\poid.repx";
        static string path_fr = @"design\impression\TICKET_Fr.repx";
        static string path_cl = @"design\impression\TICKET_Cl.repx";
        static string path_fr_att = @"design\impression\TICKET_Fr_Att.repx";
        static string path_cl_att = @"design\impression\TICKET_Cl_Att.repx";
        static string path_public = @"design\impression\TICKET_Public.repx";
        public static void print_fr(string Num_PS = null)
        {

            XtraReport rp = XtraReport.FromFile(path_fr, true);
            string add = "";
            if (Num_PS != null)
            {
                add = "where Num_PS=" + Num_PS;
                rp.Parameters[0].Value = int.Parse(Num_PS);
                rp.Parameters[0].Visible = false;
            }
            string sql = @"SELECT Pesage.Num_PS AS [N° Order],Pesage.anne_PS AS [Annee], Pesage.ID_PS AS [N° PESAGE], Pesage.Dt_PS AS [DATE ENTREE], Pesage.Ht_PS AS [HEUR ENTREE],
                                  Pesage.Hts_PS AS [HEUR SORTIE], Pesage.Dts_PS AS [DATE SORTIE], Pesage.Tare+ Pesage.ACC_Tare AS [TARE PESAGE], Pesage.Brut+Pesage.ACC_Brut AS [Brut PESAGE], Pesage.Net AS [POID NET],
                                  Pesage.Nom_CL AS [NOM CLIENT], Pesage.ID_CL AS [N° CLIENT], Pesage.Designe_PDT AS PRODUIT, Pesage.ID_PDT AS [N° PRODUIT], Pesage.ID_Op AS [N° OPERATEUR], Pesage.ID_TR AS [N° TRANSPORTEUR ], Pesage.Nom_TR AS TRANSPORTEUR, Pesage.ID_VEH AS [N° VEHCULE], Pesage.MAT_VEH AS MATRICULE, Pesage.ID_CH AS [N° CHAUFFEUR], Pesage.Nom_CH AS [NOM CHAUFFEUR], Pesage.ID_FR AS [N° FOURNISSEUR], Pesage.Nom_FR AS FOURNISSEUR, Pesage.Nom_DS AS DESTINATION, Pesage.ID_DS AS [N° DESTINATION], Pesage.Bon AS [N° Bon], Pesage.obsevation AS [NOTE],
                                  Pesage.ACC_Tare AS [ACCESOIR TARA], Pesage.ACC_Brut AS [ACCESOIR BRUT], Pesage.prix_un AS [PRIX UNITAIRE], Pesage.Montant AS [MONTANT HT],Pesage.ttc AS [MONTANT TTC],Pesage.tva AS [TVA],
                                  Pesage.Caisse_Un_Tare,Pesage.Palette_Un_Tare,Caisse_NB_Brut,Palette_NB_Brut,Caisse_NB_Tare,Palette_NB_Tare,Pesage.ID_FR AS [CODE FOURNISSUER], Pesage.Nom_FR AS [NOM FOURNISSEUR]
                    FROM Pesage  " + add;


            DataTable TICKET2 = new DataTable();
            TICKET2 = Controle.HelperFunctions.Rempli(sql);
            TICKET2.TableName = "TICKET_Fr";
            //adapter.Fill(TICKET2);

            rp.DisplayName = "TICKET_Fr";
            //rp.Name= "TICKET";
            //rp.LoadLayout("TICKET.repx");
            rp.DataSource = TICKET2;
            if (Num_PS != null)
            {
                //rp.ShowRibbonPreview();
                rp.ShowPreview();
                return;
            }
            // Create a design form and get its MDI controller.
            XRDesignForm form = new XRDesignForm();
            mdiController = form.DesignMdiController;

            // Handle the DesignPanelLoaded event of the MDI controller,
            // to override the SaveCommandHandler for every loaded report.
            mdiController.DesignPanelLoaded += new DesignerLoadedEventHandler(mdiController_DesignPanelLoaded);

            // Open an empty report in the form.
            mdiController.OpenReport(rp);


            form.ShowDialog();

            if (mdiController.ActiveDesignPanel != null)
            {
                mdiController.ActiveDesignPanel.CloseReport();
            }
            void mdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e)
            {
                XRDesignPanel panel = (XRDesignPanel)sender;
                panel.AddCommandHandler(new SaveCommandHandler(panel));
            }
            
    }
        public static void print_cl(string Num_PS = null)
        {

            XtraReport rp = XtraReport.FromFile(path_cl, true);
            string add = "";
            if (Num_PS != null)
            {
                add = "where Num_PS=" + Num_PS;
                rp.Parameters[0].Value = int.Parse(Num_PS);
                rp.Parameters[0].Visible = false;
            }
            string sql = @"SELECT Pesage.Num_PS AS [N° Order],Pesage.anne_PS AS [Annee], Pesage.ID_PS AS [N° PESAGE], Pesage.Dt_PS AS [DATE ENTREE], Pesage.Ht_PS AS [HEUR ENTREE],
                                  Pesage.Hts_PS AS [HEUR SORTIE], Pesage.Dts_PS AS [DATE SORTIE], Pesage.Tare+ Pesage.ACC_Tare AS [TARE PESAGE], Pesage.Brut+Pesage.ACC_Brut AS [Brut PESAGE], Pesage.Net AS [POID NET],
                                  Pesage.Nom_CL AS [NOM CLIENT], Pesage.ID_CL AS [N° CLIENT], Pesage.Designe_PDT AS PRODUIT, Pesage.ID_PDT AS [N° PRODUIT], Pesage.ID_Op AS [N° OPERATEUR], Pesage.ID_TR AS [N° TRANSPORTEUR ], Pesage.Nom_TR AS TRANSPORTEUR, Pesage.ID_VEH AS [N° VEHCULE], Pesage.MAT_VEH AS MATRICULE, Pesage.ID_CH AS [N° CHAUFFEUR], Pesage.Nom_CH AS [NOM CHAUFFEUR], Pesage.ID_FR AS [N° FOURNISSEUR], Pesage.Nom_FR AS FOURNISSEUR, Pesage.Nom_DS AS DESTINATION, Pesage.ID_DS AS [N° DESTINATION], Pesage.Bon AS [N° Bon], Pesage.obsevation AS [NOTE],
                                  Pesage.ACC_Tare AS [ACCESOIR TARA], Pesage.ACC_Brut AS [ACCESOIR BRUT], Pesage.prix_un AS [PRIX UNITAIRE], Pesage.Montant AS [MONTANT HT],Pesage.ttc AS [MONTANT TTC],Pesage.tva AS [TVA],
                                  Pesage.Caisse_Un_Tare,Pesage.Palette_Un_Tare,Caisse_NB_Brut,Palette_NB_Brut,Caisse_NB_Tare,Palette_NB_Tare,Pesage.ID_FR AS [CODE FOURNISSUER], Pesage.Nom_FR AS [NOM FOURNISSEUR]
                    FROM Pesage  " + add;


            DataTable TICKET2 = new DataTable();
            TICKET2 = Controle.HelperFunctions.Rempli(sql);
            TICKET2.TableName = "TICKET_Cl";
            //adapter.Fill(TICKET2);

            rp.DisplayName = "TICKET_Cl";
            //rp.Name= "TICKET";
            //rp.LoadLayout("TICKET.repx");
            rp.DataSource = TICKET2;
            if (Num_PS != null)
            {
                //rp.ShowRibbonPreview();
                rp.ShowPreview();
                return;
            }
            // Create a design form and get its MDI controller.
            XRDesignForm form = new XRDesignForm();
            mdiController = form.DesignMdiController;

            // Handle the DesignPanelLoaded event of the MDI controller,
            // to override the SaveCommandHandler for every loaded report.
            mdiController.DesignPanelLoaded += new DesignerLoadedEventHandler(mdiController_DesignPanelLoaded);

            // Open an empty report in the form.
            mdiController.OpenReport(rp);


            form.ShowDialog();

            if (mdiController.ActiveDesignPanel != null)
            {
                mdiController.ActiveDesignPanel.CloseReport();
            }
            void mdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e)
            {
                XRDesignPanel panel = (XRDesignPanel)sender;
                panel.AddCommandHandler(new SaveCommandHandler(panel));
            }

        }
        public static void print_public(string Num_PS = null)
        {

            XtraReport rp = XtraReport.FromFile(path_public, true);
            string add = "";
            if (Num_PS != null)
            {
                add = "where Num_PS=" + Num_PS;
                rp.Parameters[0].Value = int.Parse(Num_PS);
                rp.Parameters[0].Visible = false;
            }
            string sql = @"SELECT ID_PS AS [N° PESAGE],anne_PS AS [Annee],Dt_PS AS [DATE ENTREE],
                                    Ht_PS AS [HEUR ENTREE],Hts_PS AS [HEUR SORTIE],
                                    Dts_PS AS [DATE SORTIE], Tare AS [TARE PESAGE],
                                    Brut AS [Brut PESAGE], Net AS [POID NET], 
                                    ID_Op AS [N° OPERATEUR],MAT AS MATRICULE,
                                    Prix_Type AS [PRIX UNITAIRE],Nom_Type 

                                    FROM PesageP " + add;


            DataTable TICKET2 = new DataTable();
            TICKET2 = Controle.HelperFunctions.Rempli(sql);
            TICKET2.TableName = "TICKET_Public";
            //adapter.Fill(TICKET2);

            rp.DisplayName = "TICKET_Public";
            //rp.Name= "TICKET";
            //rp.LoadLayout("TICKET.repx");
            rp.DataSource = TICKET2;
            if (Num_PS != null)
            {
                rp.ShowPreview();
                return;
            }
            // Create a design form and get its MDI controller.
            XRDesignForm form = new XRDesignForm();
            mdiController = form.DesignMdiController;

            // Handle the DesignPanelLoaded event of the MDI controller,
            // to override the SaveCommandHandler for every loaded report.
            mdiController.DesignPanelLoaded += new DesignerLoadedEventHandler(mdiController_DesignPanelLoaded);

            // Open an empty report in the form.
            mdiController.OpenReport(rp);


            form.ShowDialog();

            if (mdiController.ActiveDesignPanel != null)
            {
                mdiController.ActiveDesignPanel.CloseReport();
            }
            void mdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e)
            {
                XRDesignPanel panel = (XRDesignPanel)sender;
                panel.AddCommandHandler(new SaveCommandHandler(panel));
            }

        }
        public static void print_Poid(int NUM)
        {

            XtraReport rp = XtraReport.FromFile(pathImpresion, true);
         
            
            //DataTable TICKET2 = new DataTable();
            //TICKET2 = Controle.HelperFunctions.Rempli(sql);
            //TICKET2.TableName = "TICKET";
            //adapter.Fill(TICKET2);

            rp.DisplayName = "poid";
            rp.Name= "poid";
            //rp.LoadLayout("TICKET.repx");
            //rp.DataSource = TICKET2;
            if (NUM >= 0)
            {
                rp.Parameters[0].Value = DateTime.Now;
                rp.Parameters[1].Value = NUM;
                rp.Parameters[0].Visible = false;
                rp.Parameters[1].Visible = false;
                rp.ShowRibbonPreview();
                return;
            }
            // Create a design form and get its MDI controller.
            XRDesignForm form = new XRDesignForm();
            mdiController = form.DesignMdiController;

            // Handle the DesignPanelLoaded event of the MDI controller,
            // to override the SaveCommandHandler for every loaded report.
            mdiController.DesignPanelLoaded += new DesignerLoadedEventHandler(mdiController_DesignPanelLoaded);

            // Open an empty report in the form.
            mdiController.OpenReport(rp);


            form.ShowDialog();

            if (mdiController.ActiveDesignPanel != null)
            {
                mdiController.ActiveDesignPanel.CloseReport();
            }
            void mdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e)
            {
                XRDesignPanel panel = (XRDesignPanel)sender;
                panel.AddCommandHandler(new SaveCommandHandler(panel));
            }

        }

       

        class SaveCommandHandler : DevExpress.XtraReports.UserDesigner.ICommandHandler
        {
            XRDesignPanel panel;

            public SaveCommandHandler(XRDesignPanel panel)
            {
                this.panel = panel;
            }

            public void HandleCommand(DevExpress.XtraReports.UserDesigner.ReportCommand command,
            object[] args)
            {
                // Save the report.
                Save();
            }

            public bool CanHandleCommand(DevExpress.XtraReports.UserDesigner.ReportCommand command,
            ref bool useNextHandler)
            {
                useNextHandler = !(command == ReportCommand.SaveFile || command == ReportCommand.SaveAll ||
                    command == ReportCommand.SaveFileAs);
                return !useNextHandler;
            }

            void Save()
            {
                // Write your custom saving here.
                // ...
               
                // For instance:
            if(    panel.Report.DisplayName == "TICKET_Fr")
                {
                 
                  panel.Report.SaveLayout(path_fr, false);
                }else
                if (panel.Report.DisplayName == "TICKET_Cl")
                {

                    panel.Report.SaveLayout(path_cl, false);
                }else
                if (panel.Report.DisplayName == "TICKET_Cl_Att")
                {

                    panel.Report.SaveLayout(path_cl_att, false);
                }
                else
                if (panel.Report.DisplayName == "TICKET_FR_Att")
                {

                    panel.Report.SaveLayout(path_fr_att, false);
                }

                else if (panel.Report.DisplayName == "poid")
                {
                    panel.Report.SaveLayout(pathImpresion, false);
                }
                else
                {
                 panel.Report.SaveLayout(path_public, false);
                }
               

                // Prevent the "Report has been changed" dialog from being shown.
                panel.ReportState = ReportState.Saved;

            }
        }


        //------------------------ Liste attente
        public static void print_fr_Att(string Num_PS = null)
        {

            XtraReport rp = XtraReport.FromFile(path_fr_att, true);
            string add = "";
            if (Num_PS != null)
            {
                add = "where Num_PS=" + Num_PS;
                rp.Parameters[0].Value = int.Parse(Num_PS);
                rp.Parameters[0].Visible = false;
            }
            string sql = @"SELECT Pesage.Num_PS AS [N° Order],Pesage.anne_PS AS [Annee], Pesage.ID_PS AS [N° PESAGE], Pesage.Dt_PS AS [DATE ENTREE], Pesage.Ht_PS AS [HEUR ENTREE],
                                  Pesage.Hts_PS AS [HEUR SORTIE], Pesage.Dts_PS AS [DATE SORTIE], Pesage.Tare+ Pesage.ACC_Tare AS [TARE PESAGE], Pesage.Brut+Pesage.ACC_Brut AS [Brut PESAGE], Pesage.Net AS [POID NET],
                                  Pesage.Nom_CL AS [NOM CLIENT], Pesage.ID_CL AS [N° CLIENT], Pesage.Designe_PDT AS PRODUIT, Pesage.ID_PDT AS [N° PRODUIT], Pesage.ID_Op AS [N° OPERATEUR], Pesage.ID_TR AS [N° TRANSPORTEUR ], Pesage.Nom_TR AS TRANSPORTEUR, Pesage.ID_VEH AS [N° VEHCULE], Pesage.MAT_VEH AS MATRICULE, Pesage.ID_CH AS [N° CHAUFFEUR], Pesage.Nom_CH AS [NOM CHAUFFEUR], Pesage.ID_FR AS [N° FOURNISSEUR], Pesage.Nom_FR AS FOURNISSEUR, Pesage.Nom_DS AS DESTINATION, Pesage.ID_DS AS [N° DESTINATION], Pesage.Bon AS [N° Bon], Pesage.obsevation AS [NOTE],
                                  Pesage.ACC_Tare AS [ACCESOIR TARA], Pesage.ACC_Brut AS [ACCESOIR BRUT], Pesage.prix_un AS [PRIX UNITAIRE], Pesage.Montant AS [MONTANT HT],Pesage.ttc AS [MONTANT TTC],Pesage.tva AS [TVA],
                                  Pesage.Caisse_Un_Tare,Pesage.Palette_Un_Tare,Caisse_NB_Brut,Palette_NB_Brut,Caisse_NB_Tare,Palette_NB_Tare,Pesage.ID_FR AS [CODE FOURNISSUER], Pesage.Nom_FR AS [NOM FOURNISSEUR]
                    FROM Pesage  " + add;


            DataTable TICKET2 = new DataTable();
            TICKET2 = Controle.HelperFunctions.Rempli(sql);
            TICKET2.TableName = "TICKET_Fr_Att";
            //adapter.Fill(TICKET2);

            rp.DisplayName = "TICKET_Fr_Att";
            //rp.Name= "TICKET";
            //rp.LoadLayout("TICKET.repx");
            rp.DataSource = TICKET2;
            if (Num_PS != null)
            {
                //rp.ShowRibbonPreview();
                rp.ShowPreview();
                return;
            }
            // Create a design form and get its MDI controller.
            XRDesignForm form = new XRDesignForm();
            mdiController = form.DesignMdiController;

            // Handle the DesignPanelLoaded event of the MDI controller,
            // to override the SaveCommandHandler for every loaded report.
            mdiController.DesignPanelLoaded += new DesignerLoadedEventHandler(mdiController_DesignPanelLoaded);

            // Open an empty report in the form.
            mdiController.OpenReport(rp);


            form.ShowDialog();

            if (mdiController.ActiveDesignPanel != null)
            {
                mdiController.ActiveDesignPanel.CloseReport();
            }
            void mdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e)
            {
                XRDesignPanel panel = (XRDesignPanel)sender;
                panel.AddCommandHandler(new SaveCommandHandler(panel));
            }

        }
        public static void print_cl_Att(string Num_PS = null)
        {

            XtraReport rp = XtraReport.FromFile(path_cl_att, true);
            string add = "";
            if (Num_PS != null)
            {
                add = "where Num_PS=" + Num_PS;
                rp.Parameters[0].Value = int.Parse(Num_PS);
                rp.Parameters[0].Visible = false;
            }
            string sql = @"SELECT Pesage.Num_PS AS [N° Order],Pesage.anne_PS AS [Annee], Pesage.ID_PS AS [N° PESAGE], Pesage.Dt_PS AS [DATE ENTREE], Pesage.Ht_PS AS [HEUR ENTREE],
                                  Pesage.Hts_PS AS [HEUR SORTIE], Pesage.Dts_PS AS [DATE SORTIE], Pesage.Tare+ Pesage.ACC_Tare AS [TARE PESAGE], Pesage.Brut+Pesage.ACC_Brut AS [Brut PESAGE], Pesage.Net AS [POID NET],
                                  Pesage.Nom_CL AS [NOM CLIENT], Pesage.ID_CL AS [N° CLIENT], Pesage.Designe_PDT AS PRODUIT, Pesage.ID_PDT AS [N° PRODUIT], Pesage.ID_Op AS [N° OPERATEUR], Pesage.ID_TR AS [N° TRANSPORTEUR ], Pesage.Nom_TR AS TRANSPORTEUR, Pesage.ID_VEH AS [N° VEHCULE], Pesage.MAT_VEH AS MATRICULE, Pesage.ID_CH AS [N° CHAUFFEUR], Pesage.Nom_CH AS [NOM CHAUFFEUR], Pesage.ID_FR AS [N° FOURNISSEUR], Pesage.Nom_FR AS FOURNISSEUR, Pesage.Nom_DS AS DESTINATION, Pesage.ID_DS AS [N° DESTINATION], Pesage.Bon AS [N° Bon], Pesage.obsevation AS [NOTE],
                                  Pesage.ACC_Tare AS [ACCESOIR TARA], Pesage.ACC_Brut AS [ACCESOIR BRUT], Pesage.prix_un AS [PRIX UNITAIRE], Pesage.Montant AS [MONTANT HT],Pesage.ttc AS [MONTANT TTC],Pesage.tva AS [TVA],
                                  Pesage.Caisse_Un_Tare,Pesage.Palette_Un_Tare,Caisse_NB_Brut,Palette_NB_Brut,Caisse_NB_Tare,Palette_NB_Tare,Pesage.ID_FR AS [CODE FOURNISSUER], Pesage.Nom_FR AS [NOM FOURNISSEUR]
                    FROM Pesage  " + add;


            DataTable TICKET2 = new DataTable();
            TICKET2 = Controle.HelperFunctions.Rempli(sql);
            TICKET2.TableName = "TICKET_Cl_Att";
            //adapter.Fill(TICKET2);

            rp.DisplayName = "TICKET_Cl_Att";
            //rp.Name= "TICKET";
            //rp.LoadLayout("TICKET.repx");
            rp.DataSource = TICKET2;
            if (Num_PS != null)
            {
                //rp.ShowRibbonPreview();
                rp.ShowPreview();
                return;
            }
            // Create a design form and get its MDI controller.
            XRDesignForm form = new XRDesignForm();
            mdiController = form.DesignMdiController;

            // Handle the DesignPanelLoaded event of the MDI controller,
            // to override the SaveCommandHandler for every loaded report.
            mdiController.DesignPanelLoaded += new DesignerLoadedEventHandler(mdiController_DesignPanelLoaded);

            // Open an empty report in the form.
            mdiController.OpenReport(rp);


            form.ShowDialog();

            if (mdiController.ActiveDesignPanel != null)
            {
                mdiController.ActiveDesignPanel.CloseReport();
            }
            void mdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e)
            {
                XRDesignPanel panel = (XRDesignPanel)sender;
                panel.AddCommandHandler(new SaveCommandHandler(panel));
            }

        }
    }


}

