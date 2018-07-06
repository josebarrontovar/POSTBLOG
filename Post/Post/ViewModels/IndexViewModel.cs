using Post.DBCache;
using Post.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Post.ViewModels
{

    public class IndexViewModel
    {
        public PostProp PostPropVM { get; set; }
        public List<Category> Categorys { get; private set; }

        public List<PostProp> PPP { get; private set; }

        public IndexViewModel()
        {
            this.Categorys = DataCache.ListCategory;
        }
    }
}