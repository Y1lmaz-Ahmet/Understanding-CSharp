using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReLearningCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student ahmet = new Student("Ahmet", 24, 70.50);
            Console.WriteLine( ahmet.GetName());

            Student femke = new Student("Femke",24);
            Console.WriteLine( femke.GetName());

            Student Laura = new Student("Laura", 18);
            Console.WriteLine(Laura.GetName());
            Laura.setName("");
            Console.WriteLine(Laura.GetName());
            Laura.setAge(0);
            Console.WriteLine(Laura.GetAge());

        }


    }
}
