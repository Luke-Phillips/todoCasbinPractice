using Microsoft.AspNetCore.Mvc;
using CasbinPractice.Models;

namespace CasbinPractice.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoListController : ControllerBase
{
    // user id should probably come from jwt or some way we can verify identity, does this already happen?
    [HttpPost("{userId}/{todoListName}")]
    public ActionResult CreateTodoList(int userId, string todoListName)
    {
        return Ok();
    }

    [HttpGet("{userId}/{todoListId}")]
    public ActionResult<TodoList> GetTodoList(int userId, int todoListId)
    {
        // use casbin to verify user can access this todo list
        var todoList = new TodoList
        {
            Id = todoListId,
            Name = "Todo List 1",
            TodoItems = new List<TodoItem> 
            {
                new TodoItem { Id = 1, Name = "Make Casbin practice app", IsComplete = true},
                new TodoItem { Id = 2, Name = "Implement Casbin in CoFi app", IsComplete = false}
            },
            LastUpdated = new DateTime()
        };

        return Ok(todoList);
    }

    [HttpGet("{userId}")]
    public ActionResult<IEnumerable<TodoList>> ListTodoLists(int userId)
    {
        var todoLists = new List<TodoList>
        {
            new TodoList { Id = 1, Name = "Todo List 1", LastUpdated = new DateTime() },
            new TodoList { Id = 2, Name = "Todo List 2", LastUpdated = new DateTime() }
        };
        return Ok(todoLists);
    }

    [HttpPut("{userId}/{todoListId}/{newTodoListName}")]
    public ActionResult EditTodoListItemName(int userId, int todoListId, string newTodoListName)
    {
        // use casbin to verify user can edit todolist
        return Ok();
    }

    [HttpDelete("{userId}/{todoListId}")]
    public ActionResult DeleteTodoList(int userId, int todoListId)
    {
        // use casbin to verify user can delete todolist
        return Ok();
    }
}
