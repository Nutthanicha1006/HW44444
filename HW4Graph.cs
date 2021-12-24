using System;

namespace HW4Graph
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] ArrayTotalCities;
            int TotalCities;
            int NumCities = 1;

            TotalCities = int.Parse(Console.ReadLine());
            ArrayTotalCities = new string[TotalCities];

            int[,] Graph = new int[ArrayTotalCities.Length, ArrayTotalCities.Length];
            for (int i = 0; i < TotalCities; i++)
            {
                ArrayTotalCities[i] = Console.ReadLine();
            }

            do
            {
                for (int j = 0; j < NumCities; j++)
                {
                    Graph[NumCities, j] = int.Parse(Console.ReadLine());
                }
                NumCities++;
            }
            while (NumCities != TotalCities);
        }
    }
}
