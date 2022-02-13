using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ColorGetAllTest();
            //ColorUpdatedTest();

            //BrandGetAllTest();
            //BrandDeletedTest();

            //CarGetAllTest();
            //CarGetCarDetailsTest();
            //CarAddTest();

            //UserAddTest();
            //CustomerAddTest();


        }

        private static void UserAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Oktay",
                LastName = "Kaya",
                Email = "kaya@gmail.com",
                Password = "5555"
            });
        }
        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                UserId = 3,
                CompanyName = "Yıldız"
            });
        }

        private static void BrandDeletedTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { BrandId = 3 });
        }

        private static void ColorUpdatedTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(new Color { ColorId = 2, ColorName = "Koyu Gri" });
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Description = "Family", DailyPrice = 100 });
        }

        private static void CarGetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else Console.WriteLine(result.Message);
        }
        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine("* * * Marka Id'sine göre * * *");
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandId);
                }
            }
            else Console.WriteLine(result.Message);
        }

        private static void ColorGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine("* * * Renk adı * * *");
            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else Console.WriteLine(result.Message);
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " " + car.ColorId + " " + car.ModelYear + " " + car.Description + " " + car.DailyPrice);
                }
            }
            else Console.WriteLine(result.Message);

            Console.WriteLine("* * * Marka Id'sine göre arama * * *");

            var result1 = carManager.GetCarsByBrandId(2);
            if (result.Success == true)
            {
                foreach (var car in result1.Data)
                {
                    Console.WriteLine(car.BrandId + " " + car.Description);
                }
            }
            else Console.WriteLine(result1.Message);


            Console.WriteLine("* * * Renk Id'sine göre arama * * *");

            var result2 = carManager.GetCarsByColorId(3);
            if (result2.Success == true)
            {
                foreach (var car in result2.Data)
                {
                    Console.WriteLine(car.ColorId + " " + car.Description);
                }
            }
            else Console.WriteLine(result2.Message);


        }
    }
}
