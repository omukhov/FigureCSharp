using System;

namespace testCsharp
{
    /// <summary>
    /// Абстрактный класс фигуры, от которого наследуются необходимые фигуры
    /// </summary>
    abstract class Figure
    {
        /// <summary>
        /// Абстрактный метод высчитывающий площадь фигуры
        /// </summary>
        /// <returns>double Площадь</returns>
        public abstract double CalcSquare();

        /// <summary>
        /// Абстрактный метод высчитывающий периметр фигуры
        /// </summary>
        /// <returns>double Периметр</returns>
        public abstract double CalcPerimeter();
    }

    /// <summary>
    /// Класс треугольника
    /// </summary>
    class Triange : Figure
    {
        /// <summary>
        /// Стороны треугольника (2 катета и гипотенуза)
        /// </summary>
        public double a, b, c;

        /// <summary>
        /// Вычисление площади по формуле Герона или по формуле прямоугольного треугольника
        /// </summary>
        /// <returns>double Площадь</returns>
        public override double CalcSquare()
        {
            double s = 0;
            if (c * c == a * a + b * b)
            {
                s = 0.5 * a * b;
                Console.WriteLine("Этот треугольник прямоугольный");
            }
            else
            {
                double p = a + b + c;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return s;
        }

        /// <summary>
        /// Вычисление периметра по простой формуле
        /// </summary>
        /// <returns>double Периметр</returns>
        public override double CalcPerimeter()
        {
            double p = a + b + c;
            return p;
        }
    }

    /// <summary>
    /// Класс круга
    /// </summary>
    class Circle : Figure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double r;

        /// <summary>
        /// Вычисление площади круга по формуле Pi * r^2
        /// </summary>
        /// <returns></returns>
        public override double CalcSquare()
        {
            double s = Math.PI * r * r;
            return s;
        }

        /// <summary>
        /// Вычисления периметра по формуле 2 * Pi * r
        /// </summary>
        /// <returns></returns>
        public override double CalcPerimeter()
        {
            double p = 2 * Math.PI * r;
            return p;
        }
    }

    /// <summary>
    /// Основной класс
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в консольное приложение
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /// Создание объектов треугольника и круга
            Triange triangle = new Triange();
            Circle circle = new Circle();

            /// Консольное меню выбора фигуры, если поставить иное значение вычислится площадь и периметр круга
            Console.WriteLine("Выберите фигуру для вычисления площади и периметра");
            Console.WriteLine("\t0 - Треугольник");
            Console.WriteLine("\t1 - Круг");

            switch (Console.ReadLine())
            {
                case "0":
                    double a, b, c;
                    Console.WriteLine("Введите стороны треугольника: ");
                    Console.Write("Сторона а: ");

                    while (!double.TryParse(Console.ReadLine(), out a))
                    {
                        Console.WriteLine("Ошибка ввода! Введите число a");
                    }

                    triangle.a = Convert.ToDouble(a);

                    Console.Write("Сторона b: ");

                    while (!double.TryParse(Console.ReadLine(), out b))
                    {
                        Console.WriteLine("Ошибка ввода! Введите число b");
                    }

                    triangle.b = Convert.ToDouble(b);

                    Console.Write("Сторона c: ");

                    while (!double.TryParse(Console.ReadLine(), out c))
                    {
                        Console.WriteLine("Ошибка ввода! Введите число c");
                    }

                    triangle.c = Convert.ToDouble(c);

                    Console.WriteLine($"Площадь {triangle.CalcSquare()}\nПериметер: {triangle.CalcPerimeter()}");
                    break;
                case "1":
                    double r;
                    Console.WriteLine("Введите радиус круга: ");

                    while (!double.TryParse(Console.ReadLine(), out r))
                    {
                        Console.WriteLine("Ошибка ввода! Введите радиус численно");
                    }

                    circle.r = Convert.ToDouble(r);
                    Console.WriteLine($"Площадь {circle.CalcSquare()}\nПериметер: {circle.CalcPerimeter()}");
                    break;
                default:
                    Console.WriteLine("Введите радиус круга: ");

                    while (!double.TryParse(Console.ReadLine(), out r))
                    {
                        Console.WriteLine("Ошибка ввода! Введите радиус численно");
                    }

                    circle.r = Convert.ToDouble(r);
                    Console.WriteLine($"Площадь {circle.CalcSquare()}\nПериметер: {circle.CalcPerimeter()}");
                    break;
            }
        }
    }
}
