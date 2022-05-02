using Business.Concrete;
using Business.Constants;
using DataAccsess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConcoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            UserAdd();
            //CustomerAdd();           
            //RentalAdd();

        }

        private static void RentalAdd()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            if (result.Success)
            {
                rentalManager.Add(new Rental() { RentalId = 4, CarId = 2, CustomerId = 4, RenDate = DateTime.Parse("2022-03-01"), ReturnDate = DateTime.Today });
                rentalManager.Add(new Rental() { RentalId = 2, CarId = 2, CustomerId = 2, RenDate = DateTime.Parse("2022-02-02"), ReturnDate = DateTime.Parse("2022-04-21") });
                rentalManager.Add(new Rental() { RentalId = 3, CarId = 5, CustomerId = 3, RenDate = DateTime.Parse("2021-10-01"), ReturnDate = DateTime.Parse("2021-12,30") });
            }
        }

        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer() { UserId = 1, CompanyName = "Atlı Sofware" });
            customerManager.Add(new Customer() { UserId = 2, CompanyName = "EP Yatırım" });
            customerManager.Add(new Customer() { UserId = 3, CompanyName = "Akbaş Tarım" });
            customerManager.Add(new Customer() { UserId = 4, CompanyName = "Acar ARGE" });
            customerManager.Add(new Customer() { UserId = 5, CompanyName = "Sarıkaya Denetim" });
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User() { FirstName = "Bekir", LastName = "Atlı", Email = "abc@gmail.com", Password = "1234a" });
            userManager.Add(new User() { FirstName = "Emir", LastName = "Acar", Email = "xxx@gmail.com", Password = "1234e" });
            userManager.Add(new User() { FirstName = "Emre", LastName = "Polat", Email = "xyx@gmail.com", Password = "1234b" });
            userManager.Add(new User() { FirstName = "Samet", LastName = "Akbaş", Email = "xyz@gmail.com", Password = "1234s" });
            userManager.Add(new User() { FirstName = "Mert", LastName = "Sarıkaya", Email = "zxx@gmail.com", Password = "1234m" });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void CarTest()
        {

            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetail();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }
    }
}

