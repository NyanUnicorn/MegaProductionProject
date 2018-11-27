using MegaProduction.Model;
using MegaProduction.Model.Structure.Tabs.WebViewerTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegaProduction.View.Fragments.UCs
{
    /// <summary>
    /// Logique d'interaction pour UCWebsiteManager.xaml
    /// </summary>
    public partial class UCWebsiteManager : UserControl
    {

        #region private field
        /// <summary>
        /// Liste d'onglet dans la fenêtre principale
        /// </summary>
        List<WebTab> tabList;
        #endregion


        /// <summary>
        /// Charge les pages et les onglets
        /// </summary>
        private void loadTabs()
        {
            tabList = new List<WebTab>();
            WebTab tabpage;
            tabpage = new IndexWebtab();
            this.TabCtrlWebview.Items.Add(tabpage.TabElement);
            tabpage = new OffersWebTab();
            this.TabCtrlWebview.Items.Add(tabpage.TabElement);

        }


        public UCWebsiteManager()
        {
            InitializeComponent();
            this.loadTabs();
        }
    }
}
