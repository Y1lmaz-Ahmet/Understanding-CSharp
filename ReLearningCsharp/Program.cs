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

            //Student ahmet = new Student("Ahmet", 24, 70.50);
            //Console.WriteLine( ahmet.GetName());

            //Student femke = new Student("Femke",24);
            //Console.WriteLine( femke.GetName());

            //Student Laura = new Student("Laura", 18);
            //Console.WriteLine(Laura.GetName());
            //Laura.setName("Thomas");
            //Console.WriteLine(Laura.GetName());
            //Laura.setName("jan");
            //Console.WriteLine(Laura.GetName());

            //BankAccount bank1 = new BankAccount(50, "ahmet");
            //BankAccount bank2 = new BankAccount(150, "atilla");

            //BankAccount bank3 = bank1 + bank2;
            //Console.WriteLine(bank3.MoneyOwner);
            //Console.WriteLine(bank3.Money);

            //timespan calculator
            birthCalculator(1998,12,7);

        }
        public static void birthCalculator(int birthYear,int monthOfBirth,int dayOfBirth)
        {
            Console.WriteLine("enter year of birth:");
             birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine("enter month of birth:");
             monthOfBirth = int.Parse(Console.ReadLine());

            Console.WriteLine("enter day of birth:");
             dayOfBirth = int.Parse(Console.ReadLine());

            DateTime personBirthDate = new DateTime(birthYear, monthOfBirth, dayOfBirth);

            TimeSpan timespan = DateTime.Now - personBirthDate;

            Console.WriteLine($"the birthDate:{personBirthDate}");
            Console.WriteLine($"days that this person is alive:{timespan}");
            
        }


    }
}
