using MegaCasting.Models;
using MegaCasting.Models.PageContents;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MegaCasting.Repositories
{
    public class PageRep : Repository
    {
        public static List<PageContent> GetPageContents(int _id)
        {
            List<PageContent> contents = new List<PageContent>();
            using (SqlConnection connection = new SqlConnection(LUDBcononnectionString))
            {
                IDataReader dataReader;
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();

                    command.CommandText = "[dbo].[SP_GetPageContent";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Prepare();
                    command.Parameters.Add("@pageId", SqlDbType.Int).Value = _id;
                    command.ExecuteNonQuery();
                    dataReader = command.ExecuteReader();
                    PageContent content;
                    /*
                    while (dataReader.Read())
                    { 
                        content = new MGTalent();
                        content.Id = dataReader.GetInt32(0);
                        content.Label = dataReader.GetString(1);
                        content.Description = dataReader.GetString(2);


                        talents.Add(talent);
                        
                    }*/
                }
            }
            return contents;
        }
    }
}
