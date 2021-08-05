using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions
{
    class Car
    {
        public string Brand;
        public bool TotalLose;
        public bool NeedRepairs;

        public Car(string brand, bool totalLose, bool needRepairs)
        {
            if (totalLose == true && needRepairs == false)
            {
                throw new RepairMismatchException("Doesn't Make Any sense");
            }
            else
            {
                Brand = brand;
                TotalLose = totalLose;
                NeedRepairs = needRepairs;
            }
        }
    }
}
