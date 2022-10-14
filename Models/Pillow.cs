﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PillowFactory.Models
{
    public class Pillow
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufactureDate { get; set; }
        public string Colour { get; set; }
        public string Size { get; set; }

        public decimal Price { get; set; }
    }
}
    

