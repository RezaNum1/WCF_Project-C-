using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ServerWCF
{
    public class NilaiInfo
    {
        string id_pivot, kode_pelajaran, kode_kelas, tahun_ajaran, keterangan, username, passwords;
        int nis, nilai_harian, nilai_UTS, nilai_UAS, rata_rata;
       // byte[] images;
     
        


        [DataMember]
        public int NIS
        {
            get { return nis; }
            set { nis = value; }
        }

    
        [DataMember]
        public string KodePelajaran
        {
            get { return kode_pelajaran; }
            set { kode_pelajaran = value; }
        }

        [DataMember]
        public string KodeKelas
        {
            get { return kode_kelas; }
            set { kode_kelas = value; }
        }

        [DataMember]
        public string ID
        {
            get { return id_pivot; }
            set { id_pivot = value; }
        }

        [DataMember]
        public string TahunAjaran
        {
            get { return tahun_ajaran; }
            set { tahun_ajaran = value; }
        }

        [DataMember]
        public int Nilai_Harian
        {
            get { return nilai_harian; }
            set { nilai_harian = value; }
        }

        [DataMember]
        public int Nilai_UTS
        {
            get { return nilai_UTS; }
            set { nilai_UTS = value; }
        }

         [DataMember]
        public int Nilai_UAS
        {
            get { return nilai_UAS;  }
            set { nilai_UAS = value; }
        }

         [DataMember]
         public int Rata_rata
         {
             get { return rata_rata; }
             set { rata_rata = value; }
         }

         [DataMember]
         public string Keterangan
         {
             get { return keterangan; }
             set { keterangan = value; }
         }

         public string Username
         {
             get { return username; }
             set { username = value; }
         }

         public string Passwords
         {
             get { return passwords; }
             set { passwords = value; }
         }

       /* public byte[] Images
         {
             get { return images; }
             set { images = value; }
         }*/
        
        
    }
}