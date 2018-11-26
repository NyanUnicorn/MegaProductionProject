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

namespace MegaProduction.View.Fragments.UCs.UCWebManFragments.Pages
{
    /// <summary>
    /// Logique d'interaction pour ChooseElementContentType.xaml
    /// </summary>
    public partial class ChooseElementContentType : UserControl
    {
        private PageElement parent;






        public ChooseElementContentType()
        {
            InitializeComponent();
        }

        public ChooseElementContentType(PageElement _parent)
        {
            InitializeComponent();
            this.parent = _parent;
        }



        private void ImgClose_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            parent.DeleteThis();            
        }

        private void Grid_LostMouseCapture(object sender, MouseEventArgs e)
        {
            //parent.CloseChoice();
        }

        private void ImgOffers_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            parent.SetContentType(PageElement.ContentType.OfferList);
        }

        private void ImgParagrph_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            parent.SetContentType(PageElement.ContentType.Paragraph);
        }

        private void UserControl_LostFocus(object sender, RoutedEventArgs e)
        {
            //parent.CloseChoice();
        }
    }
}
