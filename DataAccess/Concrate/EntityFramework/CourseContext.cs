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
        public DbSet<CourseVideo> CourseVideos { get; set; }
        public DbSet<VideoDetail> VideoDetails { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserContact> UserContact { get; set; }
        public DbSet<Payment> Payment{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserVerify> userVerifyCodes{ get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<SupportContact> SupportContacts { get; set; }
        public DbSet<SoldCourse> SoldCourses{ get; set; }
        public DbSet<Teacher> Teachers{ get; set; }
        public DbSet<TeacherStudentContact> TeacherStudentContacts { get; set; }
        public DbSet<TeacherCourse> TeacherCourse { get; set; }
        public DbSet<TeacherStudent> TeacherStudents { get; set; }

    }
}
