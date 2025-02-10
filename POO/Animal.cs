using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Animal
    {
        public string Espece { get; set; }
        public int Age { get; set; }
        public string Nom { get;  set; }

        public Animal(int age) { 
            Age = age;
        }
    }
}
