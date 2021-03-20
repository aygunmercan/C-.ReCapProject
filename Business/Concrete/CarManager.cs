using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;   ////Business katmanında DataAccess katmanını kullanabilmek için constructor injection uygulandı.

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {

            if (car.DailyPrice>0 && car.Descriptions.Length>=2)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araç eklenmedi...");
            }

        }

        //public void Delete(Car car)
        //{
        //    _carDal.Delete(car);
        //}

        //public void Update(Car car)
        //{
        //    _carDal.Update(car);
        //}

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetByDailyPrice(double min, double max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }


    }
}
