Console.Clear();


int Number()
{
    Console.Write("Введите массив: ");
    return  Convert.ToInt32(Console.ReadLine());    
}


void RandomArray(int[] array)
{
    for(int i = 0; i < array.Length;i++)
    {
        array[i] = new Random().Next(-100,100);
    }
}


void PrintArray(int[] array)
{
    List<int> siz = new List<int>(array); 
    Console.Write("[" );
    Console.Write(string.Join(",", siz));
    Console.Write("]");
}

int a = Number();
int[] size = new int[a];
int[] scan = new int[a];

RandomArray(size);

PrintArray(size);

for(int i = 0; i < size.Length; i ++ )
{
    scan[i] = size[i]; 

}
Console.Write(" <--> ");
    PrintArray(scan);

Console.WriteLine();








