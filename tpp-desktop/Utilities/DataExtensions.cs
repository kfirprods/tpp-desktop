using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpp_desktop.Utilities
{
    public static class DataExtensions
    {
        public static DataTable FetchTable(this SQLiteConnection connection, string query)
        {
            var command = new SQLiteCommand(query, connection);

            var table = new DataTable();
            table.Load(command.ExecuteReader());

            return table;
        }

        public static int ExecuteNonQuery(this SQLiteConnection connection, string query)
        {
            return new SQLiteCommand(query, connection).ExecuteNonQuery();
        }
    }
}
