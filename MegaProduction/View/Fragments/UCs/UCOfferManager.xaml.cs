using MegaProduction.Model.MGCasting;
using MegaProduction.Model.MGProduction;
using MegaProduction.Respositories.MGCasting;
using MegaProduction.Respositories.MGProduction;
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
    /// Logique d'interaction pour UCOfferManager.xaml
    /// </summary>
    public partial class UCOfferManager : UserControl
    {
        /// <summary>
        /// l'offre à ajouter
        /// </summary>
        private MGCastingOffer newOffer;
        /// <summary>
        /// liste de talents disponible
        /// </summary>
        private List<MGTalent> talents;
        /// <summary>
        /// liste de type de contrat disponible
        /// </summary>
        private List<ContractType> contractTypes;
        /// <summary>
        /// liste de clients
        /// </summary>
        private List<MGClient> clients;

        /// <summary>
        /// Remplie la combobox avec les types de contrat disponible
        /// </summary>
        private void fillContactTypes()
        {
            foreach(ContractType contract in contractTypes)
            {
                CBContract.Items.Add(contract.ShortLabel);
                try
                {
                    CBContract.SelectedIndex = 0;
                }
                catch (Exception)
                {

                }
            }
        }
        /// <summary>
        /// remplie la liste de talents avec les talents disponible
        /// </summary>
        private void fillTalents()
        {
            foreach(MGTalent talent in talents)
            {
                CBTalent.Items.Add(talent.Label);
                try
                {
                    CBTalent.SelectedIndex = 0;
                }
                catch (Exception)
                {

                }
            }
        }
        /// <summary>
        /// remplie la liste de clients professionelles
        /// </summary>
        private void fillClients()
        {
            foreach(MGClient client in clients)
            {
                CBClient.Items.Add(client.Name + " " + client.City);
            }
        }

        /// <summary>
        /// Envoyer la nouvelle offre sur la base de donnée
        /// </summary>
        private void saveNewOffer()
        {
            newOffer = new MGCastingOffer();
            newOffer.Label = TxtTitre.Text;
            newOffer.Description = TxtDescription.Text;
            newOffer.Location.Street = TxtStreet.Text;
            newOffer.Location.City = TxtCity.Text;
            newOffer.Location.PostalCode = TxtPostalCode.Text;
            newOffer.Contract = contractTypes.ElementAt(CBContract.SelectedIndex);
            newOffer.Talent = talents.ElementAt(CBTalent.SelectedIndex);
            newOffer.Client = clients.ElementAt(CBClient.SelectedIndex);
            CastingOfferRep.AddOffer(newOffer);
            TxtTitre.Text = "";
            TxtDescription.Text = "";
            TxtStreet.Text = "";
            TxtCity.Text = "";
            TxtPostalCode.Text = "";
        }

        public UCOfferManager()
        {
            InitializeComponent();
            //remplir les listes
            talents = TalentRep.GetTalents();
            contractTypes = ContractRep.GetContracts();
            clients = ClientRep.GetClients();
            //remplir les affichages
            fillClients();
            fillContactTypes();
            fillTalents();
        }

        private void BtnValider_Click(object sender, RoutedEventArgs e)
        {
            saveNewOffer();
            OfferListerBx.UpdateCastingOffers();
            OfferListerBx.UpdateList();
        }

        private void CBClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TxtStreet.Text = clients.ElementAt(CBClient.SelectedIndex).Street;
            TxtCity.Text = clients.ElementAt(CBClient.SelectedIndex).City;
            TxtPostalCode.Text = clients.ElementAt(CBClient.SelectedIndex).PCode;
        }
    }
}
