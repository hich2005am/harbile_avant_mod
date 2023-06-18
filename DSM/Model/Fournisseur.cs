using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSM.Model
{
  public  class Fournisseur
    {
        public int ID_FR { get; set; }
        public int Code_FR { get; set; }
        public string CNIE_FR { get; set; }
        public string Nom_FR { get; set; }
        public string Adr_FR { get; set; }
        public string Tel_FR { get; set; }
        public string Fax_FR { get; set; }
        public string Note_FR { get; set; }
    }
}
