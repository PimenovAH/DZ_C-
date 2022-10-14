// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



//                   m = 0 -->          n + 1;
// формула A(m,n) =  m > 0, n = 0 -->   A(m-1,1)
//                   m > 0, n > 0 -->   A(m-1,A(m,n-1))


int GetNumberConsole()
{ 
return Convert.ToInt32(Console.ReadLine());
}


int AckermannFunction(int m, int n)
{

    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));

    return AckermannFunction(m,n);
   
    
}


Console.Write("Введите M = ");
int  m = GetNumberConsole();

Console.Write("Введите N = ");
int  n = GetNumberConsole();

Console.Write($"M = {m}; N = {n}; -> A(m,n) = ");
Console.Write(AckermannFunction(m,n));
