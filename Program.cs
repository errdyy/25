using System;


class Program
{
    static void Main()
    {
        int[] primalArray = { 1, 2, 2, 3, 4, -1, -2, -2, -2, 5, 5 };

        Console.WriteLine("Исходный массив:");
        PrintArray(primalArray);

        List<int> Values = GetValues(primalArray);
        int[,] endArray = new int[Values.Count, 3];

        for (int i = 0; i < Values.Count; i++)
        {
            endArray[i, 0] = Values[i];
            endArray[i, 1] = CountRepeat(primalArray, Values[i]);

            if (Values[i] >= 0)
            {
                endArray[i, 2] = Array.IndexOf(primalArray, Values[i]);
            }
            else
            {
                endArray[i, 2] = Array.LastIndexOf(primalArray, Values[i]);
            }
        }

        Console.WriteLine("Преобразованный двумерный массив:");
        PrintMatrix(endArray);

        Console.ReadLine();
    }

    static List<int> GetValues(int[] array)
    {
        List<int> Values = new List<int>();
        foreach (int value in array)
        {
            if (!Values.Contains(value))
            {
                Values.Add(value);
            }
        }
        return Values;
    }

    static int CountRepeat(int[] array, int value)
    {
        int count = 0;
        foreach (int element in array)
        {
            if (element == value)
            {
                count++;
            }
        }
        return count;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}