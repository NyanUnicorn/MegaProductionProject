using MegaProduction.Model.MGProduction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace MegaProduction.Respositories.MGProduction
{
    class ClientRep : Repository
    {
        public static List<MGClient> GetClients()
        {
            List<MGClient> clients = new List<MGClient>();

            using (IDbConnection connection = new SqlConnection(LUDBcononnectionString))
            {
                IDataReader dataReader;
                using (IDbCommand command = new SqlCommand())
                {
                    connection.Open();


                    command.CommandText = "[SP_GetClients]";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    dataReader = command.ExecuteReader();

                    MGClient client;

                    while (dataReader.Read())
                    {
                        client = new MGClient();
                        client.Id = dataReader.GetInt32(0);
                        client.Name = dataReader.GetString(1);
                        client.TelMGProd = dataReader.GetString(2);
                        client.TelContact = dataReader.GetString(3);
                        client.Street = dataReader.GetString(4);
                        client.City = dataReader.GetString(5);
                        client.PCode = dataReader.GetString(6);
                        client.Tokens = dataReader.GetInt32(7);

                        clients.Add(client);
                    }
                }
            }
            return clients;
        }


        public static List<MGClient> GetClients(String _search)
        {
            List<MGClient> clients = new List<MGClient>();

            using (SqlConnection connection = new SqlConnection(LUDBcononnectionString))
            {
                IDataReader dataReader;
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();


                    command.CommandText = "[dbo].[SP_GetClientsByName]";
                    
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Prepare();
                    command.Parameters.Add("@Param1", SqlDbType.NVarChar).Value = _search;
                    dataReader = command.ExecuteReader();

                    MGClient client;

                    while (dataReader.Read())
                    {
                        client = new MGClient();
                        client.Name = dataReader.GetString(0);
                        client.TelMGProd = dataReader.GetString(1);
                        client.TelContact = dataReader.GetString(2);
                        client.Street = dataReader.GetString(3);
                        client.City = dataReader.GetString(4);
                        client.PCode = dataReader.GetString(5);
                        client.Tokens = dataReader.GetInt32(6);

                        clients.Add(client);
                    }
                }
            }
            return clients;
        }

        public static void updateClient(MGClient _client, MGPurchase _purchase)
        {
            List<MGClient> clients = new List<MGClient>();

            using (SqlConnection connection = new SqlConnection(LUDBcononnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();


                    command.CommandText = "[dbo].[SP_UpdateClient]";

                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Prepare();
                    command.Parameters.Add("@clientId", SqlDbType.NVarChar).Value = _client.Id;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = _client.Name;
                    command.Parameters.Add("@telNumCt", SqlDbType.NVarChar).Value = _client.TelContact;
                    command.Parameters.Add("@telNumApp", SqlDbType.NVarChar).Value = _client.TelMGProd;
                    command.Parameters.Add("@street", SqlDbType.NVarChar).Value = _client.Street;
                    command.Parameters.Add("@city", SqlDbType.NVarChar).Value = _client.City;
                    command.Parameters.Add("@postalCode", SqlDbType.NVarChar).Value = _client.PCode;
                    command.Parameters.Add("@tokensLeft", SqlDbType.Int).Value = _client.Tokens;
                    command.Parameters.Add("@packQt", SqlDbType.Int).Value = _purchase.Quantity;
                    command.Parameters.Add("@packCost", SqlDbType.Decimal).Value = _purchase.Cost;
                    command.Parameters.Add("@packCastingId", SqlDbType.Int).Value = _purchase.PackId;
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}