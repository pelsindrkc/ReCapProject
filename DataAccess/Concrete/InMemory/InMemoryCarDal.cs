using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=60000, ModelYear=2015, Description="Mercedes-BENZ"},
                new Car{Id=2, BrandId=2, ColorId=1, DailyPrice=70000, ModelYear=2015, Description="BMW"},
                new Car{Id=3, BrandId=3, ColorId=6, DailyPrice=50000, ModelYear=2018, Description="Honda"},
                new Car{Id=4, BrandId=4, ColorId=4, DailyPrice=10000, ModelYear=2014, Description="Audi"},
                new Car{Id=5, BrandId=5, ColorId=3, DailyPrice=160000, ModelYear=2020, Description="Toyota"},
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

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByld(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToUpdate);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;


        }
    }
}
