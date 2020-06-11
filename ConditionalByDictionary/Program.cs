using System;
using System.Collections.Generic;

namespace ConditionalByDictionary
{
    class Program
    {
        static Dictionary<ToDoType, Action> dictionaryToDo = new Dictionary<ToDoType, Action>();

        static void Main(string[] args)
        {
            ToDoTask toDoTask = new ToDoTask();
            dictionaryToDo.Add(ToDoType.Daily, new Action(toDoTask.Daily));
            dictionaryToDo.Add(ToDoType.Weekly, new Action(toDoTask.Weekly));
            dictionaryToDo.Add(ToDoType.Monthly, new Action(toDoTask.Monthly));

            // Do task
            dictionaryToDo[ToDoType.Weekly]();
        }
    }

    class ToDoTask
    {
        public void Daily()
        {
            Console.WriteLine("To do tasks daily");
        }

        public void Weekly()
        {
            Console.WriteLine("To do tasks weekly");
        }

        public void Monthly()
        {
            Console.WriteLine("To do tasks monthly");
        }
    }

    enum ToDoType
    {
        Daily,
        Weekly,
        Monthly
    }
}
