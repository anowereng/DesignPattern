using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public static class CarFactory
    {
        public static ICarSupplier GetInstance(int id) {
            switch (id)
            {
                case 0:
                    return new Honda();
                case 1:
                    return new BMW();
                default:
                    return null;
            }
                
        }
    }
}
