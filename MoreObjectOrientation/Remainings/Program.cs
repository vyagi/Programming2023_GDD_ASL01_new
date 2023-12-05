using System;

namespace Remainings
{
    struct Student
    {
        public string Name;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "James";
            s.Age = 40;

            Modify(s);
            Console.WriteLine($"{s.Name} is {s.Age}");
        }

        public static void Modify(Student student)
        {
            student.Name = "Mr. Bean";
            student.Age = 50;
        }
    }
}
