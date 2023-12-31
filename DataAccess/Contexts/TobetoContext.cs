﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class TobetoContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<UserSurvey> UserSurveys { get; set; }
        public DbSet<CalendarEvent> CalendarEvents { get; set; }
        public DbSet<UserCourse> UserCourses { get; set; }

        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<UserAnnouncement> UserAnnouncements { get; set; }
        public DbSet<Appeal> Appeals { get; set; }
        public TobetoContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
