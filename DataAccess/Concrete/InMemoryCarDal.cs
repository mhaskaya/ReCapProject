using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                 new Car{Id=1, BrandId=1, ColorId=5, DailyPrice=375, ModelYear=2015, Description="Mercedes-Benz C180"},
                 new Car{Id=2, BrandId=3, ColorId=2, DailyPrice=450, ModelYear=2018, Description="Mercedes-Benz G Serisi"},
                 new Car{Id=3, BrandId=1, ColorId=6, DailyPrice=380, ModelYear=2017, Description="Citroen C Elysse"},
                 new Car{Id=4, BrandId=2, ColorId=2, DailyPrice=150, ModelYear=2009, Description="Opel Astra"},
                 new Car{Id=5, BrandId=4, ColorId=1, DailyPrice=1200, ModelYear=2020, Description="Porsche Cayenne"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = carToDelete = _cars.SingleOrDefault(c => car.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = carToUpdate = _cars.SingleOrDefault(c => car.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
