Console.WriteLine("Нахождение min и max числа");

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if  (a > b)
    Console.WriteLine("max = "+ a + "; min = " + b );
    
else if ( a< b)
    Console.WriteLine("max = "+ b + "; min = " + a );

else
    Console.WriteLine("Числа равны");