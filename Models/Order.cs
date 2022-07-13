using System.ComponentModel.DataAnnotations;

namespace ThirdTemplateforfoodordering.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string Email { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Qnt { get; set; }
        public float TotalPrice { get; set; }
        public string Image { get; set; }


    }
}
