
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Raschet()
{

    int Number()
    {
        Console.Write("Введите число: ");
        return Convert.ToInt32(Console.ReadLine() ?? "0");

    }


    int Natur(int A)
    {

    int result = 0;
        for(int i = 1; i <= A; i++)
        {    
         result += A  % 10;  
         A /= 10;       
        }
    
     return result;  
    }

    int A = Number();

    int nat = Natur(A);

    Console.Write( $"{A} -> " + nat);
        

}   

Raschet();




