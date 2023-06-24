using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Models.Services.Infrastructure
{
    public class SqliteDatabaseAccessor : IDatabaseAccessor
    {
        public DataSet Query(string query)
        {
            var conn = new SqliteConnection("Data Source=Data/MyCourse.db");
            conn.Open();
            var cmd = new SqliteCommand(query, conn);
            var reader=cmd.ExecuteReader();
            while(reader.Read())
            {
                string title = (string)reader["Title"];
            }
            conn.Dispose();
            throw new NotImplementedException();
        }
    }
}