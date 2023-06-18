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
    public partial class Client_update : DevExpress.XtraEditors.XtraUserControl
    {
        string btn;
        int lign;
        Client_ctr cs = new Client_ctr();
        public Client_update(string btn,int lign)
        {
            InitializeComponent();
            this.btn = btn;
            this.lign = lign;
        }

        private void Client_update_Load(object sender, EventArgs e)
        {
            /*INFO.ClearErrors()*/;
           
            if (btn == "V")
            {
                //lblNum.
                Model.Client client;
                client = cs.Select(lign);
                txtCode.EditValue = client.Code_CL;
                lblNum.Text = client.ID_CL.ToString();
                txtNom.Text = client.Nom_CL;
                txtCNIE.Text = client.CNIE_CL;
                txtTel.Text = client.Tel_CL;
                txtNote.Text = client.Fax_CL;
                txtAdresse.Text = client.Adr_CL;
                BtnSave.Enabled = false;
            }
            else if (btn == "N")
            {
                int i = 0;
                 i =  cs.Max();
               
                lblNum.Text = i.ToString();
                txtCode.EditValue = i;
                BtnSave.Enabled = true;
                txtNom.Focus();
            }
            else if (btn == "M")
            {
                Model.Client client;
                client = cs.Select(lign);
                txtCode.EditValue = client.Code_CL;
                lblNum.Text = client.ID_CL.ToString();
                txtNom.Text = client.Nom_CL;
                txtCNIE.Text = client.CNIE_CL;
                txtTel.Text = client.Tel_CL;
                txtNote.Text = client.Fax_CL;
                txtAdresse.Text = client.Adr_CL;
                BtnSave.Enabled = true;
            }
        }
        private void BtnSave_(object sender, EventArgs e)
        {
            //if (dxValidationProvider1.Validate() == false) return;
            MDI f = (MDI)Application.OpenForms["MDI"];
            int vrais=0;
           
            if (txtNom.Text == "") {  XtraMessageBox.Show("Champ Nom Client obligtoir"); return; }
            if (btn == "N")
            {
                List<Model.Client> cl = cs.Select2();
                if (cs.recherche(int.Parse(txtCode.Text), cl) == true) { MessageBox.Show("deja utilise code client"); return; }
                var client=     new Model.Client();
                client.ID_CL = int.Parse(lblNum.Text);
               client.Code_CL = int.Parse(txtCode.EditValue.ToString());
                client.Nom_CL=txtNom.Text.Trim()  ;
               client.CNIE_CL= txtCNIE.Text  ;
               client.Tel_CL =txtTel.Text  ;
               client.Fax_CL  = txtNote.Text ;
               client.Adr_CL =  txtAdresse.Text ;
                 vrais =   cs.ADD(client);
               
               
              
            }
            else if (btn == "M")
            {
                var client = new Model.Client();
                client.ID_CL =int.Parse(lblNum.Text);
                client.Code_CL  = int.Parse(txtCode.EditValue.ToString());

                txtCode.ReadOnly = true;
                client.Nom_CL = txtNom.Text.Trim();
                client.CNIE_CL = txtCNIE.Text;
                client.Tel_CL = txtTel.Text;
                client.Fax_CL = txtNote.Text;
                client.Adr_CL = txtAdresse.Text;
                 vrais  = cs.update(client);


             
            }
            if (vrais == 1)
            {
               
                FlyoutDialog dlg = this.Parent as FlyoutDialog;
                dlg.DialogResult = DialogResult.OK;
              
                dlg.Close();

            }

        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {

        }
    }
}