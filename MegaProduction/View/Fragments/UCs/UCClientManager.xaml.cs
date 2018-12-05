using MegaProduction.Model.MGCasting;
using MegaProduction.Model.MGProduction;
using MegaProduction.Respositories.MGCasting;
using MegaProduction.Respositories.MGProduction;
using MegaProduction.View.Fragments.UCs.ListTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private List<MGCastingPack> castingPacks;
        private bool isNewClient;
        private int clientId;
        private bool searchByName = false;
        MGPurchase purchase;
        MGClient updClient;
        #endregion

        #region internal field
        internal List<MGClient> ClientList { get => clientList; set => clientList = value; }
        public bool IsNewClient { get => isNewClient; set => isNewClient = value; }
        public int ClientId { get => clientId; set => clientId = value; }
        #endregion

        #region private method
        /// <summary>
        /// Remplie la listeBox avec les clients stoqué dans la liste de client
        /// </summary>
        private void fillList()
        {
            this.ListBxClients0.Items.Clear();
            foreach (MGClient client in this.clientList)
            {
                ClientListBxItem clientItem = new ClientListBxItem(this, this.clientList.IndexOf(client));
                clientItem.LblName.Content = client.Name;
                clientItem.LblCity.Content = client.City;
                ListBxClients0.Items.Add(clientItem);
            }
        }

        private void fillCastingPackBox()
        {
            this.ComBxAddTokenPack.Items.Clear();
            this.castingPacks = CastingPackRep.GetCastingPacks();
            foreach (MGCastingPack pack in castingPacks)
            {
                this.ComBxAddTokenPack.Items.Add(pack.Label);
            }
        }

        #endregion

        /// <summary>
        /// Met à jour les champs éditable
        /// </summary>
        private void updateTextfields()
        {
            this.TxtBxClientName.Text = updClient.Name;
            this.TxtBxTelNumContact.Text = updClient.TelContact;
            this.TxtBxTelApplication.Text = updClient.TelMGProd;
            this.TxtBxStreet.Text = updClient.Street;
            this.TxtBxCity.Text = updClient.City;
            this.TxtBxPC.Text = updClient.PCode;
            this.LblVarOfferCount.Content = updClient.Tokens;
        }
        /// <summary>
        /// Selectionne un client de la liste par son index
        /// </summary>
        /// <param name="_index"></param>
        internal void SelectClient(int _index)
        {
            updClient = ClientList.ElementAt(_index);
            purchase = new MGPurchase();
            updateTextfields();
        }
    
        private void reinitialisePage()
        {
            this.clientList = ClientRep.GetClients();
            purchase = new MGPurchase();
            fillList();
            TxtBxCustomTokenAdd.IsReadOnly = true;
            TxtBxClientName.Text = "";
            TxtBxTelNumContact.Text = "";
            TxtBxTelApplication.Text = "";
            TxtBxStreet.Text = "";
            TxtBxCity.Text = "";
            TxtBxPC.Text = "";
            LblVarOfferCount.Content = 0;
        }


        #region contructor
        public UCClientManager()
        {
            InitializeComponent();
            fillCastingPackBox();
            /*
            this.clientList = ClientRep.GetClients();
            //UserControl uc = new UserControl();
            fillList();
            fillCastingPackBox();
            //ListBxClients0.Items.Add(uc);
            TxtBxCustomTokenAdd.IsReadOnly = true;
            purchase = new MGPurchase();*/
            reinitialisePage();
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
                searchByName = true;
                this.clientList.Clear();
                this.clientList = ClientRep.GetClients(TxtBxSearchClient.Text);
                this.fillList();
            }
            else if (searchByName == true)
            {
                searchByName = false;
                this.clientList.Clear();
                this.clientList = ClientRep.GetClients();
                this.fillList();
            }

        }
        /// <summary>
        /// N'ajoute ques des entées numérique dans la textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        /// <summary>
        /// Modifie le nombre de tokens dans le pack a chaque changement de selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComBxAddTokenPack_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MGCastingPack pack = castingPacks.ElementAt(ComBxAddTokenPack.SelectedIndex);
            this.TxtBxCustomTokenAdd.Text = pack.Size.ToString();
            if (pack.Size > 1)
            {
                TxtBxCustomTokenAdd.IsReadOnly = true;
            }
            else
            {
                TxtBxCustomTokenAdd.IsReadOnly = false;
            }
        }

        #endregion

        private void BtnNouveauClient_Click(object sender, RoutedEventArgs e)
        {
            updClient = new MGClient();
            purchase = new MGPurchase();
            updateTextfields();
        }

        private void BtnAddTokenPack_Click(object sender, RoutedEventArgs e)
        {
            purchase = new MGPurchase();
            MGCastingPack pack = castingPacks.ElementAt(ComBxAddTokenPack.SelectedIndex);

            
            purchase.PackId = pack.Id;

            if (pack.Size > 1)
            {
                purchase.Cost = pack.Cost;
                purchase.Quantity = pack.Size;
            }
            else
            {
                purchase.Cost = pack.Size * Int32.Parse(TxtBxCustomTokenAdd.Text);
                purchase.Quantity = Int32.Parse(TxtBxCustomTokenAdd.Text);
            }
            LblVarOfferCount.Content = updClient.Tokens + purchase.Quantity;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            updClient.Name = TxtBxClientName.Text;
            updClient.TelContact = TxtBxTelNumContact.Text;
            updClient.TelMGProd = TxtBxTelApplication.Text;
            updClient.Street = TxtBxStreet.Text;
            updClient.City = TxtBxCity.Text;
            updClient.PCode = TxtBxPC.Text;
            updClient.Tokens = Int32.Parse(LblVarOfferCount.Content.ToString()) + purchase.Quantity;
            ClientRep.updateClient(updClient, purchase);
            reinitialisePage();
        }

    }
}
