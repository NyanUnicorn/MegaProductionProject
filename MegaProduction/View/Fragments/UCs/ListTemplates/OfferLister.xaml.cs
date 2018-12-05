using MegaProduction.Model.MGCasting;
using MegaProduction.Respositories.MGCasting;
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

namespace MegaProduction.View.Fragments.UCs.ListTemplates
{
    /// <summary>
    /// Logique d'interaction pour OfferLister.xaml
    /// </summary>
    public partial class OfferLister : UserControl
    {
        public enum SearchType {active, search, all}
        private SearchType retrieve;
        private List<MGCastingOffer> castingOffers;

        /// <summary>
        /// Génère une liste d'offre avec des critères
        /// </summary>
        /// <param name="_seach"></param>
        /// <param name="_filter"></param>
        public void UpdateCastingOffers(SearchType _seach = SearchType.active, String _filter = "")
        {
            switch (_seach)
            {
                case SearchType.active:
                default:
                    castingOffers = Respositories.MGCasting.CastingOfferRep.GetActiveCastingOffers();
                    break;
                case SearchType.all:
                    break;
                case SearchType.search:
                    break;

            }
        }

        public void UpdateList()
        {
            try
            {
                this.ListBxOfferBox.Items.Clear();
                foreach (MGCastingOffer offer in castingOffers)
                {
                    ListBxOfferBox.Items.Add(new OfferListItem(offer.Label, offer.Client.Name, offer.DaysLeft, offer.Description));
                }
            }
            catch (Exception)
            {
                try
                {
                    castingOffers = CastingOfferRep.GetActiveCastingOffers();
                    foreach (MGCastingOffer offer in castingOffers)
                    {
                        ListBxOfferBox.Items.Add(new OfferListItem(offer.Label, offer.Client.Name, offer.DaysLeft, offer.Description));
                    }
                }
                catch
                {

                }
            }
        }

        public void DisableSearch()
        {
            this.TxtBxSearch.IsEnabled = false;
        }


        public OfferLister()
        {
            InitializeComponent();
            UpdateCastingOffers();
            UpdateList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
