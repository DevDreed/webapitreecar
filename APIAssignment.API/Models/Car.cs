using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIAssignment.API.Models
{
    public class Car
    {
        public int CarId { get; set; }

        public string CarName { get; set; }

        public string CarMake { get; set; }

        public string CarModel { get; set; }
    }
}