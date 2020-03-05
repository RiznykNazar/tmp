using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ForSomeMagic
{
    class Animal
    {
        public virtual void Pet_animal(int repeats)
        {
            Console.WriteLine("Погладив тваринку " + repeats + " разiв");
        }
    }
    class Cat : Animal
    {
        public override void Pet_animal(int repeats)
        {
            Console.WriteLine("Погладив котика " + repeats + " разiв");
        }
    }

    class Tank : Animal
    {
        public override void Pet_animal(int repeats)
        {
            Console.WriteLine("Погладив танк " + repeats + " разiв");
        }
    }

    interface IСaress<T>
    {
        void DoOperation(T animal, int repeats);
    }

    class Сaress<T> : IСaress<T> where T : Animal
    {
        public void DoOperation(T animal, int repeats)
        {
            animal.Pet_animal(repeats);
        }
    }

    class Program
    {
        static void Main()
        {
            IСaress<Animal> pet_animal = new Сaress<Animal>();
            pet_animal.DoOperation(new Animal(), 4);

            IСaress<Cat> pet_cat = new Сaress<Cat>();
            pet_cat.DoOperation(new Cat(), 5);


            Console.ReadKey();
        }
    }

}