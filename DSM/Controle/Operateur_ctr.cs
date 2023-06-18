using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSM.Model;
using Dapper;
namespace DSM.Controle
{

    public class Operateur_ctr 
    {

        public List<Operateur> Select()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                
                return con.Query<Operateur>("select * from Operateur").ToList();
            }
            catch  {
                throw;
            }
        }
        public Operateur Select(int ID_Op)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<Operateur>("select * from Operateur where ID_Op=@ID_Op", new { ID_Op }).FirstOrDefault();
              
            }
            catch
            {
                throw;
            }
        }
        public List<Operateur> Aff(int Type_Op,int ID_Op)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                if (Type_Op == 3)
                    return con.Query<Operateur>("select * from Operateur").ToList();
                else if (Type_Op == 1)
                    return con.Query<Operateur>("select * from Operateur where Type_Op = 2 or Type_Op = 1  ").ToList();
                else
                {
                    return con.Query<Operateur>("select * from Operateur where ID_Op=@ID_Op ",new { ID_Op }).ToList();
                }
            }
            catch
            {
                throw;
            }
        }
        public int ADD(Operateur  operateur)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO Operateur (ID_Op , Nom_Op,User_Op , Password_Op, Type_Op,Role_Op, Etat_Op)
                                              VALUES (@ID_Op , @Nom_Op,@User_Op , @Password_Op, @Type_Op,@Role_Op, @Etat_Op)";
         
                  return con.Execute(sql,new { operateur.ID_Op, operateur.Nom_Op, operateur.User_Op, operateur.Password_Op, operateur.Type_Op, operateur.Role_Op, operateur.Etat_Op });      
                          
            }
            catch
            {
                throw;
            }
        }
        public int update(Operateur Operateur)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"UPDATE Operateur   SET User_Op = @User_Op,Password_Op = @Password_Op,Type_Op = @Type_Op,Etat_Op = @Etat_Op,Role_Op = @Role_Op
                              WHERE  Operateur.ID_Op=@ID_Op";              
                return con.Execute(sql, new { Operateur.User_Op, Operateur.Password_Op, Operateur.Type_Op, Operateur.Etat_Op, Operateur.Role_Op, Operateur.ID_Op });

            }
            catch
            {
                throw;
            }
        }
        public int delete(int ID_Op)
        {
             var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"delete from Operateur WHERE  Operateur.ID_Op=@ID_Op";
                return con.Execute(sql, new { ID_Op });

            }
            catch
            {
                throw;
            }
        }
        public int trouver(string User_Op, string Password_Op)
        {
            var con = ConnectionFactory.GetConnection();

            return con.Query<int?>("select count(*) from Operateur where User_Op=@User_Op and Password_Op=@Password_Op", new { User_Op, Password_Op }).Single() ?? 0;



        }
        public Operateur login(string User_Op, string Password_Op)
        {
            var con = ConnectionFactory.GetConnection();
            
              return   con.Query<Operateur>("select * from Operateur where User_Op=@User_Op and Password_Op=@Password_Op", new { User_Op, Password_Op }).FirstOrDefault();

          
           
        }

        public int Max()
        {
           
             var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<int?>(" SELECT Max(ID_Op)+1 from Operateur ").Single()??1;

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
                string sql = @"delete from Operateur where Type_Op=2 or Type_Op=1  ";
                return con.Execute(sql);

            }
            catch
            {
                throw;
            }
        }




    }
}

