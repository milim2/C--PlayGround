using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Java
            // 2D Primitive type in Java - rectangular array
            /*
            int[][] arr = new int[2][3];
            for(int i = 0; i < 2; i++)// rows
            {
                for (int j = 0; j < 3; j++) // cols
                {
                    arr[i][j] = j;
                    System.print(arr[i][j] + " ");
                }
                System.print(" ");
            }
            */

            // Java
            // 2D Non Primitive type in Java -> rectangular
            /*
            String [][] arrString = new String[2][3];
            for (int i = 0; i < arrString.length; i++)// rows
            {
                for (int j = 0; j < arrString[i].length; j++) // cols
                {
                    arrString[i][j] = ("Str " + j + " ");
                    System.print(arrString.length[i][j] =  + "Str " + j + " ");
                }
                System.print(" ");
            }
            */

            int[,] arr = new int[2, 3];
            for (int i = 0; i < 2; i++)// rows
            {
                for (int j = 0; j < 3; j++) // cols
                {
                    arr[i, j] = j;
                    Console.Write(arr[i, j] + " "); // cw
                }
                Console.WriteLine(" ");// cwl         
            }

            Console.WriteLine(" ");// cwl  

            for (int i = 0; i< arr.GetLength(0); i++)// rows
                {
                    for (int j = 0; j< arr.GetLength(1); j++) // cols
                    {
                        arr[i, j] = j;
                        Console.Write(arr[i, j] + " "); // cw
                    }
                Console.WriteLine(" ");// cwl         
                }
            Console.WriteLine(" ");// cwl  


            for (int i = 0; i < arr.Length; i++)// rows
                {
                    for (int j = 0; j < arr.Length; j++) // cols
                    {
                        arr[i, j] = j;
                        Console.Write(arr[i, j] + " "); // cw: arr.Length --for 1D
                    }
                    Console.WriteLine(" ");// cwl         
                }

            // jagged arrays








            Console.Read();
        }
    }
}
