
int num = 0;
 while(true)
{
    try
    { 
        Console.Write("Введите число: ");
        num = int.Parse(Console.ReadLine() ?? "0");
        break;
    }
    catch
    {
        
        Console.WriteLine("Введено некоректное значение");
    }
}

void Kvadrat(int a)
{
    int count = 1;
    while(count <= a)
    {
         Console.WriteLine(Math.Pow((count),3) + " \t " + count);
         count ++;
    }
    Console.WriteLine("Таблица кубов чисел  ");

}

    Kvadrat(num);