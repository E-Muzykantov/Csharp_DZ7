// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
int[,] array = FillArray(3, 4, 0, 10);
PrintArray(array);
GetAverageColumns(array);

int[,] FillArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write("{0,4}\t", inputArray[i, j]);
        }
        Console.WriteLine("");
    }
}

void GetAverageColumns(int[,] array)
{
    double sum = 0;
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            Console.Write(array[i, j] + " ");
        }
        average = Math.Round(sum / array.GetLength(0), 2);
        Console.WriteLine($"-> Среднее арифметическое {j + 1}-ого столбца равняется {average}");
        sum = 0;
        average = 0;
    }
}