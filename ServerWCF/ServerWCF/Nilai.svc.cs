using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;
using System.Data;
using System.Collections;
using System.Configuration;

namespace ServerWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Nilai" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Nilai.svc or Nilai.svc.cs at the Solution Explorer and start debugging.
    public class Nilai : INilai
    {
        public List<NilaiInfo> getNilaiByID(string id)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            List<NilaiInfo> objList = new List<NilaiInfo>();
            NilaiInfo objNilai = new NilaiInfo();

            using (sqlcon)
            {
                sqlcon.Open();

                string sql = "select*from nilai where nis = @nis";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);

                using (sqlcom)
                {
                    sqlcom.Parameters.AddWithValue("@nis", id);
                    SqlDataReader dr = sqlcom.ExecuteReader();

                    if (dr.Read())
                    {
                        objNilai.NIS = dr.GetInt32(0);
                        objNilai.KodePelajaran = dr.GetString(1);
                        objNilai.KodeKelas = dr.GetString(2);
                        objNilai.ID = dr.GetString(3);
                        objNilai.TahunAjaran = dr.GetString(4);
                        objNilai.Nilai_Harian = dr.GetInt32(5);
                        objNilai.Nilai_UTS = dr.GetInt32(6);
                        objNilai.Nilai_UAS = dr.GetInt32(7);
                        objNilai.Rata_rata = dr.GetInt32(8);
                        objNilai.Keterangan = dr.GetString(9);
                        objNilai.Username = dr.GetString(10);
                        objNilai.Passwords = dr.GetString(11);

                        objList.Add(objNilai);
                    }
                }
                sqlcon.Close();
            }
            return objList;
        }

        public int updateNilai(NilaiInfo data)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            int result = 0;

            using (sqlcon)
            {
                sqlcon.Open();

                string sql = "update nilai set kode_pelajaran = @kode_pelajaran, kode_kelas = @kode_kelas, id_pivot = @id_pivot, tahun_ajaran = @tahun_ajaran, nilai_harian = @nilai_harian, nilai_UTS = @nilai_UTS, nilai_UAS = @nilai_UAS, Rata_rata = @Rata_rata, Keterangan = @Keterangan, username = @username, passwords = @passwords where nis = @nis ";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);

                using (sqlcom)
                {
                    sqlcom.Parameters.AddWithValue("@nis", data.NIS);
                    sqlcom.Parameters.AddWithValue("@kode_pelajaran", data.KodePelajaran);
                    sqlcom.Parameters.AddWithValue("@kode_kelas", data.KodeKelas);
                    sqlcom.Parameters.AddWithValue("@id_pivot", data.ID);
                    sqlcom.Parameters.AddWithValue("@tahun_ajaran", data.TahunAjaran);
                    sqlcom.Parameters.AddWithValue("@nilai_harian", data.Nilai_Harian);
                    sqlcom.Parameters.AddWithValue("@nilai_UTS", data.Nilai_UTS);
                    sqlcom.Parameters.AddWithValue("@nilai_UAS", data.Nilai_UAS);
                    sqlcom.Parameters.AddWithValue("@Rata_rata", data.Rata_rata);
                    sqlcom.Parameters.AddWithValue("@Keterangan", data.Keterangan);
                    sqlcom.Parameters.AddWithValue("@username", data.Username);
                    sqlcom.Parameters.AddWithValue("@passwords", data.Passwords);

                    result = sqlcom.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            return result;
        }

        public int insertNilai(NilaiInfo data)
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            int result = 0;

            using (sqlcon)
            {
                sqlcon.Open();
                string sql = "insert into nilai values(@nis, @kode_pelajaran, @kode_kelas, @id_pivot, @tahun_ajaran, @nilai_harian, @nilai_UTS, @nilai_UAS, @Rata_rata, @Keterangan, @username, @passwords)";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                //SqlCommand cmd = new SqlCommand("INSERT INTO nilai(images) VALUES(@images)");
               // MemoryStream stream = new MemoryStream();
                //pb1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
               // byte[] pic = stream.ToArray();
                //sqlcom.Parameters.AddWithValue("images", pic);

                using (sqlcom)
                {
                    sqlcom.Parameters.AddWithValue("@nis", data.NIS);
                    sqlcom.Parameters.AddWithValue("@kode_pelajaran", data.KodePelajaran);
                    sqlcom.Parameters.AddWithValue("@kode_kelas", data.KodeKelas);
                    sqlcom.Parameters.AddWithValue("@id_pivot", data.ID);
                    sqlcom.Parameters.AddWithValue("@tahun_ajaran", data.TahunAjaran);
                    sqlcom.Parameters.AddWithValue("@nilai_harian", data.Nilai_Harian);
                    sqlcom.Parameters.AddWithValue("@nilai_UTS", data.Nilai_UTS);
                    sqlcom.Parameters.AddWithValue("@nilai_UAS", data.Nilai_UAS);
                    sqlcom.Parameters.AddWithValue("@Rata_rata", data.Rata_rata);
                    sqlcom.Parameters.AddWithValue("@Keterangan", data.Keterangan);
                    sqlcom.Parameters.AddWithValue("@username", data.Username);
                    sqlcom.Parameters.AddWithValue("@passwords", data.Passwords);
                   // sqlcom.Parameters.AddWithValue("@images", data.Images);

                    result = sqlcom.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            return result;
        }

       

        public List<NilaiInfo> getNilai()
        {
            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            List<NilaiInfo> objList = new List<NilaiInfo>();

            using (sqlcon)
            {
                string sql = "select * from nilai";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);

                using (sqlcon)
                {
                    SqlDataReader dr = sqlcom.ExecuteReader();
                    while (dr.Read())
                    {
                        NilaiInfo objNilai = new NilaiInfo();
                        objNilai.NIS = dr.GetInt32(0);
                        objNilai.KodePelajaran = dr.GetString(1);
                        objNilai.KodeKelas = dr.GetString(2);
                        objNilai.ID = dr.GetString(3);
                        objNilai.TahunAjaran = dr.GetString(4);
                        objNilai.Nilai_Harian = dr.GetInt32(5);
                        objNilai.Nilai_UTS = dr.GetInt32(6);
                        objNilai.Nilai_UAS = dr.GetInt32(7);
                        objNilai.Rata_rata = dr.GetInt32(8);
                        objNilai.Keterangan = dr.GetString(9);
                        objNilai.Username = dr.GetString(10);
                        objNilai.Passwords = dr.GetString(11);
                      //  objNilai.Images = dr.GetSqlBinary(12);

                        objList.Add(objNilai);
                    }
                }
                sqlcon.Close();
            }
            return objList;
        }


        public int GantiPass(NilaiInfo data)
        {

            Koneksi kon = new Koneksi();
            SqlConnection sqlcon = kon.getConnection();
            int result = 0;

            using (sqlcon)
            {
                sqlcon.Open();
                string sql = "update nilai set username = @username, passwords = @passwords where nis = @nis ";
                SqlCommand sqlcom = new SqlCommand(sql, sqlcon);

                using (sqlcom)
                {
                    sqlcom.Parameters.AddWithValue("@nis", data.NIS);
                    sqlcom.Parameters.AddWithValue("@username", data.Username);
                    sqlcom.Parameters.AddWithValue("@passwords", data.Passwords);

                    result = sqlcom.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            return result;
        }
        
    }
}
