using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Employee : Human
    {

        public Employee (string name, string surname) : base (name, surname)
        {

        }


        public string Position;
        public override void Showinfo()
        {
            Console.WriteLine(Name + Surname + Age + Position);
        }

    }
}
