using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProduction.Model.MGProduction
{
    class MGPurchase
    {
        #region private fields
        /// <summary>
        /// Identifiant de l'achat
        /// </summary>
        private int id;
        /// <summary>
        /// quantité de token dans l'achat
        /// </summary>
        private int quantity;
        /// <summary>
        /// Cout de l'achat
        /// </summary>
        private double cost;
        /// <summary>
        /// identifiant du pack acheté
        /// </summary>
        private int packId;
        /// <summary>
        /// Moment de la validation de l'achat
        /// </summary>
        private DateTime purchaseDate;
        #endregion

        #region public fields
        /// <summary>
        /// Permet de récupérer ou de modifier l'identifiant de l'achat
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// Permet de récupérer ou de modifier la quantité de token dans l'achat
        /// </summary>
        public int Quantity { get => quantity; set => quantity = value; }
        /// <summary>
        /// Permet de rcupérer ou de modifier la somme payé
        /// </summary>
        public double Cost { get => cost; set => cost = value; }
        /// <summary>
        /// Permet de récupérer ou de modifier l'identifiant du pack acheté
        /// </summary>
        public int PackId { get => packId; set => packId = value; }
        /// <summary>
        /// permet de récupérer ou de modifier la tade et l'heure de l'achat
        /// </summary>
        public DateTime PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
        #endregion
    }
}
