using BlogST.Models;
using IdentityForExample.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdentityForExample.Models
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {

        public DataContext() : base("DataContext")
        {
            
        }

        public DbSet<Category> Category { get; set; }
    }
}