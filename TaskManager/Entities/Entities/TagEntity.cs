
using Dapper.Contrib.Extensions;

namespace Entities.Entities
{
    [Table("Tag")]
    public class TagEntity : BaseEntity
    {

        public TagEntity()
        {
            Tasks = new List<TaskEntity>();
        }

        [Write(false)]
        public UserEntity User { get; set; }
        public int UserId { get; set; }

        [Write(false)]
        public List<TaskEntity> Tasks { get; set; }
    }
}
