using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Command;
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
            this.SuppressMVVMLightEventToCommandMessage = false;

            this.LaunchCopyViewCommand = new RelayCommand<TItem>(LaunchCopyView);

            this.LaunchViewDetailsViewCommand = new RelayCommand<TItem>(LaunchViewDetailsView);
            this.CloseViewDetailsViewCommand = new RelayCommand(CloseViewDetailsView);

            this.LaunchEditViewCommand = new RelayCommand<TItem>(LaunchEditView);
            this.CloseEditViewCommand = new RelayCommand(CloseEditView);
            this.SaveCommand = new RelayCommand(Save, CanSave);

            this.LaunchCreateViewCommand = new RelayCommand(LaunchCreateView);
            this.CloseCreateViewCommand = new RelayCommand(CloseCreateView);
            this.AddCommand = new RelayCommand(Add, CanAdd);

            this.LaunchDeleteViewCommand = new RelayCommand<TItem>(LaunchDeleteView);
            this.CloseDeleteViewCommand = new RelayCommand(CloseDeleteView);
            this.DeleteCommand = new RelayCommand(Delete, CanDelete);

            this.RefreshCurrentItemCommand = new RelayCommand(RefreshItem);

            this.LoadItemCommand = new RelayCommand(this.LoadItem);
            this.LoadItemCommandTyped = new RelayCommand<TSearchCriteria>(this.LoadItem);
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

        protected virtual void PrepareItem(TItem o, bool isReloadFromDataSource, bool createNew, bool withIdentifier)
        {
            if (createNew)
            {
                this.Item = new TItem();
            }
            else if (isReloadFromDataSource)
            {
                if (o != null)
                {
                    this.ReLoadItem(o);
                }
                else
                {
                    this.ReLoadItem(this.Item);
                }
            }
            else
            {
                if (o != null)
                {
                    if (withIdentifier)
                    {
                        this.OriginalItem = ((Framework.EntityContracts.IClone<TItem>)o).GetAClone();
                        this.Item = ((Framework.EntityContracts.IClone<TItem>)o).GetAClone();
                    }
                    else
                    {
                        this.OriginalItem = ((Framework.EntityContracts.IClone<TItem>)o).GetACloneWithoutIdentifier();
                        this.Item = ((Framework.EntityContracts.IClone<TItem>)o).GetACloneWithoutIdentifier();
                    }
                }
            }
        }

        #region ViewDetails

        public RelayCommand<TItem> LaunchViewDetailsViewCommand { get; protected set; }

        protected void LaunchViewDetailsView(TItem o)
        {
            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.ViewDetails;

            PrepareItem(o, true, false, true);

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

            PrepareItem(o, false, false, false);

            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(EntityName, viewName, uiAction, Framework.UIActionStatus.Launch));
        }

        #endregion Copy

        #region Save

        public RelayCommand<TItem> LaunchEditViewCommand { get; protected set; }

        protected void LaunchEditView(TItem o)
        {
            string viewName = ViewName_Details;
            Framework.UIAction uiAction = Framework.UIAction.Update;

            PrepareItem(o, true, false, true);

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
            return true;
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

            PrepareItem(o, true, false, true);

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

        #region LoadItem

        public RelayCommand LoadItemCommand { get; protected set; }
        public RelayCommand<TSearchCriteria> LoadItemCommandTyped { get; protected set; }


        public virtual void LoadItem()
        {
            this.LoadItem(this.Criteria);
        }

        public abstract void LoadItem(TSearchCriteria identifier);


        public abstract void ReLoadItem(TItem o);

        #endregion LoadItem

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

