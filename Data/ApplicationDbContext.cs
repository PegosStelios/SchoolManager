using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SchoolManager.Models;

namespace SchoolManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SchoolManager.Models.Student> Student { get; set; }
        public DbSet<SchoolManager.Models.Teachers> Teachers { get; set; }
        public DbSet<SchoolManager.Models.Subjects> Subjects { get; set; }
    }
}
