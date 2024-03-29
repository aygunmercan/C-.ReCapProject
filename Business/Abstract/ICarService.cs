﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByColorId(int id);
        List<Car> GetByDailyPrice(double min, double max);
        List<Car> GetCarsByBrandId(int id);

        void Add(Car car);
    }
}
