using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MegaProduction.Model.MGProduction
{
    class MGClient
    {
        #region private field
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
        /// Région du client
        /// </summary>
        private String region;
        /// <summary>
        /// Code postale du client
        /// </summary>
        private String pCode;
        /// <summary>
        /// Pays du client
        /// </summary>
        private String country;
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
        /// Permet de modifier ou récupérer la région du client
        /// </summary>
        public string Region { get => region; set => region = value; }
        /// <summary>
        /// Permet de modifier ou récupérer le code postale du client
        /// </summary>
        public string PCode { get => pCode; set => pCode = value; }
        /// <summary>
        /// Permet de modifier ou récupérer le pays du client
        /// </summary>
        public string Country { get => country; set => country = value; }
        #endregion
    }
}