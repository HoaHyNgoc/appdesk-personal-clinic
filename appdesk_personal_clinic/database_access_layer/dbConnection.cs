using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace database_access_layer
{
    public class dbConnection
    {
        protected SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.DBPersonalClinicConnectionString);
    }
}
