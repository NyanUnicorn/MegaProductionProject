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
    /// Logique d'interaction pour PageElement.xaml
    /// </summary>
    public partial class PageElement : UserControl
    {
        #region enum
        public enum ElementType {Undecided, Paragraph, OfferList };
        #endregion

        #region private field
        /// <summary>
        /// Identifiant connue par le parent
        /// </summary>
        private int id;
        /// <summary>
        /// Pointeur pers le parent
        /// </summary>
        private PageContentHolder parent;
        /// <summary>
        /// Titre du contenu
        /// </summary>
        private String title;
        /// <summary>
        /// Contenue non typé. Peut ètre une paragraphe, ou un control utilisateur de la liste d'offre;
        /// </summary>
        private Object contentObj;
        /// <summary>
        /// Si l'élément est éditable ou non
        /// </summary>
        private bool editable = false;
        /// <summary>
        /// Libelle du titre
        /// </summary>
        private Label lblTitle;
        /// <summary>
        /// TexteBox du titre (pour l'édition)
        /// </summary>
        private TextBox txtTitle;
        /// <summary>
        /// TextBox du paragraph (our les deux situation, mois d'importance avec la présentation)
        /// </summary>
        private TextBox txtPara;
        /// <summary>
        /// Control utilisateur pour le choix de l'utilisateur
        /// </summary>
        private ChooseElementContentType ContentChoice;
        /// <summary>
        /// Type de contenue
        /// </summary>
        private ElementType contentType;
        #endregion

        #region public field
        /// <summary>
        /// Permet de récupérer et de modifier le type de contenue.
        /// </summary>
        public ElementType ContentType { get => contentType; set => contentType = value; }
        /// <summary>
        /// Permet de récupérer et de modifier la booléenne d'éditabilité
        /// </summary>
        public bool Editable { get => editable; set => editable = value; }
        /// <summary>
        /// Permet de récupérer et de modifier le libelle du titre
        /// </summary>
        public Label LblTitle { get => lblTitle; set => lblTitle = value; }
        /// <summary>
        /// Permet de récupérer et de modifier la texteBox du titre.
        /// </summary>
        public TextBox TxtTitle { get => txtTitle; set => txtTitle = value; }
        /// <summary>
        /// Permet de récupérer et de modifier La textBox du paragraphe.
        /// </summary>
        public TextBox TxtPara { get => txtPara; set => txtPara = value; }
        /// <summary>
        /// Permet de récupérer et de modifier le titre.
        /// </summary>
        public string Title { get => title; set => title = value; }
        #endregion

        #region private method
        /// <summary>
        /// Permet de changer le type de contenue
        /// </summary>
        /// <param name="_t"></param>
        public void SetContentType(ElementType _t)
        {
            this.ContentType = _t;
            if (this.ContentType == ElementType.Paragraph)
            {
                this.GridContent.Children.Clear();
                TxtPara = new TextBox();
                TxtPara.AcceptsReturn = true;
                TxtPara.TextWrapping = TextWrapping.WrapWithOverflow;
                TxtPara.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
                TxtPara.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
                TxtPara.Background = null;
                TxtPara.IsReadOnly = false;
                this.GridContent.Children.Add(TxtPara);
            }
        }
        /// <summary>
        /// Ferme l'option de choix et lance la sauvegarde
        /// </summary>
        public void CloseChoice()
        {
            parent.Save();
        }
        /// <summary>
        /// Rend le contenaire étitable
        /// </summary>
        private void edit()
        {
            this.Editable = true;
            parent.EditedItem = this;
            parent.EditingItem = this.Editable;
            this.GridLabel.Children.Clear();
            TxtTitle.Text = this.Title;
            this.GridLabel.Children.Add(TxtTitle);
            //ToDo : set characteristics for textboxes
            if (ContentType == ElementType.Paragraph)
            {
                this.GridContent.Children.Clear();
                TxtPara.IsReadOnly = false;
                this.GridContent.Children.Add(TxtPara);
            }
            else if (ContentType == ElementType.OfferList)
            {

            }
            else
            {

            }
        }
        /// <summary>
        /// Permet de changer d'atat entre éditable ou non.
        /// </summary>
        private void switchState()
        {
            if (!Editable)
            {
                this.edit();
            }
            else
            {
                parent.Save();
            }
        }
        #endregion

        #region public method
        /// <summary>
        /// Rend l'élément en lisible seulement.
        /// </summary>
        public void SetContentReadOnly()
        {
            TxtPara.IsReadOnly = true;
        }
        /// <summary>
        /// Supprimer cette élément. Demander au parent d'être supprimé.
        /// </summary>
        public void DeleteThis()
        {
            parent.deleteContent(this);

        }

        #endregion

        #region contructor
        public PageElement()
        {
            InitializeComponent();
        }

        public PageElement(PageContentHolder _parent, int _id, bool _isNew = true)
        {
            InitializeComponent();
            this.ContentChoice = new ChooseElementContentType(this);
            this.parent = _parent;
            this.id = _id;
            this.LblTitle = new Label();
            this.TxtTitle = new TextBox();
            this.ContentChoice = new ChooseElementContentType(this);
            if (_isNew)
            {
                this.GridContent.Children.Add(ContentChoice);
                edit();
            }
        }
        public PageElement(PageContentHolder _parent, int _id, String _label, Object _content)
        {
            InitializeComponent();
            this.ContentChoice = new ChooseElementContentType(this);
            this.parent = _parent;
            this.id = _id;
            this.LblTitle = new Label();
            this.Title = _label;
            this.contentObj = _content;
        }
        #endregion

        #region event
        /// <summary>
        /// Changer d'état de l'élément quand double cliqué.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            switchState();
        }
        #endregion

    }
}
