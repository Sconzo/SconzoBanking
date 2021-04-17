using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationRazor.Data;
using WebApplicationRazor.Modelos;

namespace WebApplicationRazor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly WebApplicationRazor.Data.WebApplicationRazorContext _context;

        public IndexModel(WebApplicationRazor.Data.WebApplicationRazorContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
