Console.Clear();

Console.WriteLine("Поиск наибольшего из трех чисел");

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.Write("max = " + a);
}
else if (b > c || c < b)
{
    Console.Write("max = " + b);
}
else
{
    Console.Write("max = " + c);
}