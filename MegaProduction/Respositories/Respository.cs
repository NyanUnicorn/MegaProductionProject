using MegaProduction.Model.Tools.Connections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MegaProduction.Respositories
{
    public abstract class Repository
    {
        #region private field
        /// <summary>
        /// "light user connection" connexion d'utilisateur de client léger
        /// </summary>
        private static DBConnection hUConnexion = new DBConnection();
        #endregion



        #region public field
        /// <summary>
        /// Permet de récupérer et de modifier la connexion d'utilisateur de client léger
        /// </summary>
        public static DBConnection HUConnexion { get => hUConnexion; set => hUConnexion = value; }
        /// <summary>
        /// Permet de récupérer la chaine de connexion à la base de donnée d'utilisateur du client léger
        /// </summary>
        public static string LUDBcononnectionString => produceConnectionString(hUConnexion);
        #endregion


        #region public method
        /// <summary>
        /// Retourne une chaine de connexion à une base de donnée pour une connexion entré en paramètre
        /// </summary>
        /// <param name="_dbconnection"></param>
        /// <returns>String: Chaine de connexion</returns>
        private static String produceConnectionString(DBConnection _dbconnection)
        {
            return "Server=" + _dbconnection.Srv + ";Database=" + _dbconnection.Dbn + ";User Id=" + _dbconnection.Uid + ";Password=" + _dbconnection.Pwd + ";Trusted_Connection=True";
        }
        #endregion

        #region public method

        #endregion
        

    }
}