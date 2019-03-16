using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;



namespace checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContextOptionsBuilder<Utils> builder = new DbContextOptionsBuilder<Utils>();
            builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BlogDb;Trusted_Connection=true");
            DbContextOptions<Utils> opts = builder.Options;
            Utils context = new Utils(opts);

            context.Database.EnsureCreated();

            ToDo todo1 = new ToDo();
            ToDo todo2 = new ToDo();
            ToDo todo3 = new ToDo();
            ToDo todo4 = new ToDo();

            context.CreateToDo(todo1);
            System.Console.WriteLine("What task do you want to complete?");
            todo1.Description = Console.ReadLine();
            context.PrintToDos(context.ToDos);
            context.CreateToDo(todo2);
            Console.WriteLine("Enter additional tasks if needed:");
            todo2.Description = Console.ReadLine();
            context.PrintToDos(context.ToDos);
            context.CreateToDo(todo3);
            Console.WriteLine("Enter additional tasks if needed:");
            todo3.Description = Console.ReadLine();
            context.PrintToDos(context.ToDos);
            context.CreateToDo(todo4);
            Console.WriteLine("Enter additional tasks if needed:");
            todo4.Description = Console.ReadLine();
            context.PrintToDos(context.ToDos);

            System.Console.WriteLine("Id of task you want to update: ");
            int id = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("What would you like to change it to?");
            string newdesc = Console.ReadLine();
            context.UpdateToDo(id, newdesc);
            context.PrintToDos(context.ToDos);

            //Console.WriteLine("Would you like to Add,Edit, or Delete any tasks>");
            //string answer = Console.ReadLine();
            //string[] commands = { "Edit", "Add", "Delete" };





            //List<String> commands { "Edit", "Add", "Delete" };
            //while (answer == )
            //    if (answer == "Edit")
            //    {
            //        System.Console.WriteLine("Id of task you want to update: ");
            //        int id = Convert.ToInt32(Console.ReadLine());
            //        System.Console.WriteLine("What would you like to change it to?");
            //        string newdesc = Console.ReadLine();
            //        context.UpdateToDo(id, newdesc);
            //        context.PrintToDos(context.ToDos);

            //    }
            //    else if (answer == "Add")
            //    {
            //        context.CreateToDo(todo1);
            //        System.Console.WriteLine("What task do you want to complete?");
            //        todo1.Description = Console.ReadLine();
            //        context.PrintToDos(context.ToDos);
            //        context.CreateToDo(todo2);
            //        Console.WriteLine("Enter additional tasks if needed:");
            //        todo2.Description = Console.ReadLine();
            //        context.PrintToDos(context.ToDos);
            //        context.CreateToDo(todo3);
            //        Console.WriteLine("Enter additional tasks if needed:");
            //        todo3.Description = Console.ReadLine();
            //        context.PrintToDos(context.ToDos);
            //        context.CreateToDo(todo4);
            //        Console.WriteLine("Enter additional tasks if needed:");
            //        todo4.Description = Console.ReadLine();
            //        context.PrintToDos(context.ToDos);
            //    }
            //    else if (answer == "Delete")
            //    {
            //        context.DeleteToDo();
            //    }





            System.Console.ReadLine();


        }

    }

}
