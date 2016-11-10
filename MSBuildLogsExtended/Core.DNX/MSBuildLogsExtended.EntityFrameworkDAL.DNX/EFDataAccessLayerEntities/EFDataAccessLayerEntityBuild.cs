using System;
using System.Collections.Generic;
using System.Linq;
//using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Text;
using LinqKit;
//using MathNet.Numerics.LinqExtensions;
using System.Data.SqlClient;
using System.Data;

namespace MSBuildLogsExtended.EntityFrameworkDAL
{
    /// <summary>
    /// Linq data access layer of entity <see cref="MSBuildLogsExtended.DataSourceEntities.Build"/>, with following methods:
    /// 1. Insert, Update and Delete
    /// 2. Batch Insert, Update and Delete
    /// 3. Queries
    /// </summary>
    public class EFDataAccessLayerEntityBuild
        : MSBuildLogsExtended.DALContracts.DataAccessLayerEntityContractBuild//<MSBuildLogsExtended.DataSourceEntities.BuildCollection, MSBuildLogsExtended.DataSourceEntities.Build, MSBuildLogsExtended.DataSourceEntities.BuildIdentifier>
    {
		#region for log4net

        /// <summary>
        /// for log4net
        /// </summary>
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(EFDataAccessLayerEntityBuild));

		#endregion for log4net

		#region LinqContext

        /// <summary>
        /// DataContext for EF Linq
        /// </summary>
        public MSBuildLogsExtended.EntityFrameworkContext.MSBuildLogsExtendedEntities LinqContext { get; set; }
        
		#endregion LinqContext

		#region constructors

        /// <summary>
        /// default constructor, developer should assign LinqConext after.
        /// </summary>
        public EFDataAccessLayerEntityBuild()
        {
        }

        /// <summary>
        /// constructor with Linq DataContext parameter
        /// </summary>
        /// <param name="linqContext">see<see cref="MSBuildLogsExtended.EntityFrameworkContext.MSBuildLogsExtendedEntities"/></param>
        public EFDataAccessLayerEntityBuild(MSBuildLogsExtended.EntityFrameworkContext.MSBuildLogsExtendedEntities linqContext)
        {
            this.LinqContext = linqContext;
        }

		#endregion constructors

        #region IDataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildCollection,MSBuildLogsExtended.DataSourceEntities.Build,MSBuildLogsExtended.DataSourceEntities.BuildIdentifier> Members

        /// <summary>
        /// single item insert with entity input
        /// </summary>
        /// <param name="input">to-be-inserted instance of entity class</param>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild Insert(MSBuildLogsExtended.DataSourceEntities.Build input)
        {
            log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild();
            _retval.OriginalValue = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildLogsExtended.EntityFrameworkContext.Build _LinqItem = MSBuildLogsExtended.EntityContracts.IBuildHelper.Clone<MSBuildLogsExtended.DataSourceEntities.Build, MSBuildLogsExtended.EntityFrameworkContext.Build>(input);
                this.LinqContext.Build.Add(_LinqItem);
                this.LinqContext.SaveChanges();
                MSBuildLogsExtended.DataSourceEntities.Build _Result = new MSBuildLogsExtended.DataSourceEntities.Build();
                MSBuildLogsExtended.EntityContracts.IBuildHelper.Copy<MSBuildLogsExtended.EntityFrameworkContext.Build, MSBuildLogsExtended.DataSourceEntities.Build>(_LinqItem, _Result);
                _retval.Result = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
                _retval.Result.Add(_Result);
            }

