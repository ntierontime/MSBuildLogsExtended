using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.EntityContracts
{
    public class ViewModelItemBase<TSearchCriteria, TItem>
        where TSearchCriteria : class, new()
        where TItem : class, new()
    {
        public ViewModelItemBase()
            : base()
        {
            this.SearchStatus = Framework.EntityContracts.SearchStatus.Unknown;
            this.ContentData = new Framework.EntityContracts.ContentData();
            this.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady;
            this.UIActionStatusMessage = new Framework.UIActionStatusMessage();
        }

        public Framework.EntityContracts.ContentData ContentData { get; set; }

        public TSearchCriteria Criteria { get; set; }

        public TItem Item { get; set; }

        public Framework.EntityContracts.SearchStatus SearchStatus { get; set; }

        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfResult { get; set; }

        public string StatusMessageOfResult { get; set; }

        public Framework.UIActionStatusMessage UIActionStatusMessage { get; set; }
    }
}

