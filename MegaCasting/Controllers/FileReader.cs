using MegaCasting.Models;
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
        private String connectionConf = @"..\Conf\connection.conf";
        /// <summary>
        /// la connection à la base de donnée tant qu'utilisateur léger
        /// </summary>
        private DBConnection lightSqlConnection;

        #endregion
        #region public parameters
        /// <summary>
        /// Permet de récupérer la connection a la base de donné Légère
        /// </summary>
        public DBConnection LightSqlConnection { get => lightSqlConnection; }

        #endregion

        #region functions

        /// <summary>
        /// Lie le ficier cofig de connection àla base de donnée et modifie la connexion sql
        /// </summary>
        public void ReadSQLConnection()
        {
            //SQLConnection sqlconnection = new SQLConnection();
            StreamReader reader = new StreamReader("C:\\Users\\phill\\source\\repos\\TeamSpace\\TeamSpace\\Config\\config.txt");


            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(':');
                switch (values[0])
                {
                    case "UID":
                        this.LightSqlConnection.Uid = values[1];
                        break;
                    case "PWD":
                        this.LightSqlConnection.Pwd = values[1];
                        break;
                    case "SRV":
                        this.LightSqlConnection.Srv = values[1];
                        break;
                    case "DNB":
                        this.LightSqlConnection.Dbn = values[1];
                        break;
                    default:
                        break;

                }
            }
        }



        #endregion


        #region constructors
        public FileReader()
        {
            //ReadSQLConnection();
            this.LightSqlConnection.Uid = "MegaCastingLightUser";
            this.LightSqlConnection.Pwd = "P@$$w0rd";
            this.LightSqlConnection.Srv = "UX310UNICORNPC\\SQLEXPRESS";
            this.LightSqlConnection.Dbn = "MegaCasting";
        }

        #endregion

    }
}
