using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Baku : City
    {
        public Human[] humans { get; }
        Human[] City.humans { get => humans; set => throw new NotImplementedException(); }

        public void AddHuman(Human human)
        {
            Human[] humans = new Human[0];
            Array.Resize(ref humans, humans.Length + 1);
            humans[humans.Length - 1] = human;
        }

        public Human[] SearchHumans(string n)
        {
            Human[] newhumans = new Human[0];
            foreach (var item in humans)
            {
                if (item.Name.Contains(n) || item.Surname.Contains(n))
                {
                    Array.Resize(ref newhumans, newhumans.Length + 1);
                    newhumans[newhumans.Length - 1] = item;
                }
            }
            return newhumans;
        }

        public Student[] GetStudents()
        {
            Student[] juststudents = new Student[0]; 
            foreach(var item in humans)
            {
                if(item is Student)
                {
                    Array.Resize(ref juststudents, juststudents.Length + 1);
                    juststudents[juststudents.Length - 1] = (Student)item;
                }
            }
            return juststudents;
        }
        public Employee[] GetEmployees()
        {
            Employee[] justemployees = new Employee[0];
            foreach (var item in humans)
            {
                if (item is Employee)
                {
                    Array.Resize(ref justemployees, justemployees.Length + 1);
                    justemployees[justemployees.Length - 1] = (Employee)item;
                }
            }
            return justemployees;
        }
    }
}
