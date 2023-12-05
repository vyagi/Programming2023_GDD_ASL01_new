using System;

namespace ExtensionMethods
{
    static class StringUtilities
    {
        public static string ToName(this string input) => 
            $"{input[0].ToString().ToUpper()}{input[1..].ToLower()}";
    }

    static class IntUtilities
    {
        public static bool IsEven(this int input) =>
           input % 2 == 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var name = "jamES"; //James
            Console.WriteLine(name.Length);
            Console.WriteLine(name.Contains("b"));
            Console.WriteLine(name.ToUpper());

            Console.WriteLine(name.ToName());

            Console.WriteLine(5.IsEven());
            Console.WriteLine(6.IsEven());
        }
    }
}
