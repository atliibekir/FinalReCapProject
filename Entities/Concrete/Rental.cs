using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        [Key]
        [Column("Id")]
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RenDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
