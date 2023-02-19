// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Числе в 1 строке в 7 столбце-> такого числа в массиве нет

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Enter the row quantiry of your matrix: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the columns quantity of your matrix: ");
int col = int.Parse(Console.ReadLine()!);
Console.Write("Enter the minimum number of your matrix: ");
int numMin = int.Parse(Console.ReadLine()!);
Console.Write("Enter the maximum number of your matrix: ");
int numMax = int.Parse(Console.ReadLine()!);
int[,] matrix2D = GetArray(row, col, numMin, numMax);
PrintArray(matrix2D);
Console.WriteLine();
Console.WriteLine("Input the row number you want to check: ");
int rowcheck = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input the columns number you want to check: ");
int colcheck = int.Parse(Console.ReadLine()!);
if (rowcheck <= matrix2D.GetLength(0) && colcheck <= matrix2D.GetLength(1)) 
Console.WriteLine($"The number in this cell is {matrix2D[rowcheck, colcheck]}");
else Console.WriteLine($"There is no number in cell row {rowcheck} and columns {colcheck}");
