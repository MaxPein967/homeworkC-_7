// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int n = ReadInt("Введите количество строк: ");
int m = ReadInt("Введите количество столбцов: ");

int[,] nums = new int[n, m];
Console.WriteLine();
FillArrayRandomNumbers(nums);
PrintArray(nums);
Console.WriteLine();

for (int j = 0; j < nums.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        sum += nums[i, j];
    }
    Console.Write($" { Math.Round(sum / nums.GetLength(0), 1)} ");
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(10, 100));
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
        Console.WriteLine(" ");
    }
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

