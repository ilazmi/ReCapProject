using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal: ICarDal
    {
        private List<Car> _car;
        private List<Brand> _brands;
        private List<Color> _colors;

        public InMemoryCarDal()
        {
            _brands = new List<Brand> {
                new Brand {Id = 1, BrandName = "Volkswagen"},
                new Brand {Id = 2, BrandName = "BMW"},
                new Brand {Id = 3, BrandName = "Fiat"}
            };
            _colors = new List<Color>
            {
                new Color {Id = 1, ColorName = "Beyaz"},
                new Color {Id = 1, ColorName = "Siyah"}
            };
            _car = new List<Car>
            {
                new Car {Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 450, Description = "PASSAT 1.4 TSI", ModelYear = 2016},
                new Car {Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 550, Description = "5.20 XDRIVE", ModelYear = 2020},
                new Car {Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 250, Description = "DOBLO 1.6 DIESEL", ModelYear = 2020},
                new Car {Id = 4, BrandId = 1, ColorId = 2, DailyPrice = 300, Description = "POLO 1.4", ModelYear = 2018},
                new Car {Id = 5, BrandId = 2, ColorId = 2, DailyPrice = 375, Description = "1.16", ModelYear = 2019}
            };
        }

        public Car GetById(Car car)
        {
            return _car.FirstOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Update(Car car)
        {
            var carToUpdate = _car.FirstOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            var carToDelete = _car.FirstOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<CarDto> GetCarsList()
        {
            throw new NotImplementedException();
        }
    }
}
