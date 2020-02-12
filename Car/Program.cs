using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            Console.Write("Введите цвет машины: ");
            string color = Console.ReadLine();
            Console.Write("Введите модель машины: ");
            string model = Console.ReadLine();
            Console.Write("Введите максимальную скорость машины: ");
            float speed = int.Parse(Console.ReadLine());
            Console.Write("Введите вес машины: ");
            float weight = int.Parse(Console.ReadLine());
            Console.Write("Введите количество колес машины: ");
            int wheels = int.Parse(Console.ReadLine());
            car.Color(color);
            car.Model(model);
            car.Speed(speed);
            car.Weihgt(weight);
            car.Wheels(wheels);
            car.Action();
            Console.ReadKey();
        }
    }
}
