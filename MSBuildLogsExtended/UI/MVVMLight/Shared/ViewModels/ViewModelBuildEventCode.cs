using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Messaging;

namespace MSBuildLogsExtended.ViewModels
{

    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// After 2014-01-31 is Asyncronized Wcf Method call
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </para>
    /// </summary>
    public class WPCommonOfBuildEventCodeVM
		: Framework.Xaml.ViewModelBaseWithResultAndUIElement<MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommon, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection, MSBuildLogsExtended.DataSourceEntities.BuildEventCode>
    {
        #region fields and properties

        public const string EntityName_Static = "WPCommonOfBuildEventCodeVM";
		
        #endregion fields and properties
		
        #region Implement abstract EntityName

        public override string EntityName
        {
            get
            {
                return EntityName_Static;
            }
        }

        #endregion Implement abstract EntityName

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the ViewModelBuildEventCode class.
        /// </summary>
        public WPCommonOfBuildEventCodeVM()
        {
			this.EntityCollection = new ObservableCollection<MSBuildLogsExtended.DataSourceEntities.BuildEventCode>();
            
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real": Connect to service, etc...
            ////}
        }

        #endregion Constructor

        #region ClearSearchResult

        /// <summary>
        /// Clears the search result in this.EntityCollection.
        /// </summary>
        protected override void ClearSearchResult()
        {
			string viewName = ViewName_SearchResult;
			Framework.UIAction uiAction = Framework.UIAction.ClearResult;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            this.m_EntityCollection.Clear();

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
        }

        #endregion ClearSearchResult

#if WINDOWS_PHONE
        /// <summary>
        /// Set entity property value from Selected value which parse from selected item.
        /// </summary>
        /// <param name="entity">The entity.</param>
        private void AssignSelectedValueFromSelectedItemToEntity(MSBuildLogsExtended.DataSourceEntities.BuildEventCode entity)
        {

        }	
#endif


        #region Implement abstract Search

        protected override void Search()
        {
            this.SearchStatus = Framework.EntityContracts.SearchStatus.Searching;

            #region Asyncronized wcf method call

            string viewName = ViewName_SearchResult;
            Framework.UIAction uiAction = Framework.UIAction.Search;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            MSBuildLogsExtended.WcfContracts.IBuildEventCodeServiceAsyn _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildEventCode();

            AsyncCallback asyncCallback = delegate(IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
					DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
					{
						var responseMessage = _Instance.EndGetCollectionOfEntityOfCommon(result);
						MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection collection = responseMessage.Message;

						if (this.m_EntityCollection == null)
						{
							this.m_EntityCollection = new ObservableCollection<MSBuildLogsExtended.DataSourceEntities.BuildEventCode>();
						}
                        else
                        {
                            this.m_EntityCollection.Clear();
                        }

#if WINDOWS_PHONE
                        if (this.IsToClearExistingCollection)
                        {
                            this.m_EntityCollection.Clear();
                        }
#endif

						if (collection != null)
						{
							foreach (MSBuildLogsExtended.DataSourceEntities.BuildEventCode item in collection)
							{
								this.m_EntityCollection.Add(item);
						    }
						}


                        if (responseMessage.QueryPagingResult != null)
                        {
                            this.QueryPagingSetting = GetQueryPagingSettingFromQueryPagingResult(responseMessage.QueryPagingResult);

#if WINDOWS_PHONE
                            if (!this.IsToClearExistingCollection && this.QueryPagingSetting.CurrentPage <= this.QueryPagingSetting.CountOfPages)
                            {
                                this.QueryPagingSetting.CurrentPage++;
                            }
#endif
                        }

                        this.SearchStatus = Framework.EntityContracts.SearchStatus.SearchResultLoaded;

						Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    });
				}
                catch (Exception ex)
                {
					DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
					{
						Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
                    });
                }
            };

            try
            {

                if (this.QueryPagingSetting != null && this.QueryPagingSetting.CurrentPage == 0)
                {
                    this.QueryPagingSetting.CurrentPage = 1;
                }
                MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfCommon()
				{
					Critieria = this.Criteria,
					QueryPagingSetting = this.QueryPagingSetting,
					QueryOrderBySettingCollection = this.QueryOrderBySettingCollection,
					BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search,
				};

                _Instance.BeginGetCollectionOfEntityOfCommon(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
				Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }

            #endregion Asyncronized wcf method call

            #region Syncronized wcf method call -- not in use/WPF only

            /*
            if (this.m_EntityCollection == null)
            {
                this.m_EntityCollection = new ObservableCollection<MSBuildLogsExtended.DataSourceEntities.BuildEventCode>();
            }

            this.m_EntityCollection.Clear();

            MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection collection = MSBuildLogsExtended.CommonBLLIoC.IoCBuildEventCode.GetCollectionOfEntityOfCommon(m_CriteriaOfGetCollectionOfEntityOfCommon, this.m_QueryPagingSetting, this.m_QueryOrderBySettingCollection);
            if(collection != null)
            {
                foreach (MSBuildLogsExtended.DataSourceEntities.BuildEventCode item in collection)
                {
                    this.m_EntityCollection.Add(item);
                }
            }
            */
            #endregion Syncronized wcf method call -- not in use/WPF only
        }

#if WINDOWS_PHONE
        ///// <summary>
        ///// Assigns the selected value from selected item to critieria of get collection of default of common.
		///// -- Please Implement for Windows Phone 71.
        ///// </summary>
        ////private void AssignSelectedValueFromSelectedItemToCritieriaOfGetCollectionOfEntityOfCommon()
        //{
		//	// this.m_CriteriaOfGetCollectionOfEntityOfCommon
        //}
#endif

        #endregion Implement abstract Search



        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("EventCode~ASC", "EventCode A-Z");
					list.Add("EventCode~DESC", "EventCode Z-A");
            return list;
        }
    }


}


