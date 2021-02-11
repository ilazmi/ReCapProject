using System;
using Business.Concrate;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var carDto in carManager.GetCarsList())
            {
                System.Console.WriteLine(carDto.CarName + " " + carDto.BrandName + " " + carDto.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            System.Console.WriteLine("GetAll:");
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.ModelYear + " - " + car.Description);
            }

            System.Console.WriteLine("Add:");
            var carNew = new Car
                {Id = 6, BrandId = 2, ColorId = 2, DailyPrice = 600, Description = "X5 XDRIVE", ModelYear = 2020};
            carManager.Add(carNew);
            System.Console.WriteLine(carNew.ModelYear + " - " + carNew.Description + " eklendi.");

            System.Console.WriteLine("GetAll:");
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.ModelYear + " - " + car.Description);
            }

            System.Console.WriteLine("Update:");
            carNew.Description = "X5 XDRIVE DIESEL";
            carManager.Update(carNew);
            System.Console.WriteLine(carNew.ModelYear + " - " + carNew.Description + " güncellendi.");

            System.Console.WriteLine("GetAll:");
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.ModelYear + " - " + car.Description);
            }

            System.Console.WriteLine("Delete:");
            carManager.Delete(carNew);
            System.Console.WriteLine(carNew.ModelYear + " - " + carNew.Description + " silindi.");

            System.Console.WriteLine("GetAll:");
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.ModelYear + " - " + car.Description);
            }
        }
    }
}
