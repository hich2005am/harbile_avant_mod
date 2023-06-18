using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSM.Model
{
  public  class Operateur
    {
        public int ID_Op { get; set; }
        public string User_Op { get; set; }
        public string Nom_Op { get; set; }
        public string Password_Op { get; set; }
        public int Type_Op { get; set; }
        public bool Etat_Op { get; set; }
        public string Role_Op { get; set; }
    }
}
