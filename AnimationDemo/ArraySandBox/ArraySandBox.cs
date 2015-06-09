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
                for(int column = 0; column < maxColumn; column++)
                {
                    input[line, column] = rand.Next() % 2;
                }
            }
            return input;
        }
    }
}
