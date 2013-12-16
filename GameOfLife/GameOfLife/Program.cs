using System;

namespace GameOfLife
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");

			int[,] testArray = new int[,] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };

			Console.WriteLine ("testArray[1, 2]: {0}", testArray[1, 2]);
		}
	}
}
