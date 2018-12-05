using MegaCasting.Models.PageContents;
using MegaCasting.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaCasting.Models
{
    public abstract class Page
    {
        private int id;
        private String name;
        private List<PageContent> pageContentList;

        
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => Name = value; }
        public List<PageContent> PageContentList { get => pageContentList; set => pageContentList = value; }

        protected Page(int _id, String _name)
        {
            this.id = _id;
            this.name = _name;
            this.pageContentList = PageRep.GetPageContents(_id);
        }

    }
}
