using System;
using System.Collections.Generic;

namespace HOmeWork06112020.EF.Models
{
    public class CustomerOrderDto
    {
        public int OrderCode { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string EmployeeName { get; set; }
        public IEnumerable<OrderDetailsDto> Detail { get; set; }

    }
}