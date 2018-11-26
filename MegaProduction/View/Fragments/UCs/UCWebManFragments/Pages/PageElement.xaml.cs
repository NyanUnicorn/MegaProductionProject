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
        public enum ContentType {Undecided, Paragraph, OfferList };
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
        private Label lblTitle;
        private TextBox txtTitle;
        private TextBox txtPara;
        private ChooseElementContentType ContentChoice;
        private ContentType contentType;



        public ContentType ContentType1 { get => contentType; set => contentType = value; }
        public bool Editable { get => editable; set => editable = value; }
        public Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public TextBox TxtTitle { get => txtTitle; set => txtTitle = value; }
        public TextBox TxtPara { get => txtPara; set => txtPara = value; }
        public string Title { get => title; set => title = value; }


        #endregion

        #region private method
        public void SetContentType(ContentType _t)
        {
            this.ContentType1 = _t;
            if (this.ContentType1 == ContentType.Paragraph)
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
        public void CloseChoice()
        {
            parent.Save();
        }
        #endregion

        
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
            if (ContentType1 == ContentType.Paragraph)
            {
                this.GridContent.Children.Clear();
                TxtPara.IsReadOnly = false;
                this.GridContent.Children.Add(TxtPara);
            }
            else if(ContentType1 == ContentType.OfferList)
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
            if (Editable)
            {
                this.edit();   
            }
            else
            {
                parent.Save();
            }
        }



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

    }
}
