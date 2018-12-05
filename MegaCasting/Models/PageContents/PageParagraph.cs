using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaCasting.Models.PageContents
{
    public class PageParagraph : PageContent
    {
        private String paragraph;

        public string Paragraph { get => paragraph; set => paragraph = value; }
    }
}
