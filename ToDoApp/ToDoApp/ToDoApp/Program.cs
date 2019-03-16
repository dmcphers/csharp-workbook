using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContextOptionsBuilder<ToDoDbContext> builder = new DbContextOptionsBuilder<ToDoDbContext>();
            builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ToDoDb;Trusted_Connection=True;");
            DbContextOptions<ToDoDbContext> opts = builder.Options;
            ToDoDbContext context = new ToDoDbContext(opts);

            context.Database.EnsureCreated();

            Console.WriteLine("Welcome to your ToDo List!!!");
            Console.WriteLine();
            
            Menu();
            RunCommand(context);
        }


        public static void Menu()
        {
            // Give user a list of options to perform certain commands
          
            Console.WriteLine("Enter the number of the command you would like to execute.");
            Console.WriteLine();
            Console.WriteLine("1 - Add a ToDo to your list.");
            Console.WriteLine("2 - Delete a ToDo from your list.");
            Console.WriteLine("3 - List all ToDos.");
            Console.WriteLine("4 - List ToDo by ID.");
            Console.WriteLine("5 - Update a ToDo already in your list.");
            Console.WriteLine("6 - Exit application.");
            Console.WriteLine();
        }

        public static void RunCommand(ToDoDbContext context)
        {

            // user picks a number that will be used to run it's corresponding command

            string value = Console.ReadLine();

            if (value == "1")
            {
                AddToDo(context);
            }
            else if (value == "2")
            {
                DeleteToDo(context);
            }
            else if (value == "3")
            {
                ListAll(context);
            }
            else if (value == "4")
            {
                ListById(context);
            }
            else if (value == "5")
            {
                UpdateToDo(context);
            }

            else if (value == "6")
            {
                Environment.Exit(0);
            }

            else
            {
                // message for invalid user entry

                Console.WriteLine("Please input a valid number that is listed in the menu.");
                Menu();
                RunCommand(context);
            }
        }

        public static void AddToDo(ToDoDbContext context)
        {
            Console.WriteLine();
            
            // adds a ToDo to user's list

            Console.WriteLine("Enter a ToDo name to add to your list.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a ToDo description for the ToDo.");
            string description = Console.ReadLine();
            bool iscompleted = false;

            ToDo myToDo = new ToDo(name, description, iscompleted);

            context.ToDos.Add(myToDo);
            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Command completed.");
            Console.WriteLine("Waiting on your next command...");
            Console.WriteLine();
            Menu();
            RunCommand(context);
        }

        static void DeleteToDo(ToDoDbContext context)
        {
            Console.WriteLine();
            
            // delete ToDo from user's list

            Console.WriteLine("Which ToDo would you like to delete?");
            Console.WriteLine("Please enter the ID of that ToDo.");

            // creates a new ToDo instance and assigns it the properties of the ToDo of matching id in the DB Set
            ToDo placeHoldToDo = null;
            do
            {
                int idValue = Convert.ToInt32(Console.ReadLine());
                placeHoldToDo = context.ToDos.Find(idValue);

                if (placeHoldToDo == null)
                {
                    Console.WriteLine("That is not a valid ID, please choose one of the valid ID's.");
                }
            } while (placeHoldToDo == null);




            // remove selected ToDo
            context.ToDos.Remove(placeHoldToDo);

            context.SaveChanges();
            Console.WriteLine();
            Console.WriteLine("Command completed.");
            Console.WriteLine("Waiting on your next command...");
            Console.WriteLine();
            Menu(); 
            RunCommand(context);
          
        }

        public static void ListAll(ToDoDbContext context)
        {
            Console.WriteLine();
            
            // list all of the ToDos

            foreach (ToDo s in context.ToDos)
            {
                Console.WriteLine(s.Id + " || " + s.Name + " || " + s.Description + " || " + s.IsCompleted);
            }

            Console.WriteLine();
            Console.WriteLine("Command completed.");
            Console.WriteLine("Waiting on your next command...");
            Console.WriteLine();
            Menu();
            RunCommand(context);
        }

        static void ListById(ToDoDbContext context)
        {

            // list the ToDo by ID

            Console.WriteLine("Which ToDo would you like to view by ID?");
            Console.WriteLine("Please enter the ID of that ToDo.");

            // creates a new ToDo instance and assigns it the properties of the ToDo of matching id in the DB Set
            ToDo placeHoldToDo = null;
            do
            {
                int idValue = Convert.ToInt32(Console.ReadLine());
                placeHoldToDo = context.ToDos.Find(idValue);

                if (placeHoldToDo == null)
                {
                    Console.WriteLine("That is not a valid ID, please choose one of the valid ID's.");
                }
            } while (placeHoldToDo == null);
            
            Console.WriteLine(placeHoldToDo.Id + " || " + placeHoldToDo.Name + " || " + placeHoldToDo.Description + " || " + placeHoldToDo.IsCompleted);
            
            Console.WriteLine();
            Console.WriteLine("Command completed.");
            Console.WriteLine("Waiting on your next command...");
            Console.WriteLine();
            Menu();
            RunCommand(context);
        }

        static void UpdateToDo(ToDoDbContext context)
        {
            Console.WriteLine();
            
            // update the name, description, or completed status of ToDo

            Console.WriteLine("Which ToDo would you like to update?");
            Console.WriteLine("Please enter the ID of that ToDo.");

            // creates a new ToDo instance and assigns it the properties of the ToDo of matching id in the DB Set
            ToDo placeHoldToDo = null;
            do
            {
                int idValue = Convert.ToInt32(Console.ReadLine());
                placeHoldToDo = context.ToDos.Find(idValue);

                if (placeHoldToDo == null)
                {
                    Console.WriteLine("That is not a valid ID, please choose one of the valid ID's.");
                }
            } while (placeHoldToDo == null);

           

            Console.WriteLine();
            Console.WriteLine("Which property would you like to update?");
            Console.WriteLine("Your choices are 'name', 'description', or 'completed'");


            string placeHoldProp = null;
            do
            {
                //  user selects a property to update and logic to update that property of that ToDo

                string strValue = Console.ReadLine();
                placeHoldProp = strValue.ToLower();

                if (placeHoldProp != "name" && placeHoldProp != "description" && placeHoldProp != "completed")
                {
                    Console.WriteLine("That is not a valid property, please choose one of the valid properties.");
                }
                else if (placeHoldProp == "name")
                {
                    Console.WriteLine("What would you like this ToDo's name to be?");
                    string newName = Console.ReadLine();
                    ToDo todoRecord = context.ToDos.First(s => s.Name.Equals(placeHoldToDo.Name));

                    // updates the name of the selected ToDo

                    todoRecord.Name = newName;
                    context.SaveChanges();
                }
                else if (placeHoldProp == "description")
                {
                    Console.WriteLine("What would you like this ToDo's description to be?");
                    string newDescription = Console.ReadLine();
                    ToDo todoRecord = context.ToDos.First(s => s.Description.Equals(placeHoldToDo.Description));

                    // updates the description of the selected ToDo

                    todoRecord.Description = newDescription;
                    context.SaveChanges();
                }
                else if (placeHoldProp == "completed")
                {
                    Console.WriteLine("Press the corresponding key to change the status of the selected ToDo.");
                    Console.WriteLine("1 - not completed");
                    Console.WriteLine("2 - completed");

                    string newStatus = null;
                    do
                    {
                        // takes input from the user to change status

                        newStatus = Console.ReadLine();

                        if (newStatus == "1")
                        {
                            placeHoldToDo.IsCompleted = false;
                            context.SaveChanges();
                        }
                        else if (newStatus == "2")
                        {
                            placeHoldToDo.IsCompleted = true;
                            context.SaveChanges();
                        }
                        else
                        {
                            Console.WriteLine("You must choose either a 1 or 2");
                        }

                    } while (newStatus != "1" && newStatus != "2");

                }

            } while (placeHoldProp != "name" && placeHoldProp != "description" && placeHoldProp != "completed");

            Console.WriteLine();
            Console.WriteLine("Command completed.");
            Console.WriteLine("Waiting on your next command...");
            Console.WriteLine();

            Menu();
            RunCommand(context);
        }
    }
}
