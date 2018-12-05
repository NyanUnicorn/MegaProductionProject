using MegaProduction.Model.MGProduction;
using MegaProduction.Respositories.MGCasting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProduction.Model.MGCasting
{
    class MGCastingOffer
    {
        private int id;
        private String label;
        private DateTime publicationDate;
        private String description;
        private Location location;
        private ContractType contract;
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
        public ContractType Contract { get => contract; set => contract = value; }
        public Location Location { get => location; set => location = value; }
        public MGClient Client { get => client; set => client = value; }
        public int DaysLeft { get => daysLeft(); }
        internal MGTalent Talent { get => talent; set => talent = value; }

        private int daysLeft()
        {
            TimeSpan span = DateTime.Today.Subtract(publicationDate);
            return (int)span.TotalDays+30;
        }

        public MGCastingOffer()
        {
            location = new Location();
            contract = new ContractType();
            client = new MGClient();
            talent = new MGTalent();
        }
    }
}