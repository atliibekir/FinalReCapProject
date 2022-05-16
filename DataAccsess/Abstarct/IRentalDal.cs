using Core.DataAccsess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace DataAccsess.Abstarct
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<RentalDetailDto> GetRentalDetail();
    }
}
