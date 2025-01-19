using TodoAppWPF;
namespace TestingToDoList
{
    public class ToDoListTests
    {
        private TodoList _todoList;
        public ToDoListTests()
        {
            _todoList = new TodoList();
        }

        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            var task = "Test task";
            _todoList.AddTask(task);
            var tasks = _todoList.GetAllTasks();
            Assert.Contains(task, tasks);

        }
        [Fact]
        public void RemoveTask_ShouldRemoveTaskToList()
        {
            var tasks = "Task to remove";
            _todoList.AddTask(tasks);
            _todoList.RemoveTask(0);
            var tasks2 = _todoList.GetAllTasks();
            Assert.Contains(tasks, tasks2);
        }
        [Fact]
        public void RemoveTask_InvalidIndex_ShouldNotThrowException() 
        { 
        }
        
    }
}