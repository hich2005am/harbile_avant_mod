using Dapper;
using DSM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSM.Controle
{
    class PesageP_ctr
    {
        public List<PesageP> Select()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {

                return con.Query<PesageP>("select * from PesageP order by ID_PS").ToList();
            } 
            catch
            {
                throw;
            }
        }
        public List<PesageP> Select_Supp()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {

                return con.Query<PesageP>("select * from PesageP where supp=true").ToList();
            }
            catch
            {
                throw;
            }
        }
        public List<PesageP> Select_Attente()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {

                return con.Query<PesageP>("select * from PesageP  where PesageP.attente_PS=false  and supp=false order by Num_PS").ToList();
            }
            catch
            {
                throw;
            }
        }

        public PesageP Select(string MAT)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<PesageP>("select * from PesageP where MAT=@MAT", new { MAT }).FirstOrDefault();

            }
            catch
            {
                throw;
            }
        }
        public List<PesageP> Mat()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<PesageP>("select distinct  MAT from PesageP").ToList(); ;

            }
            catch
            {
                throw;
            }
        }
        public List<PesageP> ATTENTE()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<PesageP>("select    Num_PS& '/'&anne_PS AS Num,* from PesageP where attente_PS=TRUE").ToList();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;

            }
        }
        public int ADD(PesageP pesage )
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO PesageP 
                              (ID_PS,Num_PS,anne_PS, Dt_PS, Ht_PS, Brut, Tare,Net,
                               attente_PS,ID_Op, MAT,Nom_Type,Prix_Type,Nom_Op)
                               VALUES
                               (@ID_PS,@Num_PS,@anne_PS, @Dt_PS, @Ht_PS,@Brut, @Tare,@Net,
                               @attente_PS, @ID_Op, @MAT,@Nom_Type,@Prix_Type,@Nom_Op )
                              
                                   ";
               
                return con.Execute(sql, new {
                  pesage.ID_PS,
                  pesage.Num_PS,
                  pesage.anne_PS,
                  pesage.Dt_PS ,
                  pesage.Ht_PS,
                  pesage.Brut,
                  pesage.Tare,
                  pesage.Net,
                    pesage.attente_PS,
                    pesage.ID_Op,
                  pesage.MAT,
                  pesage.Nom_Type,
                  pesage.Prix_Type,
                  pesage.Nom_Op
                });

            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;
            }
        }
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
        public int updateAttente(PesageP pesage)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"UPDATE PesageP   SET 
                              
                               attente_PS=@attente_PS,
                               supp=true,
                               NoteP=" + "'suppression la  liste attente'"+" WHERE  PesageP.ID_PS=@ID_PS";
                return con.Execute(sql, new
                {
                    
                    pesage.attente_PS,

                    pesage.ID_PS


                });

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;

            }
        }
        public int update(PesageP pesage)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"UPDATE PesageP   SET 
                               Brut=@Brut,
                               Tare=@Tare,
                               Net=@Net, 
                               Hts_PS=@Hts_PS,
                               Dts_PS=@Dts_PS ,
                               attente_PS=@attente_PS
                                                                                                     
                               WHERE  PesageP.ID_PS=@ID_PS";
                return con.Execute(sql, new
                {
                                 pesage.Brut,
                                 pesage.Tare,
                                 pesage.Net,
                                 pesage.Hts_PS,
                                 pesage.Dts_PS,
                                 pesage.attente_PS,
                               
                                 pesage.ID_PS    
                    

                });

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;

            }
        }
        public int delete(int Num_PS)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"update PesageP set supp=true,attente_PS=false   WHERE  PesageP.Num_PS=@Num_PS";
                return con.Execute(sql, new { Num_PS });
                
            }
            catch
            {
                throw;
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
               
                string sql = @" SELECT max(ID_PS)+1 from PesageP ";
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


                return con.Query<int?>(" SELECT max(ID_PS)+1 from PesageP").Single() ?? 1;

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
                string sql = @"delete from PesageP ";
                return con.Execute(sql);

            }
            catch
            {
                throw;
            }
        }
    }
}
