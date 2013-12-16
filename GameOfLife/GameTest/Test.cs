using NUnit.Framework;
using System;

namespace Game
{
	[TestFixture ()]
	public class Test
	{
		private GameOfLife game;
		[SetUp()]
		public void AllBefore()
		{
			game = new GameOfLife ();
		}
		[Test ()]
		public void TestCase1 ()
		{
			//Assert.IsNotNull(game);
			int[,] cells = new int[,]{ {0, 0, 0, 0}, {0, 1, 1, 0}, {0, 0, 1, 0}, {0, 0, 0, 0} };
			Assert.AreEqual (new int[,]{{0, 0, 0, 0}, {0, 1, 1, 0}, {0, 0, 1, 0}, {0, 0, 0, 0}}, game.GetNextTick (cells));
		}

		[Test()]
		public void TestCase2()
		{
			int[,] cells = new int[,]{ {0, 1, 0, 0}, {0, 1, 1, 0}, {0, 1, 0, 0},{0, 0, 0, 0}};
			Assert.AreEqual (new int[,]{{0, 1, 0, 0}, {0, 1, 1, 0}, {0, 1, 0, 0},{0, 0, 0, 0}}, game.GetNextTick (cells));
		}
	}
}

