Console.Clear();

Console.WriteLine("Нахождение кол-во четных от 1 до N");

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N ; i++)
{
    if(i % 2 == 0)
    Console.Write(i + ",");
                
}