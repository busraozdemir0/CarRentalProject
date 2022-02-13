using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ArastirmaContext> , ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ArastirmaContext context=new ArastirmaContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join o in context.Colors
                             on c.ColorId equals o.ColorId
                             select new CarDetailDto
                             {
                                CarId=c.CarId, Description=c.Description, BrandName=b.BrandName, ColorName=o.ColorName, DailyPrice=c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
