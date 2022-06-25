// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections;

namespace CsharpClass // our namespace 
{
    class Program // Classs name program
    {
        static void Main(string[] args) // function parameter name args, function name is Main // static direclty belong to class 
        {
            var now = DateTime.Now;

            string[] months = {"January", "February", "March", "April", "May",
    "June", "July", "August", "September", "October", "November", "December"};

            Console.WriteLine("Today's date: {0}", now.Date);
            Console.WriteLine("Month's : {0}", now.Month);
            Console.WriteLine("Today's date: {0}", DateTime.Now.ToString());
            Console.WriteLine("Today is {0} day of {1}", now.Day, months[now.Month - 1]);
            Console.WriteLine("Today is {0} day of {1}", months[0], months[months.Length - 1]);

            Console.WriteLine("Today is {0} day of {1}", now.DayOfYear, now.Year);
            Console.WriteLine("Today's time: {0}", now.TimeOfDay);
            Console.WriteLine("Hour: {0}", now.Hour);
            Console.WriteLine("Minute: {0}", now.Minute);
            Console.WriteLine("Second: {0}", now.Second);
            Console.WriteLine("Millisecond: {0}", now.Millisecond);
            Console.WriteLine("The day of week: {0}", now.DayOfWeek);
            Console.WriteLine("Kind: {0}", now.Kind);

            // int result = Program.Sum();

            Program.Sum();
            Program.Sum();
            Program.Sum();
            Program.Sum();
            Program.Sum(2, 10);
            Program.Sum(12, 10);
            Program.Sum(22, 10);
            Program.Sum(32, 10);
            Program.Sum(42, 10);
            Program.Sub(15, 7);
            //  Console.WriteLine(result);
            int age = Program.CalculateAge(new DateTime(2002, 7, 25));
            Console.WriteLine($"age is {age}");
        }

        // public static int Sum()
        // {
        //     Console.WriteLine("Function calling....");
        //     return 5 + 10;
        // }

        public static void Sum()
        {
            Console.WriteLine("Function calling...." + (5 + 10));
        }

        public static void Sum(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Function calling...." + (firstNumber + secondNumber));
        }

        public static void Sub(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Function calling...." + (firstNumber - secondNumber));
        }


        public static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            return age;
        }

        // static string Reverse()
        // {
        // }
    }
}

// namespace MyNewApp.Business
// {
//   // Classes here    
// }
