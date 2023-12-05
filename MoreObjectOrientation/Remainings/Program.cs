using System;
using System.Collections.Generic;

namespace Remainings
{
    class Pair<T1, T2>
    {
        public T1 First;
        public T2 Second;

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pair<int, int> p = new Pair<int, int>(1, 2);
            Console.WriteLine($"{p.First}, {p.Second}");

            Pair<string, string> ps = new Pair<string, string>("James", "Bond");
            Console.WriteLine($"{ps.First}, {ps.Second}");

            Pair<DateTime, string> pd = new Pair<DateTime, string>(new DateTime(), "Birthday");
            Console.WriteLine($"{pd.First}, {pd.Second}");

            List<int> l = new List<int>();

            l.Add(5);
            //l.Add("aa");

            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("Age", 20);
            d.Add("Shoe size", 44);


            //Student s = new Student();
            //s.Name = "James";
            //s.Age = 40;

            //Modify(s);
            //Console.WriteLine($"{s.Name} is {s.Age}");
        }

        public static void Modify(Student student)
        {
            student.Name = "Mr. Bean";
            student.Age = 50;
        }
    }
}
