using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev69Restaurant.DTO.Entities
{
    [Table("BillDetails")]
    public class BillDetail
    {
        [Key]
        [Column(Order = 1)]
        public int BillId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int FoodId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public DateTime DateCheckin { get; set; }
        public DateTime DateCheckout { get; set; }

        [ForeignKey("BillId")]
        public virtual Bill Bill { set; get; }

        [ForeignKey("FoodId")]
        public virtual Food Food { set; get; }
    }
}