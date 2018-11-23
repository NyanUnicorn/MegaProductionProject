using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace MegaProduction.Model
{
     abstract class Tab : ITab
    {
        #region private field
        /// <summary>
        /// nom de Tab
        /// </summary>
        private String name;
        /// <summary>
        /// Contenue de Tab
        /// </summary>
        private UserControl tabcontent;
        /// <summary>
        /// Element TabItem de Tab
        /// </summary>
        private TabItem tabElement;
        #endregion

        #region public field
        /// <summary>
        /// Modifie ou récupérer le nom de Tab
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Modifier ou récupérer le contenue de Tab
        /// </summary>
        public UserControl TabContent { get => tabcontent; set => tabcontent = value; }
        /// <summary>
        /// Modifie ou récupérer la TabItem de Tab
        /// </summary>
        public TabItem TabElement { get => tabElement; }
        #endregion


        /// <summary>
        /// Créer l'arrière plan de l'onglet
        /// </summary>
        private void assembleBackground()
        {
            System.Windows.Media.LinearGradientBrush background = new System.Windows.Media.LinearGradientBrush();
            System.Windows.Media.GradientStop gradStop = new System.Windows.Media.GradientStop();
            gradStop.Color = Color.FromRgb(63, 63, 70);
            gradStop.Offset = 1;
            background.GradientStops.Add(gradStop);
            gradStop = new System.Windows.Media.GradientStop();
            gradStop.Color = Color.FromRgb(108, 109, 107);            
            background.GradientStops.Add(gradStop);

            System.Windows.Point brushGradPoint = new System.Windows.Point();
            brushGradPoint.X = 0.5;
            brushGradPoint.Y = 1;
            background.EndPoint = brushGradPoint;
            brushGradPoint.X = 0.5;
            brushGradPoint.Y = 0;
            background.StartPoint = brushGradPoint;
            tabElement.Background = background;
        }


        /// <summary>
        /// Céation d'un élément TabItem adapté au besoins en prennant le nom de Tab en paramètre
        /// </summary>
        /// <param name="_nom">modifie le nom de Tab</param>
        public Tab(String _nom)
        {
            tabElement = new TabItem();
            tabElement.FontSize = 20;
            //TabElement.FontFamily = new System.Windows.Media.FontFamily("Franklin Gothic Book");
            tabElement.Padding = new System.Windows.Thickness(40, 10, 40, 10);
            assembleBackground();
            tabElement.Foreground = new SolidColorBrush(Color.FromRgb(206, 214, 199));
            tabElement.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
            tabElement.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
        }
        /// <summary>
        /// Céation d'un élément TabItem adapté au besoins
        /// </summary>
        public Tab()
        {
            tabElement = new TabItem();
            tabElement.FontSize = 20;
            //TabElement.FontFamily = new System.Windows.Media.FontFamily("Franklin Gothic Book");
            tabElement.Padding = new System.Windows.Thickness(40, 10, 40, 10);
            assembleBackground();
        }
    }
}
