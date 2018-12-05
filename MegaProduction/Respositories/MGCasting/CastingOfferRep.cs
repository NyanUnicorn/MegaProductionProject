using MegaProduction.Model.MGCasting;
using MegaProduction.Model.MGProduction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProduction.Respositories.MGCasting
{
    class CastingOfferRep : Repository
    {
        /// <summary>
        /// Ajouter une offre dans la base de données
        /// </summary>
        /// <param name="_offerToAdd">Offre à ajouter</param>
        public static void AddOffer(MGCastingOffer _offerToAdd)
        {
            using (SqlConnection connection = new SqlConnection(LUDBcononnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();

                    command.CommandText = "[dbo].[SP_CreateCastingOffer]";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Prepare();
                    command.Parameters.Add("@Label", SqlDbType.NVarChar).Value =_offerToAdd.Label;
                    command.Parameters.Add("@Description", SqlDbType.NVarChar).Value =_offerToAdd.Description;
                    command.Parameters.Add("@Street", SqlDbType.NVarChar).Value =_offerToAdd.Street;
                    command.Parameters.Add("@City", SqlDbType.NVarChar).Value =_offerToAdd.City;
                    command.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value =_offerToAdd.PostalCode;
                    command.Parameters.Add("@ContractId", SqlDbType.Int).Value =_offerToAdd.Contract.Id;
                    command.Parameters.Add("@ClientId", SqlDbType.Int).Value =_offerToAdd.Client.Id;
                    command.Parameters.Add("@TalentId", SqlDbType.Int).Value =_offerToAdd.Talent.Id;
                    command.Parameters.Add("@UserId", SqlDbType.Int).Value = MGCurrentHeavyUser.Id;
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Selectionner tout les offres de casting actif
        /// </summary>
        /// <returns></returns>
        public static List<MGCastingOffer> GetActiveCastingOffers()
        {
            List<MGCastingOffer> offers = new List<MGCastingOffer>();

            using (SqlConnection connection = new SqlConnection(LUDBcononnectionString))
            {
                IDataReader dataReader;
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();


                    command.CommandText = "[dbo].[SP_GetCastingOffers]";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    dataReader = command.ExecuteReader();

                    MGCastingOffer offer;

                    while (dataReader.Read())
                    {

                        offer = new MGCastingOffer();
                        offer.Id =                  dataReader.GetInt32(0);
                        offer.Label =               dataReader.GetString(1);
                        offer.PublicationDate =     dataReader.GetDateTime(2);
                        offer.Description =         dataReader.GetString(3);
                        offer.Street =              dataReader.GetString(4);
                        offer.City =                dataReader.GetString(5);
                        offer.PostalCode =          dataReader.GetString(6);
                        offer.Contract.Id =         dataReader.GetInt32(7);
                        offer.Contract.Label =      dataReader.GetString(8);
                        offer.Contract.ShortLabel = dataReader.GetString(9);
                        offer.Talent.Id =           dataReader.GetInt32(10);
                        offer.Talent.Label =        dataReader.GetString(11);
                        offer.Talent.Description =  dataReader.GetString(12);
                        offer.Client.Id =           dataReader.GetInt32(13);
                        offer.Client.Name =         dataReader.GetString(14);

                        offers.Add(offer);
                    }
                }
            }
            return offers;
        }
    }
}
