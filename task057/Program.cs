﻿// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine( );
    }
}

void PrintRepeatsOfElements(int[,] matrix)
{
    int[] repeats = new int[10];
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            repeats[matrix[i,j]]++;
        }
    }
    for(int i = 0; i < repeats.Length; i++)
    {
        Console.WriteLine($"Количество повторений {i} = {repeats[i]}");
    }
}

Console.Write("Введите m: "); // Число строк
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: "); // Число столбцов
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine("");
PrintRepeatsOfElements(matrix);
PrintMatrix(matrix);