﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCars();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsDailyPrice(decimal min, decimal max);
        bool CheckCarNameLength(Car car);
        bool CheckCarDailyPrice(Car car);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<RentDetailsDto> GetRentDetailsDto();

    }
}
