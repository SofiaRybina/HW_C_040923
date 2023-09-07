// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0)/*rows*/; i++) //0 соответствует строкам
    {
        for (int j = 0; j < matrix.GetLength(1)/*columns*/; j++) // 1 соответствует столбцам
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}"); //5 это длина строки вместе с выводимым числом
        }
        Console.WriteLine("|");
    }
}

double[] SumColumn(int[,] massive2d)
{
    double tempSum = 0;
    double[] newArray = new double[massive2d.GetLength(1)];

    for (int j = 0; j < massive2d.GetLength(1); j++)
    {
        for (int i = 0; i < massive2d.GetLength(0); i++)
        {
            tempSum += massive2d[i, j];
        }
        newArray[j] = tempSum / massive2d.GetLength(0);
        tempSum = 0;
    }
    return newArray;
}

Console.WriteLine("[Задайте двумерный массив из целых чисел M x N.]");
int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
Console.WriteLine();

Console.WriteLine("[Задайте диапазон элементов.]");
int minNum = Prompt("Введите min: ");
int maxNum = Prompt("Введите max: ");
Console.WriteLine();

Console.WriteLine("[Массив:]");
int[,] array2d = CreateMatrixRndInt(m, n, minNum, maxNum);
PrintMatrix(array2d);
Console.WriteLine();
Console.WriteLine($"[Количество символов в столбцах массива: {array2d.GetLength(0)}]");
Console.WriteLine($"[Количество символов в строках массива: {array2d.GetLength(1)}]");

Console.Write($"Среднее арифметическое каждого столбца: ");
var tempSumColumn = SumColumn(array2d);
for (int i = 0; i < tempSumColumn.Length; i++)
    {
        Console.Write($"{Math.Round(tempSumColumn[i], 2)}");
        if(i == tempSumColumn.Length-1)
        {
            Console.Write(".");
        }
        else
        {
            Console.Write("; ");
        }
    }