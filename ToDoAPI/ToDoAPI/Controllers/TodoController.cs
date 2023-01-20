using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ToDoAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {

        /// <summary>
        /// Endpoint that returns a todo list (api/Todo/GetTodoList)
        /// </summary>
        /// <returns>NotImplementedException()</returns>
        [HttpGet]
        [Route("GetTodoList")]
        public async Task<IActionResult> GetTodoList()
        {
            await Task.Delay(100);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Endpoint that inserts a todo item (api/Todo/AddTodoItem)
        /// </summary>
        /// <returns>NotImplementedException()</returns>
        [HttpPost]
        [Route("AddTodoItem")]
        public async Task<IActionResult> AddTodoItem([FromBody] string todo)
        {
            await Task.Delay(100);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Endpoint that updates a todo item (api/Todo/UpdateTodoItem/{itemId})
        /// </summary>
        /// <returns>NotImplementedException()</returns>
        [HttpPut]
        [Route("UpdateTodoItem/{itemId}")]
        public async Task<IActionResult> UpdateTodoItem(int itemId, [FromBody] string newItemName)
        {
            await Task.Delay(100);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Endpoint that deletes a todo item (api/Todo/DeleteTodoItem/{itemId})
        /// </summary>
        /// <returns>NotImplementedException()</returns>
        [HttpDelete]
        [Route("DeleteTodoItem/{itemId}")]
        public async Task<IActionResult> DeleteTodoItem(int itemId)
        {
            await Task.Delay(100);

            throw new NotImplementedException();
        }
    }
}
