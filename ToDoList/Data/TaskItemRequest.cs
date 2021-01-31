using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Data
{
   public class TaskItemRequest
   {
      public int Id { get; set; }
      public EnumTaskColumns NewColumn { get; set; }
   }
}
