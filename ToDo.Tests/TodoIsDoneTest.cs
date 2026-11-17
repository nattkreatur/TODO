using System;

namespace ToDo.Tests;


public class TodoIsDoneTest
{
    [Fact]
    public void DiplayText_WhenTodoIsDone()
    {
        TodoItem todo = new TodoItem(1, "Diska", true);
        
        string result = todo.DisplayText(); //Testar Displaytext-metoden för enkelhetens skull

        Assert.Contains("Status: Klar", result);
    }
        [Fact]
    public void DiplayText_WhenTodoIsNotDone()
    {
        TodoItem todo = new TodoItem(2, "Diska", false);
        
        string result = todo.DisplayText(); //Testar Displaytext-metoden för enkelhetens skull

        Assert.Contains("Status: Ej klar", result);
    }

    
}
