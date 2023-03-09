// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Clear();
double[,] array = FillArray(3, 4, -10, 10);
PrintArray(array);

double[,] FillArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Math.Round(rnd.Next(min, max + 1) + rnd.NextDouble(), 2, MidpointRounding.ToZero);
        }
    }
    return result;
}

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write("{0,5}\t", inputArray[i, j]);
        }
        Console.WriteLine("");
    }
}