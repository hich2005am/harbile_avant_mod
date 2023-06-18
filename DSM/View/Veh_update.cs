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
    public partial class type_update2 : DevExpress.XtraEditors.XtraForm
    {
        public type_update2()
        {
            InitializeComponent();
        }
        TypVehcule_ctr typ = new TypVehcule_ctr();
        char type ;
        private void XtraForm2_Load(object sender, EventArgs e)
        {
            gdAttente_public.DataSource = typ.Select().ToList();
        }

        private void gvAttente_public_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           if( gvAttente_public.OptionsSelection.EnableAppearanceFocusedRow == true)
            { 
           txtNom.Text = gvAttente_public.GetFocusedRowCellDisplayText(colNom);
           lblNum.Text = gvAttente_public.GetFocusedRowCellDisplayText(colNum);
            txtPrix.Text= gvAttente_public.GetFocusedRowCellDisplayText(colPrix);
        }
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim() == "") { XtraMessageBox.Show("NOM EST OBLIGATTOIR."); return; }
            TypVehcule TypV= new TypVehcule();
            TypV.ID_Type = int.Parse(lblNum.Text);
            TypV.Nom_Type = txtNom.Text;
            TypV.Prix_Type =decimal.Parse( txtPrix.Text);
            if (type=='M') { int i = gvAttente_public.FocusedRowHandle;
              typ.update(TypV);
                XtraForm2_Load(sender, e);
                gvAttente_public.FocusedRowHandle = i;
            }
            else if (type == 'N')
            {

                typ.ADD(TypV);
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
                    typ.delete(int.Parse(gvAttente_public.GetFocusedRowCellDisplayText(colNum)));
                    XtraForm2_Load(sender, e);
                    gvAttente_public.MoveLast();
               
            }
           
        }
     private void BtnNV_Click(object sender, EventArgs e)
        {
            lblNum.Text = typ.Max().ToString();
            txtNom.Text = "";
            txtPrix.EditValue = 0;
            txtNom.ReadOnly = false;
            txtPrix.ReadOnly = false;
            BtnNV.Enabled = false;
            BtnModifier.Enabled = false;
            BtnSup.Enabled = false;
            //
            btnSave.Enabled = true;
            BtnAnnuler.Enabled = true;
            type = 'N';
            gvAttente_public.OptionsSelection.EnableAppearanceFocusedRow = false;
        }
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            //
            txtNom.ReadOnly = false;
            txtPrix.ReadOnly = false;
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
            txtPrix.ReadOnly = !false;
            BtnNV.Enabled = !false;
            BtnModifier.Enabled = !false;
            BtnSup.Enabled = !false;
            //
            btnSave.Enabled = !true;
            BtnAnnuler.Enabled = !true;
            type = 'I';
            gvAttente_public.OptionsSelection.EnableAppearanceFocusedRow = true;
            if (typ.Max() == int.Parse(lblNum.Text)) gvAttente_public.FocusedRowHandle = 0; ;
        }
      
    }
}