// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

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
System.Console.WriteLine();

// int [] array1 = new int [m];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i<m) array1[i] += array[i,j];
        
//     }
//     System.Console.WriteLine();
// }

// for (int i = 0; i < array1.Length; i++)
// {
//      Console.Write(array1[i] + "\t" );
// }


int [] array1 = new int [n];
for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       if (j < n) array1 [j] += array[i,j];
        
    }
    
}
// Сумма чисел в столбцах
System.Console.WriteLine("Среднее арифметическое элементов в каждом столбце ");
for (int i = 0; i < array1.Length; i++)
{
   array1 [i] /=m;
   Console.Write(array1[i] + "\t" );

}
