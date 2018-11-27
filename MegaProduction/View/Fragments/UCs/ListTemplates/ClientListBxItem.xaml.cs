using MegaProduction.Model.MGProduction;
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
    /// Logique d'interaction pour ClientListBxItem.xaml
    /// </summary>
    public partial class ClientListBxItem : UserControl
    {
        #region private field
        private UCClientManager parent;
        private int index;
        #endregion

        public ClientListBxItem(UCClientManager _clientManager, int _index)
        {
            InitializeComponent();
            this.parent = _clientManager;
            this.index = _index;
        }

        public ClientListBxItem()
        {
            InitializeComponent();
        }

        #region event
        /// <summary>
        /// Evenement, quand l'item est double cliqué, ses informations sont affiché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientListBxItem0_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            this.parent.TxtBxClientName.Text = parent.ClientList.ElementAt(this.index).Name;
            this.parent.TxtBxTelNumContact.Text = parent.ClientList.ElementAt(this.index).TelContact;
            this.parent.TxtBxTelApplication.Text = parent.ClientList.ElementAt(this.index).TelMGProd;
            this.parent.TxtBxStreet.Text = parent.ClientList.ElementAt(this.index).Street;
            this.parent.TxtBxCity.Text = parent.ClientList.ElementAt(this.index).City;
            this.parent.TxtBxRegion.Text = parent.ClientList.ElementAt(this.index).Region;
            this.parent.TxtBxPC.Text = parent.ClientList.ElementAt(this.index).PCode;
            this.parent.TxtBxCountry.Text = parent.ClientList.ElementAt(this.index).Country;
        }
        #endregion

    }
}
