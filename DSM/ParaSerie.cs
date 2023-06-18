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
    public partial class ParaSerie : DevExpress.XtraEditors.XtraForm
    {
        public ParaSerie()
        {
            InitializeComponent();
        }

        private void ParaSerie_Load(object sender, EventArgs e)
        {
            bool annee = Properties.Settings.Default.anne;
            if (annee == false)
            {
            rdChoix.SelectedIndex = 1;
            dtDu.EditValue = Properties.Settings.Default.dateDebut;
            dtAu.EditValue=Properties.Settings.Default.dateFin  ;
            pnlDate.Visible = true;
            }
            else
            {
                rdChoix.SelectedIndex = 0;
                pnlDate.Visible = false;
            }
        }

        private void rdChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdChoix.SelectedIndex == 0)
            {
                pnlDate.Visible = false;
            }
            else pnlDate.Visible = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
                if(rdChoix.SelectedIndex == 0)
            { 
                Properties.Settings.Default.anne = true;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                Properties.Settings.Default.anne = false;
                Properties.Settings.Default.dateDebut =DateTime.Parse( dtDu.Text);
                Properties.Settings.Default.dateFin = DateTime.Parse(dtAu.Text);
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}