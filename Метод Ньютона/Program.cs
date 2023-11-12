using System;

class Program
{
    static void Main()
    {
        NewtonMethod(10); // Вызов функции, передавая начальное значение x
    }

    static void NewtonMethod(double x0)
    {
        double x = x0;

        for (int i = 0; i < 10; i++) // Ограничим количество итераций 10
        {
            double f = Function(x); // Вычисление значения функции в точке x
            double df = Derivative(x); // Вычисление значения производной функции в точке x

            if (Math.Abs(f) < 0.0001) // Проверка, достигнута ли достаточная точность
            {
                Console.WriteLine("Решение: x = " + x);
                Console.WriteLine("f'(5x - 6ln(x) - 7) = " + Function(x));
                return; // Выходим из функции, если достигли точности
            }

            double delta = f / df; // Вычисление приращения
            x = x - delta; // Обновление значения x

            Console.WriteLine("Итерация " + (i + 1) + ": x = " + x);
        }

        Console.WriteLine("Не удалось найти решение после 10 итераций.");
    }

    static double Function(double x)
    {
        return 5 * x - 6 * Math.Log(x) - 7; // Возвращает значение функции в точке x
    }

    static double Derivative(double x)
    {
        return 5 - 6 / x; // Возвращает значение производной функции в точке x
    }
}