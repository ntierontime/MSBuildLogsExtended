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
        }

        public Framework.EntityContracts.ContentData ContentData { get; set; }

        public TSearchCriteria Criteria { get; set; }
        public TItem Item { get; set; }
        public Framework.EntityContracts.SearchStatus SearchStatus { get; set; }
    }
}

