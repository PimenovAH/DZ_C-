// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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


void FillArray(int[,] arr )
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


void SearchminRow(int[,] arr)
{
    int min = 0;
    int minsum = 0;
    int sum = 0;
  

    for (int i = 0; i < arr.GetLength(1); i++) min += arr[0, i];
            
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) sum += arr[i, j];  
          
        if (sum < min )
        {             
            min = sum;
            minsum = i ;
        }
        sum = 0;
    } 
 Console.Write($"{minsum + 1} строка c наименьшей суммой");
}



Console.WriteLine("Задайте масштаб массива!");
int m = GetNumber("Введите кол-во строк в массиве m: ");
int n = GetNumber("Введите кол-во столбцев в массиве n: ");



int[,] array = new int[n,m];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

SearchminRow(array);




