using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Baku city = new Baku();
            int counterforemployees = 0;
            int counterforstudents = 0;
            string option;            

            do
            {

                Console.WriteLine("1. Employee elave et");
                Console.WriteLine("2. Student elave et");
                Console.WriteLine("3. Employeelerin sayini goster");
                Console.WriteLine("4. Studentlerin sayini goster");
                Console.WriteLine("5. Employeelere bax");
                Console.WriteLine("6. Studentlere bax");
                Console.WriteLine("7. Insanlar uzere axtaris et");
                Console.WriteLine("0. Out");
                option = Console.ReadLine();
                
                switch (option)
                {
                    case "1":
                        
                        Console.WriteLine("Employee Elave Edilir");
                        Console.WriteLine("Name Daxil Et");
                        string name = Console.ReadLine();
                        Console.WriteLine("Surname Daxil Et");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Surname Daxil Et");
                        Employee employee = new Employee(name, surname);
                        city.AddHuman(employee);
                        counterforemployees++;
                        break;

                    case "2":

                        Console.WriteLine("Student Elave Edilir");
                        Console.WriteLine("Name Daxil Et");
                        name = Console.ReadLine();
                        Console.WriteLine("Surname Daxil Et");
                        surname = Console.ReadLine();
                        Student student = new Student(name, surname);
                        city.AddHuman(student);
                        counterforstudents++;
                        break;

                    case "3":

                        Console.WriteLine("Employee Sayi Gosterilir");
                        Console.WriteLine(counterforemployees);
                        break;

                    case "4":

                        Console.WriteLine("Student Sayi Gosterilir");
                        Console.WriteLine(counterforstudents);
                        break;

                    case "5":
                        foreach(var items in city.humans)
                        {
                            if(items is Employee)
                            {
                                items.Showinfo(); 
                            }
                        }
                        break;

                    case "6":
                        foreach (var items in city.humans)
                        {
                            if (items is Student)
                            {
                                items.Showinfo();
                            }
                        }
                        break;

                    case "7":

                        Console.WriteLine("N daxil et");
                        string n = Console.ReadLine();
                        city.SearchHumans(n);
                        foreach(var item in city.humans)
                        {
                            if(item.Name.Contains(n) || item.Surname.Contains(n))
                            {
                                item.Showinfo();
                            }
                        }
                        
                        break;
                    default:
                        break;
                }


            } while (option != "0");
        }
    }
}
