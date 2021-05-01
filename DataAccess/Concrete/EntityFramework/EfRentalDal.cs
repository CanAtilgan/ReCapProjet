using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext> , IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from re in context.Rentals
                             join ca in context.Cars
                             on re.CarId equals ca.Id
                             join b in context.Brands
                             on ca.BrandId equals b.BrandId
                             join cus in context.Customers
                             on re.CustomerId equals cus.Id
                             join u in context.Users
                             on cus.Id equals u.Id
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             select new RentalDetailDto
                             {
                                 CarId = ca.Id,
                                 CarName = ca.CarName,
                                 Description = ca.Description,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 CompanyName = cus.CompanyName,
                                 ModelYear = ca.ModelYear,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate
                             };
                return result.ToList();


            }
        }
    }
}
