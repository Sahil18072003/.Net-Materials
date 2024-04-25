using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1D Array
            string[] dog = { "tail", "ears" };

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            Console.WriteLine(cars);

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);

            for (int i = 0; i < cars.GetLength(0); i++)
            {
                Console.WriteLine(cars[i]);
            }

            int[] myNum = { 10, 20, 30, 40 };

            myNum[2] = 67;

            Console.WriteLine(myNum[2]);

            Console.WriteLine(myNum.Length);

            Console.WriteLine(myNum.ToString());

            foreach (var i in myNum)
            {
                Console.WriteLine(i);
            }

            // 2D Array
            int[,] todi = new int[2, 3]
            { { 2,3,4 }, { 5,6,7 } };

            for (int i = 0; i < todi.Length; i++)
            {
                for (int j = 0; j < todi.Length; j++)
                {
                    Console.WriteLine(todi[i, j] + " ");
                }
                Console.WriteLine();
            }


            // Jagged Array
            // data_type[][] name_of_array = new data_type[rows][]

            int[][] jagged_arr =
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2 },
                new int[] { 1 }
            };

            for (int i = 0; i < jagged_arr.Length; i++)
            {
                for (int j = 0; j < jagged_arr[i].Length; j++)
                {
                    Console.WriteLine(jagged_arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
