using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceApplication99
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDBWCF" in both code and config file together.
    [ServiceContract]
    public interface IDBWCF
    {
        [OperationContract]
        DataSet getEmployee();
    }
}
