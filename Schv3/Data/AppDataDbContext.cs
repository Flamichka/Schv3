using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Microsoft.Extensions.Options;
using Schv3.Models;
using System.Data.Common;

namespace Schv3.Data
{
    public class AppDataDbContext : DbContext
    {
        public AppDataDbContext() 
        {

        } 

        public AppDataDbContext(DbContextOptions<AppDataDbContext>options): base(options) 
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<testdata>().ToTable("TestTab");
            //base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("DataSource=database.db");
        public DbSet<Class> Classes {get; set;}
        public DbSet<ClassRoom> Classrooms { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
