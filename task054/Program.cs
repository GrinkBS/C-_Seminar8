// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
        Console.WriteLine();
    }
}

void SortInDescendingOrderByRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < (matrix.GetLength(0)); k++)
        {
            for (int j = 0; j < (matrix.GetLength(1)); j++)
            {
                for (int l = 0; l < (matrix.GetLength(1) - 1); l++)
                {
                    if (matrix[(k), (l + 1)] > matrix[k, l])
                    {
                        int temp = matrix[k, l];
                        matrix[k, l] = matrix[(k), (l + 1)];
                        matrix[(k), (l + 1)] = temp;
                    }

                }
            }
        }
    }
}

Console.Write("Введите m: "); // Число строк
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: "); // Число столбцов
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
SortInDescendingOrderByRow(matrix);
PrintMatrix(matrix);