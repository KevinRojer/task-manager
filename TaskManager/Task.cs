class Task
{
    // A class that represents a task.
    // The class should have properties such as name, due date, and status
    public string Name { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsComplete { get; set; }

    public Task(string name, DateTime dueDate)
    {
        // Initialize a task with a name and due date. Automatically, the status is incomplete.
        Name = name;
        DueDate = dueDate;
        IsComplete = false;
    }

}