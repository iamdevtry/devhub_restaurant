using Dev69Restaurant.DTO.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev69Restaurant.DTO.Entities
{
    [Table("VATs")]
    public class VAT : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public decimal TaxPrice { get; set; }

        [Required]
        public decimal TaxPercent { get; set; }

        public virtual IEnumerable<Bill> Bills { set; get; }
    }
}