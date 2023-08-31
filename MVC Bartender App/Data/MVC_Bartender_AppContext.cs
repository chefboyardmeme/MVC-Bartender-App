using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Bartender_App.Models;

namespace MVC_Bartender_App.Data
{
    public class MVC_Bartender_AppContext : DbContext
    {
        public MVC_Bartender_AppContext (DbContextOptions<MVC_Bartender_AppContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Bartender_App.Models.Drink> Drink { get; set; } = default!;
    }
}
