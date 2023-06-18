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
using System.IO.Ports;

namespace DSM
{
    public partial class Ports_view : DevExpress.XtraEditors.XtraForm
    {
        MDI f = (MDI)Application.OpenForms["MDI"];
        //SerialPort serialPort;
        //int vitesse;
        public Ports_view()
        {
            InitializeComponent();
            //this.serialPort = serialPort;
        }
        DataTable dt;
        Port_ctr port_ = new Port_ctr();
        SerialPort serialPort= ((MDI)Application.OpenForms["MDI"]).ps.sp;
        private void Ports_view_Load(object sender, EventArgs e)
        {

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbxCom.Properties.Items.Add(port);
            }
            if (serialPort.IsOpen)
            {
                BtnConnexion.Enabled = false;
                cbxCom.Text = serialPort.PortName;
                cbxBaudRate.EditValue = serialPort.BaudRate;
                cbxDatabit.EditValue = serialPort.DataBits;
                cbxParity.EditValue = serialPort.Parity;
                cbxStopBit.EditValue = serialPort.StopBits;
                cbxFlux.EditValue = serialPort.Handshake;
              
                trackBarVetesse.Value = DSM.View.Pesage_view.vettesse;
                aff(true);
            }

            //if (System.IO.File.Exists(@"design\port\update.xml"))
            //{

            //        Port port = port_.GetPort(@"design\port\update.xml");
            //        cbxCom.Text = port.com;
            //        cbxBitSc.EditValue = port.bitSecond;
            //        cbxdonne.EditValue = port.bitDonne;
            //        cbxParite.EditValue =port.parite ;
            //        cbxBarret.EditValue =port.bitArret;
            //        cbxFlux.EditValue = port.flux;
            //        trackBarVetesse.Value = port.vitesse;



            //}
        }
        private void aff(bool active)
        {
            cbxCom.ReadOnly = active;
            cbxBaudRate.ReadOnly = active;
            cbxDatabit.ReadOnly = active;
            cbxParity.ReadOnly = active;
            cbxStopBit.ReadOnly = active;
            cbxFlux.ReadOnly = active;
            trackBarVetesse.ReadOnly= active;
        }
      

        private void BtnFermer_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
              
                //serialPort.BaudRate = int.Parse(cbxBaudRate.EditValue.ToString());
                //serialPort.DataBits = int.Parse(cbxDatabit.EditValue.ToString());
                //serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbxParity.SelectedItem.ToString());
                //serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbxStopBit.SelectedItem.ToString());
                //serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cbxFlux.SelectedItem.ToString());
                //DSM.View.Pesage_view.vettesse = trackBarVetesse.Value;
                //serialPort.Open();

                Port port = new Port();
            port.numero = 1;
            port.com = cbxCom.Text;
            port.BaudRate = int.Parse(cbxBaudRate.Text);
            port.Databit = int.Parse(cbxDatabit.Text);
            port.Parity = cbxParity.Text;
            port.StopBit = cbxStopBit.Text;
            port.flux = cbxFlux.Text;
            port.vitesse = trackBarVetesse.Value;
            port_.Save(@"design\port\update.xml", port);

            this.Close();
        }
              catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackBarVetesse_EditValueChanged(object sender, EventArgs e)
        {
      
        //f.ps.psPoid.Text = trackBarVetesse.Value.ToString();
        }

        private void cbxCom_TextChanged(object sender, EventArgs e)
        {
          //  try
          //  {
          ////serialPort.BaudRate= int.Parse(cbxBaudRate.EditValue.ToString())  ;
          //// serialPort.DataBits =int.Parse(cbxDatabit.EditValue.ToString())  ;
          //// serialPort.Parity= (Parity) Enum.Parse(typeof(Parity),cbxParity.SelectedItem.ToString()); 
          ////  serialPort.StopBits = (StopBits) Enum.Parse(typeof(StopBits), cbxStopBit.SelectedItem.ToString()); 
          ////  serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cbxFlux.SelectedItem.ToString()); 
          //   //f.ps.vettesse = trackBarVetesse.Value  ;
          //  }
          //  catch (Exception ex)
          //  {
          //      MessageBox.Show(ex.Message);
          //  }
            //serialPort.PortName = cbxCom.Text;
          
        }

        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
           if( serialPort.IsOpen ) { serialPort.Close();BtnConnexion.Enabled = true; aff(false); BtnSave.Enabled = true;BtnApplique.Enabled = true; }
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {

            if (serialPort.IsOpen==false) { serialPort.Open(); BtnConnexion.Enabled = false; aff(true); BtnSave.Enabled = false; BtnApplique.Enabled = false; }
        }

        private void Pardefault_Click(object sender, EventArgs e)
        {
            cbxBaudRate.EditValue = 9600;
            cbxStopBit.EditValue = "One";
            cbxParity.EditValue = "None";
            cbxDatabit.EditValue = 8;
          
          
            cbxFlux.EditValue = "None";
            trackBarVetesse.Value = 300;
        }

        private void BtnApplique_Click(object sender, EventArgs e)
        {
            try { 
            if (serialPort.IsOpen) serialPort.Close();
          
            serialPort.PortName = cbxCom.Text;
                serialPort.BaudRate = int.Parse(cbxBaudRate.EditValue.ToString());
                serialPort.DataBits = int.Parse(cbxDatabit.EditValue.ToString());
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbxParity.SelectedItem.ToString());
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbxStopBit.SelectedItem.ToString());
                serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cbxFlux.SelectedItem.ToString());
                DSM.View.Pesage_view.vettesse = trackBarVetesse.Value;
                BtnConnexion.PerformClick();
                BtnSave.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();
            }
           
        }
    }
}