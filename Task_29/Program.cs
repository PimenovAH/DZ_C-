// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void R()
{
    int Num()
    {
        Console.Write("Укажите длину массива: ");
         
        return Convert.ToInt32(Console.ReadLine() ?? "0");
    }

    int b = Num();

    int[] array = new int[b];
    List<int> siz = new List<int>(b);
    

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100); 
        siz.Add(array[i]);             
    } 
    
    Console.Write(string.Join(",", siz));
    Console.Write(" -> [" );
    Console.Write(string.Join(",", siz));
    Console.Write("]");
}
R();