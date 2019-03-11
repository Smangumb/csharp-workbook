using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace checkpoint3
{
    class Utils
    {
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
        public void PrintToDos()
        {
            foreach (var item in ToDos)
            {
                System.Console.WriteLine($"Task ID:{0} = {1}", ToDo.todo1.Id, todo1.Description);
            }
        }
    }
}
