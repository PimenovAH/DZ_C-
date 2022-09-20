
int RandommNumbers3()
{
    int numbers = new Random().Next(1,999999);  
    return numbers;
}

int a = RandommNumbers3();


int NomerRand = a;
string IntvString = Convert.ToString(a);

if (IntvString.Length > 2)
{
  Console.WriteLine(a + " -> " + IntvString[2]);
}
else 
{
  Console.WriteLine(a + " -> третьей цифры нет: Error!");
}
