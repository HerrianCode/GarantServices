﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Garant.Models
{
    public class ApplicationContext:IdentityDbContext<User>
    {
        public DbSet<CommentsViewModel> CommentsViewModel { get; set; }
        public DbSet<Deal> Deals { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
