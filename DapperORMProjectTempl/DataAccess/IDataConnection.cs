using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperORMProjectTempl.DataAccess
{
   public  interface IDataConnection
    {

        /// <summary>
        /// Creates new row of in the table you selected.
        /// </summary>
        /// <typeparam name="T">The type of data model ,you want to save</typeparam>
        /// <param name="model">The data model object.</param>
        /// <param name="commandText">The text of the sql command or stored procdure , you want to perform.</param>
        /// <param name="commandType">The way you want to perform action , by stored  procedure or sql command text.</param>
        /// <returns></returns>
        T Create<T>(T model,string commandText,CommandType commandType = CommandType.StoredProcedure);

        /// <summary>
        /// Gets all the rows in table and put them in list of data model.
        /// </summary>
        /// <typeparam name="T">The type of data model, you want to get.</typeparam>
        /// <param name="commandText">The text of the sql command or stored procdure , you want to perform.</param>
        /// <param name="commandType">The way you want to perform action , by stored  procedure or sql command text.</param>
        /// <returns><see cref="List{T}"/></returns>
        List<T> Get<T>(string commandText, CommandType commandType = CommandType.StoredProcedure);
        
    }
}
