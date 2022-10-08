// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetNumber(string text)
{
    int num = 0;
    while(true)
{
    try
    {
        Console.Write(text);
        num = int.Parse(Console.ReadLine() ?? "0");
        break;
    }
    catch
    {
        Console.WriteLine("Введено некоректное значение");
    }

}
    return num;
}


void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
}


void PrintArray(int[,] arr)
{
      for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}


void SearchArithmeticMean(int[,] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i,j];
        }
           
        Console.Write( $"{ sum / arr.GetLength(0):f1}" + "; "); 
    
               
    }  
}


int m = GetNumber("Введите размерность массива m: ");
int n = GetNumber("Введите размерность массива n: ");
int[,] array = new int[m,n];

FillArray(array);

PrintArray(array);

SearchArithmeticMean(array);

