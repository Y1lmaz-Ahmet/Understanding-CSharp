using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReLearningCsharp
{
    public class Student
    {
        private string Name;
        private int Age;
        private double FinalGrade;

        public Student(string name,int age,double finalGrade)
        {
            Name = name;
            Age = age;
            FinalGrade= finalGrade;
        }

        public Student(string name,int age) : this(name,age,0)
        {
            
        }
        public string GetName()
        {
            if (Age >= 18) return Name;
            return "sorry, but u have to be 18 or more.";   
        }
        public void setName(string newName)
        {
            if (newName != Name & newName != "") { 
                Name = newName;
            
            } else
            {
                Console.WriteLine("sorry but this name is not correct: {0}",newName);
            }
            
        }
        public int GetAge() 
        {
            if (Age != 0) return Age;
            return -1;
        }
        public int setAge(int newAge)
        {
            if(newAge != 0)
            {
                Age = newAge;
            }
            return Age;
        }
        public double setFinalGrade (double newGrade)
        {
            return FinalGrade = newGrade;
        }
        public double getFinalGrade()
        {
            return FinalGrade;
        }
    }
}
