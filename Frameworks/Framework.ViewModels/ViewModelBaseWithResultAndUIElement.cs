using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.ViewModels
{
    public abstract class ViewModelBaseWithResultAndUIElement<TSearchCriteria, TSearchResult>
        : Framework.EntityContracts.ViewModelBase<TSearchCriteria>
        where TSearchCriteria : class, new()
        where TSearchResult : class, new()
    {
        public ViewModelBaseWithResultAndUIElement()
            : base()
        {
        }


        public TSearchResult Result { get; set; }
		public Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfResult { get; set; }
        public string StatusMessageOfResult { get; set; }

        public override void PopulateAllUIElements(Framework.EntityContracts.IViewModelBase<TSearchCriteria> vmFromTempData, int currentPage)
        {
			base.PopulateAllUIElements(vmFromTempData, currentPage);
        }
    }
}