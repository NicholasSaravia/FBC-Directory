using System;
using System.Collections.Generic;
using System.Text;
using FBC.Business.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FBC.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Family> Families { get; set; }
        public DbSet<ContactInfo> ContactInformation { get; set; }
    }
}
