using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSM.Model
{
 public   class Produit
    {
        public int ID_PDT { get; set; }
        public string Designe_PDT { get; set; }
        public string description_PDT { get; set; }
        public int QtInitial_PDT { get; set; }
        public decimal prixUnitaire_PDT { get; set; }
        
    }
}
