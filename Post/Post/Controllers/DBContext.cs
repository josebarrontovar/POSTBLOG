using Post.Models;
using System;
using System.Data.Entity;

namespace Post.Controllers
{
    public class DBContext : DbContext
    {
        public DbSet<PostProp> DBContextSet { get; set; }

    }
}