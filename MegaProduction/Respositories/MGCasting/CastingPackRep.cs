using MegaProduction.Model.MGCasting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace MegaProduction.Respositories.MGCasting
{
    class CastingPackRep : Repository
    {
        public static List<MGCastingPack> GetCastingPacks()
        {
            List<MGCastingPack> packs = new List<MGCastingPack>();

            using (IDbConnection connection = new SqlConnection(LUDBcononnectionString))
            {
                IDataReader dataReader;
                using (IDbCommand command = new SqlCommand())
                {
                    connection.Open();


                    command.CommandText = "[SP_GetCastingPacks]";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    dataReader = command.ExecuteReader();

                    MGCastingPack pack;

                    while (dataReader.Read())
                    {
                        pack = new MGCastingPack();
                        pack.Id = dataReader.GetInt32(0);
                        pack.Label = dataReader.GetString(1);
                        pack.Size = dataReader.GetInt32(2);
                        pack.Cost = (double) dataReader.GetDecimal(3);


                        packs.Add(pack);
                    }
                }
            }
            return packs;
        }
    }
}