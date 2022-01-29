using System;

namespace _12_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение радиуса окружности r: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Проверка принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x = 0, y = 0");
            Console.Write("Введите значение координаты x точки: ");
            double x_coordinate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение координаты y точки: ");
            double y_coordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Сircle.Length(radius);
            Сircle.Square(radius);
            Сircle.Coordinate(x_coordinate, y_coordinate, radius);

            Console.ReadKey();
        }
    }

    public static class Сircle
    {
        public static double length;
        public static double square;

        public static void Length(double radius)
        {
            length = 2 * Math.PI * radius;
            Console.WriteLine("Длина окружности равна: {0:f2}", length);
        }
        public static void Square(double radius)
        {
            square = Math.PI * radius * radius;
            Console.WriteLine("Площадь окружности равна: {0:f2}", square);
        }
        public static void Coordinate(double x_coordinate, double y_coordinate, double radius)
        {
            if (Math.Pow(radius, 2) > Math.Pow(x_coordinate, 2) + Math.Pow(y_coordinate, 2))
            {
                Console.WriteLine("Точка пренадлежит окружности");
            }
            else
            {
                Console.WriteLine("Точка НЕ пренадлежит окружности");
            }
        }
    }


}
