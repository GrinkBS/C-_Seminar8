// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// }

Console.Write("Количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[lines, columns];
Console.Write("Начальное значение: ");
int val = Convert.ToInt32(Console.ReadLine());

int i = 0, k = 0, j;

while (i < lines * columns)
{
    k++;
    for (j = k - 1; j < columns - k + 1; j++)
    {
        numbers[k - 1, j] = val++;
        i++;
    }

    for (j = k; j < lines - k + 1; j++)
    {
        numbers[j, columns - k] = val++;
        i++;
    }
    for (j = columns - k - 1; j >= k - 1; j--)
    {
        numbers[lines - k, j] = val++;
        i++;
    }
    for (j = lines - k - 1; j >= k; j--)
    {
        numbers[j, k - 1] = val++;
        i++;
    }
}

PrintArray(numbers);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            Console.Write(array[i, j] + "; ");

        Console.WriteLine();
    }

}


// __________

// int n;
//             Console.WriteLine("Введите размерность массива");
//             n = Convert.ToInt32(Console.ReadLine());
//             var a = GetSpire(n);
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     Console.Write(a[i, j]);
//                 }
//                 Console.WriteLine();
//             }


//         int[,] GetSpire(int n)
//         {
//             var result = new int[n, n];
//             Random rand = new Random();
//             for (int i = 0; i < n; i++)
//                 for (int j = 0; j < n; j++)
//                     result[i, j] = rand.Next(n, n);
//             for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
//             {
//                 for (int j = padding; j < n - padding; j++)
//                     result[padding, j] = currentChar;
//                 for (int j = padding; j < n - padding; j++)
//                     result[n - padding - 1, j] = currentChar;
//                 for (int i = padding + 2; i < n - padding - 1; i++)
//                     result[i, padding] = currentChar;
//                 for (int i = padding + 1; i < n - padding - 1; i++)
//                     result[i, n - padding - 1] = currentChar;
//                 currentChar = 1 - currentChar;
//                 result[padding + 1, padding] = currentChar;
//             }
//             if (n % 2 != 0 && result[0, 0] == 1)
//                 result[n / 2, n / 2] = 1;
//             return result;
//         }

//         _____________________

// const int n = 4;
// const int m = 4;
// int[,] matrix = new int[n, m];

// int row = 0;
// int col = 0;
// int dx = 1;
// int dy = 0;
// int dirChanges = 0;
// int visits = m;

// for (int i = 0; i < matrix.Length; i++)
// {
//     matrix[row, col] = i + 1;
//     if (--visits == 0)
//     {
//         visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
//         int temp = dx;
//         dx = -dy;
//         dy = temp;
//         dirChanges++;
//     }

//     col += dx;
//     row += dy;
// }

// FillArray(matrix);
// PrintArray(matrix);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// }