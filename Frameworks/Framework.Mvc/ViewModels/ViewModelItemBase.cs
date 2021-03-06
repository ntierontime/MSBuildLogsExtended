using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Mvc
{
    public class ViewModelItemBase<TSearchCriteria, TItem> : Framework.EntityContracts.ViewModelItemBase<TSearchCriteria, TItem>
        where TSearchCriteria : class, new()
        where TItem : class, new()
    {
        public ViewModelItemBase()
            : base()
        {
            this.StatusOfResult = Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady;
            this.UIActionStatusMessage = new Framework.UIActionStatusMessage();
        }
        public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfResult { get; set; }
        public string StatusMessageOfResult { get; set; }

        public Framework.UIActionStatusMessage UIActionStatusMessage { get; set; }
    }
}

