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
    public partial class Chauffeur_update : DevExpress.XtraEditors.XtraUserControl
    {
        string btn;
        int lign;
          Chauffeur_ctr        cs = new Chauffeur_ctr();
        public Chauffeur_update(string btn,int lign)
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
                Model.Chauffeur chauffeur;
                chauffeur = cs.Select(lign);
                lblNum.Text = chauffeur.ID_CH.ToString();
                txtNom.Text = chauffeur.Nom_CH;
                txtCNIE.Text = chauffeur.CNIE_CH;
                txtTel.Text = chauffeur.Tel_CH;
                txtAdresse.Text = chauffeur.Adr_CH;
                txtNote.Text = chauffeur.NOTE_CH;
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
                Model.Client client;
                Model.Chauffeur chauffeur;
                chauffeur = cs.Select(lign);
                lblNum.Text = chauffeur.ID_CH.ToString();
                txtNom.Text = chauffeur.Nom_CH;
                txtCNIE.Text = chauffeur.CNIE_CH;
                txtTel.Text = chauffeur.Tel_CH;

                txtAdresse.Text = chauffeur.Adr_CH;
                txtNote.Text = chauffeur.NOTE_CH;
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
               var chauffeur=     new Model.Chauffeur();
               chauffeur.ID_CH = int.Parse(lblNum.Text);
               chauffeur.Nom_CH=txtNom.Text  ;
               chauffeur.CNIE_CH= txtCNIE.Text  ;
               chauffeur.Tel_CH =txtTel.Text  ;
               //chauffeur.Fax_CH  = txtType.Text ;
               chauffeur.Adr_CH =  txtAdresse.Text ;
               chauffeur.NOTE_CH =txtNote.Text  ;
                vrais =   cs.ADD(chauffeur);
               
               
              
            }
            else if (btn == "M")
            {
                var chauffeur = new Model.Chauffeur();
                chauffeur.ID_CH =int.Parse(lblNum.Text);
                chauffeur.Nom_CH = txtNom.Text;
                chauffeur.CNIE_CH = txtCNIE.Text;
                chauffeur.Tel_CH = txtTel.Text;
                //chauffeur.Fax_CL = txtType.Text;
                chauffeur.Adr_CH = txtAdresse.Text;
                chauffeur.NOTE_CH = txtNote.Text;
                vrais  = cs.update(chauffeur);


             
            }
            if (vrais == 1) BtnSave.DialogResult = DialogResult.OK;
             
        }

        
      

      

       
    }
}