using MegaProduction.View.Fragments.UCs.UCWebManFragments.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MegaProduction.Model.Structure.Tabs.WebViewerTabs
{
    class IndexWebtab : WebTab
    {

        public IndexWebtab() : base("index")
        {
            TabContent = new PageContentHolder((int) WebTab.PageName.Index);
            TabElement.Content = TabContent;
            TabElement.Header = "Index";
        }
    }
}