// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Array = new int[m,n];

void FillArray()
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
           Array[i,j] = new Random().Next(1,10);
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


void FindAverage()
{
    double average = 0;
    int columns = 0;
    for(int j=0; j<n; j++)
    {
        columns++;
        double sum = 0;
        for(int i=0; i<m; i++)
        {
            sum = sum + Array[i,j];
        }
        average = sum / m;
        Console.WriteLine($"Среднее арифметичское " + columns + " столбца -> " + Math.Round(average, 1));
    }

}



FillArray();
PrintArray();
FindAverage();
