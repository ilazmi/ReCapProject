using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;

namespace Business.Concrate
{
    public class CarManager: ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public Car GetById(Car car)
        {
            return _carDal.GetById(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
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
    }
}
