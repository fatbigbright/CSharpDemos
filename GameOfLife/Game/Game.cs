using System;
using System.Diagnostics;

namespace Game
{
	public class GameOfLife
	{
		public GameOfLife ()
		{
		}

		private int GetNextAlive(int currentAlive, int aroundAlive)
		{
			if (currentAlive == 1) {
				return aroundAlive < 2 || aroundAlive > 3 ? 0 : 1;
			} else {
				return aroundAlive > 3 ? 1 : 0;
			}
		}

		private bool IfAroundCellAvailable(int centerX, int centerY, int x, int y)
		{
			return !((x == centerX && y == centerY) || x < 0 || x > 3 || y < 0 || y > 3);
		}

		private int GetAroundAlive(int[, ] cells, int x, int y)
		{
			int aroundAlive = 0;
			for (int i = x - 1; i <= x + 1; i++) 
				for (int j = y - 1; j <= y + 1; j++) 
					aroundAlive += IfAroundCellAvailable(x, y, i, j) && cells [i, j] == 1 ? 1 : 0;
			return aroundAlive;
		}

		public int[,] GetNextTick(int[,] cells)
		{
			int[,] buffer = new int [,]{{0, 0, 0, 0},{0, 0, 0, 0},{0, 0, 0, 0},{0, 0, 0, 0}};
			for (int x = 0; x < 4; x++) 
				for (int y = 0; y < 4; y++) 
					buffer [x, y] = GetNextAlive (cells [x, y], GetAroundAlive (cells, x, y));
			return buffer;
		}
	}
}

