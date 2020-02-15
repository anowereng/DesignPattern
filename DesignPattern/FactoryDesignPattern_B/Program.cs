using System;

namespace FactoryDesignPattern_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var staff = Factory.GetInstance(1);
            var teacher = Factory.GetInstance(2);

            staff.GetEmployeeInfo();
            teacher.GetEmployeeInfo();

            Console.ReadLine();
        }
    }
}
