using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysunProgram
{
  public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string  Gender { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public int Limit { get; set; }
        public string Group { get; set; }

        public Student(string Name , string Surname , string Gender , int Age , string PhoneNumber , int Limit , string Group)
        {
            this.Name = Name;  
            this.Surname = Surname;
            this.Gender = Gender;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
            this.Limit = Limit;
            this.Group = Group;
        }

        public void Absent()
        {
            if (Limit > 0)
            {
                Limit--;
                Console.WriteLine($"{Name} bu gun derse gelmeyib");
            }
            else 
                Console.WriteLine($"Kesildiniz");
        }

    }
}
