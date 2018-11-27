using MegaCasting.Controllers;
using MegaCasting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaCasting.Repositories
{
    public abstract class Repository
    {
        #region field
        /// <summary>
        /// "light user connection" connexion d'utilisateur de client léger
        /// </summary>
        private static DBConnection lUConnexion;
        #endregion

        #region public field
        /// <summary>
        /// Permet de récupérer et de modifier la connexion d'utilisateur de client léger
        /// </summary>
        public static DBConnection LUConnexion { get => lUConnexion; set => lUConnexion = value; }
        /// <summary>
        /// Permet de récupérer la chaine de connexion à la base de donnée d'utilisateur du client léger
        /// </summary>
        public static string LUDBcononnectionString => produceConnectionString(lUConnexion);
        #endregion

        #region public method
        /// <summary>
        /// Retourne une chaine de connexion à une base de donnée pour une connexion entré en paramètre
        /// </summary>
        /// <param name="_dbconnection"></param>
        /// <returns>String: Chaine de connexion</returns>
        private static String produceConnectionString(DBConnection _dbconnection)
        {
            return "Server=" + _dbconnection.Srv + ";Database=" + _dbconnection.Dbn + ";userid=" + _dbconnection.Uid + ";password=" + _dbconnection.Pwd + ";Trusted_Connection=True";
        }
        #endregion

    }




}
