﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrate;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        Car GetById(Car car);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}