            log.Info(string.Format("{0}: Insert", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retval;
        }

        /// <summary>
        /// single item update with entity input
        /// </summary>
        /// <param name="input">to-be-updated instance of entity class</param>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild Update(MSBuildLogsExtended.DataSourceEntities.Build input)
        {
            log.Info(string.Format("{0}: Update", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild();
            _retval.OriginalValue = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildLogsExtended.EntityFrameworkContext.Build _LinqItem = GetLinqObjectByIdentifier(input);
                if (_LinqItem != null)
                {
                    MSBuildLogsExtended.EntityContracts.IBuildHelper.Copy<MSBuildLogsExtended.DataSourceEntities.Build, MSBuildLogsExtended.EntityFrameworkContext.Build>(input, _LinqItem);
                    this.LinqContext.SaveChanges();
					MSBuildLogsExtended.DataSourceEntities.Build _Result = new MSBuildLogsExtended.DataSourceEntities.Build();
					MSBuildLogsExtended.EntityContracts.IBuildHelper.Copy<MSBuildLogsExtended.EntityFrameworkContext.Build, MSBuildLogsExtended.DataSourceEntities.Build>(_LinqItem, _Result);
					_retval.Result = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
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
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild Delete(MSBuildLogsExtended.DataSourceEntities.Build input)
        {
            log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild();
            _retval.OriginalValue = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
            _retval.OriginalValue.Add(input);

            if (input != null)
            {
                MSBuildLogsExtended.EntityFrameworkContext.Build _LinqItem = GetLinqObjectByIdentifier(input);
                if (_LinqItem != null)
                {
                    this.LinqContext.Build.Remove(_LinqItem);
                    this.LinqContext.SaveChanges();
                }
            }
            log.Info(string.Format("{0}: Delete", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
			return _retval;
        }

        /// <summary>
        /// single item delete by identifier with entity identifier input
        /// </summary>
        /// <param name="id">delete the item if its identifier equals to this parameter</param>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild DeleteByIdentifier(MSBuildLogsExtended.DataSourceEntities.BuildIdentifier id)
        {
            log.Info(string.Format("{0}: DeleteByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            
			MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild();

            if (id != null)
            {
                MSBuildLogsExtended.EntityFrameworkContext.Build _LinqItem = GetLinqObjectByIdentifier(id);
                if (_LinqItem != null)
                {
					MSBuildLogsExtended.DataSourceEntities.Build _Original = new MSBuildLogsExtended.DataSourceEntities.Build();
					MSBuildLogsExtended.EntityContracts.IBuildHelper.Copy<MSBuildLogsExtended.EntityFrameworkContext.Build, MSBuildLogsExtended.DataSourceEntities.Build>(_LinqItem, _Original);

					_retval.OriginalValue = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
					_retval.OriginalValue.Add(_Original);

                    this.LinqContext.Build.Remove(_LinqItem);
                    this.LinqContext.SaveChanges();
                }
            }
            log.Info(string.Format("{0}: DeleteByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
			return _retval;
        }

        /// <summary>
        /// Batches insert with entity collection input.
        /// </summary>
        /// <param name="input">The input.</param>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild BatchInsert(MSBuildLogsExtended.DataSourceEntities.BuildCollection input)
        {
            log.Info(string.Format("{0}: BatchInsert", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

			MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild();
            _retval.OriginalValue = input;

            if (input != null && input.Count > 0)
            {
                try
                {
                    DataTable _DataTable = new DataTable();
				_DataTable.Columns.Add("Id", typeof(System.Int64));
				_DataTable.Columns.Add("SolutionId", typeof(System.Int32));
				_DataTable.Columns.Add("Name", typeof(System.String));
				_DataTable.Columns.Add("Description", typeof(System.String));
				_DataTable.Columns.Add("BuildStartTime", typeof(System.DateTime));

                    foreach (MSBuildLogsExtended.DataSourceEntities.Build _Item in input)
                    {
                        _DataTable.Rows.Add(new object[] { _Item.Id, _Item.SolutionId, _Item.Name, _Item.Description, _Item.BuildStartTime });
                    }

                    using (SqlBulkCopy s = new SqlBulkCopy(this.LinqContext.Database.Connection.ConnectionString))
                    {
                        s.DestinationTableName = "dbo.Build";

					s.ColumnMappings.Add("Id", "Id");
					s.ColumnMappings.Add("SolutionId", "SolutionId");
					s.ColumnMappings.Add("Name", "Name");
					s.ColumnMappings.Add("Description", "Description");
					s.ColumnMappings.Add("BuildStartTime", "BuildStartTime");

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
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild BatchDelete(MSBuildLogsExtended.DataSourceEntities.BuildCollection input)
        {
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

			MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild();
            _retval.OriginalValue = input;

            if (input != null)
            {
                List<MSBuildLogsExtended.EntityFrameworkContext.Build> _ListOfLinq = new List<MSBuildLogsExtended.EntityFrameworkContext.Build>();
                foreach (MSBuildLogsExtended.DataSourceEntities.Build _ItemOfInput in input)
                {
                    MSBuildLogsExtended.EntityFrameworkContext.Build _LinqItem = GetLinqObjectByIdentifier(_ItemOfInput);	
					this.LinqContext.Build.Remove(_LinqItem);
                }
                this.LinqContext.SaveChanges();
            }
            log.Info(string.Format("{0}: BatchDelete", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
			return _retval;
        }

        /// <summary>
        /// Batches the update with entity collection input.
        /// </summary>
        /// <param name="input">The input.</param>
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild BatchUpdate(MSBuildLogsExtended.DataSourceEntities.BuildCollection input)
        {
            log.Info(string.Format("{0}: BatchUpdate", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

			MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild  _retval = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild();
            _retval.OriginalValue = input;

            if (input != null)
            {
                List<MSBuildLogsExtended.EntityFrameworkContext.Build> _ListOfLinq = new List<MSBuildLogsExtended.EntityFrameworkContext.Build>();
                foreach (MSBuildLogsExtended.DataSourceEntities.Build _ItemOfInput in input)
                {
                    MSBuildLogsExtended.EntityFrameworkContext.Build _LinqItem = GetLinqObjectByIdentifier(_ItemOfInput);
                    MSBuildLogsExtended.EntityContracts.IBuildHelper.Copy<MSBuildLogsExtended.DataSourceEntities.Build, MSBuildLogsExtended.EntityFrameworkContext.Build>(_ItemOfInput, _LinqItem);
                    _ListOfLinq.Add(_LinqItem);
                }
                this.LinqContext.SaveChanges();

                for (int i = 0; i < input.Count; i++)
                {
                    MSBuildLogsExtended.EntityContracts.IBuildHelper.Copy
                        <
                            MSBuildLogsExtended.EntityFrameworkContext.Build, MSBuildLogsExtended.DataSourceEntities.Build
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
        /// <returns>an instance of <see cref="MSBuildLogsExtended.DataSourceEntities.BuildIdentifier"/> class, with same identifier.</returns>
        public MSBuildLogsExtended.DataSourceEntities.Build GetByIdentifier(MSBuildLogsExtended.DataSourceEntities.BuildIdentifier id)
        {
            MSBuildLogsExtended.EntityFrameworkContext.Build _Only = GetLinqObjectByIdentifier(id);
            if (_Only != null)
            {
                return new MSBuildLogsExtended.DataSourceEntities.Build(_Only);
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
        /// <returns>an instance of <see cref="MSBuildLogsExtended.EntityFrameworkContext.Build"/> class, with same identifier, which is a IQueryable.</returns>
        private MSBuildLogsExtended.EntityFrameworkContext.Build GetLinqObjectByIdentifier(MSBuildLogsExtended.EntityContracts.IBuildIdentifier id)
        {
            Func<MSBuildLogsExtended.EntityFrameworkContext.Build, bool> m_Predicate = (MSBuildLogsExtended.EntityFrameworkContext.Build t) =>
            {
                return MSBuildLogsExtended.EntityContracts.IBuildIdentifierHelper.Equals<MSBuildLogsExtended.EntityContracts.IBuildIdentifier, MSBuildLogsExtended.EntityFrameworkContext.Build>(id, t);
            };

            return this.LinqContext.Build.SingleOrDefault<MSBuildLogsExtended.EntityFrameworkContext.Build>(m_Predicate);
        }

        #endregion

		#region Binary Columns



        #endregion Binary Columns



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
        internal IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _GetQueryOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
					where
						(
							(
							(criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon.IsToCompare && Solution_S1_1.Id == criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon.ValueToCompare)
							 &&
							(criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare && t.Name.Contains(criteriaOfNameOftOfCommonOfCommonOfCommon.ValueToBeContained))
							 &&
							(criteriaOfDescriptionOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfDescriptionOftOfCommonOfCommonOfCommon.IsToCompare && t.Description.Contains(criteriaOfDescriptionOftOfCommonOfCommonOfCommon.ValueToBeContained))
							 &&
							(criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.BuildStartTime > criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.BuildStartTime <= criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.UpperBound))
							)
						)
					select new MSBuildLogsExtended.DataSourceEntities.Build { Id = t.Id, SolutionId = t.SolutionId, Name = t.Name, Description = t.Description, BuildStartTime = t.BuildStartTime } into x
					select x
				);
			var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _retval1;
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfEntityOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _Query = _GetQueryOfEntityOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
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
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
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
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
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
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
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
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuild GetSingleOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuild _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuild();
            try
            {
                bool _Exists = _ExistsOfEntityOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _Query = _GetQueryOfEntityOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
				,queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Build _retval = _Query.SingleOrDefault();

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
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild GetCollectionOfEntityOfCommon(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild();
            try
            {
                bool _Exists = _ExistsOfEntityOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _Query = _GetQueryOfEntityOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
				,queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
					_retMessage.Result.AddRange(_retval);
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



        #region Query Methods Of Default of Common 

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
        internal IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _GetQueryOfDefaultOfCommon(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
					where
						(
							(
							(criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon.IsToCompare && Solution_S1_1.Id == criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon.ValueToCompare)
							 &&
							(criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfNameOftOfCommonOfCommonOfCommon.IsToCompare && t.Name.Contains(criteriaOfNameOftOfCommonOfCommonOfCommon.ValueToBeContained))
							 &&
							(criteriaOfDescriptionOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfDescriptionOftOfCommonOfCommonOfCommon.IsToCompare && t.Description.Contains(criteriaOfDescriptionOftOfCommonOfCommonOfCommon.ValueToBeContained))
							 &&
							(criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.IsToCompare == false || criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.IsToCompare && (criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.IsToCompareLowerBound == false || criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.IsToCompareLowerBound && t.BuildStartTime > criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.LowerBound) && (criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.IsToCompareUpperBound == false || criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.IsToCompareUpperBound && t.BuildStartTime <= criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon.UpperBound))
							)
						)
					select new MSBuildLogsExtended.DataSourceEntities.Build.Default { Id = t.Id, SolutionId = t.SolutionId, Name = t.Name, Description = t.Description, BuildStartTime = t.BuildStartTime, Solution_S1_1_Name = Solution_S1_1.Name } into vD2
					select vD2
				);
			var _retval = _ResultFromDataSource;
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _retval1;
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
        private bool _ExistsOfDefaultOfCommon(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfDefaultOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
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
        private int _GetCountOfDefaultOfCommon(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _Query = _GetQueryOfDefaultOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfCommon(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
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
                log.Error(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfCommon(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
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
                log.Error(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfCommon(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefault _retMessage = new MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _Query = _GetQueryOfDefaultOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
				,queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Build.Default _retval = _Query.SingleOrDefault();

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
                log.Error(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfCommon(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfNameOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemStringContainsCriteria criteriaOfDescriptionOftOfCommonOfCommonOfCommon
			,Framework.EntityContracts.QuerySystemDateTimeRangeCriteria criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _Query = _GetQueryOfDefaultOfCommon(
				criteriaOfIdOfSolution_S1_1OfCommonOfCommonOfCommon
				,criteriaOfNameOftOfCommonOfCommonOfCommon
				,criteriaOfDescriptionOftOfCommonOfCommonOfCommon
				,criteriaOfBuildStartTimeOftOfCommonOfCommonOfCommon
				,queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection();
					_retMessage.Result.AddRange(_retval);
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfCommon", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of Common 



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
        internal IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _GetQueryOfEntityOfAll(
			Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
					select new MSBuildLogsExtended.DataSourceEntities.Build { Id = t.Id, SolutionId = t.SolutionId, Name = t.Name, Description = t.Description, BuildStartTime = t.BuildStartTime } into x
					select x
				);
			var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _retval1;
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
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _Query = _GetQueryOfEntityOfAll(
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
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuild GetSingleOfEntityOfAll(
			Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuild _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuild();
            try
            {
                bool _Exists = _ExistsOfEntityOfAll(
				-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _Query = _GetQueryOfEntityOfAll(
				queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Build _retval = _Query.SingleOrDefault();

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
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild GetCollectionOfEntityOfAll(
			int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfAll", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild();
            try
            {
                bool _Exists = _ExistsOfEntityOfAll(
				currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _Query = _GetQueryOfEntityOfAll(
				queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
					_retMessage.Result.AddRange(_retval);
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
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
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
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
					let _IdentifierInString = t.Id.ToString()
					select new Framework.RssItem { Title = t.Name, Description = t.Name, PubDate = t.BuildStartTime, IdentifierInString = _IdentifierInString } into vD1
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



        #region Query Methods Of Entity of ByFKOnly 

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
        internal IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _GetQueryOfEntityOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
					where
						(
							(
							(criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Solution_S1_1.Id == criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							)
						)
					select new MSBuildLogsExtended.DataSourceEntities.Build { Id = t.Id, SolutionId = t.SolutionId, Name = t.Name, Description = t.Description, BuildStartTime = t.BuildStartTime } into x
					select x
				);
			var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _retval1;
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
        private bool _ExistsOfEntityOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfEntityOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        private int _GetCountOfEntityOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _Query = _GetQueryOfEntityOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfEntityOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfEntityOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
                log.Error(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfEntityOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfEntityOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
                log.Error(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuild GetSingleOfEntityOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuild _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuild();
            try
            {
                bool _Exists = _ExistsOfEntityOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _Query = _GetQueryOfEntityOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Build _retval = _Query.SingleOrDefault();

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
                log.Error(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild GetCollectionOfEntityOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild();
            try
            {
                bool _Exists = _ExistsOfEntityOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _Query = _GetQueryOfEntityOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
					_retMessage.Result.AddRange(_retval);
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
                log.Error(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Entity of ByFKOnly 



        #region Query Methods Of NameValuePair of ByFKOnly 

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
        internal IQueryable<Framework.NameValuePair> _GetQueryOfNameValuePairOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
					where
						(
							(
							(criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Solution_S1_1.Id == criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							)
						)
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
        private bool _ExistsOfNameValuePairOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfNameValuePairOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        private int _GetCountOfNameValuePairOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfNameValuePairOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfNameValuePairOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
                log.Error(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfNameValuePairOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfNameValuePairOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
                log.Error(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity GetSingleOfNameValuePairOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntity();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,queryOrderBySettingCollection
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
                log.Error(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection GetCollectionOfNameValuePairOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfNameValuePairEntityCollection();
            try
            {
                bool _Exists = _ExistsOfNameValuePairOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<Framework.NameValuePair> _Query = _GetQueryOfNameValuePairOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,queryOrderBySettingCollection
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
                log.Error(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfNameValuePairOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of NameValuePair of ByFKOnly 



        #region Query Methods Of RssItem of ByFKOnly 

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
        internal IQueryable<Framework.RssItem> _GetQueryOfRssItemOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
					where
						(
							(
							(criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Solution_S1_1.Id == criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							)
						)
					let _IdentifierInString = t.Id.ToString()
					select new Framework.RssItem { Title = t.Name, Description = t.Name, PubDate = t.BuildStartTime, IdentifierInString = _IdentifierInString } into vD1
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
        private bool _ExistsOfRssItemOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfRssItemOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        private int _GetCountOfRssItemOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfRssItemOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfRssItemOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
                log.Error(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfRssItemOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfRssItemOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
                log.Error(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public Framework.DataSourceEntities.DataAccessLayerMessageRssItem GetSingleOfRssItemOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageRssItem _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageRssItem();
            try
            {
                bool _Exists = _ExistsOfRssItemOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,queryOrderBySettingCollection
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
                log.Error(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection GetCollectionOfRssItemOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfRssItemCollection();
            try
            {
                bool _Exists = _ExistsOfRssItemOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<Framework.RssItem> _Query = _GetQueryOfRssItemOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,queryOrderBySettingCollection
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
                log.Error(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfRssItemOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of RssItem of ByFKOnly 



        #region Query Methods Of Default of ByFKOnly 

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
        internal IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _GetQueryOfDefaultOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
					where
						(
							(
							(criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Solution_S1_1.Id == criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							)
						)
					select new MSBuildLogsExtended.DataSourceEntities.Build.Default { Id = t.Id, SolutionId = t.SolutionId, Name = t.Name, Description = t.Description, BuildStartTime = t.BuildStartTime, Solution_S1_1_Name = Solution_S1_1.Name } into vD2
					select vD2
				);
			var _retval = _ResultFromDataSource;
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _retval1;
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
        private bool _ExistsOfDefaultOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfDefaultOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        private int _GetCountOfDefaultOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _Query = _GetQueryOfDefaultOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
                log.Error(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
                log.Error(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefault _retMessage = new MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _Query = _GetQueryOfDefaultOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Build.Default _retval = _Query.SingleOrDefault();

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
                log.Error(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _Query = _GetQueryOfDefaultOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection();
					_retMessage.Result.AddRange(_retval);
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of ByFKOnly 



        #region Query Methods Of DefaultGroupedDataView of ByFKOnly 

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
        internal IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView> _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
					where
						(
							(
							(criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare == false || criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.IsToCompare && Solution_S1_1.Id == criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly.ValueToCompare)
							)
						)
					group t by new { SolutionId = t.SolutionId, Name = string.Format("{0}", Solution_S1_1.ExternalParentId) } into tG
					let _CountPerFK = tG.Count()
					select new MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView { SolutionId = tG.Key.SolutionId, CountPerFK = _CountPerFK, Name = tG.Key.Name } into vD3
					select vD3
				);
			var _retval = _ResultFromDataSource;
            IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView> _retval1;
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
        private bool _ExistsOfDefaultGroupedDataViewOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        private int _GetCountOfDefaultGroupedDataViewOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultGroupedDataViewOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
                log.Error(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultGroupedDataViewOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
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
                log.Error(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultGroupedDataView GetSingleOfDefaultGroupedDataViewOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultGroupedDataView _retMessage = new MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultGroupedDataView();
            try
            {
                bool _Exists = _ExistsOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView _retval = _Query.SingleOrDefault();

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
                log.Error(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultGroupedDataViewCollection GetCollectionOfDefaultGroupedDataViewOfByFKOnly(
			Framework.EntityContracts.QuerySystemInt32EqualsCriteria criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultGroupedDataViewCollection _retMessage = new MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultGroupedDataViewCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView> _Query = _GetQueryOfDefaultGroupedDataViewOfByFKOnly(
				criteriaOfIdOfSolution_S1_1OfByFKOnlyOfByFKOnlyOfByFKOnly
				,queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataView> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.Build.DefaultGroupedDataViewCollection();
					_retMessage.Result.AddRange(_retval);
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultGroupedDataViewOfByFKOnly", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of DefaultGroupedDataView of ByFKOnly 



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
        internal IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _GetQueryOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
					where
						(
							(
							(criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
							)
						)
					select new MSBuildLogsExtended.DataSourceEntities.Build { Id = t.Id, SolutionId = t.SolutionId, Name = t.Name, Description = t.Description, BuildStartTime = t.BuildStartTime } into x
					select x
				);
			var _retval = _ResultFromDataSource.Distinct();
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _retval1;
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _Query = _GetQueryOfEntityOfByIdentifier(
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuild GetSingleOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuild _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityBuild();
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
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _Query = _GetQueryOfEntityOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Build _retval = _Query.SingleOrDefault();

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
        public MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild GetCollectionOfEntityOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfEntityOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild _retMessage = new MSBuildLogsExtended.DataSourceEntities.DataAccessLayerMessageOfEntityCollectionBuild();
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
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build> _Query = _GetQueryOfEntityOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.BuildCollection();
					_retMessage.Result.AddRange(_retval);
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



        #region Query Methods Of Default of ByIdentifier 

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
        internal IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _GetQueryOfDefaultOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
					where
						(
							(
							(criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
							)
						)
					select new MSBuildLogsExtended.DataSourceEntities.Build.Default { Id = t.Id, SolutionId = t.SolutionId, Name = t.Name, Description = t.Description, BuildStartTime = t.BuildStartTime, Solution_S1_1_Name = Solution_S1_1.Name } into vD2
					select vD2
				);
			var _retval = _ResultFromDataSource;
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _retval1;
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
        private bool _ExistsOfDefaultOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            int _Count = _GetCountOfDefaultOfByIdentifier(
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
        private int _GetCountOfDefaultOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _Query = _GetQueryOfDefaultOfByIdentifier(
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfInteger GetCountOfDefaultOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfInteger _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfInteger();
            try
            {
                int _retval = _GetCountOfDefaultOfByIdentifier(
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
                log.Error(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCountOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean ExistsOfDefaultOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean _retMessage = new Framework.DataSourceEntities.DataAccessLayerMessageOfBoolean();
            try
            {
                bool _retval = _ExistsOfDefaultOfByIdentifier(
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
                log.Error(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: ExistsOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefault GetSingleOfDefaultOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefault _retMessage = new MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefault();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,-1
				,-1
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _Query = _GetQueryOfDefaultOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Build.Default _retval = _Query.SingleOrDefault();

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
                log.Error(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetSingleOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
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
        public MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection GetCollectionOfDefaultOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection _retMessage = new MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfDefaultCollection();
            try
            {
                bool _Exists = _ExistsOfDefaultOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,currentIndex
				,pageSize
				,queryOrderBySettingCollection
			);

                if (_Exists)
                {
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _Query = _GetQueryOfDefaultOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build.Default> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.Build.DefaultCollection();
					_retMessage.Result.AddRange(_retval);
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
                log.Error(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Failed.ToString()), ex);
            }
            log.Info(string.Format("{0}: GetCollectionOfDefaultOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Ended.ToString()));
            return _retMessage;
        }
        #endregion Query Methods Of Default of ByIdentifier 



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
        internal IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation> _GetQueryOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
			var _ResultFromDataSource = 
				(
					from t in this.LinqContext.Build
					join Solution_S1_1 in this.LinqContext.Solution on t.SolutionId equals Solution_S1_1.Id
					where
						(
							(
							(criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare == false || criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.IsToCompare && t.Id == criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier.ValueToCompare)
							)
						)
					select new MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation { Id = t.Id } into vD4
					select vD4
				);
			var _retval = _ResultFromDataSource;
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation> _retval1;
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)

        {
            IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
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
        public MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfKeyInformation GetSingleOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetSingleOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));
            MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfKeyInformation _retMessage = new MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfKeyInformation();
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
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,queryOrderBySettingCollection
			);

                    MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation _retval = _Query.SingleOrDefault();

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
        public MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfKeyInformationCollection GetCollectionOfKeyInformationOfByIdentifier(
			Framework.EntityContracts.QuerySystemInt64EqualsCriteria criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
			,int currentIndex
			,int pageSize
			,Framework.EntityContracts.QueryOrderBySettingCollection queryOrderBySettingCollection
			)
        {
            log.Info(string.Format("{0}: GetCollectionOfKeyInformationOfByIdentifier", Framework.LoggingOptions.Data_Access_Layer_Process_Started.ToString()));

            MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfKeyInformationCollection _retMessage = new MSBuildLogsExtended.DataSourceEntities.Build.DataAccessLayerMessageOfKeyInformationCollection();
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
                    IQueryable<MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation> _Query = _GetQueryOfKeyInformationOfByIdentifier(
				criteriaOfIdOftOfByIdentifierOfByIdentifierOfByIdentifier
				,queryOrderBySettingCollection
			);

                    IEnumerable<MSBuildLogsExtended.DataSourceEntities.Build.KeyInformation> _retval;
					
					if (currentIndex == -1 || pageSize == -1)
					{
						_retval = _Query;
					}
					else
					{
						_retval = _Query.Skip(currentIndex).Take(pageSize);
					}
                    _retMessage.DataAccessLayerMessageStatus = Framework.DataSourceEntities.DataAccessLayerMessageStatus.Success;
                    _retMessage.Result = new MSBuildLogsExtended.DataSourceEntities.Build.KeyInformationCollection();
					_retMessage.Result.AddRange(_retval);
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

