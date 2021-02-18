﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext (DbContextOptions<ProjectDbContext> options) : base (options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
