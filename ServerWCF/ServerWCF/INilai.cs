using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INilai" in both code and config file together.
    [ServiceContract]
    public interface INilai
    {
        [OperationContract]
        List<NilaiInfo> getNilai();

        [OperationContract]
        List<NilaiInfo> getNilaiByID(string id);

        [OperationContract]
        int insertNilai(NilaiInfo data);

        [OperationContract]
        int updateNilai(NilaiInfo data);

        [OperationContract]
        int GantiPass(NilaiInfo data);
        

       

    }
 
    
}
