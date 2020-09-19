﻿using System;
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

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}