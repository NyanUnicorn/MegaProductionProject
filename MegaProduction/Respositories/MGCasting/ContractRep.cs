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
    class ContractRep : Repository
    {
        public static List<ContractType> GetContracts()
        {
            List<ContractType> contracts = new List<ContractType>();

            using (IDbConnection connection = new SqlConnection(LUDBcononnectionString))
            {
                IDataReader dataReader;
                using (IDbCommand command = new SqlCommand())
                {
                    connection.Open();


                    command.CommandText = "[SP_GetContracts]";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    dataReader = command.ExecuteReader();

                    ContractType contract;

                    while (dataReader.Read())
                    {
                        contract = new ContractType();
                        contract.Id = dataReader.GetInt32(0);
                        contract.Label = dataReader.GetString(1);
                        contract.ShortLabel = dataReader.GetString(2);


                        contracts.Add(contract);
                    }
                }
            }
            return contracts;
        }
    }
}
