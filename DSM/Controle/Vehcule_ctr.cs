using Dapper;
using DSM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSM.Controle
{
    class Vehcule_ctr
    {
        public List<Vehcule> Select()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {

                return con.Query<Vehcule>("select * from Vehcule").ToList();
            }
            catch
            {
                throw;
            }
        }

        public bool recherche(string Mat, List<Vehcule> VC)
        {
            Vehcule vehcule = VC.Find(x => x.MAT_VEH == Mat.Trim());
            if (vehcule != null) return true;
            else return false;
        }
        //public List<Fournisseur> Select2()
        //{
        //    var con = ConnectionFactory.GetConnection();
        //    try
        //    {
        //        return con.Query<Fournisseur>("SELECT * FROM Fournisseur").ToList();

        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        public List<Vehcule> aff()
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
             List<Vehcule> Vc1= con.Query<Vehcule>("select DISTINCT ID_VEH,MAT_VEH from Vehcule").ToList();
             List<Vehcule> Vc2 = con.Query<Vehcule>("select DISTINCT ID_VEH,MAT_VEH from Pesage where ID_VEH=0 ").ToList();

                return Vc1.Union(Vc2).ToList();
            }
            catch
            {
                throw;
            }
        }
        public Vehcule Select(int ID_VEH)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                return con.Query<Vehcule>("select * from Vehcule where ID_VEH=@ID_VEH", new { ID_VEH }).FirstOrDefault();

            }
            catch
            {
                throw;
            }
        }
        public int Tare(int ID_VEH)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
               return  con.QueryAsync<int>("select TAR_VEH from Vehcule where ID_VEH=@ID_VEH", new { ID_VEH }).Result.FirstOrDefault();
                 //vehcule.TAR_VEH.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public int ADD(Vehcule vehcule )
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"INSERT INTO Vehcule (ID_VEH , MAT_VEH , TYPE_VEH, TAR_VEH, Marque_VEH,Note_VEH)
                                            VALUES (@ID_VEH , @MAT_VEH , @TYPE_VEH, @TAR_VEH, @Marque_VEH,@Note_VEH)";

                return con.Execute(sql, new { vehcule.ID_VEH, vehcule.MAT_VEH, vehcule.TYPE_VEH, vehcule.TAR_VEH, vehcule.Marque_VEH,  vehcule.Note_VEH });

            }
            catch
            {
                throw;
            }
        }
        public int update(Vehcule vehcule)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"UPDATE Vehcule   SET TYPE_VEH=@TYPE_VEH, TAR_VEH=@TAR_VEH, Marque_VEH=@Marque_VEH,Note_VEH=@Note_VEH
                              WHERE  Vehcule.ID_VEH=@ID_VEH";
                return con.Execute(sql, new {  vehcule.TYPE_VEH, vehcule.TAR_VEH, vehcule.Marque_VEH, vehcule.Note_VEH, vehcule.ID_VEH});

            }
            catch
            {
                throw;
            }
        }
        public int delete(int ID_VEH)
        {
            var con = ConnectionFactory.GetConnection();
            try
            {
                string sql = @"delete from Vehcule WHERE  Vehcule.ID_VEH=@ID_VEH";
                return con.Execute(sql, new { ID_VEH });

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
               return con.Query<int?>(" SELECT max(ID_VEH)+1 from Vehcule ").Single() ?? 1;
                

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
                string sql = @"delete from Vehcule ";
                return con.Execute(sql);

            }
            catch
            {
                throw;
            }
        }



    }
}
