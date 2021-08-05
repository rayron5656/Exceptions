using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage G1 = new Garage();

            Car C1 = new Car("Mazda", false, true);
            Car C2 = new Car("Mazda", false, true);
            Car C3 = new Car("Mazda", false, true);
            Car C4 = new Car("Mazda", false, true);
            G1.AddCar(C1);

            try
            {
                G1.AddCar(C1);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}
