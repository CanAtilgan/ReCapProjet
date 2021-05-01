using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();

        }
        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }
        //}


        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.Description + result.Message);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

        }


        private static void Test()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            

            var result = customerManager.GetAll();
            foreach (var cust in result.Data)
            {
                Console.WriteLine(cust.Id + "/" + cust.CompanyName);
            }
        }



    }
}
