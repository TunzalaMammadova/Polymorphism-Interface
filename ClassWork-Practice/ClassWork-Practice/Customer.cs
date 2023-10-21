using System;
namespace ClassWork_Practice
{
	public class Customer
	{
		public static int instanceCount = 0;

		public  Customer()
		{
			instanceCount++;

        }

		public static void GetInstances()
		{
			Console.WriteLine(instanceCount);
		}
	}
}

