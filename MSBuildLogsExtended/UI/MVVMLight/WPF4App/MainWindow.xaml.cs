using System.Windows;
using System.Collections.Generic;
using System;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace MSBuildLogsExtended.WPF4App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => MSBuildLogsExtended.ViewModels.ViewModelLocator.Cleanup();

            // The MVVM Light Messenger In-Depth: http://msdn.microsoft.com/en-us/magazine/dn745866.aspx

			InitializeMainMenuTree();

            InitializeNavigationSettingCollectionInMainViewModel();

            Messenger.Default.Register<Framework.UIActionStatusMessage>(
                this,
                message =>
                {
                    if (MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Exists(t => t.SourceTypeFullName == message.SourceTypeFullName && t.SenderView == message.SenderView && t.UIAction == message.UIAction && t.UIActionStatus == message.UIActionStatus))
                    {
                        var navigationSetting = MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.FirstOrDefault(t => t.SourceTypeFullName == message.SourceTypeFullName && t.SenderView == message.SenderView && t.UIAction == message.UIAction && t.UIActionStatus == message.UIActionStatus);
                        if (navigationSetting != null)
                        {
                            if (navigationSetting.NextUIAction == Framework.UIAction.GoBack)
                            {
                                _mainFrame.GoBack();
                            }
                            else if (navigationSetting.NextUIAction == Framework.UIAction.Navigate)
                            {
                                _mainFrame.Navigate(new Uri(navigationSetting.TargetUrl, UriKind.Relative));
                            }
                        }
                    }
                });
        }


        private static void InitializeMainMenuTree()
        {
// 1.1 MSBuildLogsExtended.Build
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildLogsExtended.Build", MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_Build, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_Build, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildLogsExtended_Build, null, null, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);
// 1.2 MSBuildLogsExtended.BuildEventCode
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildLogsExtended.BuildEventCode", MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_BuildEventCode, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_BuildEventCode, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildLogsExtended_BuildEventCode, null, null, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);
// 1.3 MSBuildLogsExtended.BuildLog
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildLogsExtended.BuildLog", MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_BuildLog, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_BuildLog, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildLogsExtended_BuildLog, null, null, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);
// 1.4 MSBuildLogsExtended.Solution
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.MainMenuTree.AddSubMenuTreeItem("Common of MSBuildLogsExtended.Solution", MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_Solution, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Common_of_MSBuildLogsExtended_Solution, MSBuildLogsExtended.Resources.UIStringResourcePerApp.Description_Of_Common_of_MSBuildLogsExtended_Solution, null, null, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.Search, Framework.UIActionStatus.Launch);

        }

        private static void InitializeNavigationSettingCollectionInMainViewModel()
        {
			#region Workspaces with MasterTypeFullName

MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfBuild));
MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfBuildEventCode));
MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfBuildLog));
MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.Search,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfSolution));


			#endregion Workspaces with MasterTypeFullName

#region Create, Update and Delete, Details of MSBuildLogsExtended.Build

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfBuild));
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfBuild));
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuild.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfBuild));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Build/Details.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.Build.Details));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Create.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.Build.Create));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_SearchResult, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Create.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.Build.Create));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Edit.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.Build.Edit));
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Build/Delete.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.Build.Delete));

            #endregion Create, Update and Delete, Details of MSBuildLogsExtended.Build
#region Create, Update and Delete, Details of MSBuildLogsExtended.BuildEventCode

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfBuildEventCode));
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfBuildEventCode));
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildEventCode.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfBuildEventCode));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Details.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.BuildEventCode.Details));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Create.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.BuildEventCode.Create));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_SearchResult, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Create.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.BuildEventCode.Create));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Edit.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.BuildEventCode.Edit));
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildEventCode/Delete.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.BuildEventCode.Delete));

            #endregion Create, Update and Delete, Details of MSBuildLogsExtended.BuildEventCode
#region Create, Update and Delete, Details of MSBuildLogsExtended.BuildLog

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfBuildLog));
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfBuildLog));
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfBuildLog.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfBuildLog));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/BuildLog/Details.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.BuildLog.Details));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Create.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.BuildLog.Create));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_SearchResult, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Create.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.BuildLog.Create));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Edit.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.BuildLog.Edit));
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/BuildLog/Delete.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.BuildLog.Delete));

            #endregion Create, Update and Delete, Details of MSBuildLogsExtended.BuildLog
#region Create, Update and Delete, Details of MSBuildLogsExtended.Solution

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.ViewDetails, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Create, Framework.UIAction.Create, Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Close, Framework.UIAction.GoBack, null, null);

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Create, Framework.UIAction.Create,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfSolution));
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Edit, Framework.UIAction.Update,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfSolution));
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Delete, Framework.UIAction.Delete,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/WPCommonOfSolution.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.WPCommonOfSolution));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.SelectionChanged,  Framework.UIActionStatus.Success, Framework.UIAction.Navigate, "/Pages/Solution/Details.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.Solution.Details));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.Copy,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Create.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.Solution.Create));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_SearchResult, Framework.UIAction.Create,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Create.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.Solution.Create));

            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.Update,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Edit.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.Solution.Edit));
            MSBuildLogsExtended.ViewModels.ViewModelLocator.MainStatic.NavigationSettingCollection.Add(MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.EntityName_Static, MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM.ViewName_Details, Framework.UIAction.Delete,  Framework.UIActionStatus.Launch, Framework.UIAction.Navigate, "/Pages/Solution/Delete.xaml", typeof(MSBuildLogsExtended.WPF4App.Pages.Solution.Delete));

            #endregion Create, Update and Delete, Details of MSBuildLogsExtended.Solution

        }
    }
}