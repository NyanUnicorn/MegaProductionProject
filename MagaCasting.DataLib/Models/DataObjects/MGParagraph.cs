using System;
using System.Collections.Generic;
using System.Text;

namespace MegaCasting.DataLib.Models
{
    public class MGParagraph
    {
        private int id;
        private String label;
        private String paraText;

        public int Id { get => id; set => id = value; }
        public string Label { get => label; set => label = value; }
        public string ParaText { get => paraText; set => paraText = value; }
    }
}
