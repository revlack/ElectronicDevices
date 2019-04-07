using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EletronicDevicesApi.Repositories
{
    public abstract class BaseSqlEletronicDevicesRepository
    {
        private readonly string ConnectionString;

        public BaseSqlEletronicDevicesRepository(IConfiguration Configuration) {
            this.ConnectionString = Configuration.GetConnectionString("DefaultConnection");
        }
        public IEnumerable<T> Query<T>(string sql)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                return SqlMapper.Query<T>(connection, sql, null, null, true, null, null);
            }
        }

        public IEnumerable<T> Query<T>(string sql, object param)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                return SqlMapper.Query<T>(connection, sql, param, null, true, null, null);
            }
        }
    }
}
