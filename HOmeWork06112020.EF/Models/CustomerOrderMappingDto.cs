using System;

namespace HOmeWork06112020.EF.Models
{
    public class CustomerOrderMappingDto
    {
        public int OrderCode { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string EmployeeName { get; set; }
        public decimal TotalPrice { get; set; }
    }
}