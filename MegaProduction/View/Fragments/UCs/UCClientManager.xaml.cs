using MegaProduction.Model.MGProduction;
using MegaProduction.Respositories.MGProduction;
using MegaProduction.View.Fragments.UCs.ListTemplates;
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
    /// Logique d'interaction pour UCCreateOffer.xaml
    /// </summary>
    public partial class UCClientManager : UserControl
    {
        #region private field
        /// <summary>
        /// Liste de clients
        /// </summary>
        private List<MGClient> clientList;
        #endregion

        #region internal field
        internal List<MGClient> ClientList { get => clientList; set => clientList = value; }
        #endregion



        #region private method
        /// <summary>
        /// Remplie la listeBox avec les clients stoqué dans la liste de client
        /// </summary>
        private void fillList()
        {
            foreach (MGClient client in this.clientList)
            {
                ClientListBxItem clientItem = new ClientListBxItem(this, this.clientList.IndexOf(client));
                clientItem.LblName.Content = client.Name;
                clientItem.LblCity.Content = client.City;
                ListBxClients0.Items.Add(clientItem);
            }
        }

        #endregion

        #region contructor
        public UCClientManager()
        {
            InitializeComponent();
            this.clientList = ClientRep.GetClients();
            UserControl uc = new UserControl();
            fillList();
            ListBxClients0.Items.Add(uc);
        }
        #endregion

        #region event
        /// <summary>
        /// Met a jour la liste avec des donné filtré en fonction de la chaine dans la textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBxSearchClient_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TxtBxSearchClient.Text.Length > 3)
            {

                this.clientList.Clear();
                this.clientList = ClientRep.GetClients();
                this.fillList();
            }
            
        }
        #endregion

    }
}
