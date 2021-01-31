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

      public void Edit(TaskItem taskItem)
      {
         _context.Entry(taskItem).State = EntityState.Modified;
         _context.SaveChanges();
      }

      public TaskItem Get(int Id)
      {
         return _context.TaskItems.Find(Id);
      }

      public IEnumerable<IEnumerable<TaskItem>> GetAll()
      {
         List<List<TaskItem>> result = new List<List<TaskItem>>();

         var groups =  _context.TaskItems.AsEnumerable().GroupBy(item => item.ColumnName).ToList();
         foreach (var group in groups) {
            result.Add(group.ToList());
         }

         return result;
      }
   }
}
