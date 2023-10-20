using System;
namespace Polymorphism_Interface
{
	public class Book : Test , IBook
	{

        public string GetText()
        {
            return "salam";
        }
         
        public void Show()
        {
            Console.WriteLine("asadddd");
        }

        public void Test()
        {
            Console.WriteLine("djfjf");
        }

        public void ShowAll()
        {
            Console.WriteLine("Show books");
        }

        public string GetName()
        {
            return "hello";

        }
    }
}

