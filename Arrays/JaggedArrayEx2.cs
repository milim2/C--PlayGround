using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = //new int[][]- 가능
            {
                new int[] { 1, 0, 2, 4, 6},
                new int[] { 1, 6 },
                new int[] { 1, 0, 2, 4, 6, 45, 67, 78 },
                new int[] { 3, 5, 7 },
            };

            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                    
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
