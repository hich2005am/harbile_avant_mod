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
using System.Management;
using Microsoft.Win32;

namespace DSM
{
    public partial class proctection : DevExpress.XtraEditors.XtraForm
    {
        public proctection()
        {
            InitializeComponent();
           tbPro.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        private void proctection_Load(object sender, EventArgs e)
        {
            string cleEssai = Read("cle essai");
           
            if (cleEssai != null)
            {
                txtSerial.Text = cleEssai;
                SKGL.Validate validate = new SKGL.Validate();
                validate.secretPhase = "123";
                validate.Key = txtSerial.Text;
                if(validate.IsValid)
                txtStatus.Text = "Creation date: " + validate.CreationDate + "\r\n" + "Expire date: " + validate.ExpireDate + "\r\n" + "Day left: " + validate.DaysLeft;
            }
                tbPro.SelectedTabPageIndex = 0;
           
            // Get HDD hardware code
          
           
            string cle = Read("key");
            txtSerialNumber.Text = cle;
        }


       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VALIDE_Click(object sender, EventArgs e)
        {
            if (txtSerialNumber.Text.Trim() != "") {
            
            string cle= (DateTime.Now.Day * DateTime.Now.Month * DateTime.Now.Year * 9).ToString();
                if (cle==txtSerialNumber.Text.Trim()) {
                Write("key", cle);
                XtraMessageBox.Show("Operation est Effectue.");
                Application.Restart();
                }
                else XtraMessageBox.Show("Serial incorrect");

            }
            else XtraMessageBox.Show("rempli champ de cle SVP !?");
        }

        private void privee_Toggled(object sender, EventArgs e)
        {
            if (privee.IsOn) tbPro.SelectedTabPageIndex = 1; else tbPro.SelectedTabPageIndex = 0;
        }

        private void BtnValidEssai_Click(object sender, EventArgs e)
        {
            try {
            if (txtSerial.Text.Trim() != "") {
            SKGL.Validate validate = new SKGL.Validate();
            validate.secretPhase = "123";
            validate.Key = txtSerial.Text;
            txtStatus.Text = "";
            if (validate.IsValid && validate.IsExpired==false)
            {
              txtStatus.Text = "Creation date: " + validate.CreationDate + "\r\n" + "Expire date: " + validate.ExpireDate + "\r\n" + "Nombre de Jours: " + validate.DaysLeft;
               Write("cle essai", txtSerial.Text);
                XtraMessageBox.Show("Operation est Effectue.");
            } else if(validate.IsValid==false) XtraMessageBox.Show("Cle est invalide.");
            else if(validate.IsExpired) XtraMessageBox.Show("Cle est Expiree.");


            }
            else XtraMessageBox.Show("rempli champ de cle SVP !?");
            }catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            //Write("mot passe", "123");


        }
        public string Read(string keyName)
        {
            string subKey = "SOFTWARE\\" + Application.ProductName.ToUpper();

            RegistryKey sk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subKey);
            if (sk == null)
                return null;
            else
                return sk.GetValue(keyName.ToUpper()).ToString();
        }

        /// <summary>
        /// This C# code writes a key to the windows registry.
        /// </summary>
        /// <param name="keyName">
        /// <param name="value">
        public void Write(string keyName, string value)
        {
            string subKey = "SOFTWARE\\" + Application.ProductName.ToUpper();

            RegistryKey sk1 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subKey);
            sk1.SetValue(keyName.ToUpper(), value);
        }

       

        private void BtnAnnulerEssai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}