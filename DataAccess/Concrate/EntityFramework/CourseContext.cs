using Core.Entities.Concrate;
using Entities.Concrate;
using Entity.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class CourseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Course;Trusted_Connection=True;");
        }
        public DbSet<CourseUser> CourseUser{ get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<UserContact> UserContact { get; set; }
        public DbSet<Payment> Payment{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
