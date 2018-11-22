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
        /// <summary>
        /// TODO : add comments
        /// </summary>
        private List<MGClient> clientList;

        internal List<MGClient> ClientList { get => clientList; set => clientList = value; }

        private void fillList()
        {
            foreach (MGClient client in this.clientList)
            {
                ClientListBxItem clientItem = new ClientListBxItem(this, this.clientList.IndexOf(client));
                clientItem.LblName.Content = client.Name;
                clientItem.LblCity.Content = client.City;
                ListBxClients0.Items.Add(clientItem);
                /*
                clientItem = new ClientListBxItem(this, this.clientList.IndexOf(client));
                clientItem.LblName.Content = client.Name;
                clientItem.LblCity.Content = client.City;
                ListBxClients0.Items.Add(clientItem);
                */
            }
        }


        public UCClientManager()
        {
            InitializeComponent();
            this.clientList = ClientRep.GetClients();
            UserControl uc = new UserControl();
            //WrapPnlClients0
            fillList();
            ListBxClients0.Items.Add(uc);
        }

        private void TxtBxSearchClient_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
