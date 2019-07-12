using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ServerWCF
{
    public class PivotInfo
    {
        string id_pivot, kode_kelas;
        int nis;

        [DataMember]
        public string ID
        {
            get { return id_pivot; }
            set { id_pivot = value; }
        }

        [DataMember]
        public string KodeKelas
        {
            get { return kode_kelas; }
            set { kode_kelas = value; }
        }

        [DataMember]
        public int NIS
        {
            get { return nis; }
            set { nis = value; }
        }
    }
}