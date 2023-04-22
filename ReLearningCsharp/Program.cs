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


        }


    }
}
