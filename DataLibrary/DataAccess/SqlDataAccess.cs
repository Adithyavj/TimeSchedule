using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataLibrary.DataAccess
{
    public class SqlDataAccess
    {
        // Connection String
        public static string GetConnectionString(string connectionName= "ScheduleData")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        // Save, Edit, Delete
        public static int ManipulateData<T>(string storedProcedure,T paramters)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                return connection.Execute(storedProcedure, paramters, 
                    commandType: CommandType.StoredProcedure);
            }
        }

        // Select / Read
        public static List<T> LoadData<T,U>(string storedProcedure, U paramters)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                // This returns Ienumerable, but we convert it to List and Return List<T> - List of Model
                return connection.Query<T>(storedProcedure, paramters, 
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

    }
}
