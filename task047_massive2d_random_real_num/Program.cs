// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5     7    -2   -0,2
//   1  -3,3     8   -9,9
//   8   7,8  -7,1      9

double[,] CreateMatrixRndInt(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0)/*rows*/; i++) //0 соответствует строкам
    {
        for (int j = 0; j < matrix.GetLength(1)/*columns*/; j++) // 1 соответствует столбцам
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           {matrix[i, j], 8}"); //8 это длина строки вместе с выводимым числом
        }
        Console.WriteLine("|");
    }
}

double[,] array2d = CreateMatrixRndInt(3, 4, -8, 8);
PrintMatrix(array2d);
