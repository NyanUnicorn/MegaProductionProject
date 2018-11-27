using MegaCasting.Models;
using MegaCasting.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MegaCasting.Controllers
{
    public class FileReader
    {
        #region private parameters
        /// <summary>
        /// position relatif du fichier de cofiguration de connection
        /// </summary>
        private static String connectionConf = @"Conf\databaseconnection.conf";

        #endregion

        #region public parameters
        #endregion

        #region public methods

        /// <summary>
        /// Lie le ficier config de connection à la base de donnée et modifie la connexion sql
        /// </summary>
        public static void ReadLightConnection()
        {
            DBConnection lightSqlConnection = new DBConnection();
            //SQLConnection sqlconnection = new SQLConnection();
            StreamReader reader = new StreamReader(connectionConf);


            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(':');
                switch (values[0])
                {
                    case "UID":
                        lightSqlConnection.Uid = values[1];
                        break;
                    case "PWD":
                        lightSqlConnection.Pwd = values[1];
                        break;
                    case "SRV":
                        lightSqlConnection.Srv = values[1];
                        break;
                    case "DNB":
                        lightSqlConnection.Dbn = values[1];
                        break;
                    default:
                        break;

                }
            }
            /*
            lightSqlConnection.Uid = "MegaCastingLightUser";
            lightSqlConnection.Pwd = "P@$$w0rd";
            lightSqlConnection.Srv = "UX310UNICORNPC\\SQLEXPRESS";
            lightSqlConnection.Dbn = "MegaCasting";
            */
            Repository.LUConnexion = lightSqlConnection;
        }
        #endregion


    }
}
