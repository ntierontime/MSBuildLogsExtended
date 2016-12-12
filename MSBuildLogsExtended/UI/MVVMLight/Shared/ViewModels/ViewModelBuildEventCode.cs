using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

#if (XAMARIN)
#else
using GalaSoft.MvvmLight.Threading;
#endif

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
		: Framework.Xaml.ViewModelBaseWithResultAndUIElement<MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerChainedQueryCriteriaEntityBuildEventCodeCommon, MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection, MSBuildLogsExtended.DataSourceEntities.BuildEventCode>
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
            this.RefreshNewItem();
			
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

#region RefreshCurrentEditingItem

        protected override void RefreshCurrentEditingItem()
        {
            string viewName = ViewName_Edit;
            Framework.UIAction uiAction = Framework.UIAction.Refresh;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            if (this.m_Current != null)
            {
                this.CurrentInEditing = this.Current.GetAClone(); //MSBuildLogsExtended.EntityContracts.IBuildEventCodeHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCode>(this.m_Current);
            }
            else
            {
                this.CurrentInEditing = null;
            }

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
        }

#endregion RefreshCurrentEditingItem

#region RefreshNewItem

        protected override void RefreshNewItem()
        {
            string viewName = ViewName_Create;
            Framework.UIAction uiAction = Framework.UIAction.Refresh;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            this.NewItem = new MSBuildLogsExtended.DataSourceEntities.BuildEventCode {  };

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
        }

#endregion RefreshNewItem

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
		
#region Copy

        protected override void PrepareCopyView()
        {
            this.NewItem = this.Current.GetAClone();
        }

#endregion Copy

#region Save
		
        /// <summary>
        /// update a MSBuildLogsExtended.DataSourceEntities.BuildEventCode.
        /// </summary>
        protected override void Save()
        {
#region Asyncronized wcf method call

			string viewName = ViewName_Edit;
			Framework.UIAction uiAction = Framework.UIAction.Update;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuildEventCode _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildEventCode();

            AsyncCallback asyncCallback = delegate(IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
					DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
					{
						var responseMessage = _Instance.EndUpdateEntity(result);
						// reload saved default
	                    this.Search();
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
#if WINDOWS_PHONE
                AssignSelectedValueFromSelectedItemToEntity(this.m_CurrentInEditing);
#endif

                MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode()
				{
					Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection(),
					BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update,
				};
                _Request.Critieria.Add(MSBuildLogsExtended.EntityContracts.IBuildEventCodeHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCode>(this.m_CurrentInEditing));
				_Instance.BeginUpdateEntity(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
				Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }

#endregion Asyncronized wcf method call

#region Syncronized wcf method call -- not in use/WPF only

            /*
            MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.UpdateEntity(this.m_Current);
			*/

#endregion Syncronized wcf method call -- not in use/WPF only

        }

        /// <summary>
        /// Determines whether you can save MSBuildLogsExtended.DataSourceEntities.BuildEventCode.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if you can; otherwise, <c>false</c>.
        /// </returns>
        protected override bool CanSave()
        {
            return this.m_Current != null;
        }

#endregion Save
		
#region Add

        /// <summary>
        /// Adds a MSBuildLogsExtended.DataSourceEntities.BuildEventCode to the list and repo.
        /// </summary>
        protected override void Add()
        {
#region Asyncronized wcf method call

			string viewName = ViewName_Create;
			Framework.UIAction uiAction = Framework.UIAction.Create;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
			            
			MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuildEventCode _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildEventCode();

            AsyncCallback asyncCallback = delegate(IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
					DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
					{
						var responseMessage = _Instance.EndInsertEntity(result);

						//// reload default
						this.Search();

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
#if WINDOWS_PHONE
                AssignSelectedValueFromSelectedItemToEntity(this.m_NewItem);
#endif

                MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode()
				{
					Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection(),
					BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create,
				};
                _Request.Critieria.Add(MSBuildLogsExtended.EntityContracts.IBuildEventCodeHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCode>(this.m_NewItem));
				_Instance.BeginInsertEntity(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
				Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }

#endregion Asyncronized wcf method call

#region Syncronized wcf method call -- not in use/WPF only

            /*
            MSBuildLogsExtended.DataSourceEntities.BuildEventCode _NewItem = new MSBuildLogsExtended.DataSourceEntities.BuildEventCode();
            this.m_EntityCollection.Add(_NewItem);
            MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.InsertEntity(_NewItemDefault);
			*/

#endregion Syncronized wcf method call -- not in use/WPF only
        }

#endregion Add

#region Delete

        /// <summary>,
        /// delete a MSBuildLogsExtended.DataSourceEntities.BuildEventCode.
        /// </summary>
        protected override void Delete()
        {
#region Asyncronized wcf method call

			string viewName = ViewName_Delete;
			Framework.UIAction uiAction = Framework.UIAction.Delete;            

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

			MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuildEventCode _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildEventCode();

            AsyncCallback asyncCallback = delegate(IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
					DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
					{
						var responseMessage = _Instance.EndDeleteEntity(result);

						this.Search();

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
#if WINDOWS_PHONE
                AssignSelectedValueFromSelectedItemToEntity(this.m_CurrentInEditing);
#endif

                MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageBuiltInBuildEventCode()
				{
		            Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection(),
					BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete,
				};
                _Request.Critieria.Add(MSBuildLogsExtended.EntityContracts.IBuildEventCodeHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildEventCode, MSBuildLogsExtended.DataSourceEntities.BuildEventCode>(this.m_Current));
				_Instance.BeginDeleteEntity(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
				Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
			}

#endregion Asyncronized wcf method call

#region Syncronized wcf method call -- not in use/WPF only

            /*
            MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.DeleteEntity(this.m_Current);//
            this.m_EntityCollection.Remove(this.m_Current);
			*/

#endregion Syncronized wcf method call -- not in use/WPF only
        }

        /// <summary>
        /// Determines whether you can delete a MSBuildLogsExtended.DataSourceEntities.BuildEventCode.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if you can; otherwise, <c>false</c>.
        /// </returns>
        protected override bool CanDelete()
        {
            return this.m_Current != null;
        }

#endregion Delete

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

            MSBuildLogsExtended.WcfContracts.WcfServiceContractAsynBuildEventCode _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildEventCode();

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

                MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BusinessLogicLayerRequestMessageUserDefinedBuildEventCodeOfCommon()
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

            MSBuildLogsExtended.DataSourceEntities.BuildEventCodeCollection collection = MSBuildLogsExtended.CommonBLLIoC.BusinessLogicLayerEntityStaticBuildEventCode.GetCollectionOfEntityOfCommon(m_CriteriaOfGetCollectionOfEntityOfCommon, this.m_QueryPagingSetting, this.m_QueryOrderBySettingCollection);
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
            list.Add("{0}~ASC", "{0} A-Z");
					list.Add("{0}~DESC", "{0} Z-A");
            return list;
        }

    }



}


