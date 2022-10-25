using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int[,] numbers = new int[10, 10];
        Random random = new Random();

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = random.Next(100);
            }
        }

        for (int x = 0; x < numbers.GetLength(0); x++)
        {
            BigInteger pro = 1;

            for (int y = 0; y < numbers.GetLength(1); y++)
            {
                Console.Write($"{numbers[y, x]};");
                pro *= numbers[y, x];
            }

            Console.WriteLine($"Произведение столбца {x + 1}: {pro}");
        }

        Console.ReadKey();
    }
}