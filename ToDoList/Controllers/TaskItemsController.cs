using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Data;

namespace ToDoList.Controllers
{
   [Route("taskItems")]
   [ApiController]
   public class TaskItemsController : ControllerBase
   {
      private readonly ITaskItemRepository _repository;

      public TaskItemsController(ITaskItemRepository repository)
      {
         _repository = repository;
      }

      // GET: api/TaskItems
      [HttpGet]
      public async Task<IEnumerable<IEnumerable<TaskItem>>> GetAll()
      {
         return _repository.GetAll();
      }

      // GET: api/TaskItems/5
      [HttpGet("{id}")]
      public async Task<TaskItem> Get(int id)
      {
         return _repository.Get(id);
      }

      [HttpPost]
      public async Task<IActionResult> CreateTask([FromBody] TaskItem payload)
      {
         payload.ColumnName = EnumTaskColumns.Backlog;
         _repository.Add(payload);

         return Ok(_repository.GetAll());
      }

      // PUT: api/TaskItems
      [HttpPut]
      public async void MoveTaskItem([FromBody] TaskItem payload)
      {
         _repository.Edit(payload);
      }

      // DELETE: api/ApiWithActions/5
      [HttpDelete("{id}")]
      public void Delete(int id)
      {

      }
   }
}
