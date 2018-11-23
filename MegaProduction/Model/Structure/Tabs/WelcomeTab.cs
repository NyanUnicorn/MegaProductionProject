using MegaProduction.View.Fragments.UCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProduction.Model.Tools.Tabs
{
    class WelcomeTab : Tab
    {
        /// <summary>
        /// Onglet de bienvenue
        /// </summary>
        public WelcomeTab() : base("welcome")
        {
            TabElement.Content = new UCPartnerManager();
            TabElement.Header = "Accueil";
        }
    }
}
