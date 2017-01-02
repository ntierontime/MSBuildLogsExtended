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
    public class WPCommonOfBuildLogVM
		: Framework.Xaml.ViewModelBaseWithResultAndUIElement<MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaCommon, MSBuildLogsExtended.DataSourceEntities.BuildLogCollection, MSBuildLogsExtended.DataSourceEntities.BuildLog, MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection, MSBuildLogsExtended.DataSourceEntities.BuildLog.Default>
    {
        #region fields and properties

        public const string EntityName_Static = "WPCommonOfBuildLogVM";
		
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
        /// Initializes a new instance of the ViewModelBuildLog class.
        /// </summary>
        public WPCommonOfBuildLogVM()
        {
            this.RefreshNewItem();
			
			this.EntityCollectionDefault = new ObservableCollection<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default>();


		#region Commands for Cascading ComboBox

            this.GetDropDownContentsOfBuildEventCode_1Command = new RelayCommand(this.GetDropDownContentsOfBuildEventCode_1);

            this.GetDropDownContentsOfSolution_1Command = new RelayCommand(this.GetDropDownContentsOfSolution_1);


#if NETFX_CORE
            this.GetDropDownContentsOfSolution_1SelectionChangedCommand = new RelayCommand<Windows.UI.Xaml.Controls.SelectionChangedEventArgs>(
                (e) =>
                {
                    if (e.AddedItems.Count > 0)
                    {
                        Framework.NameValuePair item = (Framework.NameValuePair)e.AddedItems[0];
                        this.GetDropDownContentsOfBuild_1(item);
                    }
                });
#else
            this.GetDropDownContentsOfSolution_1SelectionChangedCommand = new RelayCommand<System.Windows.Controls.SelectionChangedEventArgs>(
                (e) =>
                {
                    if (e.AddedItems.Count > 0)
                    {
                        Framework.NameValuePair item = (Framework.NameValuePair)e.AddedItems[0];
                        this.GetDropDownContentsOfBuild_1(item);
                    }
                });
#endif


		#endregion Commands for Cascading ComboBox



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

            if (this.m_CurrentDefault != null)
            {
                this.CurrentInEditingDefault = this.CurrentDefault.GetAClone(); //MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog.Default>(this.m_CurrentDefault);
            }
            else
            {
                this.CurrentInEditingDefault = null;
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

            this.NewItemDefault = new MSBuildLogsExtended.DataSourceEntities.BuildLog.Default {  };

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

            this.m_EntityCollectionDefault.Clear();

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
        }

        #endregion ClearSearchResult
		
        #region Copy

        protected override void PrepareCopyView()
        {
            this.NewItemDefault = this.CurrentDefault.GetAClone();
        }

        #endregion Copy

		#region Save
		
        /// <summary>
        /// update a MSBuildLogsExtended.DataSourceEntities.BuildLog.
        /// </summary>
        protected override void Save()
        {
            #region Asyncronized wcf method call

			string viewName = ViewName_Edit;
			Framework.UIAction uiAction = Framework.UIAction.Update;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            MSBuildLogsExtended.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

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
                AssignSelectedValueFromSelectedItemToEntity(this.m_CurrentInEditingDefault);
#endif

                MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltIn()
				{
					Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection(),
					BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Update,
				};
                _Request.Critieria.Add(MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(this.m_CurrentInEditingDefault));
				_Instance.BeginUpdateEntity(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
				Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }

            #endregion Asyncronized wcf method call

            #region Syncronized wcf method call -- not in use/WPF only

            /*
            MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.UpdateEntity(this.m_CurrentDefault);
			*/

            #endregion Syncronized wcf method call -- not in use/WPF only

        }

        /// <summary>
        /// Determines whether you can save MSBuildLogsExtended.DataSourceEntities.BuildLog.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if you can; otherwise, <c>false</c>.
        /// </returns>
        protected override bool CanSave()
        {
            return this.m_CurrentDefault != null;
        }

		#endregion Save
		
		#region Add

        /// <summary>
        /// Adds a MSBuildLogsExtended.DataSourceEntities.BuildLog to the list and repo.
        /// </summary>
        protected override void Add()
        {
			#region Asyncronized wcf method call

			string viewName = ViewName_Create;
			Framework.UIAction uiAction = Framework.UIAction.Create;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
			            
			MSBuildLogsExtended.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

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
                AssignSelectedValueFromSelectedItemToEntity(this.m_NewItemDefault);
#endif

                MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltIn()
				{
					Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection(),
					BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create,
				};
                _Request.Critieria.Add(MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(this.m_NewItemDefault));
				_Instance.BeginInsertEntity(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
				Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }

            #endregion Asyncronized wcf method call

            #region Syncronized wcf method call -- not in use/WPF only

            /*
            MSBuildLogsExtended.DataSourceEntities.BuildLog.Default _NewItem = new MSBuildLogsExtended.DataSourceEntities.BuildLog.Default();
            this.m_EntityCollectionDefault.Add(_NewItem);
            MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.InsertEntity(_NewItemDefault);
			*/

            #endregion Syncronized wcf method call -- not in use/WPF only
        }

		#endregion Add

		#region Delete

        /// <summary>,
        /// delete a MSBuildLogsExtended.DataSourceEntities.BuildLog.
        /// </summary>
        protected override void Delete()
        {
			#region Asyncronized wcf method call

			string viewName = ViewName_Delete;
			Framework.UIAction uiAction = Framework.UIAction.Delete;            

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

			MSBuildLogsExtended.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

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
                AssignSelectedValueFromSelectedItemToEntity(this.m_CurrentInEditingDefault);
#endif

                MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltIn _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageBuiltIn()
				{
		            Critieria = new MSBuildLogsExtended.DataSourceEntities.BuildLogCollection(),
					BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Delete,
				};
                _Request.Critieria.Add(MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(this.m_CurrentDefault));
				_Instance.BeginDeleteEntity(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
				Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
			}

            #endregion Asyncronized wcf method call

            #region Syncronized wcf method call -- not in use/WPF only

            /*
            MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.DeleteEntity(this.m_CurrentDefault);//
            this.m_EntityCollectionDefault.Remove(this.m_CurrentDefault);
			*/

            #endregion Syncronized wcf method call -- not in use/WPF only
        }

        /// <summary>
        /// Determines whether you can delete a MSBuildLogsExtended.DataSourceEntities.BuildLog.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if you can; otherwise, <c>false</c>.
        /// </returns>
        protected override bool CanDelete()
        {
            return this.m_CurrentDefault != null;
        }

		#endregion Delete

#if WINDOWS_PHONE
        /// <summary>
        /// Set entity property value from Selected value which parse from selected item.
        /// </summary>
        /// <param name="entity">The entity.</param>
        private void AssignSelectedValueFromSelectedItemToEntity(MSBuildLogsExtended.DataSourceEntities.BuildLog.Default entity)
        {
            entity.BuildEventCodeId = this.ParseDropDownContentsOfBuildEventCode_1SelectedItem();
            entity.Solution_1Id = this.ParseDropDownContentsOfSolution_1SelectedItem();
            entity.BuildId = this.ParseDropDownContentsOfBuild_1SelectedItem();

        }	
#endif
#if WINDOWS_PHONE
		private void AssignSelectedValueFromSelectedItemToCritieriaOfDefault()
        {
            this.m_Criteria.BuildLogQueryCriteriaCommon.IdCommonOfBuildEventCode_1.ValueToCompare = this.ParseDropDownContentsOfBuildEventCode_1SelectedItem();
            this.m_Criteria.BuildLogQueryCriteriaCommon.IdCommonOfSolution_1.ValueToCompare = this.ParseDropDownContentsOfSolution_1SelectedItem();
            this.m_Criteria.BuildLogQueryCriteriaCommon.IdCommonOfBuild_1.ValueToCompare = this.ParseDropDownContentsOfBuild_1SelectedItem();
			
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

            MSBuildLogsExtended.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

            AsyncCallback asyncCallback = delegate(IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
					DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
					{
						var responseMessage = _Instance.EndGetCollectionOfDefaultOfCommon(result);
						MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection collection = responseMessage.Message;

						if (this.m_EntityCollectionDefault == null)
						{
							this.m_EntityCollectionDefault = new ObservableCollection<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default>();
						}

#if WINDOWS_PHONE
                        if (this.IsToClearExistingCollection)
                        {
                            this.m_EntityCollectionDefault.Clear();
                        }
#endif

						if (collection != null)
						{
							foreach (MSBuildLogsExtended.DataSourceEntities.BuildLog.Default item in collection)
							{
								this.m_EntityCollectionDefault.Add(item);
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
#if WINDOWS_PHONE
				this.AssignSelectedValueFromSelectedItemToCritieriaOfDefault();
#endif
                MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfCommon()
				{
					Critieria = this.Criteria,
					QueryPagingSetting = this.QueryPagingSetting,
					QueryOrderBySettingCollection = this.QueryOrderBySettingCollection,
					BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search,
				};

                _Instance.BeginGetCollectionOfDefaultOfCommon(_Request, asyncCallback, null);
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
                this.m_EntityCollectionDefault = new ObservableCollection<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default>();
            }

            this.m_EntityCollectionDefault.Clear();

            MSBuildLogsExtended.DataSourceEntities.BuildLog.DefaultCollection collection = MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.GetCollectionOfDefaultOfCommon(m_CriteriaOfGetCollectionOfDefaultOfCommon, this.m_QueryPagingSetting, this.m_QueryOrderBySettingCollection);
            if(collection != null)
            {
                foreach (MSBuildLogsExtended.DataSourceEntities.BuildLog.Default item in collection)
                {
                    this.m_EntityCollectionDefault.Add(item);
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
        ////private void AssignSelectedValueFromSelectedItemToCritieriaOfGetCollectionOfDefaultOfCommon()
        //{
		//	// this.m_CriteriaOfGetCollectionOfDefaultOfCommon
        //}
#endif

        #endregion Implement abstract Search


		#region Commands for Cascading ComboBox

        public ObservableCollection<Framework.NameValuePair> m_DropDownContentsOfBuildEventCode_1 = new ObservableCollection<Framework.NameValuePair>();

        public ObservableCollection<Framework.NameValuePair> DropDownContentsOfBuildEventCode_1
        {
            get
            {
                return this.m_DropDownContentsOfBuildEventCode_1;
            }
            set
            {
                if (this.m_DropDownContentsOfBuildEventCode_1 == value)
                {
                    return;
                }

                this.m_DropDownContentsOfBuildEventCode_1 = value;
                RaisePropertyChanged("DropDownContentsOfBuildEventCode_1");
            }
        }

#if WINDOWS_PHONE
        public Framework.NameValuePair m_DropDownContentsOfBuildEventCode_1SelectedItem;
        /// <summary>
        /// For Windows Phone PickList for now only
        /// </summary>
        public Framework.NameValuePair DropDownContentsOfBuildEventCode_1SelectedItem 
        {
            get
            {
                return this.m_DropDownContentsOfBuildEventCode_1SelectedItem;
            }
            set
            {
                if (this.m_DropDownContentsOfBuildEventCode_1SelectedItem == value)
                {
                    return;
                }

                this.m_DropDownContentsOfBuildEventCode_1SelectedItem = value;
                RaisePropertyChanged("DropDownContentsOfBuildEventCode_1SelectedItem");
            }
        }

        private System.Int32 ParseDropDownContentsOfBuildEventCode_1SelectedItem()
        {
            if (this.m_DropDownContentsOfBuildEventCode_1SelectedItem == null)
            {
                return default(System.Int32);
            }
            else
            {
                return this.m_DropDownContentsOfBuildEventCode_1SelectedItem.ParseToSystemInt32(this.DropDownContentsOfBuildEventCode_1[0].Value);
            }
        }
#endif

#if NETFX_CORE
        public RelayCommand<Windows.UI.Xaml.Controls.SelectionChangedEventArgs> GetDropDownContentsOfBuildEventCode_1SelectionChangedCommand { get; private set; }
#else
        public RelayCommand<System.Windows.Controls.SelectionChangedEventArgs> GetDropDownContentsOfBuildEventCode_1SelectionChangedCommand { get; private set; }
#endif

        public RelayCommand GetDropDownContentsOfBuildEventCode_1Command { get; private set; }
        public void GetDropDownContentsOfBuildEventCode_1()
        {
            MSBuildLogsExtended.WcfContracts.IBuildEventCodeServiceAsyn _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildEventCode();

            AsyncCallback asyncCallback = delegate(IAsyncResult result)
            {
                try
                {
#if WINDOWS_PHONE
                    DispatcherHelper.Initialize();
#endif
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
                    {
                        var responseMessage = _Instance.EndGetCollectionOfNameValuePairOfAll(result);
                        Framework.NameValueCollection collection = responseMessage.Message;
                        this.DropDownContentsOfBuildEventCode_1.Clear();
                        if (collection != null)
                        {
                            foreach (Framework.NameValuePair item in collection)
                            {
                                this.DropDownContentsOfBuildEventCode_1.Add(item);
                            }
                        }
                    });
                }
                catch (Exception ex)
                {

                }
            };

            try
            {
                MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeRequestMessageUserDefinedOfAll()
                {
                    Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildEventCodeChainedQueryCriteriaAll(),
                    QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(-1, -1),
                    QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection(null),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search,
                };

                _Instance.BeginGetCollectionOfNameValuePairOfAll(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {

            }
        }
        public ObservableCollection<Framework.NameValuePair> m_DropDownContentsOfSolution_1 = new ObservableCollection<Framework.NameValuePair>();

        public ObservableCollection<Framework.NameValuePair> DropDownContentsOfSolution_1
        {
            get
            {
                return this.m_DropDownContentsOfSolution_1;
            }
            set
            {
                if (this.m_DropDownContentsOfSolution_1 == value)
                {
                    return;
                }

                this.m_DropDownContentsOfSolution_1 = value;
                RaisePropertyChanged("DropDownContentsOfSolution_1");
            }
        }

#if WINDOWS_PHONE
        public Framework.NameValuePair m_DropDownContentsOfSolution_1SelectedItem;
        /// <summary>
        /// For Windows Phone PickList for now only
        /// </summary>
        public Framework.NameValuePair DropDownContentsOfSolution_1SelectedItem 
        {
            get
            {
                return this.m_DropDownContentsOfSolution_1SelectedItem;
            }
            set
            {
                if (this.m_DropDownContentsOfSolution_1SelectedItem == value)
                {
                    return;
                }

                this.m_DropDownContentsOfSolution_1SelectedItem = value;
                RaisePropertyChanged("DropDownContentsOfSolution_1SelectedItem");
            }
        }

        private System.Int32 ParseDropDownContentsOfSolution_1SelectedItem()
        {
            if (this.m_DropDownContentsOfSolution_1SelectedItem == null)
            {
                return default(System.Int32);
            }
            else
            {
                return this.m_DropDownContentsOfSolution_1SelectedItem.ParseToSystemInt32(this.DropDownContentsOfSolution_1[0].Value);
            }
        }
#endif

#if NETFX_CORE
        public RelayCommand<Windows.UI.Xaml.Controls.SelectionChangedEventArgs> GetDropDownContentsOfSolution_1SelectionChangedCommand { get; private set; }
#else
        public RelayCommand<System.Windows.Controls.SelectionChangedEventArgs> GetDropDownContentsOfSolution_1SelectionChangedCommand { get; private set; }
#endif

        public RelayCommand GetDropDownContentsOfSolution_1Command { get; private set; }
        public void GetDropDownContentsOfSolution_1()
        {
            MSBuildLogsExtended.WcfContracts.ISolutionServiceAsyn _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceSolution();

            AsyncCallback asyncCallback = delegate(IAsyncResult result)
            {
                try
                {
#if WINDOWS_PHONE
                    DispatcherHelper.Initialize();
#endif
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
                    {
                        var responseMessage = _Instance.EndGetCollectionOfNameValuePairOfAll(result);
                        Framework.NameValueCollection collection = responseMessage.Message;
                        this.DropDownContentsOfSolution_1.Clear();
                        if (collection != null)
                        {
                            foreach (Framework.NameValuePair item in collection)
                            {
                                this.DropDownContentsOfSolution_1.Add(item);
                            }
                        }
                    });
                }
                catch (Exception ex)
                {

                }
            };

            try
            {
                MSBuildLogsExtended.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll _Request = new MSBuildLogsExtended.CommonBLLEntities.SolutionRequestMessageUserDefinedOfAll()
                {
                    Critieria = new MSBuildLogsExtended.CommonBLLEntities.SolutionChainedQueryCriteriaAll(),
                    QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(-1, -1),
                    QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection(null),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search,
                };

                _Instance.BeginGetCollectionOfNameValuePairOfAll(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {

            }
        }
        public ObservableCollection<Framework.NameValuePair> m_DropDownContentsOfBuild_1 = new ObservableCollection<Framework.NameValuePair>();

        public ObservableCollection<Framework.NameValuePair> DropDownContentsOfBuild_1
        {
            get
            {
                return this.m_DropDownContentsOfBuild_1;
            }
        }

#if WINDOWS_PHONE
        public Framework.NameValuePair m_DropDownContentsOfBuild_1SelectedItem;
        /// <summary>
        /// For Windows Phone PickList for now only
        /// </summary>
        public Framework.NameValuePair DropDownContentsOfBuild_1SelectedItem 
        {
            get
            {
                return this.m_DropDownContentsOfBuild_1SelectedItem;
            }
            set
            {
                if (this.m_DropDownContentsOfBuild_1SelectedItem == value)
                {
                    return;
                }

                this.m_DropDownContentsOfBuild_1SelectedItem = value;
                RaisePropertyChanged("DDropDownContentsOfBuild_1SelectedItem");
            }
        }

        private System.Int64 ParseDropDownContentsOfBuild_1SelectedItem()
        {
            if (this.m_DropDownContentsOfBuild_1SelectedItem == null)
            {
                return default(System.Int64);
            }
            else
            {
                return this.m_DropDownContentsOfBuild_1SelectedItem.ParseToSystemInt64(this.DropDownContentsOfBuild_1[0].Value);
            }
        }
#endif

        public void GetDropDownContentsOfBuild_1(Framework.NameValuePair input)
        {
            MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier parentIdentifier = MSBuildLogsExtended.EntityContracts.ISolutionIdentifierHelper.Create<MSBuildLogsExtended.DataSourceEntities.SolutionIdentifier>(input.Value);

            MSBuildLogsExtended.WcfContracts.IBuildServiceAsyn _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuild();

            AsyncCallback asyncCallback = delegate(IAsyncResult result)
            {
                try
                {
#if WINDOWS_PHONE
                    DispatcherHelper.Initialize();
#endif
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate()
                    {
                        var responseMessage = _Instance.EndGetCollectionOfNameValuePairOfByFKOnly(result);
                        Framework.NameValueCollection collection = responseMessage.Message;
                        this.DropDownContentsOfBuild_1.Clear();
                        if (collection != null)
                        {
                            foreach (Framework.NameValuePair item in collection)
                            {
                                this.DropDownContentsOfBuild_1.Add(item);
                            }
                        }
                    });
                }
                catch (Exception ex)
                {

                }
            };

            try
            {
                MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildRequestMessageUserDefinedOfByFKOnly()
                {
                    Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildChainedQueryCriteriaByFKOnly(true,parentIdentifier.Id),
                    QueryPagingSetting = new Framework.EntityContracts.QueryPagingSetting(-1, -1),
                    QueryOrderBySettingCollection = new Framework.EntityContracts.QueryOrderBySettingCollection(null),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Search,
                };

                _Instance.BeginGetCollectionOfNameValuePairOfByFKOnly(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {

            }
        }

		#endregion Commands for Cascading ComboBox



        public override Framework.NameValueCollection GetDefaultListOfQueryOrderBySettingCollecionInString()
        {
            Framework.NameValueCollection list = new Framework.NameValueCollection();
            list.Add("{0}~ASC", "{0} A-Z");
					list.Add("{0}~DESC", "{0} Z-A");
            return list;
        }

    }



}


