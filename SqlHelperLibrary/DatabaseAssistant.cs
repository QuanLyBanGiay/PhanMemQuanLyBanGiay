using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace SqlHelperLibrary
{
    public abstract class DatabaseAssistant
    {
        #region Methods

        /// <summary>
        /// Create new connection
        /// </summary>
        /// <param nam="pConnectionString">connection string</param>
        public abstract void CreateConnection(string pConnectionString);

        /// <summary>
        /// ExecuteScalar
        /// </summary>
        /// <param name="pQuery">String Sql query</param>
        /// <returns>object</returns>
        public abstract object ExecuteScalar(string pQuery);

        /// <summary>
        /// Excute query
        /// </summary>
        /// <param name="pQuery">String sql query</param>
        /// <returns>DataTable</returns>
        public abstract DataTable ExcuteQuery(string pQuery);

        /// <summary>
        /// Excute query
        /// </summary>
        /// <param name="pQuery">String sql query</param>
        /// <param name="pDataTable">DataTable will contain data</param>
        /// <returns>SqlDataAdapter</returns>
        public abstract object ExcuteQuery(string pQuery, out DataTable pDataTable);

        /// <summary>
        /// Update data
        /// </summary>
        /// <param name="pDataAdapter">DataAdapter</param>
        /// <param name="pDataRow">DataRow</param>
        /// <returns>bool</returns>
        public abstract bool Update(object pDataAdapter, DataRow pDataRow);

        /// <summary>
        /// Update data
        /// </summary>
        /// <param name="pDataAdapter">DataAdapter</param>
        /// <param name="pDataRows">DataRow[]</param>
        /// <returns>bool</returns>
        public abstract bool Update(object pDataAdapter, DataRow[] pDataRows);

        /// <summary>
        /// Update data
        /// </summary>
        /// <param name="pDataAdapter">DataAdapter</param>
        /// <param name="DataTable">DataTable</param>
        /// <returns>bool</returns>
        public abstract bool Update(object pDataAdapter, DataTable pDataTable);

        /// <summary>
        /// Test connection
        /// </summary>
        /// <returns>boolean</returns>
        public abstract bool TestConnection();

        #endregion


    }
}