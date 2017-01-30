using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using MSBuildLogsExtended.UWP81.Common;
using GalaSoft.MvvmLight.Messaging;

// The Universal Hub Application project template is documented at http://go.microsoft.com/fwlink/?LinkID=391955

namespace MSBuildLogsExtended.UWP81
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App : Application
    {
#if WINDOWS_PHONE_APP
        private TransitionCollection transitions;
#endif

        /// <summary>
        /// Initializes the singleton instance of the <see cref="App"/> class. This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += this.OnSuspending;

            //Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<Framework.CommonBLLEntities.IBusinessLogicLayerContextContainer, Framework.CommonBLLEntities.BusinessLogicLayerContextContainerCommon>();

            //Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<MSBuildLogsExtended.WcfContracts.IBusinessLogicLayerFactoryAsyn, MSBuildLogsExtended.WcfClientBLL.WcfClientFactoryAsyn>();

            //Framework.CommonBLLEntities.BusinessLogicLayerMemberShip _BusinessLogicLayerMemberShip = new Framework.CommonBLLEntities.BusinessLogicLayerMemberShip();
            //Framework.CommonBLLEntities.SessionVariablesCommon.BusinessLogicLayerContext = new Framework.CommonBLLEntities.BusinessLogicLayerContext(_BusinessLogicLayerMemberShip);
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used when the application is launched to open a specific file, to display
        /// search results, and so forth.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected async override void OnLaunched(LaunchActivatedEventArgs e)
        {
#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif

            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                //Associate the frame with a SuspensionManager key                                
                SuspensionManager.RegisterFrame(rootFrame, "AppFrame");

                // TODO: change this value to a cache size that is appropriate for your application
                rootFrame.CacheSize = 1;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    // Restore the saved session state only when appropriate
                    try
                    {
                        await SuspensionManager.RestoreAsync();
                    }
                    catch (SuspensionManagerException)
                    {
                        // Something went wrong restoring state.
                        // Assume there is no state and continue
                    }
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
#if WINDOWS_PHONE_APP
                // Removes the turnstile navigation for startup.
                if (rootFrame.ContentTransitions != null)
                {
                    this.transitions = new TransitionCollection();
                    foreach (var c in rootFrame.ContentTransitions)
                    {
                        this.transitions.Add(c);
                    }
                }

                rootFrame.ContentTransitions = null;
                rootFrame.Navigated += this.RootFrame_FirstNavigated;
#endif

                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                if (!rootFrame.Navigate(typeof(HubPage), e.Arguments))
                {
                    throw new Exception("Failed to create initial page");
                }
            }

            // Ensure the current window is active
            Window.Current.Activate();

            //InitializeMainMenuTree();

            //InitializeNavigationSettingCollectionInMainViewModel();

            //Messenger.Default.Register<Framework.UIActionStatusMessage>(
            //    this,
            //    message =>
            //    {
            //        if (MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Count(t => t.SourceTypeFullName == message.SourceTypeFullName && t.SenderView == message.SenderView && t.UIAction == message.UIAction && t.UIActionStatus == message.UIActionStatus) > 0)
            //        {
            //            var navigationSetting = MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.FirstOrDefault(t => t.SourceTypeFullName == message.SourceTypeFullName && t.SenderView == message.SenderView && t.UIAction == message.UIAction && t.UIActionStatus == message.UIActionStatus);
            //            if (navigationSetting != null)
            //            {
            //                if (navigationSetting.NextUIAction == Framework.UIAction.GoBack)
            //                {
            //                    rootFrame.GoBack();
            //                }
            //                else if (navigationSetting.NextUIAction == Framework.UIAction.Navigate)
            //                {
            //                    rootFrame.Navigate(navigationSetting.TargetPageType);
            //                }
            //            }
            //        }
            //    });
        }

#if WINDOWS_PHONE_APP
        /// <summary>
        /// Restores the content transitions after the app has launched.
        /// </summary>
        /// <param name="sender">The object where the handler is attached.</param>
        /// <param name="e">Details about the navigation event.</param>
        private void RootFrame_FirstNavigated(object sender, NavigationEventArgs e)
        {
            var rootFrame = sender as Frame;
            rootFrame.ContentTransitions = this.transitions ?? new TransitionCollection() { new NavigationThemeTransition() };
            rootFrame.Navigated -= this.RootFrame_FirstNavigated;
        }
