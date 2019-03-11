using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo todo1 = new ToDo();
            Utils utils = new Utils();

            utils.CreateToDo(todo1);
            System.Console.WriteLine("What task do you want to complete?");
            todo1.Description = Console.ReadLine();

            System.Console.WriteLine("Id of task you want to update: ");
            int id = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("What would you like to change it to?");
            string newdesc = Console.ReadLine();
            utils.UpdateToDo(id, newdesc);
            System.Console.WriteLine();


        }

    }

}
