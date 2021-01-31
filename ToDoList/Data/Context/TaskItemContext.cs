using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Data.Context
{
   public class TaskItemContext : DbContext
   {
      private readonly IConfiguration _config;

      public DbSet<TaskItem> TaskItems { get; set; }

      public TaskItemContext(DbContextOptions options, IConfiguration config) : base(options)
      {
         _config = config;
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"));
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         //Use this code to initializa and populate DB with objects. Copy paste a couple times then change shit.
         modelBuilder.Entity<TaskItem>()
            .HasData(new TaskItem {
               Id = 1,
               Name = "Default Entity",
               Description = "Default Description",
               ColumnName = EnumTaskColumns.Backlog
            }, 
            new TaskItem {
               Id = 2,
               Name = "Default Entity",
               Description = "Default Description",
               ColumnName = EnumTaskColumns.InProgress
            });
      }
   }
}
