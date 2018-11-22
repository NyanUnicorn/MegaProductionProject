using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MegaProduction.Model
{
     abstract class Tab : ITab
    {
        /// <summary>
        /// nom de Tab
        /// </summary>
        private String name;
        /// <summary>
        /// Contenue de Tab
        /// </summary>
        private UserControl tabcontent;
        /// <summary>
        /// Element TabItem de Tab
        /// </summary>
        private TabItem tabElement;


        /// <summary>
        /// Modifie ou récupérer le nom de Tab
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Modifier ou récupérer le contenue de Tab
        /// </summary>
        public UserControl TabContent { get => tabcontent; set => tabcontent = value; }
        /// <summary>
        /// Modifie ou récupérer la TabItem de Tab
        /// </summary>
        public TabItem TabElement { get => tabElement;}

        /// <summary>
        /// Céation d'un élément TabItem adapté au besoins en prennant le nom de Tab en paramètre
        /// </summary>
        /// <param name="_nom">modifie le nom de Tab</param>
        public Tab(String _nom)
        {
            tabElement = new TabItem();
            tabElement.FontSize = 20;
            //TabElement.FontFamily = new System.Windows.Media.FontFamily("Franklin Gothic Book");
            tabElement.Padding = new System.Windows.Thickness(40, 10, 40, 10);
        }
        /// <summary>
        /// Céation d'un élément TabItem adapté au besoins
        /// </summary>
        public Tab()
        {
            tabElement = new TabItem();
            tabElement.FontSize = 20;
            //TabElement.FontFamily = new System.Windows.Media.FontFamily("Franklin Gothic Book");
            tabElement.Padding = new System.Windows.Thickness(40, 10, 40, 10);
        }
    }
}
