using MegaProduction.View.Fragments.UCs.UCWebManFragments.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProduction.Model.Structure.Tabs.WebViewerTabs
{
    class OffersWebTab : WebTab
    {

        public OffersWebTab() : base("jobOffers")
        {
            TabContent = new PageContentHolder((int)WebTab.PageName.JobOffers);
            TabElement.Content = TabContent;
            TabElement.Header = "Castings";
        }
    }
}
