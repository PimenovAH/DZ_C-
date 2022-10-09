// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



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


void SearchElementArray(int[,] arr, int a, int b)
{

    while(true)
        try
        {
            Console.Write($"{arr[a, b]} -> Такой элемент есть!");
            break;
        }
        catch
        {
            Console.Write( $"{a};{b} ->  Нет элемента в данном диапозоне!");
            break;
        }
    

}

Console.WriteLine("Задайте масштаб массива!");
int m = GetNumber("Введите кол-во строк в массиве m: ");
int n = GetNumber("Введите кол-во столбцев в массиве n: ");


Console.WriteLine("Укажите диапозон!");
int b = GetNumber("Введите сторку: ");
int a = GetNumber("Введите столбец: ");

int[,] array = new int[n,m];
FillArray(array);
PrintArray(array);
SearchElementArray(array,a,b);



