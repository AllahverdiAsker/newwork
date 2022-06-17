using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Human
    {

      

        public string Name;
        public Human(string name,string surname )
        {
            Name = name;
            Surname = surname;
        }
        public string Surname;
        

        public int Age;

        
        public virtual void Showinfo()
        {
            Console.WriteLine(Name + Surname + Age);
        }

    }
}
