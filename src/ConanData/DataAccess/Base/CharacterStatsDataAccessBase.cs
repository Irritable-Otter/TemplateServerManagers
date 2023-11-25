//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a code generation tool.
//     Date generated: 14/05/2018 17:05:24
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using ConanData.Database;
using ConanData.Datasets;
using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Text;

namespace ConanData.DataAccess.Base
{
    /// <summary>
    /// Data access class to perform Fetches, Deletes, Inserts and Updates 
    /// on table character_stats
    /// </summary>
    internal class CharacterStatsDataAccessBase
    {
        #region Constants

        internal const String SCHEMA__NAME = "";
        internal const String TABLE__NAME = "character_stats";

        internal const String COLUMN__CHARID = "char_id";
        internal const String COLUMN__STATTYPE = "stat_type";
        internal const String COLUMN__STATID = "stat_id";
        internal const String COLUMN__STATVALUE = "stat_value";

        #endregion

        private Connection _connection = null;

        public CharacterStatsDataAccessBase(Connection connection)
        {
            _connection = connection;
        }

        #region Properties

        public Connection Connection => _connection;

        #endregion

        #region Fetch Typed DataSets

        /// <summary>
        /// Fetches all the records into a typed dataset from the 
        /// table character_stats
        /// </summary>
        /// <returns>A populated typed dataset</returns>
        public CharacterStatsDataSet FetchDataSetAll()
        {
            Connection connection = Connection;

            StringBuilder sql = new StringBuilder();
            sql.Append(GetSelect());

            CharacterStatsDataSet dataSet = new CharacterStatsDataSet();
            connection.FillDataSet(sql.ToString(), null, CommandType.Text, 300, dataSet, new String[] { TABLE__NAME });
            return dataSet;
        }

        #endregion

        #region Fetch DataTables

        /// <summary>
        /// Fetches all the records into an untyped datatable from the 
        /// table character_stats
        /// </summary>
        /// <returns>A populated untyped datatable</returns>
        public DataTable FetchDataTableAll()
        {
            Connection connection = Connection;

            StringBuilder sql = new StringBuilder();
            sql.Append(GetSelect());

            return connection.ExecuteDataTable(sql.ToString(), null, CommandType.Text, 300, TABLE__NAME);
        }

        #endregion

        #region Support Methods

        protected String GetSelect()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT [{0}].[{1}] AS [CharacterId],", TABLE__NAME, COLUMN__CHARID);
            sql.AppendFormat("[{0}].[{1}] AS [StatType],", TABLE__NAME, COLUMN__STATTYPE);
            sql.AppendFormat("[{0}].[{1}] AS [StatId],", TABLE__NAME, COLUMN__STATID);
            sql.AppendFormat("[{0}].[{1}] AS [StatValue] ", TABLE__NAME, COLUMN__STATVALUE);
            sql.AppendFormat("FROM {0}[{1}] ", SCHEMA__NAME, TABLE__NAME);
            return sql.ToString();
        }

        #endregion
    }
}
