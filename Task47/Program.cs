// Задача 47. Задайте двумерный массив размером m×n
// , заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Console.Clear();
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());




double[,] Array = new double[m,n];

void FillArray()
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
           Array[i,j] = new Random().Next(-100,100) / 10.0;
        }
    }
    
}

void PrintArray()
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n;j++)
        {
            Console.Write($" {Array [i,j] } ");
        }
        Console.WriteLine();
    }
}

FillArray();
PrintArray();