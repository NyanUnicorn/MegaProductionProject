using MegaCasting.Controllers;
using MegaProduction.Model;
using MegaProduction.Model.Tools.Tabs;
using MegaProduction.Respositories;
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
        /// <summary>
        /// Liste d'onglet dans la fenêtre principale
        /// </summary>
        List<ITab> tabList;
        /// <summary>
        /// Status, vrai si l'utilisateur est administrateur/manager, faux si non.
        /// </summary>
        private bool isAdmin = true;
        #endregion

        #region public field

        #endregion

        #region private method
        /// <summary>
        /// Charge les pages et les onglets
        /// </summary>
        private void loadTabs()
        {
            tabList = new List<ITab>();
            ITab tabpage;
            tabpage = new WelcomeTab();
            this.AppTabControl0.Items.Add(tabpage.TabElement);
            tabpage = new OfferManagerTab();
            this.AppTabControl0.Items.Add(tabpage.TabElement);
            tabpage = new ClientManagerTab();
            this.AppTabControl0.Items.Add(tabpage.TabElement);
            tabpage = new PartnerManagerTab();
            this.AppTabControl0.Items.Add(tabpage.TabElement);            
            if (isAdmin)
            {
                tabpage = new WebsiteManagerTab();
                this.AppTabControl0.Items.Add(tabpage.TabElement);
                tabpage = new HeavyUserManagerTab();
                this.AppTabControl0.Items.Add(tabpage.TabElement);
            }

        }
        /// <summary>
        /// Charge des éléments additionnel de la page
        /// </summary>
        private void loadFeatures()
        {
            this.ConnectedDatabaseStatus0.Content = Repository.HUConnexion.Srv + @"\" + Repository.HUConnexion.Dbn;

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
            loadFeatures();
        }


        #endregion

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnWinSize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState != WindowState.Maximized)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StatusBarWindowBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
