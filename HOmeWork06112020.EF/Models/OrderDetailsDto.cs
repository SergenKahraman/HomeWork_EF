namespace HOmeWork06112020.EF.Models
{
    public class OrderDetailsDto
    {
        public int OrderCode { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public short? Quantity { get; set; }
        public float Discount { get; set; }

        public decimal Summary
        {
            get
            {
                return Price.Value * Quantity.Value * (1M - (decimal)Discount);
            }
        }
    }
}