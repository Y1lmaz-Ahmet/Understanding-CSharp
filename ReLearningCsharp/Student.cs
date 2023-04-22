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
            if (Name.StartsWith("A") || Name.StartsWith("a")) return Name;
            return "no data found";
            
        }
    }
}
