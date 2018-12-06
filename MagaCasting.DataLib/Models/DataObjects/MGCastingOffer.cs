using MegaCasting.DataLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.DataLib.Models
{
    public class MGCastingOffer
    {
        private int id;
        private String label;
        private DateTime publicationDate;
        private String description;
        private MGLocation location;
        private MGContractType contract;
        private MGClient client;
        private MGTalent talent;


        public int Id { get => id; set => id = value; }
        public string Label { get => label; set => label = value; }
        public DateTime PublicationDate { get => publicationDate; set => publicationDate = value; }
        public string Description { get => description; set => description = value; }
        public String Street { get => Location.Street; set => Location.Street = value; }
        public String City { get => Location.Street; set => Location.Street = value; }
        public String PostalCode { get => Location.PostalCode; set => Location.PostalCode = value; }
        public int ContractId { get => contract.Id; }
        public MGContractType Contract { get => contract; set => contract = value; }
        public MGLocation Location { get => location; set => location = value; }
        public MGClient Client { get => client; set => client = value; }
        public int DaysLeft { get => daysLeft(); }
        public MGTalent Talent { get => talent; set => talent = value; }

        private int daysLeft()
        {
            TimeSpan span = DateTime.Today.Subtract(publicationDate);
            return (int)span.TotalDays+30;
        }

        public MGCastingOffer()
        {
            location = new MGLocation();
            contract = new MGContractType();
            client = new MGClient();
            talent = new MGTalent();
        }
    }
}