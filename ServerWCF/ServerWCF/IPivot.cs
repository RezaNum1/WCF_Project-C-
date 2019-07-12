using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPivot" in both code and config file together.
    [ServiceContract]
    public interface IPivot
    {
            [OperationContract]
            List<PivotInfo> getPivot();

            [OperationContract]
            List<PivotInfo> getPivotByID(string id);

            [OperationContract]
            int insertPivot(PivotInfo data);

            [OperationContract]
            int updatePivot(PivotInfo data);

            [OperationContract]
            string perulangan();

    }
}
