using System;

namespace BaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Person
    {
        public int Fname { get; set; }
        public int Lname { get; set; }
        public int Age { get; set; }


        public Person (string f, string l)
        {
            Fname = f;
            Lname = l;
       
        }

        public string Greeting()
        {
            return $"Hello {Fname} {Lname}";
        }


        public Person1(string f, string l, string a)
        {
            Fname = f;
            Lname = l;
            Age = a;

        }

        public string Age()
        {
            return $"{Age} + 1";
        }

    }
    
}
