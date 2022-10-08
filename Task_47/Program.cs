// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


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


void FillArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().NextDouble() * 20  -10;
        }
    }
}


void PrintArray(double[,] arr)
{
      for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]:f2}"+ " " );
        }
        Console.WriteLine();
    }
}


int m = GetNumber("Введите размерность массива m: ");
int n = GetNumber("Введите размерность массива n: ");
double[,] array = new double[m,n];
FillArray(array);
PrintArray(array);