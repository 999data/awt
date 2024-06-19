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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DBWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DBWCF.svc or DBWCF.svc.cs at the Solution Explorer and start debugging.
    public class DBWCF : IDBWCF
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataSet ds;

        public DataSet getEmployee()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahil\OneDrive\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30;");
            cmd = new SqlCommand("select * from Employee", conn);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
