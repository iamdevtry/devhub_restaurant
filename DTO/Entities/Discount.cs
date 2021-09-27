using Dev69Restaurant.DTO.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev69Restaurant.DTO.Entities
{
    [Table("Discounts")]
    public class Discount : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "varchar")]
        public string Code { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [Required]
        public decimal DiscountPercent { get; set; }

        public decimal? ConditionPrice { get; set; }
    }
}