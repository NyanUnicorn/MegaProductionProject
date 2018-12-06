using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MegaCasting.DataLib.Models
{
    public class MGClient
    {
        #region private field
        /// <summary>
        /// Identifiant du client
        /// </summary>
        private int id;
        /// <summary>
        /// Nom du client
        /// </summary>
        private String name;
        /// <summary>
        /// Numéro de téléphone de contact pour les artistes
        /// </summary>
        private String telContact;
        /// <summary>
        /// Numéro de téléphone de contact pour l'équipe MegaProduction
        /// </summary>
        private String telMGProd;
        /// <summary>
        /// Rue du client
        /// </summary>
        private String street;
        /// <summary>
        /// Ville du client
        /// </summary>
        private String city;
        /// <summary>
        /// Code postale du client
        /// </summary>
        private String pCode;
        /// <summary>
        /// Nombre de tokens restant
        /// </summary>
        private int tokens;
        #endregion

        #region public field 
        /// <summary>
        /// Permet de modifier ou récupérer le nom du client
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Permet de modifier ou récupérer le numéro de téléphone de contact pour les artistes
        /// </summary>
        public string TelContact { get => telContact; set => telContact = value; }
        /// <summary>
        /// Permet de modifier ou récupérer le numéro de téléphone de contact pour l'équipe de MégaProduction
        /// </summary>
        public string TelMGProd { get => telMGProd; set => telMGProd = value; }
        /// <summary>
        /// Permet de modifier ou récupérerLa rue du client
        /// </summary>
        public string Street { get => street; set => street = value; }
        /// <summary>
        /// Permet de modifier ou récupérer va ville du client
        /// </summary>
        public string City { get => city; set => city = value; }
        /// <summary>
        /// Permet de modifier ou récupérer le code postale du client
        /// </summary>
        public string PCode { get => pCode; set => pCode = value; }
        /// <summary>
        /// Permet de récupérer ou de modifier le nombre de tokens
        /// </summary>
        public int Tokens { get => tokens; set => tokens = value; }
        /// <summary>
        /// Permet de récupérer ou de modifier l'identifiant
        /// </summary>
        public int Id { get => id; set => id = value; }
        #endregion
    }
}