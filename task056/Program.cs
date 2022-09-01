
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



Console.Write("Количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[lines, columns];
int[] linSumArray = new int[lines];

FillArray(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
        sum = sum + numbers[i, j];
    linSumArray[i] = sum;
}

Console.WriteLine(string.Join(", ", linSumArray));

int min = linSumArray.Cast<int>().Min();
int imin = Array.FindIndex(linSumArray, x => x == min);

Console.WriteLine($"Строка с наименьшей суммой элементов -> {imin + 1}");



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
         Console.WriteLine();
    }
   
}