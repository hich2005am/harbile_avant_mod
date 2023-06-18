using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Reflection;

namespace DSM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try { 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName =Properties.Settings.Default.ApplicationSkinName;
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinMaskColor = Properties.Settings.Default.SkinMaskColor;
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinMaskColor2 = Properties.Settings.Default.SkinMaskColor2;
                BonusSkins.Register();
            
            //UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
               //Application.Run(new proctection());
                //Application.Run(new MDI(1));
                //Application.Run(new View.type_update2());
                //Application.Run(new  ParaSerie());
                Application.Run(new login());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
