using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev69Restaurant.DTO.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(128)]
        [MinLength(6)]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string DisplayName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string FullName { get; set; }

        [MaxLength(256)]
        public string Avatar { set; get; }

        public DateTime? BirthDay { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string Address { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string Email { get; set; }

        public bool Status { get; set; }

        public virtual IEnumerable<UserRole> UserRoles{ set; get; }
    }
}