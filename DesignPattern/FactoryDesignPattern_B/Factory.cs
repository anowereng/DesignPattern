using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern_B
{
    public class Factory 
    {
        public static IEmployee GetInstance(int id)
        {
            switch (id)
            {
                case 1:
                    return new Staff();
                case 2:
                    return new Teacher();
                default:
                    return null;

            }
        }

    }
}
