using MegaProduction.View.Fragments.UCs.UCWebManFragments.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace MegaProduction.Model.Structure.Tabs.WebViewerTabs
{
    abstract class WebTab : ITab
    {
        public enum PageName {Index =0, JobOffers=1 };

        #region private field
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
        #endregion

        #region public field
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
        public TabItem TabElement { get => tabElement; }
        #endregion



        /// <summary>
        /// Céation d'un élément TabItem adapté au besoins en prennant le nom de Tab en paramètre
        /// </summary>
        /// <param name="_nom">modifie le nom de Tab</param>
        public WebTab(String _nom)
        {
            tabElement = new TabItem();
            tabElement.FontSize = 20;
            tabElement.Padding = new System.Windows.Thickness(40, 10, 40, 10);
            tabElement.Foreground = new SolidColorBrush(Color.FromRgb(107, 107, 107));
            tabElement.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
            tabElement.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
        }
    }
}