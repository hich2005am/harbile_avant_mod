using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSM.Model;
using Dapper;
namespace DSM.Controle
{

    public class Produit_ctr
    {

        public List<Produit> Select()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                
                return con.Query<Produit>("select * from Produit").ToList();
            }
            catch  {
                throw;
            }
        }
        
        public Produit Select(int ID_PDT)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<Produit>("select * from Produit where ID_PDT=@ID_PDT", new { ID_PDT }).FirstOrDefault();
              
            }
            catch
            {
                throw;
            }
        }
        public decimal Prix(int ID_PDT)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.QueryAsync<decimal>("select prixUnitaire_PDT from Produit where ID_PDT=@ID_PDT", new { ID_PDT }).Result.FirstOrDefault();
                //vehcule.TAR_VEH.ToString();

            }
            catch
            {
                throw;
            }
        }
        public int ADD(Produit produit)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO Produit (ID_PDT , Designe_PDT , description_PDT, QtInitial_PDT, prixUnitaire_PDT)
                               VALUES (@ID_PDT , @Designe_PDT , @description_PDT, @QtInitial_PDT, @prixUnitaire_PDT)";
         
                  return con.Execute(sql,new { produit.ID_PDT, produit.Designe_PDT, produit.description_PDT, produit.QtInitial_PDT, produit.prixUnitaire_PDT });      
                          
            }
            catch
            {
                throw;
            }
        }
        public int update(Produit produit)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"UPDATE Produit   SET description_PDT=@description_PDT, QtInitial_PDT=@QtInitial_PDT, prixUnitaire_PDT=@prixUnitaire_PDT
                              WHERE  Produit.ID_PDT=@ID_PDT";              
                return con.Execute(sql, new { produit.description_PDT, produit.QtInitial_PDT, produit.prixUnitaire_PDT, produit.ID_PDT });

            }
            catch
            {
                throw;
            }
        }
        public int delete(int ID_PDT)
        {
             var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"delete from Produit WHERE  Produit.ID_PDT=@ID_PDT";
                return con.Execute(sql, new { ID_PDT });

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
                return con.Query<int?>(" SELECT Max(ID_PDT)+1 from Produit ").Single() ?? 1;
             
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
                string sql = @"delete from Produit ";
                return con.Execute(sql);

            }
            catch
            {
                throw;
            }
        }



    }
}

