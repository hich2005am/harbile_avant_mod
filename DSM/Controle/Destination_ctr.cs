using Dapper;
using DSM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSM.Controle
{ 
    class Destination_ctr
    {
        public List<Destination> Select()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {

                return con.Query<Destination>("select * from Destination").ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<Destination> aff()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                //List<Destination> Vc1 = con.Query<Destination>("select DISTINCT ID_DS,Nom_DS from Destination").ToList();
                List<Destination> Vc2 = con.Query<Destination>("select DISTINCT ID_DS,Nom_DS from Pesage where ID_DS=0 and  Nom_DS<>'' ").ToList();

                return Vc2.ToList();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public Destination Select(int ID_DS)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<Destination>("select * from Destination where ID_DS=@ID_DS", new { ID_DS }).FirstOrDefault();

            }
            catch
            {
                throw;
            }
        }
        public int ADD(Destination destination)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO Destination (ID_DS,Nom_DS)
                               VALUES (@ID_DS,@Nom_DS)";

                return con.Execute(sql, new { destination.ID_DS, destination.Nom_DS });

            }
            catch
            {
                throw;
            }
        }
        public int update(Destination destination)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"UPDATE Destination   SET Nom_DS = @Nom_DS
                              WHERE  Destination.ID_DS=@ID_DS";
                return con.Execute(sql, new { destination.Nom_DS,destination.ID_DS });

            }
            catch
            {
                throw;
            }
        }
        public int delete(int ID_DS)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"delete from Destination WHERE  Destination.ID_DS=@ID_DS";
                return con.Execute(sql, new { ID_DS });

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
                return con.Query<int?>(" SELECT Max(ID_DS)+1 from Destination ").Single() ?? 1;

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
                string sql = @"delete from Destination ";
                return con.Execute(sql);

            }
            catch
            {
                throw;
            }
        }



    }
}
