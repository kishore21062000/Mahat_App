using System;

namespace DebuggingExample
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 1, 2, 3, 4, 5 };
			int sum = 0;

			for (int i = 0; i < numbers.Length; i++) // Bug: should be i < numbers.Length
			{
				sum += numbers[i];
			}

			Console.WriteLine("Sum: " + sum);
		}
	}
}
