using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace checkpoint3
{
    class Utils : DbContext
    {
        public Utils(DbContextOptions<Utils> options) : base(options)
        {

        }
        public List<ToDo> ToDos = new List<ToDo>();
        public int count;

        public ToDo GetToDoByID(int id)
        {
            return ToDos.FirstOrDefault(x => x.Id == id);
        }


        public void UpdateToDo(int Id, string newdesc)
        {
            ToDo todo = GetToDoByID(Id);
            todo.Description = newdesc;
        }


        public void DeleteToDo()
        {

        }


        public void CreateToDo(ToDo todo)
        {
            count++;
            todo.Id = count;
            ToDos.Add(todo);


        }


        public void PrintToDos(List<ToDo> toDos)
        {
            foreach (var item in toDos)
            {
                System.Console.WriteLine("Task ID: " + item.Id + ", and the description: " + item.Description);
            }
        }
    }
}
