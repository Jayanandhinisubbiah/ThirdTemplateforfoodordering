using System.ComponentModel.DataAnnotations;

namespace ThirdTemplateforfoodordering.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string BankName { get; set; }
        public string CardNo { get; set; }
        public int CCV { get; set; }
        public float Amount { get; set; }
    }
}
