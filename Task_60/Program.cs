//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int GetNumber(string text)
{
    int num = 0;
    while(true)
{
    try
    {
        Console.Write(text);
        num = int.Parse(Console.ReadLine() ?? "0");
        break;
    }
    catch
    {
        Console.WriteLine("Введено некоректное значение");
    }

}
    return num;
}

void PrintArray(int[,,] arr)
{
      for(int x = 0; x < arr.GetLength(2); x++)
    {
        for(int y = 0; y < arr.GetLength(0); y++)
        {
            for(int z = 0; z < arr.GetLength(1); z++)
            {
                Console.Write( arr[y,z,x] + $"({y},{z},{x})" + "  ");
            }
        Console.WriteLine();
        }
    }
}


void FillArray(int[,,] arr )
{
    int temp = 10;
    for(int x = 0; x < arr.GetLength(0); x++)
    {
        for(int y = 0;  y < arr.GetLength(1); y++)
        {
            for(int z = 0; z < arr.GetLength(2); z++)
            {
           
              
                  if (temp < 100)
                  {
                    arr[x, y, z] = temp;
                    temp++; 
                  }  
            }
        }    
    }
        Console.WriteLine();
}



Console.WriteLine("Введите количество строк");
int x = GetNumber("X: ");
System.Console.WriteLine("Введите количество столбцов");
int y= GetNumber("Y: ");
System.Console.WriteLine("Введите обьем массива");
int z = GetNumber("Z: ");

int[,,] array = new int[x,y,z];

FillArray(array);
PrintArray(array);









        