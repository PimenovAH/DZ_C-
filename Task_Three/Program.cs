Console.Clear();

Console.WriteLine("Поиск наибольшего из трех чисел");

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if(b > max) max = b;
if(c > max) max = c;
Console.Write("max = " + max);    