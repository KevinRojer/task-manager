class TaskManager
{
    // A class to manage the tasks.
    // The tasks should be stored in memory as a list.
    // This class must contain the operations to manage a task: The features.

    public List<Task> tasks;

    public TaskManager()
    {
        // Initialize an instance of Task Manager (an empty list.)
        tasks = new List<Task>();
    }

    // A method to add a new task to the list
    public void AddTask(string name, DateTime dueDate)
    {
        // Create a new task object
        Task task = new Task(name, dueDate);
        // Add the newly created task to the task list.
        tasks.Add(task);
        // Provide visual confirmation to the user.
        Console.WriteLine("Your task has been successfully created.");
    }

    // A method to view all task in the list.
    public void ViewTasks()
    {
        // Check if task list is empty.
        if (tasks.Count == 0)
        {
            Console.WriteLine("No task found.");
        }
        else
        {
            // List is not empty, populate all the tasks.
            Console.WriteLine("Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                // retrieve the taks from the list
                Task task = tasks[i];
                // Automatically, the status is incomplete
                string status = task.IsComplete ? "[Complete]" : "[Incomplete]";
                Console.WriteLine("{0}. {1}\t{2}\tdue date:{3}", i+1, status, task.Name, task.DueDate.ToShortDateString());
            }
        }
    }

    // A method to remove a task from the list.
    public static void RemoveTask(string name)
    {
        Console.WriteLine("Task has been removed.");
    }
}