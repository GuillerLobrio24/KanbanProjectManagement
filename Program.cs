using System;
using System.Data;
using System.Threading;

namespace KanbanApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            var milliseconds1 = 5000;
            var milliseconds2 = 3000;
            var milliseconds3 = 2000;


            Console.WriteLine("Hello!");
                //Thread.Sleep(milliseconds2);
            
            Console.WriteLine("This is your Kanban Project Management System");
                //Thread.Sleep(milliseconds2);
            
            Console.WriteLine("And I'm here to organize your task on its own categories");
                //Thread.Sleep(milliseconds2);
            Console.WriteLine(" ");
            
            Console.WriteLine("First, please help me to know your Name");
                Console.Write("Name : ");
                string fullName = Console.ReadLine();

            Console.WriteLine(" ");

            Console.WriteLine("Next is your student Id number");
                Console.Write("Student Id : ");
                string studentId = Console.ReadLine();

            Console.WriteLine(" ");

            Console.WriteLine("Well done!!");
                Thread.Sleep(milliseconds3);

            Console.WriteLine(" ");

            Console.WriteLine("Please Wait a Moment!!");
                Thread.Sleep(milliseconds1);
            Console.WriteLine("Initializing");
                Thread.Sleep(milliseconds1);

            Console.WriteLine(" ");

            Console.WriteLine("Kanban Project Management System");
            
            Console.WriteLine(" ");

            Console.WriteLine(fullName + "/" + studentId);

            Console.WriteLine(" ");

            bool menu = true;
            while (menu)
            {
                menu = Menu();
            }
            
        }
        static void Menu()
        {

        }
    }
}
