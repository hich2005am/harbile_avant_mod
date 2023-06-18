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
    public partial class Produit_update : DevExpress.XtraEditors.XtraUserControl
    {
        string btn;
        int lign;
       Produit_ctr cs = new Produit_ctr();
        public Produit_update(string btn,int lign)
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
                Model.Produit produit;
                produit = cs.Select(lign);
                lblNum.Text = produit.ID_PDT.ToString();
                txtdescription_PDT.Text = produit.description_PDT;
                txtDesigne_PDT.Text = produit.Designe_PDT;
                txtprixUnitaire_PDT.EditValue =produit.prixUnitaire_PDT;
                 txtQtInitial_PDT.EditValue = produit.QtInitial_PDT;
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
                Model.Produit produit;
                produit = cs.Select(lign);
                lblNum.Text = produit.ID_PDT.ToString();
                txtdescription_PDT.Text = produit.description_PDT;
                txtDesigne_PDT.Text = produit.Designe_PDT;
                txtprixUnitaire_PDT.EditValue = produit.prixUnitaire_PDT;
                txtQtInitial_PDT.EditValue = produit.QtInitial_PDT;
                BtnSave.Enabled = true;
            }
        }
        private void BtnSave_(object sender, EventArgs e)
        {
            MDI f = (MDI)Application.OpenForms["MDI"];
            int vrais=0;
           
            if (txtDesigne_PDT.Text == "") {  XtraMessageBox.Show("Champ Nom produit obligtoir"); return; }
            if (btn == "N")
            {
                 var produit=     new Model.Produit();
                produit.ID_PDT = int.Parse(lblNum.Text);
                produit.description_PDT=txtdescription_PDT.Text  ;
               produit.Designe_PDT= txtDesigne_PDT.Text  ;
               produit.prixUnitaire_PDT =decimal.Parse( txtprixUnitaire_PDT.EditValue.ToString())  ;
               
               produit.QtInitial_PDT = int.Parse( txtQtInitial_PDT.EditValue.ToString() );
                 vrais =   cs.ADD(produit);
               
               
              
            }
            else if (btn == "M")
            {
                var produit = new Model.Produit();
                produit.ID_PDT = int.Parse(lblNum.Text);
                produit.description_PDT = txtdescription_PDT.Text;
                produit.Designe_PDT = txtDesigne_PDT.Text;
                produit.prixUnitaire_PDT = decimal.Parse(txtprixUnitaire_PDT.EditValue.ToString());

                produit.QtInitial_PDT = int.Parse(txtQtInitial_PDT.EditValue.ToString());
                vrais  = cs.update(produit);


             
            }
            //if (vrais == 1)
            //{
            //    //BtnSave.DialogResult = DialogResult.OK;
            //    BtnSave.DialogResult = DialogResult.Cancel;
            //    //MessageBox.Show(vrais.ToString());
            //}

        }

        
      

      

       
    }
}