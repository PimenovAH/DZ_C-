// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


double[] FillA()
{
    int input = Convert.ToInt32(Console.ReadLine());
    double[] arr = new double[input];
    for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Введите число: {i+1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

        }
    return arr;
}

double ChetArray(double[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length;i++)
    {
        if(arr[i] > 0)
        {
            count++;
        }   
    }

    return count;
}


void PrintArray(double[] array)
{
    List<double> siz = new List<double>(array); 
    Console.Write("[" );
    Console.Write(string.Join(",", siz));
    Console.Write("] -> ");
}

Console.Write("Введите размер массива: ");
double[] arr = FillA();

Console.WriteLine();

PrintArray(arr);
Console.Write($"Чисел больше 0 = {ChetArray(arr)}");

