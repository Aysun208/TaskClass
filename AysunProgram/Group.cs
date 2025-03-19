using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AysunProgram
{
    public class Group
    {
        public string Name { get; set; }
        public string Shift { get; set; }
        public Student[] students;




        public Group(string Name, string Shift )
        {
            this.Name = Name;
            this.Shift = Shift;
        }

        public void AddStudent(Student student)       
        {
            students[0] = student;
        }

        public void FindStudent(string name)
        {
            foreach (Student i in students)
            {
                if (i.Name == name)
                {
                    Console.WriteLine("Telebe tapildi"); return;
                }
               
            }
            Console.WriteLine("telebe tapilmadi");


        }
    }
}
