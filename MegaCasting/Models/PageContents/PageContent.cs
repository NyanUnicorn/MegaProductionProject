using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaCasting.Models.PageContents
{
    public abstract class PageContent
    {
        private int id;
        private String label;
        private DateTime lastUpdate;

        public int Id { get => id; set => id = value; }
        public string Label { get => label; set => label = value; }
        public DateTime LastUpdate { get => lastUpdate; set => lastUpdate = value; }
    }
}
