using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSM.Model;
using Dapper;
namespace DSM.Controle
{

    public class Chauffeur_ctr 
    {

        public List<Chauffeur> Select()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {

                return con.Query<Chauffeur>("select * from Chauffeur").ToList();
            }
            catch
            {
                throw;
            }
        }
        public Chauffeur Select(int ID_CH)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<Chauffeur>("select * from Chauffeur where ID_CH=@ID_CH", new { ID_CH }).FirstOrDefault();
              
            }
            catch
            {
                throw;
            }
        }


        public List<Chauffeur> aff()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                List<Chauffeur> Vc1 = con.Query<Chauffeur>("select DISTINCT ID_CH,Nom_CH from Chauffeur").ToList();
                List<Chauffeur> Vc2 = con.Query<Chauffeur>("select DISTINCT ID_CH,Nom_CH from Pesage where ID_CH=0 and Nom_CH<>'' ").ToList();

                return Vc1.Union(Vc2).ToList();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
        public int ADD(Chauffeur chauffeur)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO Chauffeur (ID_CH,CNIE_CH , Nom_CH , Adr_CH, Tel_CH, NOTE_CH)
                               VALUES (@ID_CH,@CNIE_CH,  @Nom_CH,  @Adr_CH,  @Tel_CH,  @NOTE_CH)";
         
                  return con.Execute(sql,new { chauffeur.ID_CH, chauffeur.CNIE_CH, chauffeur.Nom_CH, chauffeur.Adr_CH, chauffeur.Tel_CH, chauffeur.NOTE_CH });      
                          
            }
            catch
            {
                throw;
            }
        }
        public int update(Chauffeur chauffeur)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"UPDATE Chauffeur   SET CNIE_CH = @CNIE_CH,Nom_CH = @Nom_CH,Adr_CH = @Adr_CH,Tel_CH = @Tel_CH,NOTE_CH = @NOTE_CH
                              WHERE  Chauffeur.ID_CH=@ID_CH";              
                return con.Execute(sql, new { chauffeur.CNIE_CH, chauffeur.Nom_CH, chauffeur.Adr_CH, chauffeur.Tel_CH, chauffeur.NOTE_CH, chauffeur.ID_CH });

            }
            catch
            {
                throw;
            }
        }
        public int delete(int ID_CH)
        {
             var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"delete from Chauffeur WHERE  Chauffeur.ID_CH=@ID_CH";
                return con.Execute(sql, new { ID_CH });

            }
            catch
            {
                throw;
            }
        }
        public int Max()
        {
           
             var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<int?>(" SELECT Max(ID_CH)+1 from Chauffeur ").Single() ?? 1;

            }
            catch
            {
                throw;
            }
        }
        public int delete()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"delete from Chauffeur ";
                return con.Execute(sql);

            }
            catch
            {
                throw;
            }
        }





    }
}

