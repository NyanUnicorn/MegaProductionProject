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
    /// Logique d'interaction pour OfferListItem.xaml
    /// </summary>
    public partial class OfferListItem : UserControl
    {
        public OfferListItem(String _title, String _client, int _days, String _description)
        {
            InitializeComponent();
            this.LblTitle.Content = _title;
            this.LblClient.Content = _client;
            this.LblDaysLeft.Content = _days;
            this.TxtContent.Text = _description;
        }
    }
}
