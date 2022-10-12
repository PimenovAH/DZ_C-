// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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


void SortArray(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++) 

            for (int j = 0; j < arr.GetLength(1); j++)
         
                    for (int c = 0; c < arr.GetLength(0) - 1 ;c++)                         
                    {           
                        if (arr[i, c] < arr[i, c + 1])
                        {
                            int temp = arr[i, c + 1];
                            arr[i, c + 1] = arr[i,c];
                            arr[i, c] = temp;
                        }
                    }

}



Console.WriteLine("Задайте масштаб массива!");
int m = GetNumber("Введите кол-во строк в массиве m: ");
int n = GetNumber("Введите кол-во столбцев в массиве n: ");



int[,] array = new int[n,m];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

SortArray(array);
PrintArray(array);




