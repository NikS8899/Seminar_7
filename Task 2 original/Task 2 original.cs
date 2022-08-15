// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите координату строки: ");
int findM = int.Parse(Console.ReadLine());

Console.Write("Введите координату столбца: ");
int findN = int.Parse(Console.ReadLine());

int mCoordinateFindNumber = 0;
int nCoordinateFindNumber = 0;

int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i, j] + "\t" );
    }
    System.Console.WriteLine();
}

if (findM > m || findN > n) Console.WriteLine("Такого элемента нет");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == findM && j == findN) Console.WriteLine($"По координатам [{findM},{findN}] находится число {array[i,j]}");
    }
}
