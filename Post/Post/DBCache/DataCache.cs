using Post.Models;
using System.Collections.Generic;

namespace Post.DBCache
{
    public class DataCache
    {
        public static List<PostProp> ListPost = new List<PostProp>
        {
            
        };

        public static List<Category> ListCategory = new List<Category>
        {
          new Category{Id = 1, Name = "Accion"},
            new Category{Id = 2, Name = "Suspenso"},
              new Category{Id = 3, Name = "Noticias"},
                new Category{Id = 4, Name = "Deportes"},
                  new Category{Id = 5, Name = "Peliculas"},
        };
    }
}