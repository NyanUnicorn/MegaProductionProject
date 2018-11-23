using MegaProduction.View.Fragments.UCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProduction.Model.Tools.Tabs
{
    class HeavyUserManagerTab : Tab
    {
        /// <summary>
        /// Onglet de gestion des utilisateurs du client lourd
        /// </summary>
        public HeavyUserManagerTab() : base("manageHeavyUser")
        {
            TabElement.Content = new UCPartnerManager();
            TabElement.Header = "Gestion des Utilisateurs";
        }
    }
}
