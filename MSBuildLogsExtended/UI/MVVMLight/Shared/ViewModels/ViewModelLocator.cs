/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:MSBuildLogsExtended.ViewModels"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
  
  OR (WPF only):
  
  xmlns:vm="clr-namespace:MSBuildLogsExtended.ViewModels"
  DataContext="{Binding Source={x:Static vm:ViewModelLocatorTemplate.ViewModelNameStatic}}"
*/

namespace MSBuildLogsExtended.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// Use the <strong>mvvmlocatorproperty</strong> snippet to add ViewModels
    /// to this locator.
    /// </para>
    /// <para>
    /// In Silverlight and WPF, place the ViewModelLocatorTemplate in the App.xaml resources:
    /// </para>
    /// <code>
    /// &lt;Application.Resources&gt;
    ///     &lt;vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:MSBuildLogsExtended.ViewModels"
    ///                                  x:Key="Locator" /&gt;
    /// &lt;/Application.Resources&gt;
    /// </code>
    /// <para>
    /// Then use:
    /// </para>
    /// <code>
    /// DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
    /// </code>
    /// <para>
    /// You can also use Blend to do all this with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </para>
    /// <para>
    /// In <strong>*WPF only*</strong> (and if databinding in Blend is not relevant), you can delete
    /// the Main property and bind to the ViewModelNameStatic property instead:
    /// </para>
    /// <code>
    /// xmlns:vm="clr-namespace:MSBuildLogsExtended.ViewModels"
    /// DataContext="{Binding Source={x:Static vm:ViewModelLocatorTemplate.ViewModelNameStatic}}"
    /// </code>
    /// </summary>
    public class ViewModelLocator
    {
        #region constructors

        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view models
            ////}
            ////else
            ////{
            ////    // Create run time view models
            ////}

            CreateMain();
        }

        #endregion constructors

        #region MSBuildLogsExtended.ViewModels.MainViewModel

        private static MSBuildLogsExtended.ViewModels.MainViewModel _main;

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        public static MSBuildLogsExtended.ViewModels.MainViewModel MainStatic
        {
            get
            {
                if (_main == null)
                {
                    CreateMain();
                }

                return _main;
            }
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MSBuildLogsExtended.ViewModels.MainViewModel Main
        {
            get
            {
                return MainStatic;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the Main property.
        /// </summary>
        public static void ClearMain()
        {
            _main.Cleanup();
            _main = null;
        }

        /// <summary>
        /// Provides a deterministic way to create the Main property.
        /// </summary>
        public static void CreateMain()
        {
            if (_main == null)
            {
                _main = new MSBuildLogsExtended.ViewModels.MainViewModel();
            }
        }

        #endregion MSBuildLogsExtended.ViewModels.MainViewModel


#if SILVERLIGHT && !WINDOWS_PHONE
        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM




        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM




        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM




        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM
#endif


#if NETFX_CORE
        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM




        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM




        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM




        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM
#endif


#if WINDOWS_PHONE && WINDOWS_PHONE
        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM




        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM




        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM




        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM
#endif


#if !WINDOWS_PHONE && !SILVERLIGHT && !NETFX_CORE
        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildVM




        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildEventCodeVM




        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfBuildLogVM




        #region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM

		#region MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM

        private static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM;
        public static MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM_Static
        {
            get
            {
                if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM == null)
                {
                    CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM();
                }

                return m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM;
            }
        }

        public MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM
        {
            get
            {
                return MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM_Static;
            }
        }

        /// <summary>
        /// Provides a deterministic way to delete the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM property.
        /// </summary>
        public static void Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM != null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM.Cleanup();
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM = null;
            }
        }

        /// <summary>
        /// Provides a deterministic way to create the MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM property.
        /// </summary>
        public static void CreateMSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM()
        {
            if (m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM == null)
            {
                m_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM = new MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM();
            }
        }

        #endregion MVVMViewModel: MSBuildLogsExtended.ViewModels.WPCommonOfSolutionVM
#endif



        #region Cleanup()

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {


#if SILVERLIGHT && !WINDOWS_PHONE
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM();




            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM();




            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM();




            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM();
#endif


#if NETFX_CORE
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM();




            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM();




            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM();




            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM();
#endif


#if WINDOWS_PHONE && WINDOWS_PHONE
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM();




            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM();




            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM();




            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM();
#endif


#if !WINDOWS_PHONE && !SILVERLIGHT && !NETFX_CORE
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildCollectionVM();




            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildEventCodeCollectionVM();




            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfBuildLogCollectionVM();




            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionVM();
            Clear_MSBuildLogsExtended_ViewModels_WPCommonOfSolutionCollectionVM();
#endif



            ClearMain();
        }

        #endregion Cleanup()

    }
}

