using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int CarId { get; set; } //car -- rental
        public string CarName { get; set; } //car
        public string Description { get; set; } // car
        public string BrandName { get; set; } //brand
        public string ColorName { get; set; } //color
        public string FirstName { get; set; } //user
        public string LastName { get; set; } //user
        public string CompanyName { get; set; } //customer
        public DateTime RentDate { get; set; } //renal
        public DateTime? ReturnDate { get; set; } //rental
        public int ModelYear { get; set; } //car

    }
}
