using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

namespace ServerWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Pivot" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Pivot.svc or Pivot.svc.cs at the Solution Explorer and start debugging.
    public class Pivot : IPivot
    {
        public List<PivotInfo> getPivotByID(string id)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            List<PivotInfo> objList = new List<PivotInfo>();
            PivotInfo objPivot = new PivotInfo();

            using (sqlcon)
            {
                sqlcon.Open();

                string sql = "select*from pivot_kelas where id = @id_pivot";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);

                using (sqlcom)
                {
                    sqlcom.Parameters.AddWithValue("@id_pivot", id);
                    SqlDataReader dr = sqlcom.ExecuteReader();

                    if (dr.Read())
                    {
                        objPivot.ID = dr.GetString(0);
                        objPivot.KodeKelas = dr.GetString(1);
                        objPivot.NIS = dr.GetInt32(2);

                        objList.Add(objPivot);
                    }
                }
                sqlcon.Close();
            }
            return objList;
        }

        public int updatePivot(PivotInfo data)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            int result = 0;

            using (sqlcon)
            {
                sqlcon.Open();

                string sql = "update barang set kode_kelas = @kode_kelas, nis = @nis where id_pivot = @id_pivot";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);

                using (sqlcom)
                {
                    sqlcom.Parameters.AddWithValue("@id_pivot", data.ID);
                    sqlcom.Parameters.AddWithValue("@kode_kelas", data.KodeKelas);
                    sqlcom.Parameters.AddWithValue("@nis", data.NIS);

                    result = sqlcom.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            return result;
        }

        public int insertPivot(PivotInfo data)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            int result = 0;

            using (sqlcon)
            {
                string sql = "insert into pivot_kelas values(@id_pivot, @kode_kelas, @nis)";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                sqlcon.Open();

                using (sqlcom)
                {
                    sqlcom.Parameters.AddWithValue("@id_pivot", data.ID);
                    sqlcom.Parameters.AddWithValue("@kode_kelas", data.KodeKelas);
                    sqlcom.Parameters.AddWithValue("@nis", data.NIS);

                    result = sqlcom.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            return result;
        }

        public List<PivotInfo> getPivot()
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            List<PivotInfo> objList = new List<PivotInfo>();

            using (sqlcon)
            {
                string sql = "select * from pivot_kelas";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);

                using (sqlcon)
                {
                    SqlDataReader dr = sqlcom.ExecuteReader();
                    while (dr.Read())
                    {
                        PivotInfo objPivot = new PivotInfo();
                        objPivot.ID = dr.GetString(0);
                        objPivot.KodeKelas = dr.GetString(1);
                        objPivot.NIS = dr.GetInt32(2);

                        objList.Add(objPivot);
                    }
                }
                sqlcon.Close();
            }
            return objList;
        }

        public string perulangan()
        {
            SqlDataReader read = null;
            string Jumlah;
            int nomor;
            string kode = "";


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QQKAF15;Initial Catalog=RapotWCF;User ID=sa;Password=123456789");
            con.Open();
            string com = "SELECT COUNT (id_pivot) AS Kode FROM pivot_kelas";
            SqlCommand cmd = new SqlCommand(com, con);
            cmd.ExecuteNonQuery();
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                Jumlah = read["Kode"].ToString();
                nomor = Convert.ToInt16(Jumlah);
                nomor = nomor + 1;
                if (nomor == 0)
                {
                    kode = "P000" + nomor.ToString();
                }
                else if (nomor < 10)
                {
                    kode = "P00" + nomor.ToString();
                }
                else if (nomor < 100)
                {
                    kode = "P0" + nomor.ToString();
                }
                else
                {
                    kode = "P" + nomor.ToString();
                }
                //textBox1.Text = kode;
            }
            con.Close();
            return kode;
        }

    }
}
