using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOmeWork06112020.EF.Models
{
    internal class ProductDto
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Category { get; set; }
        public decimal? Price { get; set; }
        public short? Stock { get; set; }

    }
}
