using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IntroduccionRazoPages.Data;
using IntroduccionRazoPages.Models;

namespace IntroduccionRazoPages.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly IntroduccionRazoPages.Data.IntroduccionRazoPagesContext _context;

        public IndexModel(IntroduccionRazoPages.Data.IntroduccionRazoPagesContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        //Se agrega esta propiedad para integrar la búsqueda en el formulario
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public async Task OnGetAsync()
        {
            //User = await _context.User.ToListAsync(); //Se comenta línea y se agrega la siguiente
            var users = from m in _context.User
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                users = users.Where(s => s.Nick.Contains(SearchString));
            }

            User = await users.ToListAsync();
        }
    }
}
