using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyUsers.Backend
{
    [Table("pharmacydb")]
    public class UserModel
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("first_name")]
        [MaxLength(50)]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        [MaxLength(50)]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [Column("age")]
        public int Age { get; set; }

        [Required]
        [Column("gender")]
        public string Gender { get; set; }

        [Required]
        [Column("login")]
        [MaxLength(15)]
        [MinLength(5)]
        public string Login { get; set; }

        [Required]
        [Column("password")]
        [MaxLength(50)]
        [MinLength(6)]
        public string Password { get; set; }

    }
}