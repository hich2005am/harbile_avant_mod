using Dapper;
using DSM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSM.Controle
{ 
    class Caisse_ctr
    {
        public List<Caisse> Select()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {

                return con.Query<Caisse>("select * from Destination").ToList();
            }
            catch
            {
                throw;
            }
        }
        //public Destination Select(int ID_DS)
        //{
        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {
        //        return con.Query<Destination>("select * from Destination where ID_DS=@ID_DS", new { ID_DS }).FirstOrDefault();

        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        //public int ADD(Destination destination)
        //{
        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {
        //        string sql = @"INSERT INTO Destination (Nom_DS)
        //                       VALUES (@Nom_DS)";

        //        return con.Execute(sql, new { destination.Nom_DS });

        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        //public int update(Destination destination)
        //{
        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {
        //        string sql = @"UPDATE Destination   SET Nom_DS = @Nom_DS
        //                      WHERE  Destination.ID_DS=@ID_DS";
        //        return con.Execute(sql, new { destination.Nom_DS,destination.ID_DS });

        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        //public int delete(int ID_DS)
        //{
        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {
        //        string sql = @"delete from Destination WHERE  Destination.ID_DS=@ID_DS";
        //        return con.Execute(sql, new { ID_DS });

        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        //public int Max()
        //{

        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {
        //        return con.Query<int>(" SELECT Max(ID_DS)from Destination ").Single();

        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}





    }
}
