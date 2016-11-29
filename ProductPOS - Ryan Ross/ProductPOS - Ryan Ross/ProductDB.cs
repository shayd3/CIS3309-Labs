using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPOS___Ryan_Ross
{
    class ProductDB
    {
        public static OleDbConnection GetConnection()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=|DataDirectory|\\ProductDB.accdb;" +
                "Persist Security Info=True";
            OleDbConnection connection = new OleDbConnection(connectionString);
            return connection;
        }
    }
}
