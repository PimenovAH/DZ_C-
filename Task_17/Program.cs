int num = 0;
 while(true)
{
    try
    {  
         
        Console.WriteLine("Проверка на  палиндромом.");
        Console.WriteLine();
        Console.Write("Введите пятизначое число: ");
        num = int.Parse(Console.ReadLine() ?? "0");
        break;
    }
    catch
    {
        
        Console.WriteLine("Введено некоректное значение");
    }
}
    

int Palynodrome(int num)
{

int a = 0;
for(int i = 0; num > 0; i++)
{
  a = a * 10 + num % 10; 
  num /= 10; 
}

return a;
}

bool res;
if(res = (Palynodrome(num) == num))
{
    Console.WriteLine($"{num} -> Да ");
}
 else
{
    Console.WriteLine($"{num} -> нет ");
}



