// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



int GetNumberConsole()
{
    System.Console.Write("Задайте значение от N до 1: ");
   
return Convert.ToInt32(Console.ReadLine());
}


string WriteNumbersRecurs(int start, double num)
{
    
    if(start < num)       
        return start + ", " + WriteNumbersRecurs(start+1, num);

    return start.ToString();
}


int number = GetNumberConsole();
System.Console.Write($"N= {number} ---> ");
System.Console.Write(WriteNumbersRecurs(number, -1));

 


