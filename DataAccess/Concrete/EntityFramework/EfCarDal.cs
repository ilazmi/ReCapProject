using System;
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDto> GetCarsList()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands on c.BrandId equals b.Id
                    join clr in context.Colors on c.ColorId equals clr.Id
                    select new CarDto
                    {
                        CarName = c.CarName,
                        BrandName = b.BrandName,
                        ColorName = clr.ColorName,
                        DailyPrice = c.DailyPrice
                    };
                return result.ToList();
            }
        }
    }
}
