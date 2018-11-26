using MegaProduction.View.Fragments.UCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProduction.Model.Tools.Tabs
{
    class WebsiteManagerTab : Tab
    {
        /// <summary>
        /// Onglet de gestion du contenue du site web
        /// </summary>
        public WebsiteManagerTab() : base("manageWabsite")
        {
            TabElement.Content = new UCWebsiteManager();
            TabElement.Header = "Gestion du Site Web";
        }
    }
}
