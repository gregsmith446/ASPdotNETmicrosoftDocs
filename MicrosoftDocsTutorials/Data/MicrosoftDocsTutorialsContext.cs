using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MicrosoftDocsTutorials.Models
{
    public class MicrosoftDocsTutorialsContext : DbContext
    {
        public MicrosoftDocsTutorialsContext (DbContextOptions<MicrosoftDocsTutorialsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
