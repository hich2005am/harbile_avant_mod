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

namespace DSM
{
    public partial class Path : DevExpress.XtraEditors.XtraForm
    {
        public Path()
        {
            InitializeComponent();
        }
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        
         private void Path_Load(object sender, EventArgs e)
        {
            txtSauvgarde.Text = DSM.Properties.Settings.Default.Sauvgarde;
            txtDatabase.Text = DSM.Properties.Settings.Default.BD;
            chActiveSauvgarde.Checked= Properties.Settings.Default.ActiveSauvgarde;
        }

        private void Sauvgarde_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string CurrentDatabasePath = Environment.CurrentDirectory + @"\Database3.accdb";
            //fbd2.RootFolder = Environment.CurrentDirectory.ToString();

            string path = "";
            
            if (fbd.ShowDialog() == DialogResult.OK)

            {

                path = fbd.SelectedPath.ToString();
                txtSauvgarde.Text = path;
                

            }
        }

         private void BD_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string path = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                path = openFileDialog1.FileName.ToString();
                txtDatabase.Text = path;
                //File.Copy(CurrentDatabasePath, PathtobackUp + @"\BackUp.accdb", true);

                //MessageBox.Show("Back Up SuccessFull! ");

            }
        }

        private void chActiveSauvgarde_CheckedChanged(object sender, EventArgs e)
        {
            if (chActiveSauvgarde.Checked) Properties.Settings.Default.ActiveSauvgarde = true;
            else Properties.Settings.Default.ActiveSauvgarde = false;
        }

    private void BtnSave_Click(object sender, EventArgs e)
        {
            try { 
             DSM.Properties.Settings.Default.Sauvgarde=txtSauvgarde.Text;
             DSM.Properties.Settings.Default.BD =txtDatabase.Text;
               
            DSM.Properties.Settings.Default.Save();
                DSM.Properties.Settings.Default.Reload();
                DSM.Properties.Settings.Default.Upgrade();
                //this.Close();
                (System.Diagnostics.Process.GetCurrentProcess()).Kill();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      private void BtnAnnuler_Click(object sender, EventArgs e)
        {           
            this.Close();
        }
     

      
    }
}