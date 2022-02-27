using Microsoft.Data.SqlClient;
using System;
using CommanLayer.Models;
using Microsoft.Data;

namespace DataAccessLayer
{
    public class DbConnecton
    {
        public SqlConnection Cnn;
        public DbConnecton()
        {
            Cnn = new SqlConnection(Connection.ConnectionStr);
        }
    }
}
