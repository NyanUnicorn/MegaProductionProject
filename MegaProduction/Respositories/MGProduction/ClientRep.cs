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

            SqlConnection sqlConnection1 = new SqlConnection(LUDBcononnectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dataReader;

            cmd.CommandText = "[PROC_GetClients]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            dataReader = cmd.ExecuteReader();

            MGClient client;

            while (dataReader.Read())
            {
                client = new MGClient();
                client.Name = dataReader.GetString(0);
                client.TelContact = dataReader.GetString(1);
                client.TelMGProd = dataReader.GetString(2);
                client.Street = dataReader.GetString(3);
                client.City = dataReader.GetString(4);
                client.Region = dataReader.GetString(5);
                client.PCode = dataReader.GetString(6);
                client.Country = dataReader.GetString(7);
                

                clients.Add(client);
            }


            sqlConnection1.Close();




            
            /*
            client.Name = "ClientTest";
            client.City = "VilleTest";

            clients.Add(client);

            client = new MGClient();
            client.Name = "ClientTest1";
            client.City = "VilleTest1";

            clients.Add(client);

            client = new MGClient();
            client.Name = "Bill";
            client.City = "Valendré";

            clients.Add(client);
            */

            return clients;
        }


        public static List<MGClient> GetClients(String _search)
        {
            List<MGClient> clients = new List<MGClient>();

            SqlConnection sqlConnection1 = new SqlConnection(LUDBcononnectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dataReader;

            cmd.CommandText = "[PROC_GetClients]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            dataReader = cmd.ExecuteReader();

            MGClient client;

            while (dataReader.Read())
            {
                client = new MGClient();
                client.Name = dataReader.GetString(0);
                client.TelContact = dataReader.GetString(1);
                client.TelMGProd = dataReader.GetString(2);
                client.Street = dataReader.GetString(3);
                client.City = dataReader.GetString(4);
                client.Region = dataReader.GetString(5);
                client.PCode = dataReader.GetString(6);
                client.Country = dataReader.GetString(7);


                clients.Add(client);
            }
            sqlConnection1.Close();
            return clients;
        }

    }
}