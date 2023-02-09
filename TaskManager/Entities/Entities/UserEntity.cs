using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("User")]
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
