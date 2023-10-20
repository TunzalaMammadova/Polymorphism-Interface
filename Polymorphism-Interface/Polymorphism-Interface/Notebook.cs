using System;
namespace Polymorphism_Interface
{
	public class Notebook : INotebook
	{

        public void GetById(int id)
        {  
            Console.WriteLine("Notebook");
        }

        public string GetName()
        {
            return "name";
        }
    }
}

