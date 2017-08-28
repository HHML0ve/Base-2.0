using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC4_1._0.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
    }


 

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}