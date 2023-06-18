using DevExpress.XtraEditors;
using DSM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DSM.Controle
{
   public class Port_ctr
    {
        XmlSerializer xs = new XmlSerializer(typeof(Port));
        public Port GetPort(string fichier)
        {
           var sr = new System.IO.StreamReader(fichier);
            
                return (Port)xs.Deserialize(sr);
           
        }
        public void Save(string fichier,Port port)
        {
            try
            {
                System.IO.TextWriter txtWriter = new System.IO.StreamWriter(fichier);

                xs.Serialize(txtWriter, port);

                txtWriter.Close();
               XtraMessageBox.Show("Operation est effectue");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}
