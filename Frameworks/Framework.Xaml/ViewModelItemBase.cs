using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Framework.Xaml
{
    public abstract class ViewModelItemBase<TSearchCriteria, TItem> : Framework.ViewModels.ViewModelItemBase<TSearchCriteria, TItem>, INotifyPropertyChanged
        where TSearchCriteria : class, new()
        where TItem : class, new()
    {
        #region constructor

        public ViewModelItemBase()
            : base()
        {
        }

        #endregion constructor

        #region override properties

        protected TSearchCriteria m_Criteria;
        public override TSearchCriteria Criteria
        {
            get { return m_Criteria; }
            set
            {
                m_Criteria = value;
                RaisePropertyChanged("Criteria");
            }
        }

        protected TItem m_Item;
        public override TItem Item
        {
            get { return m_Item; }
            set
            {
                m_Item = value;
                RaisePropertyChanged("Item");
            }
        }

        #endregion override properties

        #region INotifyPropertyChanged Implementation 

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
#if (SILVERLIGHT || XAMARIN)
#elif (NETFX_CORE)
#else
        [field: NonSerialized]
#endif
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies that <see cref="propertyName" /> has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(
                    this,
                    new PropertyChangedEventArgs(propertyName)
                    );
            }
        }

        #endregion INotifyPropertyChanged Implementation 

        public TItem OriginalItem { get; set; }

        public bool SuppressMVVMLightEventToCommandMessage { get; set; }

        protected virtual void PrepareItem(TItem o)
        {
            this.OriginalItem = o;
            this.Item = o;
        }

        #region ViewDetails

        public RelayCommand<TItem> LaunchViewDetailsViewCommand { get; protected set; }

        protected void LaunchViewDetailsView(TItem o)
        {
            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;

            PrepareItem(o);

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));
        }

        public RelayCommand CloseViewDetailsViewCommand { get; protected set; }

        protected void CloseViewDetailsView()
        {
            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Close));
        }

        #endregion ViewDetails

        #region Copy

        public RelayCommand<TItem> LaunchCopyViewCommand { get; protected set; }

        protected void LaunchCopyView(TItem o)
        {
            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.Copy;

            PrepareItem(o);

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));
        }

        #endregion Copy

        #region Save

        public RelayCommand<TItem> LaunchEditViewCommand { get; protected set; }

        protected void LaunchEditView(TItem o)
        {
            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.Update;

            PrepareItem(o);

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));
        }

        public RelayCommand CloseEditViewCommand { get; protected set; }

        protected void CloseEditView()
        {
            string viewName = ViewName_Edit;
            Framework.UIAction uiAction = Framework.UIAction.Update;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Close));
        }

        public RelayCommand SaveCommand { get; protected set; }

        /// <summary>
        /// update an Entity
        /// </summary>
        protected abstract void Save();

        /// <summary>
        /// Determines whether you can save Entity
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if you can; otherwise, <c>false</c>.
        /// </returns>
        protected virtual bool CanSave()
        {
            return this.Item != null;
        }

        #endregion Save

        #region Add

        public RelayCommand LaunchCreateViewCommand { get; protected set; }

        protected void LaunchCreateView()
        {
            string viewName = ViewName_SearchResult;
            Framework.UIAction uiAction = Framework.UIAction.Create;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));
        }

        public RelayCommand CloseCreateViewCommand { get; protected set; }

        protected void CloseCreateView()
        {
            string viewName = ViewName_Create;
            Framework.UIAction uiAction = Framework.UIAction.Create;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Close));
        }

        public RelayCommand AddCommand { get; protected set; }

        /// <summary>
        /// Adds a Entity to the list and repo.
        /// </summary>
        protected abstract void Add();

        /// <summary>
        /// Determines whether you can create a CustomerInformation.DataSourceEntities.CustomerProduct.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if you can; otherwise, <c>false</c>.
        /// </returns>
        protected bool CanAdd()
        {
            return true;
        }

        #endregion Add

        #region Delete

        public RelayCommand<TItem> LaunchDeleteViewCommand { get; protected set; }

        protected void LaunchDeleteView(TItem o)
        {
            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.Delete;

            PrepareItem(o);

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));
        }

        public RelayCommand CloseDeleteViewCommand { get; protected set; }

        protected void CloseDeleteView()
        {
            string viewName = ViewName_Delete;
            Framework.UIAction uiAction = Framework.UIAction.Delete;

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Close));
        }

        public RelayCommand DeleteCommand { get; protected set; }

        /// <summary>,
        /// delete a CustomerInformation.DataSourceEntities.CustomerProduct.
        /// </summary>
        protected abstract void Delete();

        /// <summary>
        /// Determines whether you can delete an Entity
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if you can; otherwise, <c>false</c>.
        /// </returns>
        protected virtual bool CanDelete()
        {
            return this.Item != null;
        }

        #endregion Delete

        #region RefreshCurrentEditingItem

        public RelayCommand RefreshCurrentItemCommand { get; protected set; }

        protected virtual void RefreshItem()
        {
            string viewName = ViewName_Edit;
            Framework.UIAction uiAction = Framework.UIAction.Refresh;

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Starting));
            RefreshItemNoMessage();

            if (!this.SuppressMVVMLightEventToCommandMessage)
                Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Success));
        }

        protected abstract void RefreshItemNoMessage();

        #endregion RefreshCurrentEditingItem

        #region string EntityName

        public abstract string EntityName { get; }

        #endregion string EntityName

        #region ViewNames

        public const string ViewName_Edit = "Edit";
        public const string ViewName_Create = "Create";
        public const string ViewName_Delete = "Delete";
        public const string ViewName_Details = "Details";
        public const string ViewName_SearchResult = "SearchResult";

        #endregion ViewNames
    }
}
