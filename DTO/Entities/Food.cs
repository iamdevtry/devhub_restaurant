using Dev69Restaurant.DTO.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev69Restaurant.DTO.Entities
{
    [Table("Foods")]
    public class Food : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [MaxLength(256)]
        public string Image { set; get; }

        [ForeignKey("CategoryId")]
        public virtual FoodCategory FoodCategory { set; get; }
    }
}