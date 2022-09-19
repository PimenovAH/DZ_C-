int RandommNumbers3()
{
    int number = new Random().Next(100,999);  
     return number;
}


int Vtoroe(int numbers)
{

    int result = numbers / 10 %  10;
    return result;
}

int a = RandommNumbers3();
int b =  Vtoroe(a);
Console.WriteLine(a+ " -> " + b);
