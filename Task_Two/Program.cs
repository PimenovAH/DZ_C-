Console.Clear();

Console.WriteLine("Проверка на чётность ");

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0)
{
    Console.WriteLine(" Чётное: " + a); 
}
else
{
    Console.WriteLine(" Не чётное: " + a);
}