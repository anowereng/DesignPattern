using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern_B
{
    public class Staff : IEmployee
    {
        public void GetEmployeeInfo()
        {
            Console.WriteLine($"Employee Name :anower , Cell: 01822339363 , Designation : System Executive ");
        }

        public void GetStaffCellNo()
        {
            Console.WriteLine($"Employee Name :shahdat , Cell: 01717187275 , Designation : Senior Officer ");
        }
    }
}
