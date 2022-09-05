// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание,
// что такого элемента нет.(на вход именно поступает позиция элемента, 
// можете разбить на две переменные или прописать в одну строку и конвертировать в два числа,
// комментарии в конце семинара по этой задаче)

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Clear();
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число которое хоите найти в данном массиве: ");
int usernum = Convert.ToInt32(Console.ReadLine());




int[,] Array = new int[m,n];

void FillArray()
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
           Array[i,j] = new Random().Next(-1,30);
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


string FindNum(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (arr1[i, j] == usernum) return "Такое число есть !";
        }
    }
    return "Такого числа нет !";
}



FillArray();
PrintArray();
Console.WriteLine(usernum + " -> " + FindNum(Array));