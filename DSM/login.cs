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
using DSM.Model;

namespace DSM
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        
        Operateur_ctr op = new Operateur_ctr();
        public login()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {
            cmxUser.Properties.DataSource = op.Select();
            cmxUser.Properties.DisplayMember = "User_Op";
            cmxUser.Properties.ValueMember = "User_Op";
        }
        private void txtMtp_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                proctection proctection = new proctection();

                aff(); return;
                //var a = Microsoft.Win32.Registry.GetValue("SOFTWARE\\" + Application.ProductName.ToUpper(), "key");
                string cleEssai = "";

                //string HHD = HelperFunctions.cle_permanente();
                //if (HelperFunctions.Read("key") != null) cle = HelperFunctions.Read("key"); else HelperFunctions.Write("key", "");
                //if (HelperFunctions.Read("cle essai") != null) cleEssai = HelperFunctions.Read("cle essai"); else HelperFunctions.Write("cle essai", "");
                //----cas key full
                if (HelperFunctions.Read("key") != null)
                {
                    aff();
                    return;
                }
                //----cas key null
                if (HelperFunctions.Read("key") == null)
                {
                    if (HelperFunctions.Read("cle essai") == null)
                    {
                       
                        this.Hide();
                        proctection.Show();
                        return;
                    }

                    if (HelperFunctions.Read("cle essai") != null)
                    {

                        SKGL.Validate validate = new SKGL.Validate();
                        validate.secretPhase = "123";
                        validate.Key = HelperFunctions.Read("cle essai");
                        if (validate.IsValid && validate.IsExpired == false)
                        {
                            aff();
                            return;
                        }
                        else
                        {

                            this.Hide();
                            if (validate.IsValid == false)
                            {
                                XtraMessageBox.Show(" serial invalide. ");
                                this.Hide();
                                proctection proctection2 = new proctection();
                                proctection2.Show();
                                return;
                            }
                            if (validate.IsExpired)
                            {
                                XtraMessageBox.Show("la date est expirée.  ");
                                this.Hide();
                                proctection.Show();
                            }

                        }
                    }
                  
                }

               
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
               
            }
           
        }

        public int GetLineNumber(Exception ex)
        {
            var lineNumber = 0;
            const string lineSearch = ":line ";
            var index = ex.StackTrace.LastIndexOf(lineSearch);
            if (index != -1)
            {
                var lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length);
                if (int.TryParse(lineNumberText, out lineNumber))
                {
                }
            }
            return lineNumber;
        }
        private void aff()
{
    if (op.trouver(cmxUser.Text.Trim(), txtMtp.Text.Trim()) == 1)
    {
        Operateur operateur = op.login(cmxUser.Text.Trim(), txtMtp.Text.Trim());
        this.Hide();
        MDI f = new MDI(operateur);
        f.Show();
            } else
        
           
            {
                XtraMessageBox.Show("aucun trouver");
            }
} 
        private void BtnFermer_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
}
    
}