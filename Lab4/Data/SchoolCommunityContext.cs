using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4.Models;

namespace Lab4.Data
{
    public class SchoolCommunityContext : DbContext
    {
        public SchoolCommunityContext(DbContextOptions<SchoolCommunityContext> options) 
            : base (options) 
        { }

        public DbSet<Student> Student
        {
            get;
            set;
        }
        public DbSet<Community> Community
        {
            get;
            set;
        }
        public DbSet<CommunityMembership> CommunityMembership
        {
            get;
            set;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("students");
            modelBuilder.Entity<Community>().ToTable("communities");
            modelBuilder.Entity<CommunityMembership>().HasKey(c => new { c.StudentID, c.CommunityID });
            modelBuilder.Entity<CommunityMembership>().ToTable("memberships");
        }

    }
}
