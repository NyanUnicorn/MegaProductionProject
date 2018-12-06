using MegaCasting.DataLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaCasting.Models.PageContents
{
    public class PageContent
    {
        public enum PageContentType {Para, Offer}

        private int id;
        private String label;
        private DateTime lastUpdate;
        private List<MGCastingOffer> castingOffers;
        private MGParagraph paragraph;
        private PageContentType type;

        public int Id { get => id; set => id = value; }
        public string Label { get => label; set => label = value; }
        public DateTime LastUpdate { get => lastUpdate; set => lastUpdate = value; }
        public List<MGCastingOffer> CastingOffers { get => castingOffers; set => castingOffers = value; }
        public MGParagraph Paragraph { get => paragraph; set => paragraph = value; }
        public PageContentType Type { get => type; set => type = value; }
    }
}
