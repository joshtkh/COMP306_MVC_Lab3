using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using COMP306_MVC_Lab3.Models;

namespace COMP306_MVC_Lab3.Data
{
    public class COMP306_MVC_Lab3Context : DbContext
    {
        public COMP306_MVC_Lab3Context (DbContextOptions<COMP306_MVC_Lab3Context> options)
            : base(options)
        {
        }

        public DbSet<COMP306_MVC_Lab3.Models.Movie> Movie { get; set; } = default!;
    }
}
