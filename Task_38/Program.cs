//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.\

void RandomNumbers(int[] array)
{
    for(int i = 0; i  < array.Length;i++)
    {
        array[i] = new Random().Next(1,100);
    }
}

void PrintArray(int[] array)
{
    List<int> siz = new List<int>(array); 
    Console.Write("[" );
    Console.Write(string.Join(",", siz));
    Console.Write("] -> ");
}

int MaxNeumberMin(int[] array)
{
    int result = 0;
    int min = array[0];
    int max =  array[0];

    for (int i = 0; i < array.Length; i++)
    {
	    if (array[i] > max)
	    {
		    max = array[i];	    
	    }

        if (array[i] < min)
	    {
		    min = array[i];	    
	    }
        result = max - min;
    }

    return  result;
}


int[] mass = new int [5];
RandomNumbers(mass);
PrintArray(mass);
Console.Write("Разница между max и min значением: " + MaxNeumberMin(mass));