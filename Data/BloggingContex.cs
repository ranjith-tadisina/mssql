using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc.Models;

    public class BloggingContex : DbContext
    {
        public BloggingContex (DbContextOptions<BloggingContex> options)
            : base(options)
        {
        }

        public DbSet<mvc.Models.Blog> Blog { get; set; }
    }
