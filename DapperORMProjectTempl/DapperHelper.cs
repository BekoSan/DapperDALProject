using Dapper;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DapperORMProjectTempl
{
   public static  class DapperHelper
    {

        /// <summary>
        /// Generate <see cref="DynamicParameters"/> from the properties of data model.
        /// </summary>
        /// <param name="model">The model object that want to generate parameters for.</param>
        /// <param name="generateId">Checks if you need Id parameter to be passed or not.</param>
        /// <returns></returns>
        public static DynamicParameters GenerateParameters(object model,bool generateId)
        {
            DynamicParameters output = new DynamicParameters();

            var tp = model.GetType();

            foreach (var property in tp.GetProperties())
            {
                if (property.GetValue(model,null) == null) continue;
                if (generateId == false)
                {
                    if (property.Name.Equals("Id"))
                    {
                        continue;
                    } 
                }
                output.Add($"@{property.Name}", property.GetValue(model,null));
            }

            return output;

        }

    }
}