#endif

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        private async void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            await SuspensionManager.SaveAsync();
            deferral.Complete();
        }


        private static void InitializeMainMenuTree()
        {
            //// 1.1 MSBuildLogsExtended.Build
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildLogsExtended.Build", MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_Build, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_Build, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildLogsExtended_Build, null, null, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);
            //// 1.2 MSBuildLogsExtended.BuildEventCode
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildLogsExtended.BuildEventCode", MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_BuildEventCode, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_BuildEventCode, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildLogsExtended_BuildEventCode, null, null, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);
            //// 1.3 MSBuildLogsExtended.BuildLog
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildLogsExtended.BuildLog", MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_BuildLog, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_BuildLog, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildLogsExtended_BuildLog, null, null, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);
            //// 1.4 MSBuildLogsExtended.Solution
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildLogsExtended.Solution", MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_Solution, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_Solution, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildLogsExtended_Solution, null, null, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);

        }

        #region InitializeNavigationSettingCollectionInMainViewModel()

        private static void InitializeNavigationSettingCollectionInMainViewModel()
        {
            //#region Workspaces with MasterTypeFullName
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfBuild));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfBuildEventCode));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfBuildLog));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfSolution));

            //#endregion Workspaces with MasterTypeFullName
            //#region Create, Update and Delete, Details of MSBuildLogsExtended.Build

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Edit, Framework.UIAction.Update, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Delete, Framework.UIAction.Delete, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfBuild));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Edit, Framework.UIAction.Update, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfBuild));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Delete, Framework.UIAction.Delete, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfBuild));

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Build/Details.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.Build.Details));

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.Create, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Create.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.Build.Create));

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.Update, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Edit.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.Build.Edit));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.Delete, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Delete.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.Build.Delete));

            //#endregion Create, Update and Delete, Details of MSBuildLogsExtended.Build
            //#region Create, Update and Delete, Details of MSBuildLogsExtended.BuildEventCode

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Edit, Framework.UIAction.Update, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Delete, Framework.UIAction.Delete, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfBuildEventCode));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Edit, Framework.UIAction.Update, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfBuildEventCode));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Delete, Framework.UIAction.Delete, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfBuildEventCode));

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Details.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.BuildEventCode.Details));

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.Create, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Create.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.BuildEventCode.Create));

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.Update, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Edit.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.BuildEventCode.Edit));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.Delete, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Delete.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.BuildEventCode.Delete));

            //#endregion Create, Update and Delete, Details of MSBuildLogsExtended.BuildEventCode
            //#region Create, Update and Delete, Details of MSBuildLogsExtended.BuildLog

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Edit, Framework.UIAction.Update, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Delete, Framework.UIAction.Delete, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfBuildLog));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Edit, Framework.UIAction.Update, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfBuildLog));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Delete, Framework.UIAction.Delete, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfBuildLog));

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildLog/Details.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.BuildLog.Details));

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.Create, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Create.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.BuildLog.Create));

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.Update, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Edit.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.BuildLog.Edit));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.Delete, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Delete.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.BuildLog.Delete));

            //#endregion Create, Update and Delete, Details of MSBuildLogsExtended.BuildLog
            //#region Create, Update and Delete, Details of MSBuildLogsExtended.Solution

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Edit, Framework.UIAction.Update, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Delete, Framework.UIAction.Delete, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfSolution));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Edit, Framework.UIAction.Update, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfSolution));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Delete, Framework.UIAction.Delete, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.WPCommonOfSolution));

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged, Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Solution/Details.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.Solution.Details));

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.Create, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Create.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.Solution.Create));

            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.Update, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Edit.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.Solution.Edit));
            //MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.Delete, Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Delete.xaml", typeof(MSBuildLogsExtended.WinStoreApp.Pages.Solution.Delete));

            //#endregion Create, Update and Delete, Details of MSBuildLogsExtended.Solution

        }

        #endregion InitializeNavigationSettingCollectionInMainViewModel()
    }
}