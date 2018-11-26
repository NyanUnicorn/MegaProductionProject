using MegaProduction.Model.Structure.Tabs.WebViewerTabs;
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
    /// Logique d'interaction pour Index.xaml
    /// </summary>
    public partial class PageContentHolder : UserControl
    {
        #region enum
        /// <summary>
        /// Enumère les noms de pages du site web
        /// </summary>
        public enum PageName { Index = 0, JobOffers = 1 };
        #endregion

        #region private field
        /// <summary>
        /// Contenue de la page divisé en eléments indépendent
        /// </summary>
        private List<PageElement> pageElms;
        /// <summary>
        /// Page du site web. Modifié par son nom.
        /// </summary>
        private PageName pageNamedType;
        /// <summary>
        /// Element en cours de modification.
        /// </summary>
        private PageElement editedItem;
        /// <summary>
        /// Vrai si in item est en cours d'éxecution.
        /// </summary>
        private bool editingItem;
        #endregion

        #region public field
        /// <summary>
        /// Permet de récupérer ou de modifier lélémént en cour d'éxecution.
        /// </summary>
        public PageElement EditedItem { get => editedItem; set => editedItem = value; }
        /// <summary>
        /// Retourne Vrai si un élémént est en cous de modification. Faux sinon. Peut aussi être modifié.
        /// </summary>
        public bool EditingItem { get => editingItem; set => editingItem = value; }
        #endregion

        #region private field
        /// <summary>
        /// Création d'un nouvel élément. Ajout de l'élément dans la liaste
        /// </summary>
        private void createNewContent()
        {

            PageElement pE = new PageElement(this, 1);
            pageElms.Add(pE);
            refreshGrid();
        }

        /// <summary>
        /// Rafréchire la page, nétoyer la page et de nouveau la remplir à parir de la liste d'éléménts
        /// </summary>
        private void refreshGrid()
        {
            this.ScrlVContentHolder.Items.Clear();
            foreach (PageElement pE in pageElms)
            {
                this.ScrlVContentHolder.Items.Add(pE);
            }
        }
        #endregion

        #region public field
        /// <summary>
        /// Supprimer un élément de la liste, puis rafréchire la page
        /// </summary>
        /// <param name="_item">Element à supprimer</param>
        public void deleteContent(PageElement _item)
        {
            pageElms.Remove(_item);
            refreshGrid();
            editingItem = false;
        }
        /// <summary>
        /// Tender de sauvegarder l'élément en cours de modification.
        /// </summary>
        public void Save()
        {
            editedItem.Editable = false;
            this.editingItem = false;
            editedItem.Title += "hello" + editedItem.TxtTitle.Text;
            editedItem.LblTitle.Content = editedItem.Title;
            editedItem.GridLabel.Children.Clear();
            editedItem.GridLabel.Children.Add(editedItem.LblTitle);
            if (editedItem.ContentType1 == PageElement.ContentType.Paragraph)
            {
                editedItem.SetContentReadOnly();
            }
            else if (editedItem.ContentType1 == PageElement.ContentType.OfferList)
            {

            }
            else
            {
                deleteContent(editedItem);
            }
            //ToDo: Save to database;
        }
        #endregion

        #region contructor
        /// <summary>
        /// Construit un conteneur d'élément de page.
        /// </summary>
        /// <param name="_page">identifiant de la page</param>
        public PageContentHolder(int _page)
        {
            InitializeComponent();
            pageElms = new List<PageElement>();
            switch (_page)
            {
                case 0:
                default:
                    pageNamedType = PageName.Index;
                    break;
                case 1:
                    pageNamedType = PageName.JobOffers;
                    break;
            }

        }
        #endregion

        #region events
        private void ImgAddContent_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (!editingItem)
            {
                createNewContent();
            }
        }

        private void ImgSaveContent_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (editingItem)
            {
                this.Save();
            }
        }

        private void ImgAddContent_MouseEnter(object sender, MouseEventArgs e)
        {
            ImgAddContent.Source = new BitmapImage(new Uri(@"pack://application:,,,/Images/AddImg0h-200.png"));
        }

        private void ImgAddContent_MouseLeave(object sender, MouseEventArgs e)
        {
            ImgAddContent.Source = new BitmapImage(new Uri(@"pack://application:,,,/Images/AddImg0-200.png"));
        }

        private void ImgSaveContent_MouseEnter(object sender, MouseEventArgs e)
        {
            ImgSaveContent.Source = new BitmapImage(new Uri(@"pack://application:,,,/Images/saveImg0h-200.png"));
        }

        private void ImgSaveContent_MouseLeave(object sender, MouseEventArgs e)
        {
            ImgSaveContent.Source = new BitmapImage(new Uri(@"pack://application:,,,/Images/saveImg0-200.png"));
        }
        #endregion

    }
}
