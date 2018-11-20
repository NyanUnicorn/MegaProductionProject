using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaCasting.Models
{
    public class Site
    {
        #region field
        /// <summary>
        /// Nom du site
        /// </summary>
        private String name;
        /// <summary>
        /// List des pages relié à l'instance de ce site
        /// </summary>
        private List<Page> pageList;
        #endregion

        #region private mothod
        #endregion

        #region public mothod
        /// <summary>
        /// Permet de récupérer le nom de cette instance de site
        /// </summary>
        /// <returns>String : name</returns>
        public String GetName()
        {
            return name;
        }
        #endregion

        #region constructor
        public Site()
        {
            this.name = "MegaCasting";
            
        }
        #endregion
    }
}
