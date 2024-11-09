try
{
    double x = 1.3;
    double k = 4;
    double a = Math.Log(Math.Abs(x));
    double b = Math.Exp(2 * x) + a * x;
    double y = x * Math.Pow(a, 3) + Math.Pow(b, 2);
    Console.WriteLine("Значение y: " + y);
}
catch
{
    Console.WriteLine("Введите верное значение:");
}
        