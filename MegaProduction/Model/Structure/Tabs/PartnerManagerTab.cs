using MegaProduction.View.Fragments.UCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProduction.Model.Tools.Tabs
{
    class PartnerManagerTab : Tab
    {
        /// <summary>
        /// Onglet de gestion des partenaires de diffusion
        /// </summary>
        public PartnerManagerTab() : base("managePartner")
        {
            TabElement.Content = new UCPartnerManager();
            TabElement.Header = "Gestion des partenaires de diffusion";
        }
    }
}
