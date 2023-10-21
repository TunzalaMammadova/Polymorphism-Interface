using System;

namespace ClassWork_Practice
{
	public class Person
	{
        static Person()
        {
            Console.WriteLine("static constructor working");
        }

        public Person()
        {
            Console.WriteLine("Non static constructor working");
        }

        public static int Age { get; set; }

        public static void ShowText()
        {
            Console.WriteLine("Text");
        }

        public static void Test()
        {
            Console.WriteLine("salam");
        }


    }

    
}

