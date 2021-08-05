using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions
{
    class Garage : Igarage 
    {
        public static string[] CarTypes = {"mazda", "Toyota", "Suzuki" };
        public Car[] Cars = new Car[10];
        

        
        
        public void AddCar(Car CarToAdd)
        {
            if  (CarToAdd.TotalLose )
            {
                throw new WeDoNotFixTotalLostException("Cannot Except Total lost Car");
            }
            for (int i = 0; i < Cars.Length; i++)
            {
                if (CarToAdd == Cars[i])
                {
                    throw new CarAlreadyHereException("This car is aleady in the garage");
                }
            }
            if(-1 == Array.IndexOf(CarTypes,CarToAdd.Brand.ToLower()))
            {
                throw new WrongGarageException("This garage Does not take care of thise Brands");
            }
            else if(CarToAdd == null)
            {
                throw new CarNullException("Null");
            }
            else if(CarToAdd.NeedRepairs == false)
            {
                throw new RepairMismatchException("This car Does not require Repairs");
            }
            else
            {
                for (int i = 0; i < Cars.Length; i++)
                {
                    if (Cars[i] == null)
                    {
                        Cars[i] = CarToAdd;
                        break;
                    }
                }
            }

        }

      

        public void FixCar(Car CarToFix)
        {
            if (CarToFix == null)
            {
                throw new CarNullException("Null");
            }
            else if (-1 == Array.IndexOf(Cars, CarToFix))
            {
                throw new CarNotInGarageException("Car Aint in the garage");
            }
            else if (CarToFix.NeedRepairs == false)
            {
                throw new RepairMismatchException("Doesn't Need Repairs");
            }
            else
            {
                CarToFix.NeedRepairs = false;
            }

        }

        public void TakeOutCar(Car CarToRelease)
        {
            if (CarToRelease == null)
            {
                throw new CarNullException("Null");
            }
            else if (-1 == Array.IndexOf(Cars,CarToRelease))
            {
                throw new CarNotInGarageException("Car Aint in the garage");
            }
            else if(CarToRelease.NeedRepairs == true)
            {
                throw new CarNotReadyException("Car still need to be fixed");
            }
            else
            {
                Cars[Array.IndexOf(Cars, CarToRelease)] = null;
            }

        }
    }
}
