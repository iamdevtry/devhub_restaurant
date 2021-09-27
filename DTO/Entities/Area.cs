using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev69Restaurant.DTO.Entities
{
    [Table("Areas")]
    public class Area
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string Name { get; set; }

        public virtual IEnumerable<TableFood> TableFoods { set; get; }
    }
}