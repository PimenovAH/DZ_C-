//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Number()
{
        Console.Write("Введите число: ");
        return Convert.ToInt32(Console.ReadLine() ?? "0");

}

int Natur(int A, int B)
{
    int result = 1;
    for(int i = 1; i <= B; i++)
    {
        result *= A;
        
    }
    return result;
}

int A = Number();
int B = Number();

int nat = Natur(A,B);

Console.Write( $"{A},{B} -> " + nat);





    