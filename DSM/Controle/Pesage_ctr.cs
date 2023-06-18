using Dapper;
using DSM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSM.Controle
{
    class Pesage_ctr
    {
        public List<Pesage> Select()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {

                return con.Query<Pesage>("select * from ps where supp=false and attente_PS=false  ").ToList();
            } 
            catch
            {
                throw;
            }
        }
        public List<Pesage> Select_Supp()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {

                return con.Query<Pesage>("select * from ps where supp=true  ").ToList();
            }
            catch
            {
                throw;
            }
        }
        public Pesage Select(int Num_PS)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<Pesage>("select *.Pesage from Pesage where Num_PS=193 ").SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }
        public List<Pesage> ATTENTE()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<Pesage>("select * from Pesage where attente_PS=TRUE and supp=false ").ToList();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;

            }
        }
        public int ADD_Brut(Pesage pesage)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO Pesage 
                              (Num_PS,ID_PS, Dt_PS, Ht_PS, Brut, Hts_PS,Dts_PS, Tare,Net,
                               attente_PS,ID_Op,  Nom_TR,  MAT_VEH, Designe_PDT,
                               Nom_CH,Nom_CL,  Nom_FR, Nom_DS,ID_DS, Bon, obsevation,
                                Code_CL,Code_FR,ID_VEH,ID_TR,ID_CH,ID_PDT,type_MV,type_Ps,tara_M,Manual,
                                Caisse_NB_Brut,Palette_NB_Brut,Caisse_Un_Brut,Palette_Un_Brut,ACC_Brut,champ1,champ2,anne_PS,Nom_Op)
                               VALUES
                               (@Num_PS,@ID_PS, @Dt_PS, @Ht_PS,   @Brut,@Hts_PS,@Dts_PS, @Tare,@Net,
                               @attente_PS, @ID_Op, @Nom_TR, @MAT_VEH, @Designe_PDT,
                               @Nom_CH,@Nom_CL,  @Nom_FR, @Nom_DS,@ID_DS, @Bon, @obsevation,
                                 @Code_CL,@Code_FR,@ID_VEH,@ID_TR,@ID_CH,@ID_PDT,@type_MV,@type_Ps,@tara_M,@Manual,
                                 @Caisse_NB_Brut,@Palette_NB_Brut,@Caisse_Un_Brut,@Palette_Un_Brut,@ACC_Brut,@champ1,@champ2,@anne_PS,@Nom_Op)";

                return con.Execute(sql, new
                {
                    pesage.Num_PS,
                    pesage.ID_PS,
                    pesage.Dt_PS,
                    pesage.Ht_PS,
                    pesage.Brut,
                    pesage.Hts_PS,
                    pesage.Dts_PS,
                    pesage.Tare,
                    pesage.Net,
                    pesage.attente_PS,
                    pesage.ID_Op,
                    pesage.Nom_TR,
                    pesage.MAT_VEH,
                    pesage.Designe_PDT,
                    pesage.Nom_CH,
                    pesage.Nom_CL,
                    pesage.Nom_FR,
                    pesage.Nom_DS,
                    pesage.ID_DS,
                    pesage.Bon,
                    pesage.obsevation
                   ,
                    pesage.Code_CL,
                    pesage.Code_FR,
                    pesage.ID_VEH,
                    pesage.ID_TR,
                    pesage.ID_CH,
                    pesage.ID_PDT,
                    pesage.type_MV,
                    pesage.type_Ps,
                    pesage.tara_M,
                    pesage.Manual,
                    pesage.Caisse_NB_Brut,
                    pesage.Palette_NB_Brut,
                    pesage.Caisse_Un_Brut,
                    pesage.Palette_Un_Brut,
                    pesage.ACC_Brut,
                    pesage.champ1,
                    pesage.champ2,
                    pesage.anne_PS,
                    pesage.Nom_Op
                });

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;
            }
        }
        public int ADD_Tare(Pesage pesage)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO Pesage 
                              (Num_PS,ID_PS, Dt_PS, Ht_PS, Tare,Net,
                               attente_PS,ID_Op,  Nom_TR,  MAT_VEH, Designe_PDT,
                               Nom_CH,Nom_CL,  Nom_FR, Nom_DS,ID_DS, Bon, obsevation,
                                Code_CL,Code_FR,ID_VEH,ID_TR,ID_CH,ID_PDT,type_MV,type_Ps,tara_M,Manual,
                                Caisse_NB_Brut,Palette_NB_Tare,Caisse_Un_Tare,Palette_Un_Tare,ACC_Tare,champ1,champ2,anne_PS,Nom_Op)
                               VALUES
                               (@Num_PS,@ID_PS, @Dt_PS, @Ht_PS, @Tare,@Net,
                               @attente_PS, @ID_Op, @Nom_TR, @MAT_VEH, @Designe_PDT,
                               @Nom_CH,@Nom_CL,  @Nom_FR, @Nom_DS,@ID_DS, @Bon, @obsevation,
                                 @Code_CL,@Code_FR,@ID_VEH,@ID_TR,@ID_CH,@ID_PDT,@type_MV,@type_Ps,@tara_M,@Manual,
                                 @Caisse_NB_Tare,@Palette_NB_Tare,@Caisse_Un_Tare,@Palette_Un_Tare,@ACC_Tare,@champ1,@champ2,@anne_PS,@Nom_Op)";

                return con.Execute(sql, new
                {
                    pesage.Num_PS,
                    pesage.ID_PS,
                    pesage.Dt_PS,
                    pesage.Ht_PS,
                   
                  
                    pesage.Tare,
                    pesage.Net,
                    pesage.attente_PS,
                    pesage.ID_Op,
                    pesage.Nom_TR,
                    pesage.MAT_VEH,
                    pesage.Designe_PDT,
                    pesage.Nom_CH,
                    pesage.Nom_CL,
                    pesage.Nom_FR,
                    pesage.Nom_DS,
                    pesage.ID_DS,
                    pesage.Bon,
                    pesage.obsevation,
                    pesage.Code_CL,
                    pesage.Code_FR        
                    
                    ,
                    pesage.ID_VEH,
                    pesage.ID_TR,
                    pesage.ID_CH,
                    pesage.ID_PDT,
                    pesage.type_MV,
                    pesage.type_Ps,
                    pesage.tara_M,
                    pesage.Manual,
                    pesage.Caisse_NB_Tare,
                    pesage.Palette_NB_Tare,
                    pesage.Caisse_Un_Tare,
                    pesage.Palette_Un_Tare,
                    pesage.ACC_Tare,
                    pesage.champ1,
                    pesage.champ2,
                    pesage.anne_PS,
                    pesage.Nom_Op
                });

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;
            }
        }
        public int ADD_Simple(Pesage pesage)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO Pesage 
                              (Num_PS,ID_PS, Dt_PS, Ht_PS, Brut, Hts_PS,Dts_PS, Tare,Net,
                               attente_PS,ID_Op,  Nom_TR,  MAT_VEH, Designe_PDT,
                               Nom_CH,Nom_CL,  Nom_FR, Nom_DS,ID_DS, Bon, obsevation,
                                Code_CL,Code_FR,ID_VEH,ID_TR,ID_CH,ID_PDT,type_MV,type_Ps,tara_M,Manual,
                                Caisse_NB_Brut,Palette_NB_Brut,Caisse_Un_Brut,Palette_Un_Brut,ACC_Brut,Caisse_Brut,Palette_Brut,
                                  prix_un,Montant,champ1,champ2,anne_PS,tva,ttc,Nom_Op,ACC_Tare)
                               VALUES
                               (@Num_PS,@ID_PS, @Dt_PS, @Ht_PS,   @Brut,@Hts_PS,@Dts_PS, @Tare,@Net,
                               @attente_PS, @ID_Op, @Nom_TR, @MAT_VEH, @Designe_PDT,
                               @Nom_CH,@Nom_CL,  @Nom_FR, @Nom_DS,@ID_DS, @Bon, @obsevation,
                                 @Code_CL,@Code_FR,@ID_VEH,@ID_TR,@ID_CH,@ID_PDT,@type_MV,@type_Ps,@tara_M,@Manual,
                                @Caisse_NB_Brut,@Palette_NB_Brut,@Caisse_Un_Brut,@Palette_Un_Brut,@ACC_Brut,@Caisse_Brut,@Palette_Brut,
                                    @prix_un,@Montant,@champ1,@champ2,@anne_PS,@tva,@ttc,@Nom_Op,0)";

                return con.Execute(sql, new
                {
                    pesage.Num_PS,
                    pesage.ID_PS,
                    pesage.Dt_PS,
                    pesage.Ht_PS,
                    pesage.Brut,
                    pesage.Hts_PS,
                    pesage.Dts_PS,
                    pesage.Tare,
                    pesage.Net,
                    pesage.attente_PS,
                    pesage.ID_Op,
                    pesage.Nom_TR,
                    pesage.MAT_VEH,
                    pesage.Designe_PDT,
                    pesage.Nom_CH,
                    pesage.Nom_CL,
                    pesage.Nom_FR,
                    pesage.Nom_DS,
                    pesage.ID_DS,
                    pesage.Bon,
                    pesage.obsevation,
                    pesage.Code_CL,
                    pesage.Code_FR,
                    pesage.ID_VEH,
                    pesage.ID_TR,
                    pesage.ID_CH,
                    pesage.ID_PDT,
                    pesage.type_MV,
                    pesage.type_Ps,
                    pesage.tara_M,
                    pesage.Manual,
                    pesage.Caisse_NB_Brut,
                    pesage.Palette_NB_Brut,
                    pesage.Caisse_Un_Brut,
                    pesage.Palette_Un_Brut,
                    pesage.ACC_Brut,
                    pesage.Caisse_Brut,
                    pesage.Palette_Brut,
                    pesage.prix_un,
                    pesage.Montant,
                    pesage.champ1,
                    pesage.champ2,
                    pesage.anne_PS,
                    pesage.tva,
                    pesage.ttc,
                   pesage.Nom_Op
                });

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;
            }
        }


        //public int ADD_Double(Pesage pesage)
        //{
        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {
        //        string sql = @"INSERT INTO Pesage 
        //                      (Num_PS,ID_PS, Dt_PS, Ht_PS, Brut, Hts_PS,Dts_PS, Tare,Net,
        //                       attente_PS,ID_Op,  Nom_TR,  MAT_VEH, Designe_PDT,
        //                       Nom_CH,Nom_CL,  Nom_FR, Nom_DS,ID_DS, Bon, obsevation,
        //                        ID_CL,ID_FR,ID_VEH,ID_TR,ID_CH,ID_PDT,type_MV,type_Ps,tara_M,Manual,
        //                        Caisse_NB_1,Palette_NB_1,Caisse_Un_1,Palette_Un_1,TarAcc_1,Tare_Caisse_1,Tare_Palette_1
        //                         , prix_un,Montant,champ1,champ2,anne_PS,tva,ttc,ACC_Brut)
        //                       VALUES
        //                       (@Num_PS,@ID_PS, @Dt_PS, @Ht_PS,   @Brut,@Hts_PS,@Dts_PS, @Tare,@Net,
        //                       @attente_PS, @ID_Op, @Nom_TR, @MAT_VEH, @Designe_PDT,
        //                       @Nom_CH,@Nom_CL,  @Nom_FR, @Nom_DS,@ID_DS, @Bon, @obsevation,
        //                         @ID_CL,@ID_FR,@ID_VEH,@ID_TR,@ID_CH,@ID_PDT,@type_MV,@type_Ps,@tara_M,@Manual,
        //                         @Caisse_NB_1,@Palette_NB_1,@Caisse_Un_1,@Palette_Un_1,@TarAcc_1,@Tare_Caisse_1,@Tare_Palette_1,
        //                            @prix_un,@Montant,@champ1,@champ2,@anne_PS,@tva,@ttc,@ACC_Brut)";

        //        return con.Execute(sql, new
        //        {
        //            pesage.Num_PS,
        //            pesage.ID_PS,
        //            pesage.Dt_PS,
        //            pesage.Ht_PS,
        //            pesage.Brut,
        //            pesage.Hts_PS,
        //            pesage.Dts_PS,
        //            pesage.Tare,
        //            pesage.Net,
        //            pesage.attente_PS,
        //            pesage.ID_Op,
        //            pesage.Nom_TR,
        //            pesage.MAT_VEH,
        //            pesage.Designe_PDT,
        //            pesage.Nom_CH,
        //            pesage.Nom_CL,
        //            pesage.Nom_FR,
        //            pesage.Nom_DS,
        //            pesage.ID_DS,
        //            pesage.Bon,
        //            pesage.obsevation
        //           ,
        //            pesage.ID_CL,
        //            pesage.ID_FR,
        //            pesage.ID_VEH,
        //            pesage.ID_TR,
        //            pesage.ID_CH,
        //            pesage.ID_PDT,
        //            pesage.type_MV,
        //            pesage.type_Ps,
        //            pesage.tara_M,
        //            pesage.Manual,
        //            pesage.Caisse_NB_1,
        //            pesage.Palette_NB_1,
        //            pesage.Caisse_Un_1,
        //            pesage.Palette_Un_1,
        //            pesage.TarAcc_1,
        //            pesage.Tare_Caisse_1,
        //            pesage.Tare_Palette_1,
        //            pesage.prix_un,
        //            pesage.Montant,
        //            pesage.champ1,
        //            pesage.champ2,
        //            pesage.anne_PS,
        //            pesage.tva,
        //            pesage.ttc,
        //            pesage.ACC_Brut
        //        });

        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //        return -1;
        //    }
        //}
        public int updateVh(int ID_VEH,string MAT_VEH)
        {
            var con = ConnectionFactory.GetConnection();
            //try
            //{
                string sql = @"UPDATE Pesage   SET ID_VEH=@ID_VEH
                                              where MAT_VEH=@MAT_VEH
                                                  ";
            return con.Execute(sql, new { ID_VEH, MAT_VEH });
              
                }
        public int update_Brut(Pesage pesage)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                //                string sql = @"UPDATE Pesage   SET 
                //Brut=           " + pesage.Brut + "," +
                //"Net=           " + pesage.Net + "," +
                //"Hts_PS = "+pesage.Hts_PS+"," +
                //"Dts_PS =         " +  pesage.Dts_PS       +"," +
                //"attente_PS =     " +  pesage.attente_PS   "," +
                //" Nom_TR =        " +  pesage.Nom_TR        "," +
                //"MAT_VEH =        " +  pesage.MAT_VEH       "," +
                //"Designe_PDT=     " + pesage.Designe_PDT,    "," +
                //" Nom_CH=         " + pesage.Nom_CH,         "," +
                //"Nom_CL=          " + pesage.Nom_CL,         "," +
                //"Nom_DS=          " + pesage.Nom_DS,         "," +
                //"Bon=             " + pesage.Bon,            "," +
                //"obsevation=      " + pesage.obsevation,     "," +
                //"ID_CL=           " + pesage.ID_CL,          "," +
                //"ID_VEH=          " + pesage.ID_VEH,         "," +
                //"ID_TR=           " + pesage.ID_TR,          "," +
                //"ID_CH=           " + pesage.ID_CH,          "," +
                //"Caisse_NB_Brut=  " + pesage.Caisse_NB_Brut  "," +
                //"Palette_NB_Brut= " + pesage.Palette_NB_Brut,"," +
                //"Caisse_Un_Brut=  " + pesage.Caisse_Un_Brut, "," +
                //"Palette_Un_Brut= " + pesage.Palette_Un_Brut,"," +
                //"ACC_Brut=        " + pesage.ACC_Brut,       "," +
                //"Caisse_Brut=     " + pesage.Caisse_Brut,    "," +
                //"Palette_Brut=    " + pesage.Palette_Brut,   "," +
                //"prix_un=         " + pesage.prix_un,        "," +
                //"Montant=         " + pesage.Montant,        "," +
                //"tva=             " + pesage.tva,            "," +
                //"ttc=             " + pesage.ttc             "," +
                //"WHERE  Pesage.Num_PS= pesage.Num_PS";
                //                "




                string sql = @" UPDATE Pesage SET
Brut = @Brut,
Net = @Net, 
Hts_PS = @Hts_PS,
Dts_PS = @Dts_PS ,
attente_PS = @attente_PS,
Nom_TR = @Nom_TR,  
MAT_VEH = @MAT_VEH, 
Designe_PDT = @Designe_PDT,
Nom_CH = @Nom_CH,
Nom_CL = @Nom_CL,
Nom_DS = @Nom_DS, 
Bon = @Bon,
obsevation = @obsevation,
Code_CL = @Code_CL,
ID_VEH = @ID_VEH,
ID_TR = @ID_TR,
ID_CH = @ID_CH,
Caisse_NB_Brut = @Caisse_NB_Brut,
Palette_NB_Brut = @Palette_NB_Brut,
Caisse_Un_Brut = @Caisse_Un_Brut,
Palette_Un_Brut = @Palette_Un_Brut,
ACC_Brut = @ACC_Brut,
Caisse_Brut = @Caisse_Brut,
Palette_Brut = @Palette_Brut,
prix_un = @prix_un,
Montant = @Montant,
tva = @tva,
ttc = @ttc
WHERE Pesage.Num_PS = @Num_PS";
                                return con.Execute(sql, new
                                {

                                    pesage.Brut,
                                    pesage.Net,
                                    pesage.Hts_PS,
                                    pesage.Dts_PS,
                                    pesage.attente_PS,
                                    pesage.Nom_TR,
                                    pesage.MAT_VEH,
                                    pesage.Designe_PDT,
                                    pesage.Nom_CH,
                                    pesage.Nom_CL,
                                    pesage.Nom_DS,
                                    pesage.Bon,
                                    pesage.obsevation,
                                    pesage.Code_CL,
                                    pesage.ID_VEH,
                                    pesage.ID_TR,
                                    pesage.ID_CH,
                                    pesage.Caisse_NB_Brut,
                                    pesage.Palette_NB_Brut,
                                    pesage.Caisse_Un_Brut,
                                    pesage.Palette_Un_Brut,
                                    pesage.ACC_Brut,
                                    pesage.Caisse_Brut,
                                    pesage.Palette_Brut,
                                    pesage.prix_un,
                                    pesage.Montant,
                                    pesage.tva,
                                    pesage.ttc,


                                    //pesage.champ1,
                                    //pesage.champ2,
                                    pesage.Num_PS
                                });

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;

            }
        }
        public int update_Tare(Pesage pesage)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {

                string sql = @"UPDATE Pesage   SET 
                               Tare=@Tare,Net=@Net,   Hts_PS=@Hts_PS,Dts_PS=@Dts_PS ,attente_PS=@attente_PS,
                                 Nom_TR=@Nom_TR,  MAT_VEH=@MAT_VEH, Designe_PDT=@Designe_PDT,
                                 Nom_CH=@Nom_CH,Nom_CL=@Nom_CL,  Nom_FR=@Nom_FR, Nom_DS=@Nom_DS, Bon=@Bon, obsevation=@obsevation,
                                  Code_CL=@Code_CL,Code_FR=@Code_FR,ID_VEH=@ID_VEH,ID_TR=@ID_TR,ID_CH=@ID_CH,
                                   Caisse_NB_Tare=@Caisse_NB_Tare,Palette_NB_Tare=@Palette_NB_Tare,Caisse_Un_Tare=@Caisse_Un_Tare,Palette_Un_Tare=@Palette_Un_Tare,
                               ACC_Tare=@ACC_Tare,Caisse_Tare=@Caisse_Tare,Palette_Tare=@Palette_Tare,prix_un=@prix_un,
                                                  Montant=@Montant,tva=@tva,ttc=@ttc, champ1=@champ1, champ2=@champ2
                                                  WHERE  Pesage.Num_PS=@Num_PS";
                return con.Execute(sql, new
                {
                    
                    pesage.Tare,
                    pesage.Net,
                    pesage.Hts_PS,
                    pesage.Dts_PS,
                    pesage.attente_PS,
                   
                    pesage.Nom_TR,
                    pesage.MAT_VEH,
                    pesage.Designe_PDT,
                    pesage.Nom_CH,
                    pesage.Nom_CL,
                    pesage.Nom_FR,
                    pesage.Nom_DS,
                    pesage.Bon,
                    pesage.obsevation,
                    pesage.Code_CL,
                    pesage.Code_FR,
                    pesage.ID_VEH,
                    pesage.ID_TR,
                    pesage.ID_CH,
                    pesage.Caisse_NB_Tare,
                    pesage.Palette_NB_Tare,
                    pesage.Caisse_Un_Tare,
                    pesage.Palette_Un_Tare,
                    pesage.ACC_Tare,
                    pesage.Caisse_Tare,
                    pesage.Palette_Tare,
                    pesage.prix_un,
                    pesage.Montant,
                    pesage.tva,
                    pesage.ttc,


                    pesage.champ1,
                    pesage.champ2,
                    pesage.Num_PS
                });

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;

            }
        }
        //public int update(Pesage pesage)
        //{
        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {

        //        string sql = @"UPDATE Pesage   SET 
        //                       Brut=@Brut,Tare=@Tare,Net=@Net,   Hts_PS=@Hts_PS,Dts_PS=@Dts_PS ,attente_PS=@attente_PS,ID_Op=@ID_Op,
        //                         Nom_TR=@Nom_TR,  MAT_VEH=@MAT_VEH, Designe_PDT=@Designe_PDT,
        //                         Nom_CH=@Nom_CH,Nom_CL=@Nom_CL,  Nom_FR=@Nom_FR, Nom_DS=@Nom_DS, Bon=@Bon, obsevation=@obsevation,
        //                          ID_CL=@ID_CL,ID_FR=@ID_FR,ID_VEH=@ID_VEH,ID_TR=@ID_TR,ID_CH=@ID_CH,
        //                           Caisse_NB_2=@Caisse_NB_2,Palette_NB_2=@Palette_NB_2,Caisse_Un_2=@Caisse_Un_2,Palette_Un_2=@Palette_Un_2,
        //                       TarAcc_2=@TarAcc_2,Tare_Caisse_2=@Tare_Caisse_2,Tare_Palette_2=@Tare_Palette_2,prix_un=@prix_un,
        //                                          Montant=@Montant,tva=@tva,ttc=@ttc,ACC_Brut=@ACC_Brut,ACC_Tare=@ACC_Tare, champ1=@champ1, champ2=@champ2
        //                                          WHERE  Pesage.ID_PS=@ID_PS";
        //        return con.Execute(sql, new
        //        {
        //            pesage.Brut,
        //            pesage.Tare,
        //            pesage.Net ,
        //             pesage.Hts_PS ,
        //             pesage.Dts_PS ,
        //             pesage.attente_PS,
        //             pesage.ID_Op ,
        //             pesage.Nom_TR ,
        //             pesage.MAT_VEH ,
        //             pesage.Designe_PDT,
        //             pesage.Nom_CH ,
        //             pesage.Nom_CL ,
        //             pesage.Nom_FR ,
        //             pesage.Nom_DS ,
        //             pesage.Bon ,
        //             pesage.obsevation ,
        //             pesage.ID_CL ,
        //             pesage.ID_FR ,
        //             pesage.ID_VEH ,
        //             pesage.ID_TR ,
        //             pesage.ID_CH ,
        //             pesage.Caisse_NB_2 ,
        //             pesage.Palette_NB_2 ,
        //             pesage.Caisse_Un_2 ,
        //             pesage.Palette_Un_2 ,
        //             pesage.TarAcc_2 ,
        //             pesage.Tare_Caisse_2 ,
        //             pesage.Tare_Palette_2 ,
        //             pesage.prix_un ,
        //             pesage.Montant ,
        //             pesage.tva,
        //             pesage.ttc,
        //             pesage.ACC_Brut,
        //             pesage.ACC_Tare,
        //            pesage.champ1,
        //            pesage.champ2,
        //             pesage.ID_PS
        //        });

        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //        return 0;

        //    }
        //}
        public int delete(int Num_PS)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"update Pesage set supp=true,attente_PS=false  WHERE  Pesage.Num_PS=@Num_PS";
                return con.Execute(sql, new { Num_PS });

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public int LastPesage()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                
              

              

                return con.Query<int?>(" SELECT Max(Month(Dt_PS)) from Pesage ").Single() ?? -1;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;

            }
        }
        public int delete()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"delete from Pesage ";
                return con.Execute(sql);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }
        }
        //public DateTime debut(DateTime du,DateTime au)
        //{
        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {

        //        return con.Query<bool>(" SELECT * from Pesage where ").Single();

        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //        return false;

        //    }
        //}

        public int Max()
        {

            var con = ConnectionFactory.GetConnection();
            try
            {
                
                string sql = @" SELECT max(ID_PS)+1 from Pesage where
                               anne_PS=" + DateTime.Now.Year % 100;
                    return con.Query<int?>(sql).Single() ?? 1;
           

            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;
               
            }
        


        }
        public int MaxOrder()
        {

            var con = ConnectionFactory.GetConnection();
            try
            {
                //bool annee=   Properties.Settings.Default.anne ;


                return con.Query<int?>(" SELECT max(Num_PS)+1 from Pesage").Single() ?? 1;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;

            }



        }

    }
}
