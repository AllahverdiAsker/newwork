using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Student : Human
    {
        public Student (string name, string surname) : base(name, surname)
        {

        }
        public int Grade;
        public string GroupNo;
        public override void Showinfo()
        {
            Console.WriteLine(Name + Surname + Age + Grade + GroupNo);

        }

    }
}
