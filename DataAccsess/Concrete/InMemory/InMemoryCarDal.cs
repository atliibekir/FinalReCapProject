using DataAccsess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { Id = 1, CarName = "Fiat Egea", BrandId = 1, ColorId = 1, DailyPrice = 350000, ModelYear = 2021, Description = "Fiat Egea Urban" },
                new Car { Id = 2, CarName = "Ford Focus", BrandId = 2, ColorId = 2, DailyPrice = 375000, ModelYear = 2018, Description = "Ford Focus Titanium" },
                new Car { Id = 3, CarName = "BMW 320",BrandId = 3, ColorId = 1, DailyPrice = 575000, ModelYear = 2015, Description = "BMW 320ed 40th Edition" },
                new Car { Id = 4, CarName = "Ford Courier",BrandId = 2, ColorId = 3, DailyPrice = 220000, ModelYear = 2017, Description = "Ford Courier Deluxe" },
                new Car { Id = 5, CarName = "Renault Clio",BrandId = 4, ColorId = 4, DailyPrice = 195000, ModelYear = 2012, Description = "Reanult Clio Extreme Edition" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<CarDetailDto> GetCarDetail(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}

