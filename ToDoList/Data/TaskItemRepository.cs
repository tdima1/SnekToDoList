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

      public async Task Add(TaskItem taskItem)
      {
         _context.Add(taskItem);
         _context.SaveChanges();
      }

      public async Task Add(IEnumerable<TaskItem> taskItems)
      {
         throw new NotImplementedException();
      }

      public async Task Delete(int Id)
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

      public async Task<TaskItem> Get(int Id)
      {
         return _context.TaskItems.Find(Id);
      }

      public async Task<IEnumerable<IEnumerable<TaskItem>>> GetAll()
      {
         List<List<TaskItem>> result = new List<List<TaskItem>>();

         List<TaskItem> one = new List<TaskItem>();

         for (int i = 0; i < 4; i++) {
            one = _context.TaskItems.Where(item => (int)item.Column == i+1).ToList();
            result.Add(one);
         }

         return result;
      }
   }
}
