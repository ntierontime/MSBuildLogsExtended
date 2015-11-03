using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Text;
using LinqKit;
using MathNet.Numerics.LinqExtensions;
using System.Data.SqlClient;
using System.Data;

namespace MSBuildLogsExtended.LinqDAL
{
    /// <summary>
    /// Linq data access layer of entity <see cref="MSBuildLogsExtended.DataSourceEntities.Solution"/>, with following methods:
    /// 1. Insert, Update and Delete
    /// 2. Batch Insert, Update and Delete
    /// 3. Queries
    /// </summary>
    public class LinqToSqlDataAccessLayerEntitySolution
        : MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractSolution//<MSBuildLogsExtended.DataSourceEntities.SolutionCollection, MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier>
    {
		#region for log4net

        /// <summary>
        /// for log4net
        /// </summary>
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion for log4net

		#region LinqContext

        /// <summary>
        /// DataContext for Linq
        /// </summary>
        public MSBuildLogsExtended.LinqToSqlContexts.MSBuildLogsExtendedContext LinqContext { get; set; }
        
		#endregion LinqContext

		#region constructors

        /// <summary>
        /// default constructor, developer should assign LinqConext after.
        /// </summary>
        public LinqToSqlDataAccessLayerEntitySolution()
        {
        }

        /// <summary>
        /// constructor with Linq DataContext parameter
        /// </summary>
        /// <param name="linqContext">see<see cref="MSBuildLogsExtended.LinqToSqlContexts.MSBuildLogsExtendedContext"/></param>
        public LinqToSqlDataAccessLayerEntitySolution(MSBuildLogsExtended.LinqToSqlContexts.MSBuildLogsExtendedContext linqContext)
        {
            this.LinqContext = linqContext;
        }

		#endregion constructors

        #region IDataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.SolutionCollection,MSBuildLogsExtended.DataSourceEntities.Solution,MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier> Members

        /// <summary>
        /// single item insert with entity input
        /// </summary>
        /// <param name="input">to-be-inserted instance of entity class</param>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution Insert(MSBuildLogsExtended.DataSourceEntities.Solution input)
        {
            log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            _retval.OriginalValue = new MSBuildLogsExtended.DataSourceEntities.SolutionCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildLogsExtended.LinqToSqlContexts.Solution _LinqItem = MSBuildLogsExtended.EntityContracts.ISolutionHelper.Clone<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.LinqToSqlContexts.Solution>(input);
                this.LinqContext.Solution.InsertOnSubmit(_LinqItem);
                this.LinqContext.SubmitChanges();
                MSBuildLogsExtended.DataSourceEntities.Solution _Result = new MSBuildLogsExtended.DataSourceEntities.Solution();
                MSBuildLogsExtended.EntityContracts.ISolutionHelper.Copy<MSBuildLogsExtended.LinqToSqlContexts.Solution, MSBuildLogsExtended.DataSourceEntities.Solution>(_LinqItem, _Result);
                _retval.Result = new MSBuildLogsExtended.DataSourceEntities.SolutionCollection();
                _retval.Result.Add(_Result);
            }

            log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// single item update with entity input
        /// </summary>
        /// <param name="input">to-be-updated instance of entity class</param>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution Update(MSBuildLogsExtended.DataSourceEntities.Solution input)
        {
            log.Info(string.Format("{0}: Update", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            _retval.OriginalValue = new MSBuildLogsExtended.DataSourceEntities.SolutionCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildLogsExtended.LinqToSqlContexts.Solution _LinqItem = GetLinqObjectByIdentifier(input);
                if (_LinqItem != null)
                {
                    //MSBuildLogsExtended.EntityContracts.ISolutionHelper.Copy<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.LinqToSqlContexts.Solution>(input, _LinqItem);
                    _LinqItem.Id = input.Id;
                    _LinqItem.ExternalParentId = input.ExternalParentId;
                    _LinqItem.Name = input.Name;
                    _LinqItem.Description = input.Description;
                    this.LinqContext.SubmitChanges();
					MSBuildLogsExtended.DataSourceEntities.Solution _Result = new MSBuildLogsExtended.DataSourceEntities.Solution();
					MSBuildLogsExtended.EntityContracts.ISolutionHelper.Copy<MSBuildLogsExtended.LinqToSqlContexts.Solution, MSBuildLogsExtended.DataSourceEntities.Solution>(_LinqItem, _Result);
					_retval.Result = new MSBuildLogsExtended.DataSourceEntities.SolutionCollection();
					_retval.Result.Add(_Result);
                }
            }
            log.Info(string.Format("{0}: Update", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
			return _retval;
        }

        /// <summary>
        /// single item deletion with entity input
        /// </summary>
        /// <param name="input">item to be deleted</param>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution Delete(MSBuildLogsExtended.DataSourceEntities.Solution input)
        {
            log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            _retval.OriginalValue = new MSBuildLogsExtended.DataSourceEntities.SolutionCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildLogsExtended.LinqToSqlContexts.Solution _LinqItem = GetLinqObjectByIdentifier(input);
                if (_LinqItem != null)
                {
                    this.LinqContext.Solution.DeleteOnSubmit(_LinqItem);
                    this.LinqContext.SubmitChanges();
                }
            }
            log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
			return _retval;
        }

        /// <summary>
        /// single item delete by identifier with entity identifier input
        /// </summary>
        /// <param name="id">delete the item if its identifier equals to this parameter</param>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution DeleteByIdentifier(MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier id)
        {
            log.Info(string.Format("{0}: DeleteByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            
			MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();

            if (id != null)
            {
                MSBuildLogsExtended.LinqToSqlContexts.Solution _LinqItem = GetLinqObjectByIdentifier(id);
                if (_LinqItem != null)
                {
					MSBuildLogsExtended.DataSourceEntities.Solution _Original = new MSBuildLogsExtended.DataSourceEntities.Solution();
					MSBuildLogsExtended.EntityContracts.ISolutionHelper.Copy<MSBuildLogsExtended.LinqToSqlContexts.Solution, MSBuildLogsExtended.DataSourceEntities.Solution>(_LinqItem, _Original);

					_retval.OriginalValue = new MSBuildLogsExtended.DataSourceEntities.SolutionCollection();
					_retval.OriginalValue.Add(_Original);

                    this.LinqContext.Solution.DeleteOnSubmit(_LinqItem);
                    this.LinqContext.SubmitChanges();
                }
            }
            log.Info(string.Format("{0}: DeleteByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
			return _retval;
        }

        /// <summary>
        /// Batches insert with entity collection input.
        /// </summary>
        /// <param name="input">The input.</param>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution BatchInsert(MSBuildLogsExtended.DataSourceEntities.SolutionCollection input)
        {
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            #region insert row-by-row to be removed

/*

            if (input != null)
            {
                List<MSBuildLogsExtended.LinqToSqlContexts.Solution> _ListOfLinq = MSBuildLogsExtended.EntityContracts.ISolutionHelper.CloneCollection
                    <
                        MSBuildLogsExtended.DataSourceEntities.SolutionCollection, List<MSBuildLogsExtended.LinqToSqlContexts.Solution>,
                        MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.LinqToSqlContexts.Solution
                    >(input);
                this.LinqContext.Solution.InsertAllOnSubmit<MSBuildLogsExtended.LinqToSqlContexts.Solution>(_ListOfLinq);
                this.LinqContext.SubmitChanges();
                for (int i = 0; i < input.Count; i++)
                {
                    MSBuildLogsExtended.EntityContracts.ISolutionHelper.Copy
                        <
                            MSBuildLogsExtended.LinqToSqlContexts.Solution, MSBuildLogsExtended.DataSourceEntities.Solution
                        >(_ListOfLinq[i], input[i]);
                }
            }

*/

            #endregion insert row-by-row to be removed

			MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            _retval.OriginalValue = input;

            if (input != null && input.Count > 0)
            {
                try
                {
                    DataTable _DataTable = new DataTable();
				_DataTable.Columns.Add("Id", typeof(System.Int32));
				_DataTable.Columns.Add("ExternalParentId", typeof(System.String));
				_DataTable.Columns.Add("Name", typeof(System.String));
				_DataTable.Columns.Add("Description", typeof(System.String));

                    foreach (MSBuildLogsExtended.DataSourceEntities.Solution _Item in input)
                    {
                        _DataTable.Rows.Add(new object[] { _Item.Id, _Item.ExternalParentId, _Item.Name, _Item.Description });
                    }

                    using (SqlBulkCopy s = new SqlBulkCopy(this.LinqContext.Connection.ConnectionString))
                    {
                        s.DestinationTableName = "dbo.Solution";

					s.ColumnMappings.Add("Id", "Id");
					s.ColumnMappings.Add("ExternalParentId", "ExternalParentId");
					s.ColumnMappings.Add("Name", "Name");
					s.ColumnMappings.Add("Description", "Description");

                        s.NotifyAfter = 10000;
                        s.WriteToServer(_DataTable);
                        s.Close();
                    }
                }
                catch (Exception ex)
                {
                    log.Error(string.Format("{0}: Insert", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()), ex);
                }
            }
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
			return _retval;
        }

        /// <summary>
        /// Batches the delete with entity collection input.
        /// </summary>
        /// <param name="input">The input.</param>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution BatchDelete(MSBuildLogsExtended.DataSourceEntities.SolutionCollection input)
        {
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

			MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            _retval.OriginalValue = input;

            if (input != null)
            {
                List<MSBuildLogsExtended.LinqToSqlContexts.Solution> _ListOfLinq = new List<MSBuildLogsExtended.LinqToSqlContexts.Solution>();
                foreach (MSBuildLogsExtended.DataSourceEntities.Solution _ItemOfInput in input)
                {
                    MSBuildLogsExtended.LinqToSqlContexts.Solution _LinqItem = GetLinqObjectByIdentifier(_ItemOfInput);
                    MSBuildLogsExtended.EntityContracts.ISolutionHelper.Copy<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.LinqToSqlContexts.Solution>(_ItemOfInput, _LinqItem);
                    _ListOfLinq.Add(_LinqItem);
                }
                this.LinqContext.Solution.DeleteAllOnSubmit<MSBuildLogsExtended.LinqToSqlContexts.Solution>(_ListOfLinq);
                this.LinqContext.SubmitChanges();
            }
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
			return _retval;
        }

        /// <summary>
        /// Batches the update with entity collection input.
        /// </summary>
        /// <param name="input">The input.</param>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution BatchUpdate(MSBuildLogsExtended.DataSourceEntities.SolutionCollection input)
        {
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

			MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            _retval.OriginalValue = input;

            if (input != null)
            {
                List<MSBuildLogsExtended.LinqToSqlContexts.Solution> _ListOfLinq = new List<MSBuildLogsExtended.LinqToSqlContexts.Solution>();
                foreach (MSBuildLogsExtended.DataSourceEntities.Solution _ItemOfInput in input)
                {
                    MSBuildLogsExtended.LinqToSqlContexts.Solution _LinqItem = GetLinqObjectByIdentifier(_ItemOfInput);
                    MSBuildLogsExtended.EntityContracts.ISolutionHelper.Copy<MSBuildLogsExtended.DataSourceEntities.Solution, MSBuildLogsExtended.LinqToSqlContexts.Solution>(_ItemOfInput, _LinqItem);
                    _ListOfLinq.Add(_LinqItem);
                }
                this.LinqContext.SubmitChanges();

                for (int i = 0; i < input.Count; i++)
                {
                    MSBuildLogsExtended.EntityContracts.ISolutionHelper.Copy
                        <
                            MSBuildLogsExtended.LinqToSqlContexts.Solution, MSBuildLogsExtended.DataSourceEntities.Solution
                        >(_ListOfLinq[i], input[i]);
                }
            }
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
			return _retval;
        }

        /// <summary>
        /// Gets an entity instance by input identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>an instance of <see cref="MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier"/> class, with same identifier.</returns>
        public MSBuildLogsExtended.DataSourceEntities.Solution GetByIdentifier(MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier id)
        {
            MSBuildLogsExtended.LinqToSqlContexts.Solution _Only = GetLinqObjectByIdentifier(id);
            if (_Only != null)
            {
                return new MSBuildLogsExtended.DataSourceEntities.Solution(_Only);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the linq object by identifier.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>an instance of <see cref="MSBuildLogsExtended.LinqToSqlContexts.Solution"/> class, with same identifier, which is a IQueryable.</returns>
        private MSBuildLogsExtended.LinqToSqlContexts.Solution GetLinqObjectByIdentifier(MSBuildLogsExtended.EntityContracts.ISolutionIdentifier id)
        {
            Func<MSBuildLogsExtended.LinqToSqlContexts.Solution, bool> m_Predicate = (MSBuildLogsExtended.LinqToSqlContexts.Solution t) =>
            {
                return MSBuildLogsExtended.EntityContracts.ISolutionIdentifierHelper.Equals<MSBuildLogsExtended.EntityContracts.ISolutionIdentifier, MSBuildLogsExtended.LinqToSqlContexts.Solution>(id, t);
            };

            return this.LinqContext.Solution.SingleOrDefault<MSBuildLogsExtended.LinqToSqlContexts.Solution>(m_Predicate);
        }

        #endregion






        #region Query Methods Of Entity of Common 

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _GetQueryOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Solution
					where
						(
							(
							(criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon.IsToCompare && t.ExternalParentId.Contains(criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon.ValueToBeContained))
							 &&
							(criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare && t.Name.Contains(criteriaOfNameOftOfCommonOfCommonOfCommon.ValueToBeContained))
							 &&
							(criteriaOfDescriptionOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfDescriptionOftOfCommonOfCommonOfCommon.IsToCompare && t.Description.Contains(criteriaOfDescriptionOftOfCommonOfCommonOfCommon.ValueToBeContained))
							)
						)
					select new MSBuildLogsExtended.DataSourceEntities.Solution { Id = t.Id, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description } into x
					select x
				);
			var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
		}

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfEntityOfCommon(
				criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfCommon(
				criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,queryOrderBySettingCollection
			);
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
			return _Count;
        }
		
        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>		
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfCommon(
				criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
					);
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfCommon(
				criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
					);
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntitySolution GetSingleOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntitySolution();
            try
            {
                bool _Exists = _ExistsOfEntityOfCommon(
				criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfCommon(
				criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Solution _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution GetCollectionOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            try
            {
                bool _Exists = _ExistsOfEntityOfCommon(
				criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfCommon(
				criteriaOfExternalParentIdOftOfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Solution> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.SolutionCollection();
					_retMessage.Result.AddRange(_retval);

                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult
                    {
                        RecordCountOfCurrentPage = _retval.Count(),
                        CountOfRecords = _Query.Count(),
                        CurrentIndexOfStartRecord = currentIndex,
                        PageSize = pageSize,
                    };
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of Common 



        #region Query Methods Of Entity of All 

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _GetQueryOfEntityOfAll(
			Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Solution
					select new MSBuildLogsExtended.DataSourceEntities.Solution { Id = t.Id, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description } into x
					select x
				);
			var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
		}

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfEntityOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfEntityOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfEntityOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfAll(
				queryOrderBySettingCollection
			);
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
			return _Count;
        }
		
        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>		
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
					);
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
					);
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntitySolution GetSingleOfEntityOfAll(
			Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntitySolution();
            try
            {
                bool _Exists = _ExistsOfEntityOfAll(
				-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfAll(
				queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Solution _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution GetCollectionOfEntityOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            try
            {
                bool _Exists = _ExistsOfEntityOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfAll(
				queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Solution> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.SolutionCollection();
					_retMessage.Result.AddRange(_retval);

                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult
                    {
                        RecordCountOfCurrentPage = _retval.Count(),
                        CountOfRecords = _Query.Count(),
                        CurrentIndexOfStartRecord = currentIndex,
                        PageSize = pageSize,
                    };
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of All 



        #region Query Methods Of NameValuePair of All 

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.NameValuePair> _GetQueryOfNameValuePairOfAll(
			Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Solution
					let _Value = t.Id.ToString()
					select new Framework.NameValuePair { Name = t.Name, Value = _Value } into vD0
					select vD0
				);
			var _retval = _ResultFromDataSource;
            IQueryable<Framework.NameValuePair> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
		}

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfNameValuePairOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfNameValuePairOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfNameValuePairOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfAll(
				queryOrderBySettingCollection
			);
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
			return _Count;
        }
		
        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>		
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfNameValuePairOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
					);
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfNameValuePairOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
					);
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfAll(
			Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfAll(
				-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfAll(
				queryOrderBySettingCollection
			);

                    Framework.NameValuePair _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfAll(
				queryOrderBySettingCollection
			);

                    IEnumerable<Framework.NameValuePair> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new Framework.NameValueCollection();
					_retMessage.Result.AddRange(_retval);

                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult
                    {
                        RecordCountOfCurrentPage = _retval.Count(),
                        CountOfRecords = _Query.Count(),
                        CurrentIndexOfStartRecord = currentIndex,
                        PageSize = pageSize,
                    };
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of NameValuePair of All 



        #region Query Methods Of RssItem of All 

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<Framework.RssItem> _GetQueryOfRssItemOfAll(
			Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Solution
					let _IdentifierInString = t.Id.ToString()
					select new Framework.RssItem { Title = t.Name, Description = t.ExternalParentId, IdentifierInString = _IdentifierInString } into vD1
					select vD1
				);
			var _retval = _ResultFromDataSource;
            IQueryable<Framework.RssItem> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
		}

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfRssItemOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfRssItemOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfRssItemOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfAll(
				queryOrderBySettingCollection
			);
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
			return _Count;
        }
		
        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>		
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfRssItemOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfRssItemOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
					);
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfRssItemOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfRssItemOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
					);
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        public Framework.DataSourceEntities.DataAccessLayerMessageRssItem GetSingleOfRssItemOfAll(
			Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageRssItem();
            try
            {
                bool _Exists = _ExistsOfRssItemOfAll(
				-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfAll(
				queryOrderBySettingCollection
			);

                    Framework.RssItem _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        public Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection GetCollectionOfRssItemOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection();
            try
            {
                bool _Exists = _ExistsOfRssItemOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfAll(
				queryOrderBySettingCollection
			);

                    IEnumerable<Framework.RssItem> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new Framework.RssItemCollection();
					_retMessage.Result.AddRange(_retval);

                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult
                    {
                        RecordCountOfCurrentPage = _retval.Count(),
                        CountOfRecords = _Query.Count(),
                        CurrentIndexOfStartRecord = currentIndex,
                        PageSize = pageSize,
                    };
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of RssItem of All 



        #region Query Methods Of Entity of ByIdentifier 

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _GetQueryOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Solution
					where
						(
							(
							(criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
							)
						)
					select new MSBuildLogsExtended.DataSourceEntities.Solution { Id = t.Id, ExternalParentId = t.ExternalParentId, Name = t.Name, Description = t.Description } into x
					select x
				);
			var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
		}

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfEntityOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,queryOrderBySettingCollection
			);
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
			return _Count;
        }
		
        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>		
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
					);
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
					);
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntitySolution GetSingleOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntitySolution _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntitySolution();
            try
            {
                bool _Exists = _ExistsOfEntityOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Solution _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution GetCollectionOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionSolution();
            try
            {
                bool _Exists = _ExistsOfEntityOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution> _Query = _GetQueryOfEntityOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Solution> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.SolutionCollection();
					_retMessage.Result.AddRange(_retval);

                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult
                    {
                        RecordCountOfCurrentPage = _retval.Count(),
                        CountOfRecords = _Query.Count(),
                        CurrentIndexOfStartRecord = currentIndex,
                        PageSize = pageSize,
                    };
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of ByIdentifier 



        #region Query Methods Of KeyInformation of ByIdentifier 

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// *internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>IQueryable&lt;...&gt; of Common</returns>
        internal IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation> _GetQueryOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Solution
					where
						(
							(
							(criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
							)
						)
					select new MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation { Id = t.Id } into vD2
					select vD2
				);
			var _retval = _ResultFromDataSource;
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation> _retval1;
            if (queryOrderBySettingCollection == null || queryOrderBySettingCollection.Count == 0)
            {
                _retval1 = _retval;
            }
            else
            {
                _retval1 = _retval.AsQueryable().OrderBy(queryOrderBySettingCollection.GetOrderByExpression());
            }
            return _retval1;
		}

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// *private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>true if any in database, otherwise false</returns>
        private bool _ExistsOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfKeyInformationOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);
            return _Count > 0;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>count of this query criteria</returns>
        private int _GetCountOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,queryOrderBySettingCollection
			);
            int _Count;
            if (currentIndex == -1 || pageSize == -1)
            {
                _Count = _Query.Count();
            }
            else
            {
                _Count = _Query.Skip(currentIndex).Take(pageSize).Count();
            }
			return _Count;
        }
		
        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>Result property will be the count of records in database, 0 if no record in database</returns>		
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfKeyInformationOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
					);
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch(Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = 0;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// *public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>an instance of <see cref="Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean"/></returns>
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfKeyInformationOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
					);
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                _retMessage.Result = _retval;
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = false;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// *public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with single entity</returns>
        public MSBuildLogsExtended.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformation GetSingleOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformation _retMessage = new MSBuildLogsExtended.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformation();
            try
            {
                bool _Exists = _ExistsOfKeyInformationOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation _retval = _Query.SingleOrDefault();

                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = _retval;
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }

        /// <summary>
        /// The return value of this set of query is: <see cref="ASPNETDB_CACHE.DataSourceEntities.AspNet_SqlCacheTablesForChangeNotification"/>
        /// The key query criteria of this set of query is: Common. 
        /// Common query set is a built-in set of query criteria, which will query all foreign keys, string/text value, and range of datatime
        /// There are 7 methods, 1 internal, 2 private and 4 public, for one set of return value and query criteria:
        /// internal _GetQueryOfEntityOf...(...) gives the Linq Query 
        /// private _ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// private _GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public GetCountOfEntityOf...(...) returns count if there is any records meets Query Criteria, otherwise 0
        /// public ExistsOfEntityOf...(...) returns true if there is any records meets Query Criteria, otherwise false
        /// public GetSingleOfEntityOf...(...) returns the first record if there is any records meets Query Criteria, otherwise null
        /// *public GetCollectionOfEntityOf...(...) returns all records if there is any records meets Query Criteria, otherwise null
        /// </summary>
        /// <param name="currentIndex">current page index</param>
        /// <param name="pageSize">page size</param>
        /// <param name="queryOrderBySettingCollection">query OrderBy setting</param>
        /// <returns>result message with entity collection</returns>
        public MSBuildLogsExtended.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildLogsExtended.DataSourceEntities.Solution.DataAccessLayerMessageOfKeyInformationCollection();
            try
            {
                bool _Exists = _ExistsOfKeyInformationOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformation> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.Solution.KeyInformationCollection();
					_retMessage.Result.AddRange(_retval);

                    _retMessage.QueryPagingResult = new Framework.EntityContracts.QueryPagingResult
                    {
                        RecordCountOfCurrentPage = _retval.Count(),
                        CountOfRecords = _Query.Count(),
                        CurrentIndexOfStartRecord = currentIndex,
                        PageSize = pageSize,
                    };
                }
                else
                {
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.SuccessButNoResult;
                    _retMessage.Result = null;
                }
            }
            catch (Exception ex)
            {
                _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Fail;
                _retMessage.Result = null;
                _retMessage.Message = ex.Message;
                log.Error(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of KeyInformation of ByIdentifier 









	}






}

