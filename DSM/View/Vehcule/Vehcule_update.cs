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
using DSM.Model;
using DSM.Controle;
using DevExpress.XtraBars.Docking2010.Customization;

namespace DSM.View.Client
{
    public partial class Vehcule_update : DevExpress.XtraEditors.XtraUserControl
    {
        string btn;
        int lign;
      Vehcule_ctr cs = new Vehcule_ctr();
        public Vehcule_update(string btn,int lign)
        {
            InitializeComponent();
            this.btn = btn;
            this.lign = lign;
        }

        private void Client_update_Load(object sender, EventArgs e)
        {
            INFO.ClearErrors();
            if (btn == "V")
            {
                //lblNum.
                Model.Vehcule vehcule;
                vehcule = cs.Select(lign);
                lblNum.Text = vehcule.ID_VEH.ToString();
                txtTYPE_VEH.Text = vehcule.TYPE_VEH;
                txtMAT_VEH.Text = vehcule.MAT_VEH;
                txtMarque_VEH.Text = vehcule.Marque_VEH;
                txtNote_VEH.Text = vehcule.Note_VEH;
                txtTAR_VEH.EditValue = vehcule.TAR_VEH;
                BtnSave.Enabled = false;
            }
            else if (btn == "N")
            {
                int i = 0;
                 i =  cs.Max();
               
                lblNum.Text = i.ToString();
              
                BtnSave.Enabled = true;
               
            }
            else if (btn == "M")
            {
                Model.Vehcule vehcule;
                vehcule = cs.Select(lign);
                lblNum.Text = vehcule.ID_VEH.ToString();
                txtTYPE_VEH.Text = vehcule.TYPE_VEH;
                txtMAT_VEH.Text = vehcule.MAT_VEH;
                txtMarque_VEH.Text = vehcule.Marque_VEH;
                txtNote_VEH.Text = vehcule.Note_VEH;
                txtTAR_VEH.EditValue = vehcule.TAR_VEH;
                BtnSave.Enabled = true;
            }
        }
        private void BtnSave_(object sender, EventArgs e)
        {
            MDI f = (MDI)Application.OpenForms["MDI"];
            int vrais=0;
           
            if (txtMAT_VEH.Text == "") {  XtraMessageBox.Show("Champ Matricule obligtoir"); return; }
            if (btn == "N")
            {
                List<Vehcule> cl = cs.Select();
                if (cs.recherche(txtMAT_VEH.Text, cl) == true) { MessageBox.Show("deja utilise Matricule"); return; }
                var vehcule =     new Model.Vehcule();
                vehcule.ID_VEH = int.Parse(lblNum.Text);
                vehcule.TYPE_VEH=txtTYPE_VEH.Text  ;
                vehcule.MAT_VEH= txtMAT_VEH.Text.Trim();
                vehcule.Marque_VEH =txtMarque_VEH.Text  ;
                vehcule.Note_VEH  = txtNote_VEH.Text ;
                vehcule.TAR_VEH = int.Parse( txtTAR_VEH.EditValue.ToString()) ;
                 vrais =   cs.ADD(vehcule);
               
               
              
            }
            else if (btn == "M")
            {
                var vehcule = new Model.Vehcule();
                vehcule.ID_VEH = int.Parse(lblNum.Text);
                vehcule.TYPE_VEH = txtTYPE_VEH.Text;
                vehcule.MAT_VEH = txtMAT_VEH.Text.Trim();
                vehcule.Marque_VEH = txtMarque_VEH.Text;
                vehcule.Note_VEH = txtNote_VEH.Text;
                vehcule.TAR_VEH = int.Parse(txtTAR_VEH.EditValue.ToString());
                vrais  = cs.update(vehcule);


             
            }
            if (vrais == 1)
            {

                FlyoutDialog dlg = this.Parent as FlyoutDialog;
                dlg.DialogResult = DialogResult.OK;

                dlg.Close();

            }

        }

        
      

      

       
    }
}