using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Data
{
   public interface ITaskItemRepository
   {
      void Add(TaskItem taskItem);
      void Add(IEnumerable<TaskItem> taskItems);

      TaskItem Get(int Id);
      IEnumerable<TaskItem> GetAll();

      void Delete(int Id);
      void Edit(TaskItem taskItem);
   }
}
