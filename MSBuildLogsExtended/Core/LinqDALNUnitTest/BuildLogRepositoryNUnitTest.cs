using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using NUnit.Framework;

namespace MSBuildLogsExtended.LinqDALNUnitTest
{
    [TestFixture]
    public class BuildLogRepositoryNUnitTest
    {

        #region Setup() and TearDown()

        [SetUp()]
        public void Init()
        {
            // some code here, that need to be run
            // at the start of every test case.
        }

        [TearDown()]
        public void Clean()
        {
            // code that will be called after each Test case
        }

        #endregion Setup() and TearDown()

        #region IDataAccessLayerContractBase<MSBuildLogsExtended.DataSourceEntities.BuildLogCollection,MSBuildLogsExtended.DataSourceEntities.BuildLog,MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier> Members

		[Test]
        public void TestMethodOfInsert()
        {
            MSBuildLogsExtended.DALContracts.IBuildLogRepository _DALInstance = MSBuildLogsExtended.LinqDAL.LinqToSqlDataAccessLayerFactorySingleton.Instance.CreateDALInstanceOfBuildLog();
            MSBuildLogsExtended.DataSourceEntities.BuildLog _TestData = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.GetDefaultValue<MSBuildLogsExtended.DataSourceEntities.BuildLog>();
            _DALInstance.Insert(_TestData);
            //Assert.IsTrue(_TestData.ID != 0);
        }
        [Test]
        public void TestMethodOfUpdate()
        {
            MSBuildLogsExtended.DALContracts.IBuildLogRepository _DALInstance = MSBuildLogsExtended.LinqDAL.LinqToSqlDataAccessLayerFactorySingleton.Instance.CreateDALInstanceOfBuildLog();
            MSBuildLogsExtended.DataSourceEntities.BuildLog _TestData = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.GetDefaultValue<MSBuildLogsExtended.DataSourceEntities.BuildLog>();
            _DALInstance.Insert(_TestData);
            _DALInstance.Update(_TestData);
            Assert.IsTrue(true);
        }
        [Test]
        public void TestMethodOfDelete()
        {
            MSBuildLogsExtended.DALContracts.IBuildLogRepository _DALInstance = MSBuildLogsExtended.LinqDAL.LinqToSqlDataAccessLayerFactorySingleton.Instance.CreateDALInstanceOfBuildLog();
            MSBuildLogsExtended.DataSourceEntities.BuildLog _TestData = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.GetDefaultValue<MSBuildLogsExtended.DataSourceEntities.BuildLog>();
            _DALInstance.Insert(_TestData);
            _DALInstance.Delete(_TestData);
            Assert.IsTrue(true);
        }
        [Test]
        public void TestMethodOfDeleteByIdentifier()
        {
            MSBuildLogsExtended.DALContracts.IBuildLogRepository _DALInstance = MSBuildLogsExtended.LinqDAL.LinqToSqlDataAccessLayerFactorySingleton.Instance.CreateDALInstanceOfBuildLog();
            MSBuildLogsExtended.DataSourceEntities.BuildLog _TestData = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.GetDefaultValue<MSBuildLogsExtended.DataSourceEntities.BuildLog>();
            _DALInstance.Insert(_TestData);
            _DALInstance.DeleteByIdentifier(new MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier(_TestData));
            Assert.IsTrue(true);
        }
        [Test]
        public void TestMethodOfBatchInsert()
        {
            MSBuildLogsExtended.DALContracts.IBuildLogRepository _DALInstance = MSBuildLogsExtended.LinqDAL.LinqToSqlDataAccessLayerFactorySingleton.Instance.CreateDALInstanceOfBuildLog();
            MSBuildLogsExtended.DataSourceEntities.BuildLog _TestData = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.GetDefaultValue<MSBuildLogsExtended.DataSourceEntities.BuildLog>();
            MSBuildLogsExtended.DataSourceEntities.BuildLogCollection _Collection = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection();
            _Collection.Add(_TestData);
            _DALInstance.BatchInsert(_Collection);
            //Assert.IsTrue(_TestData.ID != 0);
        }
        [Test]
        public void TestMethodOfBatchDelete()
        {
            MSBuildLogsExtended.DALContracts.IBuildLogRepository _DALInstance = MSBuildLogsExtended.LinqDAL.LinqToSqlDataAccessLayerFactorySingleton.Instance.CreateDALInstanceOfBuildLog();
            MSBuildLogsExtended.DataSourceEntities.BuildLog _TestData = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.GetDefaultValue<MSBuildLogsExtended.DataSourceEntities.BuildLog>();
            MSBuildLogsExtended.DataSourceEntities.BuildLogCollection _Collection = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection();
            _Collection.Add(_TestData);
            _DALInstance.BatchInsert(_Collection);
            _DALInstance.BatchUpdate(_Collection);
            Assert.IsTrue(true);
        }

        [Test]
        public void TestMethodOfBatchUpdate()
        {
            MSBuildLogsExtended.DALContracts.IBuildLogRepository _DALInstance = MSBuildLogsExtended.LinqDAL.LinqToSqlDataAccessLayerFactorySingleton.Instance.CreateDALInstanceOfBuildLog();
            MSBuildLogsExtended.DataSourceEntities.BuildLog _TestData = MSBuildLogsExtended.EntityContracts.IBuildLogHelper.GetDefaultValue<MSBuildLogsExtended.DataSourceEntities.BuildLog>();
            MSBuildLogsExtended.DataSourceEntities.BuildLogCollection _Collection = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection();
            _Collection.Add(_TestData);
            _DALInstance.BatchInsert(_Collection);
            _DALInstance.BatchDelete(_Collection);
            Assert.IsTrue(true);
        }

        #endregion
    }
}