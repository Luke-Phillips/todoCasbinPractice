
namespace CasbinPractice.Models
{
    public class TodoList
    {
        public TodoList()
        {
            Name = "";
            TodoItems = new List<TodoItem>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public IEnumerable<TodoItem> TodoItems { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}