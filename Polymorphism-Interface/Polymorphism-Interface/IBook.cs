using System;

namespace Polymorphism_Interface
{
    public interface IBook : ICommon 
	{
		void Test();
		void Show();
		string GetText();
		void ShowAll();
	}
}
  
