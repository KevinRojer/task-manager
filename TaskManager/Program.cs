using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        //Manages the tasks.
        // The class should have methods to add a task, view all tasks, and manipulate their status.
        //      - use appropriate control structures to handle user input and perform the desired actions.
        //      - Validate the user input to ensure it meets the expected format and requirements.
        //      - Provide a menu-based interface that allows users to select different options.

        static void ShowMenu()
        {
            Console.WriteLine("########## Task Manager ##########");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task as Complete");
            Console.WriteLine("4. Exit");
        }

        static void Main(string[] args)
        {
            // Create a new TaskManager instance
            TaskManager taskManager = new TaskManager();

            while (true)
            {
                ShowMenu();
                
                // Read user input
                string? input = Console.ReadLine();
                
                // Process the user input
                if (input == null)
                {
                    Console.WriteLine("Invalid input. Please, try again.");
                }
                else if (input == "1")
                {
                    // Ask for a task name
                    Console.WriteLine("Enter task name: ");
                    string? name = Console.ReadLine();

                    // validate user input for name
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Task name cannot be empty.");
                        continue; // restart the loop
                    }

                    // Ask for a due date
                    Console.WriteLine("Due date (MM/DD/YYYY): ");
                    string? dueDate = Console.ReadLine();

                    // validate user inputs for date
                    if (DateTime.TryParse(dueDate, out DateTime date))
                    {
                        // Check if due date is not in the past
                        if (date < DateTime.Today)
                        {
                            Console.WriteLine("Due date cannot be in the past. Please, try again.");
                            continue; // restart the loop
                        }
                        // Create a new task instance
                        taskManager.AddTask(name, date);
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format. Try again.");
                    }
                }
                else if (input == "2")
                {
                    // View task
                    taskManager.ViewTasks();
                }
                else if (input == "3")
                {
                    // Ask user for task that he wants to mark as completed.
                    Console.WriteLine("Enter the task number to mark as complete: ");
                    string? inNumber = Console.ReadLine();
                    
                    // validate user input
                    if (int.TryParse(inNumber, out int taskNumber))
                    {
                        taskManager.MarkTaskAsComplete(taskNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Try Again.");
                    }
                }
                else if (input == "4")
                {
                    // Exit the while loop
                    break;
                }
                else
                {
                    // Choice not in menu.
                    Console.WriteLine("Invalid choice. Please, try again.");
                }
                // Print an empty line for readability
                Console.WriteLine();
            }
            // User has exited the application
            Console.WriteLine("Switching Off.");
        }
    }
}