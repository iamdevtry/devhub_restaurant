using Dev69Restaurant.DTO.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev69Restaurant.DTO.Entities
{
    [Table("FoodCategories")]
    public class FoodCategory : Auditable
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
        public string Description { get; set; }

        public virtual IEnumerable<Food> Foods { set; get; }
    }
}