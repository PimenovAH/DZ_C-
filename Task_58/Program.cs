// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:


// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




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
            Console.Write( arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}



void MultiplicationMatrix(int[,] array,int[,] arra,int[,] matrix)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int c = 0; c < arra.GetLength(1); c++)
            {
                 matrix[i,j] += array[i, c] * arra[c, j];
            }
        }
    }
       
}



Console.WriteLine("Задайте масштаб массива!");
int m = GetNumber("Введите кол-во строк в массиве m: ");
int n = GetNumber("Введите кол-во столбцев в массиве n: ");


int[,] array = new int[n,m];
int[,] arra = new int[n,m];
int[,] matrix = new int[n,m];



FillArray(array);
System.Console.WriteLine();
FillArray(arra);

PrintArray(array);
System.Console.WriteLine();
PrintArray(arra);

Console.WriteLine();
MultiplicationMatrix(array,arra,matrix);
PrintArray(matrix);




