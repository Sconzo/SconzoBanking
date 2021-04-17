using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationRazor.Modelos;

namespace WebApplicationRazor.Data
{
    public class WebApplicationRazorContext : DbContext
    {
        public WebApplicationRazorContext (DbContextOptions<WebApplicationRazorContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationRazor.Modelos.Movie> Movie { get; set; }
    }
}
