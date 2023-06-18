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
    public partial class Operateur_update : DevExpress.XtraEditors.XtraUserControl
    {
        string btn;
        int lign;
        MDI f = (MDI)Application.OpenForms["MDI"];
        Operateur_ctr     cs = new Operateur_ctr();
        public Operateur_update(string btn,int lign)
        {
            InitializeComponent();
            this.btn = btn;
            this.lign = lign;
        }

        private void Client_update_Load(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { rol = "Admin", Type = 1 });
            people.Add(new Person { rol = "Operateur", Type = 2 });
            people.Add(new Person { rol = "Gardien", Type = 4 });
            txtRol.Properties.DataSource = people;
            txtRol.Properties.DisplayMember = "rol";
            txtRol.Properties.ValueMember = "Type";
            INFO.ClearErrors();
            if (btn == "V")
            {
                //lblNum.
                Model.Operateur  operateur;
                operateur = cs.Select(lign);
                lblID_Op.Text = operateur.ID_Op.ToString();
                txtNom.Text = operateur.Nom_Op;
                txtUser.Text = operateur.User_Op;
                txtEtat.Checked = operateur.Etat_Op;
                txtRol.EditValue = operateur.Type_Op;
                txtMotPasse.Text = operateur.Password_Op;
                BtnSave.Enabled = false;
            }
            else if (btn == "N")
            {
                int i = 0;
                 i =  cs.Max();
               
                lblID_Op.Text = i.ToString();
              
                BtnSave.Enabled = true;
               
            }
            else if (btn == "M")
            {
                Model.Operateur operateur;
                operateur = cs.Select(lign);
                lblID_Op.Text = operateur.ID_Op.ToString();
                txtNom.Text = operateur.Nom_Op;
                txtUser.Text = operateur.User_Op;
                txtEtat.Checked = operateur.Etat_Op;
                txtRol.EditValue = operateur.Type_Op;
                txtMotPasse.Text = operateur.Password_Op;
                if(f.operateur.Type_Op==2)
                {
                    txtEtat.ReadOnly = true;
                    txtUser.ReadOnly = true;
                    txtEtat.ReadOnly = true;
                    txtRol.ReadOnly = true;
                    txtNom.ReadOnly = true;
                }
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
                 var operateur=     new Model.Operateur();
                operateur.ID_Op = int.Parse(lblID_Op.Text);
               operateur.Nom_Op=txtNom.Text  ;
               operateur.User_Op= txtUser.Text  ;
               operateur.Etat_Op =txtEtat.Checked  ;
               operateur.Role_Op  = txtRol.Text ;
                operateur.Type_Op = int.Parse(txtRol.EditValue.ToString());
               operateur.Password_Op =  txtMotPasse.Text ;
                 vrais =   cs.ADD(operateur);
               
               
              
            }
            else if (btn == "M")
            {
                var operateur = new Model.Operateur();
                operateur.ID_Op = int.Parse(lblID_Op.Text);
                operateur.Nom_Op = txtNom.Text;
                operateur.User_Op = txtUser.Text;
                operateur.Etat_Op = txtEtat.Checked;
                operateur.Role_Op = txtRol.Text;
                operateur.Type_Op = int.Parse(txtRol.EditValue.ToString());
                operateur.Password_Op = txtMotPasse.Text;
                vrais  = cs.update(operateur);


             
            }
            if (vrais == 1) {
                //BtnSave.DialogResult = DialogResult.OK;
                BtnSave.DialogResult = DialogResult.Cancel;
                XtraMessageBox.Show("opération est effectué");
            }
             
        }





        public class Person
        {
            public int Type { get; set; }
            public string rol { get; set; }
           
        }


    }
}