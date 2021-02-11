using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrate
{
    public class CarManager: ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car Get(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public void Add(Car car)
        {
            if (car.CarName.Length < 2)
            {
                Console.WriteLine("Aracın adı en az iki karakter olmalıdır");
                return;
            }
            if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Aracın günlük fiyatı sıfırdan büyük olmalıdır");
                return;
            }
            _carDal.Add(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId).ToList();
        }

        public List<CarDto> GetCarsList()
        {
            return _carDal.GetCarsList();
        }
    }
}
