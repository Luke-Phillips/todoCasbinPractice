using Microsoft.AspNetCore.Mvc;

namespace CasbinPractice.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoItemController : ControllerBase
{
    [HttpPost("{userId}/{todoListId}")]
    public ActionResult CreateTodoItem(int userId, int todoListId)
    {
        // use casbin to authorize
        return Ok();
    }

    [HttpPut("{userId}/{todoItemId}/{newTodoItemName}")]
    public ActionResult EditTodoItemName(int userId, int todoItemId, string newTodoItemName)
    {
        // use casbin to authorize
        return Ok();
    }

    [HttpPut("{userId}/{todoItemId}/{isComplete}")]
    public ActionResult EditTodoItemCompletionStatus(int userId, int todoItemId, bool isComplete)
    {
        // use casbin to authorize
        return Ok();
    }
    
    [HttpDelete("{userId}/{todoItemId}")]
    public ActionResult DeleteTodoItem(int userId, int todoItemId)
    {
        // use casbin to authorize
        return Ok();
    }


}
