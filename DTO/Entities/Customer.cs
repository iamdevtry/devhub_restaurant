using Dev69Restaurant.DTO.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev69Restaurant.DTO.Entities
{
    [Table("Customers")]
    public class Customer : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string Address { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Required]
        public int CustomerCategoryId { get; set; }

        [ForeignKey("CustomerCategoryId")]
        public virtual CustomerCategory CustomerCategory { set; get; }
    }
}