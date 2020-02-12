using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    interface CarColor { void Color(string color); }
    interface CarModel { void Model(string model); }
    interface CarWheels { void Wheels(int numwheels); }
    interface CarWeight { void Weihgt(float weight); }
    interface CarSpeed { void Speed(float speed); }
    interface CarAction { void Action(); }
    class Car : CarColor, CarModel, CarWheels, CarWeight, CarSpeed
    {
        public void Color(string color)
        {
            Console.WriteLine("My color is: " + color);
        }
        public void Model(string model)
        {
            Console.WriteLine("My model is: " + model);
        }
        public void Speed(float speed)
        {
            Console.WriteLine("My speed is: " + speed);
        }
        public void Weihgt(float weight)
        {
            Console.WriteLine("My weight is: " + weight);
        }
        public void Wheels(int numwheels)
        {
            Console.WriteLine("My number of wheels is: " + numwheels);
        }
    }
}
