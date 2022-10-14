// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumberConsole()
{ 
return Convert.ToInt32(Console.ReadLine());
}

int SummaNaturElement(int m, int n)
{
    int res = 0;
    if (m == n)
    {
        return res; 
    }
    else
    {
        m++;
        res = m + SummaNaturElement(m,n);
        return res;
    }
    
}


Console.Write("Введите M= ");
int  m = GetNumberConsole();

Console.Write("Введите N= ");
int  n = GetNumberConsole();

Console.Write($"M = {m}; N = {n}; -> ");
Console.Write(SummaNaturElement(m- 1, n));

 