using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TallerAPI.API.Models
{
    public class PublicacionContext : DbContext
    {
        public PublicacionContext() : base("PublicacionConnection")
        {

        }
        public DbSet <Publicaciones> Publicacion { get; set; }

    }
}