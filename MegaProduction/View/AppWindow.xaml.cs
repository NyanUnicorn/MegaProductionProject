using MegaCasting.Controllers;
using MegaProduction.Model;
using MegaProduction.Model.Structure.Tabs;
using MegaProduction.View.Fragments.UCs;
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
using System.Windows.Shapes;

namespace MegaProduction.View
{

    public partial class AppWindow : Window
    {


        #region private field
        List<ITab> tabList;
        private bool isAdmin = true;
        #endregion

        #region public field

        #endregion

        #region private method
        private void loadTabs()
        {
            tabList = new List<ITab>();
            ITab tabpage;
            tabpage = new OfferManagerTab();
            this.AppTabControl0.Items.Add(tabpage.TabElement);
            tabpage = new ClientManagerTab();
            this.AppTabControl0.Items.Add(tabpage.TabElement);
            if (isAdmin)
            {

            }

        }
        #endregion

        #region contructor
        /// <summary>
        /// Logique d'interaction pour AppWindow.xaml
        /// </summary>
        public AppWindow()
        {
            InitializeComponent();
            FileReader.ReadHeavyConnection();
            loadTabs();
        }
        #endregion

        

    }
}
