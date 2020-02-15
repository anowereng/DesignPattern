using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class Honda : ICarSupplier
    {
        public string CarColor { get { return "White"; } }

        public void CarModel()
        {
            Console.WriteLine("Honda Car Model is Honda 2014");
        }
    }
}
