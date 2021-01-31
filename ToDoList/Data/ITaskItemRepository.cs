using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Data
{
   public interface ITaskItemRepository
   {
      Task Add(TaskItem taskItem);
      Task Add(IEnumerable<TaskItem> taskItems);

      Task<TaskItem> Get(int Id);
      Task<IEnumerable<IEnumerable<TaskItem>>> GetAll();

      Task Delete(int Id);
      Task Edit(TaskItem taskItem);
   }
}
