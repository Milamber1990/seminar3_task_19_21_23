double rast(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double lenght = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
    return lenght;
}




Console.Write("Введите координату x для первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y для первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату z для первой точки ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату x для второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y для второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату z для второй точки ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точками равно {Math.Round(rast(x1, y1, z1, x2, y2, z2),2)}");