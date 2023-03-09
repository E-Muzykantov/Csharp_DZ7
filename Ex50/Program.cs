// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет


Console.Clear();

int[,] array = FillArray(3, 4, -10, 10);
PrintArray(array);
(int, int) index = InputIndex();
CheckIndexElement(index.Item1, index.Item2, array);


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
            Console.Write("{0,5}\t", inputArray[i, j]);
        }
        Console.WriteLine("");
    }
}

(int, int) InputIndex()
{
    Console.Write("Введите 1-ый индекс массива: ");
    int index1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2-ой индекс массива: ");
    int index2 = Convert.ToInt32(Console.ReadLine());
    return (index1, index2);
}

bool CheckIndexElement(int ind1, int ind2, int[,] array)
{
    if (ind1 >= array.GetLength(0) || ind1 < 0)
    {
        Console.WriteLine("Элемента с данными индексами в массиве не существует.");
        return false;
    }
    if (ind2 >= array.GetLength(1) || ind2 < 0)
    {
        Console.WriteLine("Элемента с данными индексами в массиве не существует.");
        return false;
    }
    Console.WriteLine($"Элемент в массиве с индексами [{ind1},{ind2}] -> {array[ind1, ind2]}");
    return true;
}
