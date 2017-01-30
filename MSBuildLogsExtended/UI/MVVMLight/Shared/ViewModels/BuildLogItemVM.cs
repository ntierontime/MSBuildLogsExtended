using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MSBuildLogsExtended.DataSourceEntities;

namespace MSBuildLogsExtended.ViewModels
{
    public partial class BuildLogItemVM : Framework.Xaml.ViewModelItemBase<MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier, MSBuildLogsExtended.DataSourceEntities.BuildLog.Default>
    {
        #region constructor

        public BuildLogItemVM()
            : base()
        {
            
        }

        #endregion constructor

        #region fields and properties

        public const string EntityName_Static = "WPCommonOfBuildLogVM";


        public override string EntityName
        {
            get
            {
                return EntityName_Static;
            }
        }

        #endregion fields and properties

        protected override void Add()
        {
            #region Asyncronized wcf method call

            string viewName = ViewName_Create;
            Framework.UIAction uiAction = Framework.UIAction.Create;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            MSBuildLogsExtended.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

            AsyncCallback asyncCallback = delegate (IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        var responseMessage = _Instance.EndInsertEntity(result);

                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    });
                }
                catch (Exception ex)
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        if (!this.SuppressMVVMLightEventToCommandMessage)
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
                _Request.Critieria.Add(MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(this.m_Item));
                _Instance.BeginInsertEntity(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
                if (!this.SuppressMVVMLightEventToCommandMessage)
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

        protected override void Delete()
        {
            #region Asyncronized wcf method call

            string viewName = ViewName_Delete;
            Framework.UIAction uiAction = Framework.UIAction.Delete;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            MSBuildLogsExtended.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

            AsyncCallback asyncCallback = delegate (IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        var responseMessage = _Instance.EndDeleteEntity(result);

                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    });
                }
                catch (Exception ex)
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        if (!this.SuppressMVVMLightEventToCommandMessage)
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
                _Request.Critieria.Add(MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(this.m_Item));
                _Instance.BeginDeleteEntity(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
                if (!this.SuppressMVVMLightEventToCommandMessage)
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

        protected override void RefreshItemNoMessage()
        {
            this.Item = this.OriginalItem.GetAClone();
        }

        protected override void Save()
        {
            #region Asyncronized wcf method call

            string viewName = ViewName_Edit;
            Framework.UIAction uiAction = Framework.UIAction.Update;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));

            MSBuildLogsExtended.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

            AsyncCallback asyncCallback = delegate (IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        var responseMessage = _Instance.EndUpdateEntity(result);

                        if (!this.SuppressMVVMLightEventToCommandMessage)
                            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
                    });
                }
                catch (Exception ex)
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        if (!this.SuppressMVVMLightEventToCommandMessage)
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
                _Request.Critieria.Add(MSBuildLogsExtended.EntityContracts.IBuildLogHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLog>(this.m_Item));
                _Instance.BeginUpdateEntity(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
                if (!this.SuppressMVVMLightEventToCommandMessage)
                    Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Failed, ex.Message));
            }

            #endregion Asyncronized wcf method call

            #region Syncronized wcf method call -- not in use/WPF only

            /*
            MSBuildLogsExtended.CommonBLLIoC.IoCBuildLog.UpdateEntity(this.m_CurrentDefault);
			*/

            #endregion Syncronized wcf method call -- not in use/WPF only
        }

        public override void ReLoadItem(MSBuildLogsExtended.DataSourceEntities.BuildLog.Default o)
        {
            var identifier = MSBuildLogsExtended.EntityContracts.IBuildLogIdentifierHelper.Clone<MSBuildLogsExtended.DataSourceEntities.BuildLog.Default, MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier>(o);
            this.LoadItem(identifier);
        }

        public override void LoadItem(MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier identifier)
        {
                if(identifier != null)
                {
                    this.Criteria = identifier;
                }
                else
                {
                    this.Criteria = new MSBuildLogsExtended.DataSourceEntities.BuildLogIdentifier(this.Item);
                }

                #region Asyncronized wcf method call

                MSBuildLogsExtended.WcfContracts.IBuildLogServiceAsyn _Instance = MSBuildLogsExtended.WcfContracts.WcfServiceResolverAsyn.ResolveWcfServiceBuildLog();

            AsyncCallback asyncCallback = delegate (IAsyncResult result)
            {
#if WINDOWS_PHONE
				DispatcherHelper.Initialize();
#endif
                try
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                        var responseMessage = _Instance.EndGetSingleOfDefaultOfByIdentifier(result);
                        this.Item = responseMessage.Message[0];
                    });
                }
                catch (Exception ex)
                {
                    DispatcherHelper.CheckBeginInvokeOnUI((Action)delegate ()
                    {
                    });
                }
            };


            try
            {

                MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier _Request = new MSBuildLogsExtended.CommonBLLEntities.BuildLogRequestMessageUserDefinedOfByIdentifier()
                {
                    Critieria = new MSBuildLogsExtended.CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier(true, this.Criteria.Id),
                    BusinessLogicLayerRequestID = Guid.NewGuid().ToString(),
                    BusinessLogicLayerRequestTypes = Framework.CommonBLLEntities.BusinessLogicLayerRequestTypes.Create,
                };
                _Instance.BeginGetSingleOfDefaultOfByIdentifier(_Request, asyncCallback, null);
            }
            catch (Exception ex)
            {
            }

            #endregion Asyncronized wcf method call   
        }

        public  void Cleanup()
        {

        }

    }
}

