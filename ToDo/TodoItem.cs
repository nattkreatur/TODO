using System;

namespace ToDo;

public class TodoItem
{
    
    
    public int Id {get; set;}
    public string Title {get; set;} = string.Empty;
    public bool Done {get; set;}

    //Constructor
    public TodoItem(int id, string title, bool done)
    {
        this.Id = id;
        this.Title = title;
        this.Done = done;
    }

    public string DisplayText()
    {
        string done = "";
        if(this.Done == true) done = "Klar";
        else if(this.Done == false) done = "Ej klar";

        return $"Id: {this.Id} \nAtt göra: {this.Title}\nStatus: {done}";
    }
    public void Print()
    {
        Console.WriteLine(DisplayText());
    }
}
