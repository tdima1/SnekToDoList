using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Data.Context;

namespace ToDoList.Data
{
   public class TaskItemRepository : ITaskItemRepository
   {
      private readonly TaskItemContext _context;

      public TaskItemRepository(TaskItemContext context)
      {
         _context = context;
      }

      public void Add(TaskItem taskItem)
      {
         _context.Add(taskItem);
         _context.SaveChanges();
      }

      public void Add(IEnumerable<TaskItem> taskItems)
      {
         throw new NotImplementedException();
      }

      public void Delete(int Id)
      {
         var taskItem = _context.TaskItems.Find(Id);
         _context.Remove(taskItem);
         _context.SaveChanges();
      }

      public async Task Edit(TaskItem taskItem)
      {
         _context.Entry(taskItem).State = EntityState.Modified;
         _context.SaveChanges();
      }

      public TaskItem Get(int Id)
      {
         return _context.TaskItems.Find(Id);
      }

      public IEnumerable<TaskItem> GetAll()
      {
         return from item in _context.TaskItems
                select item;
      }
   }
}
