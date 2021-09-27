using Dev69Restaurant.DTO.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev69Restaurant.DTO.Entities
{
    [Table("TableFoods")]
    public class TableFood : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        public int AreaId { get; set; }

        [ForeignKey("AreaId")]
        public virtual Area Area { set; get; }

        public virtual IEnumerable<Bill> Bills { set; get; }
    }
}