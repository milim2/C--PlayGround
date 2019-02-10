using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Arrays
{

    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = 8;

            int[][] G = new int[size][]; // format
            for (int i = 0; i < size; i++)
            {
                int[] sub = new int[rand.Next(1, 20)]; //HW== what this line does
                // int[] sub = new int[4];

                for (int j = 0; j < sub.Length ; j++)
                {
                    sub[j] = rand.Next(20, 100);
                }
                G[i] = sub; // HW == what this line does
            }


            for (int i = 0; i < size; i++)
            {               

                for (int j = 0; j < G[i].Length; j++) // test에 이걸 응용해서 나온다-- 반드시 이해해야함채ㅡcompare 23, 34
                {
                    Console.Write(G[i][j] + " ");
                }

                Console.WriteLine(" "); 
            }

            Console.Read();

        }
    }
}
