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
namespace DSM.View.Client
{
    public partial class Transporteur_update : DevExpress.XtraEditors.XtraUserControl
    {
        string btn;
        int lign;
     Transporteur_ctr    cs = new Transporteur_ctr();
        public Transporteur_update(string btn,int lign)
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
                Model.Transporteur transporteur;
                transporteur = cs.Select(lign);
                lblNum.Text = transporteur.ID_TR.ToString();
                txtNom.Text = transporteur.Nom_TR;
                txtCNIE.Text = transporteur.CNIE_TR;
                txtTel.Text = transporteur.Tel_TR;
                txtNote.Text = transporteur.Note_TR;
                txtAdresse.Text = transporteur.Adr_TR;
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
                Model.Transporteur transporteur;
                transporteur = cs.Select(lign);
                lblNum.Text = transporteur.ID_TR.ToString();
                txtNom.Text = transporteur.Nom_TR;
                txtCNIE.Text = transporteur.CNIE_TR;
                txtTel.Text = transporteur.Tel_TR;
                txtNote.Text = transporteur.Note_TR;
                txtAdresse.Text = transporteur.Adr_TR;
                BtnSave.Enabled = true;
            }
        }
        private void BtnSave_(object sender, EventArgs e)
        {
            MDI f = (MDI)Application.OpenForms["MDI"];
            int vrais=0;
           
            if (txtNom.Text == "") {  XtraMessageBox.Show("Champ Nom Client obligtoir"); return; }
            if (btn == "N")
            {
                 var transporteur=     new Model.Transporteur();
                transporteur.ID_TR = int.Parse(lblNum.Text);
                transporteur.Nom_TR = txtNom.Text  ;
               transporteur.CNIE_TR = txtCNIE.Text  ;
               transporteur.Tel_TR = txtTel.Text  ;
               transporteur.Note_TR = txtNote.Text ;
               transporteur.Adr_TR =  txtAdresse.Text ;
                 vrais =   cs.ADD(transporteur);
               
               
              
            }
            else if (btn == "M")
            {
                var transporteur = new Model.Transporteur();
                transporteur.ID_TR =int.Parse(lblNum.Text);
                transporteur.Nom_TR = txtNom.Text;
                transporteur.CNIE_TR = txtCNIE.Text;
                transporteur.Tel_TR = txtTel.Text;
                transporteur.Note_TR = txtNote.Text;
                transporteur.Adr_TR = txtAdresse.Text;
                 vrais  = cs.update(transporteur);


             
            }
            if (vrais == 1) BtnSave.DialogResult = DialogResult.OK;
             
        }

        
      

      

       
    }
}