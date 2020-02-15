using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern_B
{
    public class Teacher : IEmployee
    {
        public void GetEmployeeInfo()
        {
            Console.WriteLine($"Employee Name :jahanara , Cell: 082222202 , Designation : Executive ");
        }

        public void GetStaffCellNo()
        {
            Console.WriteLine($"Employee Name :joshim , Cell: 0925252525 , Designation : Senior ");
        }
    }
}
