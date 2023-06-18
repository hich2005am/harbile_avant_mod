using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSM.Model;
using Dapper;
namespace DSM.Controle
{

    public class Fournisseur_ctr 
    {

        public List<Fournisseur> Select()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                
                return con.Query<Fournisseur>("SELECT * FROM Fournisseur").ToList();
            }
            catch  {
                throw;
            }
        }
        public List<Fournisseur> aff()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                List<Fournisseur> Vc1 = con.Query<Fournisseur>("select DISTINCT Code_FR,Nom_FR from Fournisseur").ToList();
                List<Fournisseur> Vc2 = con.Query<Fournisseur>("select DISTINCT Code_FR,Nom_FR from Pesage where Code_FR=0 and Nom_FR<>'' ").ToList();

                return Vc1.Union(Vc2).ToList();
            }
            catch
            {
                throw;
            }
        }
        public Fournisseur Select(int ID_FR)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<Fournisseur>("select * from Fournisseur where ID_FR=@ID_FR", new { ID_FR }).FirstOrDefault();
              
            }
            catch
            {
                throw;
            }
        }
        public int ADD(Fournisseur fournisseur)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO Fournisseur (ID_FR,Code_FR,CNIE_FR , Nom_FR , Adr_FR, Tel_FR, Fax_FR)
                               VALUES (@ID_FR,@Code_FR,@CNIE_FR , @Nom_FR , @Adr_FR, @Tel_FR, @Fax_FR)";

                return con.Execute(sql, new { fournisseur.ID_FR,fournisseur.Code_FR, fournisseur.CNIE_FR, fournisseur.Nom_FR, fournisseur.Adr_FR, fournisseur.Tel_FR, fournisseur.Fax_FR });

            }
            catch
            {
                throw;
            }
        }
        public int update(Fournisseur fournisseur)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"UPDATE Fournisseur   SET CNIE_FR = @CNIE_FR,Code_FR=@Code_FR,Nom_FR = @Nom_FR,Adr_FR = @Adr_FR,Tel_FR = @Tel_FR,Fax_FR = @Fax_FR
                              WHERE  Fournisseur.ID_FR=@ID_FR";
                return con.Execute(sql, new { fournisseur.CNIE_FR,fournisseur.Code_FR ,fournisseur.Nom_FR, fournisseur.Adr_FR, fournisseur.Tel_FR, fournisseur.Fax_FR, fournisseur.ID_FR });

            }
            catch
            {
                throw;
            }
        }
        public bool recherche(int code, List<Fournisseur> FR)
        {
            Fournisseur fournisseur = FR.Find(x => x.Code_FR == code);
            if (fournisseur != null) return true;
            else return false;
        }
        public List<Fournisseur> Select2()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<Fournisseur>("SELECT * FROM Fournisseur").ToList();

            }
            catch
            {
                throw;
            }
        }

        //public int ADD(Fournisseur fournisseur)
        //{
        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {
        //        string sql = @"INSERT INTO Fournisseur (CNIE_FR , Nom_FR , Adr_FR, Tel_FR, NOTE_FR)
        //                       VALUES (@CNIE_FR,  @Nom_FR,  @Adr_FR,  @Tel_FR,  @NOTE_FR)";

        //          return con.Execute(sql,new {fournisseur.CNIE_FR, fournisseur.Nom_FR, fournisseur.Adr_FR, fournisseur.Tel_FR, fournisseur.Note_FR });      

        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        //public int update(Fournisseur fournisseur)
        //{
        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {
        //        string sql = @"UPDATE Fournisseur   SET CNIE_FR = @CNIE_CL,Nom_FR = @Nom_CL,Adr_CL = @Adr_FR,Tel_FR = @Tel_FR,NOTE_FR = @NOTE_FR
        //                      WHERE  Fournisseur.ID_CL=@ID_FR";              
        //        return con.Execute(sql, new { fournisseur.CNIE_FR, fournisseur.Nom_FR, fournisseur.Adr_FR, fournisseur.Tel_FR, fournisseur.NOTE_FR, fournisseur.ID_FR });

        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        public int delete(int ID_FR)
        {
             var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"delete from Fournisseur WHERE  Fournisseur.ID_FR=@ID_FR";
                return con.Execute(sql, new { ID_FR });

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
                return con.Query<int?>(" SELECT Max(ID_FR)+1 from Fournisseur ").Single() ?? 1;

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
                string sql = @"delete from Fournisseur ";
                return con.Execute(sql);

            }
            catch
            {
                throw;
            }
        }





    }
}

