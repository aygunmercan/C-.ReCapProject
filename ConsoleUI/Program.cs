// DataAccess ürünü ekleyecek
// Business kontrol edecek
// Console ürünü gösterecek
// Entities yardımcı katmanımız olacak. Diğer 3 katman bu entities'i kullanacak

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetCarsByColorId(1))
            foreach (var car in carManager.GetAll())
            {
                //System.Console.WriteLine(car.ModelYear+", "+car.Descriptions+", "+car.DailyPrice);
                System.Console.WriteLine(car.Descriptions + "\t" + car.DailyPrice);

            }

            System.Console.WriteLine("\n" + "2 numaralı araçların sınıf ve modeli");

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                System.Console.WriteLine(car.ModelYear + " " + car.Descriptions + " " + car.BrandId);
            }


            //Araç ekleme
            //Car car1 = new Car() { BrandId = 1, ColorId = 1, DailyPrice = 500, Descriptions = "Not for Rent", ModelYear = 2021 };
            //carManager.Add(car1);

            //foreach (var car in carManager.GetAll())
            //{
            //    System.Console.WriteLine(car.Id + " ," + car.BrandId + " ," + car.ColorId + " ," + car.DailyPrice + " ," + car.ModelYear + " ," + car.Descriptions);

            //}

            //Araç Güncelleme


            //Car car2 = new Car() { Id = 1, BrandId = 1, ColorId = 45, DailyPrice = 300, ModelYear = 2017, Descriptions = "Not for Rent" };


            //foreach (var car in carManager.GetAll())
            //{
            //    if (car.Id.Equals(1))
            //    {
            //        System.Console.WriteLine(car.Id + " ," + car.BrandId + " ," + car.ColorId + " ," + car.DailyPrice + " ," + car.ModelYear + " ," + car.Descriptions);
            //        carManager.Update(car2);
            //        System.Console.WriteLine(Environment.NewLine);
            //    }
            //    System.Console.WriteLine(car.Id + " ," + car.BrandId + " ," + car.ColorId + " ," + car.DailyPrice + " ," + car.ModelYear + " ," + car.Descriptions);


            //}

            //Araç silme
            //carManager.Delete(car1);
            //foreach (var car in carManager.GetAll())
            //{
            //    System.Console.WriteLine(car.Id + " ," + car.BrandId + " ," + car.ColorId + " ," + car.DailyPrice + " ," + car.ModelYear + " ," + car.Descriptions);

            //}

        }
    }
}
