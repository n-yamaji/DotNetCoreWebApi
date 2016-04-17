using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace DotNetCoreWebApi.Repository
{

    public class YbRepository
    {
        private readonly string connectionString = "Data Source=localhost;Initial Catalog=Wel81;User ID=sa;Password=ymj123!";
        private DbConnection connection;

        public YbRepository()
        {
            this.connection = new SqlConnection(connectionString);
        }

        public IEnumerable<Yb001> GetYb001ByJno(string jno)
        {
            string query = "SELECT * FROM yb001 WHERE 整理番号 = @jno";
            return this.connection.Query<Yb001>(query,new { jno = jno});
        }
    }
}
