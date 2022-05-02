using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstarct;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helper.FileHelper;
using Core.Utilities.Results;
using DataAccsess.Abstarct;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelperService _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IFileHelperService fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageCount(carImage.CarId));
            if (result!=null)
            {
                return result;
            }

            carImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagePath);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            _fileHelper.Delete(PathConstants.ImagePath + carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            var result = BusinessRules.Run(CheckCarImage(carId));
            if (result != null)
            {
                return new ErrorDataResult<List<CarImage>>(GetDefaultImage(carId).Data);
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
        }

        public IDataResult<CarImage> GetByImageId(int id)
        { 
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id));
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagePath + carImage.ImagePath, PathConstants.ImagePath);
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }
        private IResult CheckIfCarImageCount(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        private IResult CheckCarImage(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count();
            if (result > 0)
            {
                return new SuccessResult();
            }

            return new ErrorResult();
        }
        private IDataResult<List<CarImage>> GetDefaultImage(int carId)
        {
            List<CarImage> carImage = new List<CarImage>();
            carImage.Add(new CarImage() { CarId = carId, Date = DateTime.Now, ImagePath = "DefaultImagePath" });
            return new SuccessDataResult<List<CarImage>>(carImage);
        }
    }
}
