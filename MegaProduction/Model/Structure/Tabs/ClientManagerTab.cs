using MegaProduction.View.Fragments.UCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProduction.Model.Structure.Tabs
{
    class ClientManagerTab : Tab
    {

        /// <summary>
        /// Onglet de gestion des clients
        /// </summary>
        public ClientManagerTab() : base("manageClient")
        {
            TabElement.Content = new UCClientManager();
            TabElement.Header = "Gestion des Clients";
        }
    }
}
