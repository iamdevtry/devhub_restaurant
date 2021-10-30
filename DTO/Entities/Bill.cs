using Dev69Restaurant.DTO.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev69Restaurant.DTO.Entities
{
    [Table("Bills")]
    public class Bill : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int TableId { get; set; }

        public string PaymentMethod { get; set; }

        [MaxLength(10)]
        public string DiscountCode { get; set; }

        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }

        [ForeignKey("TableId")]
        public virtual TableFood TableFood { set; get; }

        public virtual IEnumerable<BillDetail> BillDetails { set; get; }
    }
}