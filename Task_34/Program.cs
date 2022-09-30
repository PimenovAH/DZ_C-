//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных


void RandomNumbers(int[] array)
{
    for(int i = 0; i  < array.Length;i++)
    {
        array[i] = new Random().Next(100,999);
    }
}

void PrintArray(int[] array)
{
    List<int> siz = new List<int>(array); 
    Console.Write("[" );
    Console.Write(string.Join(",", siz));
    Console.Write("] -> ");
}

int GetPriverkaChetn(int[] array)
{
    int i = 0;

    while(array[i] % 2  == 0)
    {
        i++;
    }
    return i;
}

int[] mass = new int [5];
RandomNumbers(mass);
PrintArray(mass);
Console.Write("Количечкество четных " + GetPriverkaChetn(mass));





