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

namespace DSM.View
{
    public partial class type_update : DevExpress.XtraEditors.XtraForm
    {
        public type_update()
        {
            InitializeComponent();
        }
        Destination_ctr destination = new Destination_ctr();
        char type ;
        private void XtraForm2_Load(object sender, EventArgs e)
        {
            gdAttente_public.DataSource = destination.Select().ToList();
        }

        private void gvAttente_public_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           txtNom.Text = gvAttente_public.GetFocusedRowCellDisplayText(colNom);
           lblNum.Text = gvAttente_public.GetFocusedRowCellDisplayText(colNum);
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim() == "") { XtraMessageBox.Show("NOM EST OBLIGATTOIR."); return; }
            Destination dst=new Destination();
            dst.ID_DS = int.Parse(lblNum.Text);
            dst.Nom_DS = txtNom.Text;
            if (type=='M') { int i = gvAttente_public.FocusedRowHandle;
                destination.update(dst);
                XtraForm2_Load(sender, e);
                gvAttente_public.FocusedRowHandle = i;
            }
            else if (type == 'N')
            {

                destination.ADD(dst);
                XtraForm2_Load(sender, e);
               gvAttente_public.MoveLast();
               
                
            }
            BtnAnnuler.PerformClick();
            //gvAttente_public.FocusedRowHandle = 0;
        }

        private void gvAttente_public_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void gvAttente_public_RowCellClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void BtnSup_Click(object sender, EventArgs e)
        {
            
                if (XtraMessageBox.Show("  vous voudrais  supprimer cette ligne ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    destination.delete(int.Parse(gvAttente_public.GetFocusedRowCellDisplayText(colNum)));
                    XtraForm2_Load(sender, e);
                    gvAttente_public.MoveLast();
               
            }
           
        }
     private void BtnNV_Click(object sender, EventArgs e)
        {
            lblNum.Text = destination.Max().ToString();
            txtNom.Text = "";
            txtNom.ReadOnly = false;
            BtnNV.Enabled = false;
            BtnModifier.Enabled = false;
            BtnSup.Enabled = false;
            //
            btnSave.Enabled = true;
            BtnAnnuler.Enabled = true;
            type = 'N';
        }
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            //
            txtNom.ReadOnly = false;
            BtnNV.Enabled = false;
            BtnModifier.Enabled = false;
            BtnSup.Enabled = false;
            //
            btnSave.Enabled = true;
            BtnAnnuler.Enabled = true;
            type = 'M';
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            txtNom.ReadOnly =! false;
            BtnNV.Enabled = !false;
            BtnModifier.Enabled = !false;
            BtnSup.Enabled = !false;
            //
            btnSave.Enabled = !true;
            BtnAnnuler.Enabled = !true;
            type = 'I';
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}