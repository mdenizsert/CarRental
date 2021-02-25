using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCars();
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsByBrandId(int id);
        void AddCar(Car car);
    }
}
