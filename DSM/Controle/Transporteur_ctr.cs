using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSM.Model;
using Dapper;
namespace DSM.Controle
{

    public class Transporteur_ctr
    {

        public List<Transporteur> Select()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                
                return con.Query<Transporteur>("SELECT * FROM Transporteur").ToList();
            }
            catch  {
                throw;
            }
        }
        public List<Transporteur> aff()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                List<Transporteur> Vc1 = con.Query<Transporteur>("select DISTINCT ID_TR,Nom_TR from Transporteur").ToList();
                List<Transporteur> Vc2 = con.Query<Transporteur>("select DISTINCT ID_TR,Nom_TR from Pesage where ID_TR=0 and Nom_TR<>'' ").ToList();

                return Vc1.Union(Vc2).ToList();
            }
            catch
            {
                throw;
            }
        }
        public Transporteur Select(int ID_TR)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<Transporteur>("select * from Transporteur where ID_TR=@ID_TR", new { ID_TR }).FirstOrDefault();
              
            }
            catch
            {
                throw;
            }
        }
        public int ADD(Transporteur transporteur)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO Transporteur (ID_TR,CNIE_TR , Nom_TR , Adr_TR, Tel_TR,Note_TR)
                               VALUES (@ID_TR,@CNIE_TR , @Nom_TR , @Adr_TR, @Tel_TR,@Note_TR)";

                return con.Execute(sql, new { transporteur.ID_TR, transporteur.CNIE_TR, transporteur.Nom_TR, transporteur.Adr_TR, transporteur.Tel_TR,transporteur.Note_TR});

            }
            catch
            {
                throw;
            }
        }
        public int update(Transporteur transporteur)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"UPDATE Transporteur   SET CNIE_TR = @CNIE_TR,Nom_TR = @Nom_TR,Adr_TR = @Adr_TR,Tel_TR = @Tel_TR,Note_TR=@Note_TR
                              WHERE  Transporteur.ID_TR=@ID_TR";
                return con.Execute(sql, new { transporteur.CNIE_TR, transporteur.Nom_TR, transporteur.Adr_TR, transporteur.Tel_TR, transporteur.Note_TR, transporteur.ID_TR });

            }
            catch
            {
                throw;
            }
        }

        //public int ADD(Transporteur transporteur)
        //{
        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {
        //        string sql = @"INSERT INTO Transporteur (CNIE_FR , Nom_FR , Adr_FR, Tel_FR, NOTE_FR)
        //                       VALUES (@CNIE_FR,  @Nom_FR,  @Adr_FR,  @Tel_FR,  @NOTE_FR)";

        //          return con.Execute(sql,new {transporteur.CNIE_FR, transporteur.Nom_FR, transporteur.Adr_FR, transporteur.Tel_FR, transporteur.Note_FR });      

        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        //public int update(Transporteur transporteur)
        //{
        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {
        //        string sql = @"UPDATE Transporteur   SET CNIE_FR = @CNIE_CL,Nom_FR = @Nom_CL,Adr_CL = @Adr_FR,Tel_FR = @Tel_FR,NOTE_FR = @NOTE_FR
        //                      WHERE  Transporteur.ID_CL=@ID_TR";              
        //        return con.Execute(sql, new { transporteur.CNIE_FR, transporteur.Nom_FR, transporteur.Adr_FR, transporteur.Tel_FR, transporteur.NOTE_FR, transporteur.ID_TR });

        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        public int delete(int ID_TR)
        {
             var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"delete from Transporteur WHERE  Transporteur.ID_TR=@ID_TR";
                return con.Execute(sql, new { ID_TR });

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
                return con.Query<int?>(" SELECT Max(ID_TR)+1 from Transporteur ").Single() ?? 1;

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
                string sql = @"delete from Transporteur ";
                return con.Execute(sql);

            }
            catch
            {
                throw;
            }
        }




    }
}

