using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProduction.Respositories.MGCasting
{
    class TalentRep : Repository
    {
        public static List<MGTalent> GetTalents()
        {
            List<MGTalent> talents = new List<MGTalent>();

            using (IDbConnection connection = new SqlConnection(LUDBcononnectionString))
            {
                IDataReader dataReader;
                using (IDbCommand command = new SqlCommand())
                {
                    connection.Open();


                    command.CommandText = "[SP_GetTalents]";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    dataReader = command.ExecuteReader();

                    MGTalent talent;

                    while (dataReader.Read())
                    {
                        talent = new MGTalent();
                        talent.Id = dataReader.GetInt32(0);
                        talent.Label = dataReader.GetString(1);
                        talent.Description = dataReader.GetString(2);


                        talents.Add(talent);
                    }
                }
            }
            return talents;
        }
    }
}
