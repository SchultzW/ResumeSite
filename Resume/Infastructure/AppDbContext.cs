
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Resume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Infastructure
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(
                DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<MyProject> Projects { get; set; }
        public DbSet<Tag> tags { get; set; }

    }
}
