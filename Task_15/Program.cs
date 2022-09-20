int a;

void InputNumber()
{  
             
Console.Write("Введите число в диапозоне от 1 до 31: ");
while (!int.TryParse(Console.ReadLine(), out a));

}

void Day(int a)
{
 
    if(a >= 1 && a <= 5 )
    {
        Console.WriteLine("Будни -> " + a );
        
    }
    else if(a > 5 && a <= 7 )
    {   
        Console.WriteLine("Выходные -> " + a );
    }
    else if(a > 7 && a <= 12)
    {
        Console.WriteLine("Будни -> " + a );
    }
    else if(a > 12 && a <= 14 )
    {
        Console.WriteLine("Выходные -> " + a);
    }
    else if(a >  14 && a <=19)
    {
        Console.WriteLine("Будни -> " + a);
    }
    else if(a > 19 && a <= 22)
    {
        Console.WriteLine("Выходные -> "+ a);
    }
    else if(a >  22 && a <= 27)
    {
        Console.WriteLine("Будни -> " + a);
    }
    else if(a > 27 && a <= 29)
    {   
        Console.WriteLine("Выходные -> " + a);
        
    }
    else if(a > 30 && a <=31)
    {
        Console.WriteLine("Будни -> " + a);   
        
    }
    else if (a > 31)
    {
        Console.WriteLine("Вы вышли из диапазона");   
    }
    else if(a <= 0)
    {
        Console.WriteLine("Вы вошли в гиперпространство...");
    }

}

InputNumber();
Day(a);


 


    




