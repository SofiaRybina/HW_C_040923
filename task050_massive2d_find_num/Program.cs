// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

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

int CheckPoint(int x, int y, int[,] massive2d)
{
    if (x > massive2d.GetLength(0) && y > massive2d.GetLength(1))
    {
        return -1;
    }
    else
    {
        int num = massive2d[x - 1, y - 1];
        return num;
    }
}

Console.WriteLine("Введите позицию элемента масссива M x N.");
int i = Prompt("Введите i:");
int j = Prompt("Введите j:");
Console.WriteLine();

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);

if (i < 0 || j < 0)
{
    Console.WriteLine("Ошибка! Значения должны быть положительными!");
}
else
{
    Console.WriteLine("Масссив M x N:");
    PrintMatrix(array2d);
    Console.WriteLine();

    int result = CheckPoint(i, j, array2d);

    Console.Write($"Вы ввели:");
    if (result == -1)
    {
        Console.WriteLine("Данной позиции нет в массиве");
    }
    else
    {
        Console.Write($" ({i},{j}) -> число на позиции = {result}");
    }
}

//int? означает что переменная может принимать значение null
//int x=null; //Error
//int? x=null; //ok
