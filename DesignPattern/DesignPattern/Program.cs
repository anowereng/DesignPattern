using FactoryDesignPattern;
using System;

namespace FactoryDesignPattern_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var honda = CarFactory.GetInstance(0);
            honda.CarModel();
            Console.WriteLine($"Car Color: {honda.CarColor}");
            Console.ReadLine();
        }
    }
}
