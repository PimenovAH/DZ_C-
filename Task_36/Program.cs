// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void RandomNumbers(int[] array)
{
    for(int i = 0; i  < array.Length;i++)
    {
        array[i] = new Random().Next(-100,100);
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
    int summa = 0;

    for(int i = 1; i < array.Length; i+=2)
    {
        summa +=  array[i];
    }
    return summa;
}

int[] mass = new int [4];
RandomNumbers(mass);
PrintArray(mass);
Console.Write("Сумма элементов в нечетных позициях: " + GetPriverkaChetn(mass));