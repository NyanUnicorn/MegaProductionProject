using MegaCasting.DataLib.Models;
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
    /*[SiteContent].[Id], [SiteContent].[LabelFr], [SiteContent].[LastUpdt] 
	,[Paragraph].[Id], [Paragraph].[LabelFr], [Paragraph].[ParagText]
	,[Offer].[Id], [Offer].[LibelFr], [Offer].[Publication], [Offer].[Description], [Offer].[StreetName], [Offer].[CityName], [Offer].[PostalCode], [Offer].[PeriodTokens]
	,[Talent].[Id], [Talent].[LabelFr]
	,[ContractType].[Id], [ContractType].[LabelShortFr]*/
                    while (dataReader.Read())
                    { 
                        content = new PageContent();
                        content.Id = dataReader.GetInt32(1);
                        content.Label = dataReader.GetString(2);
                        content.LastUpdate = dataReader.GetDateTime(3);
                        if (dataReader.GetInt32(7) == 0)
                        {
                            content.Type = PageContent.PageContentType.Para;
                            MGParagraph para = new MGParagraph();
                            para.Id = dataReader.GetInt32(4);
                            para.Label = dataReader.GetString(5);
                            para.ParaText = dataReader.GetString(6);
                        }
                        else
                        {
                            content.Type = PageContent.PageContentType.Offer;
                            MGCastingOffer offer = new MGCastingOffer();
                            offer.Id = dataReader.GetInt32(7);
                            offer.Label = dataReader.GetString(8);
                            offer.PublicationDate = dataReader.GetDateTime(9);
                            offer.Description = dataReader.GetString(10);
                            offer.Street = dataReader.GetString(11);
                            offer.City = dataReader.GetString(12);
                            offer.PostalCode = dataReader.GetString(13);
                            offer.Talent.Id = dataReader.GetInt32(15);
                            offer.Talent.Label = dataReader.GetString(16);

                            content.CastingOffers.Add(offer);
                        }


                        contents.Add(content);
                        
                    }
                }
            }
            return contents;
        }


        public static List<PageContent> GetPageOffers(int _id)
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

                    while (dataReader.Read())
                    {
                        content = new MGTalent();
                        try
                        {
                            if (dataReader.GetInt32(7) != 0)
                            {
                                content = new PageOffers();
                            }
                        }
                        catch (Exception)
                        {

                        }
                        content.Id = dataReader.GetInt32(0);
                        content.Label = dataReader.GetString(1);
                        content.Description = dataReader.GetString(2);


                        talents.Add(talent);

                    }
                }
            }
            return contents;
        }

    }
}
