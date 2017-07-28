using System;
using System.Data.SqlClient;
using System.Data;

namespace Common
{
    public static class Database
    {
        public static string ConnectionString
        {
            get
            {
                return "server=.";
            }
        }

        public const string CreateEmployee = "CreateEmployee"; 
    }
}
