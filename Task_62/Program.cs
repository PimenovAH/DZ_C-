// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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


void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
             if (arr[i, j] < 10)
            {
                Console.Write("0" + arr[i, j]);
                Console.Write(" ");
                Thread.Sleep(65);
            }
            else Console.Write(arr[i, j] + " ");
            Thread.Sleep(65);
                
        }
        Console.WriteLine();
    }
}


void MultiplicationMatrix(int[,] arr)
{
  int i =0;
  int j =0;
  int count = 1;
  while(count <= arr.GetLength(0) * arr.GetLength(1))
  {
    arr[i,j] = count;
    count++;


    if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
    {
        j++;
    }
    else if (i < j && i + j >= arr.GetLength(0) - 1)
    {
        i++;
    }
    else if (i >= j && i + j > arr.GetLength(1) - 1)
        j--;
    else
        i--;              
  }   

}


Console.WriteLine("Введите размер массива nxn!");

int n = GetNumber("n: ");
int[,] array = new int[n,n];
MultiplicationMatrix(array);
PrintArray(array);




