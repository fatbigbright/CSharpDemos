using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySandBox
{
    public class ArraySandBox
    {
        public static int[,] CalculateRandomly(int[,] input)
        {
            Random rand = new Random();
            int maxLine = input.GetLength(0);
            int maxColumn = input.GetLength(1);

            for (int line = 0; line < maxLine; line++)
            {
                for (int column = 0; column < maxColumn; column++)
                {
                    input[line, column] = rand.Next() % 2;
                }
            }
            return input;
        }
        public static int[,] GetGameOfLifeNextStep(int[,] input)
        {
            int maxLine = input.GetLength(0);
            int maxColumn = input.GetLength(1);

            int[,] copied = input.Clone() as int[,];
            int count = 0;

            for (int line = 0; line < maxLine; line++)
            {
                for (int column = 0; column < maxColumn; column++)
                {
                    count = GetAliveNeiborCount(copied, line, column);
                    if(copied[line, column] == 0 && count == 3)
                    {
                        input[line, column] = 1;
                        continue;
                    }
                    if (copied[line, column] == 1 && (count <= 1 || count >= 4))
                    {
                        input[line, column] = 0;
                        continue;
                    }
                }
            }
                return input;
        }

        private static int GetAliveNeiborCount(int[,] input, int line, int column)
        {
            int count = 0;
            for (int x = -1; x <= 1; x++)
            {
                if (line + x < input.GetLowerBound(0) || line + x > input.GetUpperBound(0)) continue;
                for (int y = -1; y <= 1; y++)
                {
                    if (column + y < input.GetLowerBound(1) || column + y > input.GetUpperBound(1)) continue;
                    if (x == 0 && y == 0) continue;
                    count += input[line + x, column + y];
                }
            }
            return count;
        }
    }
}
