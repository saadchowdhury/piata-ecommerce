using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace work_01.ViewModels
{
    public class ProductView
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Unit { get; set; }

        public string Type { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }

        public IFormFile Image { get; set; }

        public string Description { get; set; }
    }
}
