using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.DataLib.Models
{
    public class ContractType
    {
        private int id;
        private String label;
        private String shortLabel;

        public string Label { get => label; set => label = value; }
        public string ShortLabel { get => shortLabel; set => shortLabel = value; }
        public int Id { get => id; set => id = value; }
    }
}
