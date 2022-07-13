using System.ComponentModel.DataAnnotations;

namespace ThirdTemplateforfoodordering.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Detail { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        public string CategoryName { get; set; }


    }
}
