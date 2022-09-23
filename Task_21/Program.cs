// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetNum(string name)
{
    Console.WriteLine("Введите координаты " + name);
    return Convert.ToDouble(Console.ReadLine());
}

double x1 = GetNum("X1");
double x2 = GetNum("X2");
double y1 = GetNum("Y1");
double y2 = GetNum("Y2");
double c1 = GetNum("С1");
double c2 = GetNum("С2");

double Rastoyn(double x1, double x2, double y1, double y2, double c1, double c2 )
{
    double R = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(c2 - c1, 2));
    return R;

}
double  tochka =  Rastoyn(x1,x2,y1,y2,c1,c2);
Console.WriteLine("A"+(x1,y1,c1)+";" + " B"+ (x2,y2,c2) + " -> "+ Math.Round(tochka,2));