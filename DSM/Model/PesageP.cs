using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSM.Model
{
    class PesageP
    {
        public int ID_PS { get; set; }
        public int Num_PS { get; set; }
        public int anne_PS { get; set; }
        public DateTime Dt_PS { get; set; }
        public DateTime Ht_PS { get; set; }
        public DateTime Hts_PS { get; set; }
        public DateTime Dts_PS { get; set; }
        public int Tare { get; set; }
        public int Brut { get; set; }
        public int Net { get; set; }
        public bool attente_PS { get; set; }
        public string MAT { get; set; }
        public int ID_Op { get; set; }
        public string Nom_Type { get; set; }
        public decimal Prix_Type { get; set; }
        public  bool supp { get; set; }
        public string NoteP { get; set; }
        public string Nom_Op { get; set; }
    }
}
