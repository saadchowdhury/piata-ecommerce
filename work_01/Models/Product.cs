using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace work_01.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Unit { get; set; }

        public string Type { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }

        public byte[] Image { get; set; }

        public string ImageFile { get; set; }

        public string Description { get; set; }

    }
}
