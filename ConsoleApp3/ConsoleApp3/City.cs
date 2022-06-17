using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface City
    {

        public Human[] humans { get; set; }



        public void AddHuman(Human human);
        

        

        public Human[] SearchHumans(string n);
            

    }
}
