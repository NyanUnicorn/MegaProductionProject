using MegaProduction.View.Fragments.UCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProduction.Model.Structure.Tabs
{
    class OfferManagerTab : Tab
    {
        /// <summary>
        /// Onglet de gestion des offres
        /// </summary>
        public OfferManagerTab() : base("manageOffer")
        {
            TabElement.Content = new UCOfferManager();
            TabElement.Header = "Gestion des Offres";
        }
    }
}
