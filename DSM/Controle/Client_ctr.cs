using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSM.Model;
using Dapper;
using System.Data;
using DevExpress.XtraEditors;

namespace DSM.Controle
{

    public class Client_ctr 
    {

        public List<Client> Select()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                
                return con.Query<Client>("select * from Client").ToList();
            }
            catch  {
                throw;
            }
        }
        public List<Client> aff()
        {
            
            var con = ConnectionFactory.GetConnection();
            try
            {

              
                List<Client> Vc1 = con.Query<Client>("select DISTINCT Code_CL,Nom_CL from Client").ToList();
                List<Client> Vc2 = con.Query<Client>("select DISTINCT Code_CL,Nom_CL from Pesage where Code_CL=0  and Nom_CL<>''").ToList();
               
                return Vc1.Union(Vc2).ToList();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                List<Client> Vc1 = con.Query<Client>("select DISTINCT Code_CL,Nom_CL from Client").ToList();
                return Vc1;
            }
        }
        public List<Client> Select2()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {

                return con.Query<Client>("select * from Client").ToList();
            }
            catch
            {
                throw;
            }
        }
        public bool recherche(int code, List<Client> CL)
        {
            Client client = CL.Find(x => x.Code_CL == code);
            if (client != null) return true;
            else return false;
        }
        public Client Select(int ID_CL)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<Client>("select * from Client where ID_CL=@ID_CL", new { ID_CL }).FirstOrDefault();
              
            }
            catch
            {
                throw;
            }
        }
        public Client Select(string Nom_CL)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<Client>("select * from Client where ID_CL=@Nom_CL", new { Nom_CL }).FirstOrDefault();

            }
            catch
            {
                throw;
            }
        }
        public int ADD(Client client)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO Client (ID_CL,Code_CL,CNIE_CL , Nom_CL , Adr_CL, Tel_CL, Fax_CL)
                               VALUES (@ID_CL,@Code_CL,@CNIE_CL,  @Nom_CL,  @Adr_CL,  @Tel_CL,  @Fax_CL)";
         
                  return con.Execute(sql,new { client.ID_CL,client.Code_CL, client.CNIE_CL, client.Nom_CL, client.Adr_CL, client.Tel_CL, client.Fax_CL });      
                          
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return -1;
            }
        }
        public int update(Client client)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"UPDATE Client   SET CNIE_CL = @CNIE_CL,Code_CL=@Code_CL,Nom_CL = @Nom_CL,Adr_CL = @Adr_CL,Tel_CL = @Tel_CL,Fax_CL = @Fax_CL
                              WHERE  Client.ID_CL=@ID_CL";              
                return con.Execute(sql, new { client.CNIE_CL, client.Code_CL, client.Nom_CL, client.Adr_CL, client.Tel_CL, client.Fax_CL, client.ID_CL });

            }
            catch
            {
                throw;
            }
        }
        public int delete(int ID_CL)
        {
             var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"delete from Client WHERE  Client.ID_CL=@ID_CL";
                return con.Execute(sql, new { ID_CL });

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
                return con.Query<int?>(" SELECT Max(ID_CL)+1 from Client ").Single() ?? 1;

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
                string sql = @"delete from Client ";
                return con.Execute(sql);

            }
            catch
            {
                throw;
            }
        }




    }
}

