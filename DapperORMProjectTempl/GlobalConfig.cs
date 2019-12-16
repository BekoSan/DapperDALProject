using DapperORMProjectTempl.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace DapperORMProjectTempl
{
  public static  class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Initialize the connection for your project.
        /// </summary>
        /// <param name="db"></param>
        public static void InitializeConnection(DataBaseType db)
        {
            switch (db)
            {
                case DataBaseType.Sql:
                    SqlConnector sqlConnector = new SqlConnector();
                    Connection = sqlConnector;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Get the connection string from the connection string section in app.config file.
        /// </summary>
        /// <param name="name">The name of the connection string in app.config file.</param>
        /// <returns></returns>
        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
