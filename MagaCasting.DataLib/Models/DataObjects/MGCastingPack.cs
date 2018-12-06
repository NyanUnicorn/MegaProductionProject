using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MegaCasting.DataLib.Models
{
    public class MGCastingPack
    {
        #region private fields
        /// <summary>
        /// Identifiant du pack
        /// </summary>
        private int id;
        /// <summary>
        /// Libelle du pack
        /// </summary>
        private String label;
        /// <summary>
        /// Nombre de token dans le pack
        /// </summary>
        private int size;
        /// <summary>
        /// Cout du pack
        /// </summary>
        private double cost;
        #endregion

        #region fublic fields
        /// <summary>
        /// Permet de récupérer ou de modifer l'identifiant du pack
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// Permet de récupérer ou de modifier le libelle du pack
        /// </summary>
        public string Label { get => label; set => label = value; }
        /// <summary>
        /// Permet de récupérer ou de modifier le nombre de token dans le pack
        /// </summary>
        public int Size { get => size; set => size = value; }
        /// <summary>
        /// Permet de récupérer ou de modifier le cout du pack
        /// </summary>
        public double Cost { get => cost; set => cost = value; }
        #endregion


    }
}