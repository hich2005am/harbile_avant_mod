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
    public partial class Fournisseur_update : DevExpress.XtraEditors.XtraUserControl
    {
        string btn;
        int lign;
       Fournisseur_ctr    Fr = new Fournisseur_ctr();
        public Fournisseur_update(string btn,int lign)
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
                Model.Fournisseur fournisseur;
                fournisseur = Fr.Select(lign);
                lblNum.Text = fournisseur.ID_FR.ToString();
                txtCode.EditValue = fournisseur.Code_FR;
                txtNom.Text = fournisseur.Nom_FR;
                txtCNIE.Text = fournisseur.CNIE_FR;
                txtTel.Text = fournisseur.Tel_FR;
                txtType.Text = fournisseur.Fax_FR;
                txtAdresse.Text = fournisseur.Adr_FR;
                BtnSave.Enabled = false;
            }
            else if (btn == "N")
            {
                int i = 0;
                 i =  Fr.Max();
               
                lblNum.Text = i.ToString();
                txtCode.EditValue = i;
                BtnSave.Enabled = true;
               
            }
            else if (btn == "M")
            {
                Model.Fournisseur fournisseur;
                fournisseur = Fr.Select(lign);
                txtCode.EditValue = fournisseur.Code_FR;
                txtCode.ReadOnly = true;
                lblNum.Text = fournisseur.ID_FR.ToString();
                txtNom.Text = fournisseur.Nom_FR;
                txtCNIE.Text = fournisseur.CNIE_FR;
                txtTel.Text = fournisseur.Tel_FR;
                txtType.Text = fournisseur.Fax_FR;
                txtAdresse.Text = fournisseur.Adr_FR;
                BtnSave.Enabled = true;
            }
        }
        private void BtnSave_(object sender, EventArgs e)
        {
            MDI f = (MDI)Application.OpenForms["MDI"];
            int vrais=0;
           
            if (txtNom.Text == "") {  XtraMessageBox.Show("Champ Nom Fournissuer obligtoir"); return; }
            if (btn == "N")
            {
                List<Model.Fournisseur> cl = Fr.Select2();
                if (Fr.recherche(int.Parse(txtCode.Text), cl) == true) { MessageBox.Show("deja utilise code Fournisseur"); return; }
                var fournisseur=     new Model.Fournisseur();
                fournisseur.ID_FR = int.Parse(lblNum.Text);
                fournisseur.Code_FR =int.Parse( txtCode.EditValue.ToString());
                fournisseur.Nom_FR=txtNom.Text.Trim()  ;
                fournisseur.CNIE_FR= txtCNIE.Text  ;
                fournisseur.Tel_FR = txtTel.Text  ;
                fournisseur.Fax_FR = txtType.Text ;
                fournisseur.Adr_FR =  txtAdresse.Text ;
                 vrais =   Fr.ADD(fournisseur);
               
               
              
            }
            else if (btn == "M")
            {
                var fournisseur = new Model.Fournisseur();
                fournisseur.ID_FR =int.Parse(lblNum.Text);
                fournisseur.Code_FR = int.Parse(txtCode.EditValue.ToString()); 
                fournisseur.Nom_FR = txtNom.Text.Trim();
                fournisseur.CNIE_FR = txtCNIE.Text;
                fournisseur.Tel_FR = txtTel.Text;
                fournisseur.Fax_FR = txtType.Text;
                fournisseur.Adr_FR = txtAdresse.Text;
                 vrais  = Fr.update(fournisseur);


             
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