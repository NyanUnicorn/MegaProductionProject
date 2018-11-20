using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaCasting.Models
{
    public class DBConnection
    {


        #region field
        /// <summary>
        /// identifiant de l'utilisateur
        /// </summary>
        private String uid;
        /// <summary>
        /// Mot de passe de connection
        /// </summary>
        private String pwd;
        /// <summary>
        /// nom du serveur
        /// </summary>
        private String srv;
        /// <summary>
        /// nom de la base de donnée
        /// </summary>
        private String dbn;
        #endregion

        #region private mothod
        #endregion

        #region public mothod
        /// <summary>
        /// Permet de récupérer l' identifiant de l'utilisateur ou de la modifier
        /// </summary>
        /// <returns>String : name</returns>
        public string Uid { get => uid; set => uid = value; }
        /// <summary>
        /// Permet de récupérer le mot de passe de connection ou de la modifier
        /// </summary>
        /// <returns>String : name</returns>
        public string Pwd { get => pwd; set => pwd = value; }
        /// <summary>
        /// Permet de récupérer le nom du serveur ou de la modifier
        /// </summary>
        /// <returns>String : name</returns>
        public string Srv { get => srv; set => srv = value; }
        /// <summary>
        /// Permet de récupérer le nom de la base de donnée ou de la modifier
        /// </summary>
        /// <returns>String : name</returns>
        public string Dbn { get => dbn; set => dbn = value; }
        #endregion

        #region constructor

        #endregion
    }
}
