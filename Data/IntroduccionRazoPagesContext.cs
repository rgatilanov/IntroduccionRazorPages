using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IntroduccionRazoPages.Models;

namespace IntroduccionRazoPages.Data
{
    public class IntroduccionRazoPagesContext : DbContext
    {
        public IntroduccionRazoPagesContext (DbContextOptions<IntroduccionRazoPagesContext> options)
            : base(options)
        {
        }

        public DbSet<IntroduccionRazoPages.Models.User> User { get; set; }
    }
}
