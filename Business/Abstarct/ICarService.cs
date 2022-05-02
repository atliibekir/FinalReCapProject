﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface ICarService
    {
        IDataResult <List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult <List<Car>> GetCarsByBrandId(int brandId);
        IDataResult <List<Car>> GetCarsByColorId(int colorId);
        IDataResult <List<CarDetailDto>> GetCarDetail();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}