using MegaProduction.View.Fragments.UCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MegaProduction.Model.Tools.Tabs
{
    class ClientManagerTab : Tab
    {

        /// <summary>
        /// Onglet de gestion des clients
        /// </summary>
        public ClientManagerTab() : base("manageClient")
        {
            TabElement.Header = "Gestion des Clients";
            TabElement.Content = new UCClientManager();
            /*
            UCClientManager uc = new UCClientManager();
            
            uc.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
            uc.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;

            System.Windows.Controls.Grid grid = new System.Windows.Controls.Grid();

            grid.Children.Add(uc);
            //System.Windows.Controls.ColumnDefinition.

            ColumnDefinition c1 = new ColumnDefinition();
            c1.Width = new GridLength(20, GridUnitType.Star);
            grid.ColumnDefinitions.Add(c1);

            RowDefinition c2 = new RowDefinition();
            c2.Height = new GridLength(20, GridUnitType.Star);
            grid.RowDefinitions.Add(c2);


            grid.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
            grid.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            
            TabElement.Content = grid;
            */

        }
    }
}
