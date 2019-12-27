﻿using Microsoft.EntityFrameworkCore;

namespace EFModeling.FluentAPI.Index
{
    class MyContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        #region Index
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasIndex(b => b.Url);
        }
        #endregion
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
    }
}