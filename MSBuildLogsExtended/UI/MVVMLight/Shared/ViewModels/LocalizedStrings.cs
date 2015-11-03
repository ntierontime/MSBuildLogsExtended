namespace MSBuildLogsExtended.ViewModels
{
    /// <summary>
    /// http://netprogrammingodyssey.wordpress.com/2011/01/10/localizing-in-silverlight/
    /// </summary>
    public class LocalizedStrings
    {
        #region constructor

		/// <summary>
        /// Initializes a new instance of the <see cref="LocalizedStrings"/> class.
        /// </summary>
        public LocalizedStrings()
        {
        }

        #endregion constructor

        #region UIComponentResourceFile_String per solution

        private static Framework.Resources.UIStringResource m_Framework_Resources_UIStringResource = new Framework.Resources.UIStringResource();

        public Framework.Resources.UIStringResource Framework_Resources_UIStringResource { get { return m_Framework_Resources_UIStringResource; } }

        #endregion UIComponentResourceFile_String per solution

        #region UIComponentResourceFile_String_PerApplication per solution

        private static MSBuildLogsExtended.Resources.UIStringResourcePerApp m_MSBuildLogsExtended_Resources_UIStringResourcePerApp = new MSBuildLogsExtended.Resources.UIStringResourcePerApp();

        public MSBuildLogsExtended.Resources.UIStringResourcePerApp MSBuildLogsExtended_Resources_UIStringResourcePerApp { get { return m_MSBuildLogsExtended_Resources_UIStringResourcePerApp; } }

        #endregion UIComponentResourceFile_String_PerApplication per solution

        #region UIComponentResourceFile_String per entity

        private static MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild m_MSBuildLogsExtended_Resources_UIStringResourcePerEntityBuild = new MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild.
        /// </value>
        public MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuild MSBuildLogsExtended_Resources_UIStringResourcePerEntityBuild { get { return m_MSBuildLogsExtended_Resources_UIStringResourcePerEntityBuild; } }

        private static MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode m_MSBuildLogsExtended_Resources_UIStringResourcePerEntityBuildEventCode = new MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode.
        /// </value>
        public MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildEventCode MSBuildLogsExtended_Resources_UIStringResourcePerEntityBuildEventCode { get { return m_MSBuildLogsExtended_Resources_UIStringResourcePerEntityBuildEventCode; } }

        private static MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog m_MSBuildLogsExtended_Resources_UIStringResourcePerEntityBuildLog = new MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog.
        /// </value>
        public MSBuildLogsExtended.Resources.UIStringResourcePerEntityBuildLog MSBuildLogsExtended_Resources_UIStringResourcePerEntityBuildLog { get { return m_MSBuildLogsExtended_Resources_UIStringResourcePerEntityBuildLog; } }

        private static MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution m_MSBuildLogsExtended_Resources_UIStringResourcePerEntitySolution = new MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution();
        /// <summary>
        /// Gets the UI component resource file of string per entity - MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.
        /// </summary>
        /// <value>
        /// The UI component resource file of string per entity - MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution.
        /// </value>
        public MSBuildLogsExtended.Resources.UIStringResourcePerEntitySolution MSBuildLogsExtended_Resources_UIStringResourcePerEntitySolution { get { return m_MSBuildLogsExtended_Resources_UIStringResourcePerEntitySolution; } }


        #endregion UIComponentResourceFile_String per entity
    }
}