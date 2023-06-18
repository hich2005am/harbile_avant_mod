using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSM.Model
{
    class Pesage
    {
        public int Num_PS { get; set; }
        public int ID_PS { get; set; }
        public int anne_PS { get; set; }
        
        public DateTime Dt_PS { get; set; }
        public DateTime Ht_PS { get; set; }
        public DateTime Hts_PS { get; set; }
        public DateTime Dts_PS { get; set; }
        
        public int Tare { get; set; }
        public int Brut { get; set; }
        public int Net { get; set; }
        public bool attente_PS { get; set; }
        public int ID_PDT { get; set; }
        public string Designe_PDT { get; set; }
        public int ID_Op { get; set; }
        public int ID_TR { get; set; }
        public string Nom_TR { get; set; }
        public string Nom_CL { get; set; }
        public int ID_VEH { get; set; }
        public string MAT_VEH { get; set; }
        public int ID_CH { get; set; }
        public string Nom_CH { get; set; }
        public string Nom_FR { get; set; }
        public string Nom_DS { get; set; }
        public int ID_DS { get; set; }
        public string Bon { get; set; }
        public string obsevation { get; set; }
        public string type_MV { get; set; }
        public string type_Ps { get; set; }
        public bool tara_M { get; set; }
        public bool Manual { get; set; }
        public int Caisse_NB_Brut { get; set; }
        public int Palette_NB_Brut { get; set; }
        public int Caisse_Un_Brut { get; set; }
        public int Palette_Un_Brut { get; set; }
        public int Caisse_Brut { get; set; }
        public int Palette_Brut { get; set; }
        public int Caisse_NB_Tare { get; set; }
        public int Palette_NB_Tare { get; set; }
        public int Caisse_Un_Tare { get; set; }
        public int Palette_Un_Tare { get; set; }
        public int Caisse_Tare { get; set; }
        public int Palette_Tare { get; set; }
        public decimal prix_un { get; set; }
        public decimal Montant { get; set; }
        public decimal tva { get; set; }
        public decimal ttc { get; set; }
        public string NSrie { get; set; }
        public string champ1 { get; set; }
        public string champ2 { get; set; }
        public int ACC_Brut { get; set; }
        public int ACC_Tare { get; set; }
        public bool supp { get; set; }
        public string Nom_Op { get; set; }
        public int Code_FR { get; set; }
        public int Code_CL { get; set; }
    }
}
