using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev69Restaurant.DTO.Entities
{
    [Table("UserRoles")]
    public class UserRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public int RoleId { get; set; }

        [ForeignKey("Username")]
        public virtual User User { set; get; }

        [ForeignKey("RoleId")]
        public virtual Role Role { set; get; }
    }
}