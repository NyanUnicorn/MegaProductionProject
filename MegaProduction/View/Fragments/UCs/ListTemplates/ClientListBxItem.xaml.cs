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

        #region constructor
        public ClientListBxItem(UCClientManager _clientManager, int _index)
        {
            InitializeComponent();
            this.parent = _clientManager;
            this.index = _index;
        }
        #endregion

        #region event
        /// <summary>
        /// Indiquer au parent qu'il est sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientListBxItem0_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.parent.SelectClient(index);
        }
        #endregion

    }
}
