// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
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

int[,] DeleteIntersectionByMinElement(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];

    int minElement = matrix[0, 0];
    int minRow = 0;
    int minColumn = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < minElement)
            {
                minElement = matrix[i,j];
                minRow = i;
                minColumn = j;
            }
        }
}

int rowOffset = 0;
int columnOffset = 0;

  for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == minRow) rowOffset++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j == minColumn) columnOffset++;
            newMatrix[i,j] = matrix[i + rowOffset, j + columnOffset];
        }
        columnOffset = 0;
    }
    return newMatrix;
}


Console.Write("Введите m: "); // Число строк
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: "); // Число столбцов
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
int[,] newMatrix = DeleteIntersectionByMinElement(matrix);
PrintMatrix(newMatrix);