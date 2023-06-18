using Dapper;
using DSM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSM.Controle
{
    class TypVehcule_ctr
    {
        public List<TypVehcule> Select()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {

                return con.Query<TypVehcule>("select * from TypVehcule").ToList();
            }
            catch
            {
                throw;
            }
        }
        public int ADD(TypVehcule typVehcule)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO TypVehcule (ID_Type,Nom_Type,Prix_Type)
                               VALUES (@ID_Type,@Nom_Type,@Prix_Type)";

                return con.Execute(sql, new { typVehcule.ID_Type, typVehcule.Nom_Type,typVehcule.Prix_Type });

            }
            catch
            {
                throw;
            }
        }
        public int update(TypVehcule typVehcule)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"UPDATE TypVehcule   SET Nom_Type = @Nom_Type,
                                                       Prix_Type=@Prix_Type
                              WHERE  TypVehcule.ID_Type=@ID_Type";
                return con.Execute(sql, new { typVehcule.Nom_Type, typVehcule.Prix_Type, typVehcule.ID_Type });

            }
            catch
            {
                throw;
            }
        }
        public int delete(int ID_Type)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"delete from TypVehcule WHERE  TypVehcule.ID_Type=@ID_Type";
                return con.Execute(sql, new { ID_Type });

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
                return con.Query<int?>(" SELECT Max(ID_Type)+1 from TypVehcule ").Single() ?? 1;

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
                string sql = @"delete from TypVehcule ";
                return con.Execute(sql);

            }
            catch
            {
                throw;
            }
        }
    }
}
