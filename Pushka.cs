double x0;

while (true)
{
    Console.WriteLine("Введите координату x");
    if (!double.TryParse(Console.ReadLine(), out x0))
    {
        Console.WriteLine("Введите x числом");
    }
    else { break; }
}

double y0;

while (true)
{
    Console.WriteLine("Введите координату y");
    if (double.TryParse(Console.ReadLine(), out y0))
    {
        if (y0 >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка. Координата y не может быть отрицательной ");
        }
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Введите координату y числом");
    }
}


double v;
while (true)
{
    Console.WriteLine("Начальная скорость v");
    if (double.TryParse(Console.ReadLine(), out v))
    {
        if (v > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка. Скорость не может быть отрицательной");
        }
    }
    else { Console.WriteLine("Ошибка. Скорость не может быть символом"); }
}

double a;
while (true)
{
    Console.WriteLine("Введите угол в градусах");
    if (double.TryParse(Console.ReadLine(), out a))
    {
        if (a > 0 | a < 360)
        {
            break;
        }
        else if (v < 0 | v > 360)
        {
            Console.WriteLine("Угол не может быть меньше 0 и больше 360.");
        }
        else if (y0 == 0 & (a < 0 | a > 180))
        {
            Console.WriteLine("При y = 0 угол не может быть меньше 0 и больше 180");
        }
    }
    else { Console.WriteLine("Ошибка. Угол не может быть символом"); }
}

double A = (a * Math.PI)/180;

double vx0 = v * Math.Cos(A);
double vy0 = v * Math.Sin(A); 
double g = 9.81;

double x = x0, y = y0;

double t = 0;
Console.WriteLine(new string('-', 31));
Console.WriteLine($"| {"x",-8} | {"y",-8} | {"t",-6} |");
Console.WriteLine(new string('-', 31));
double T = Math.Round(2 * vy0 / g, 1);
while (t <= T)
{
    x = x0 + vx0 * t;
    y = y0 + vy0 * t - ((g * Math.Pow(t, 2)) / 2);


    Console.WriteLine($"| {x,-8:F2} | {y,-8:F2} | {t,-6:F1} |");
    t = Math.Round(t + 0.1, 1);
}

/* 
 * (a*Math.PI/180);
 */
