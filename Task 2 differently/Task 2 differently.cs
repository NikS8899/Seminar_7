// Альтернативный вариант задачи где пользователь вводит искомое число, а программа в свою очередь находит его в массиве и сообщает его координаты в двумерном массиве

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите искомое число: ");
int findNumber = int.Parse(Console.ReadLine());

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

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == findNumber) 
        {mCoordinateFindNumber = i; nCoordinateFindNumber = j; }
        break;

    }
}

if (findNumber == array[mCoordinateFindNumber,nCoordinateFindNumber]) Console.Write($"Искомое в массиве число {findNumber} находится по координатам [{mCoordinateFindNumber},{nCoordinateFindNumber}]");
else Console.Write($"Искомое число {findNumber} отсутствуе в массиве ");
