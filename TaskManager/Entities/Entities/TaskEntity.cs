using Dapper.Contrib.Extensions;
using Entities.Enums;

namespace Entities.Entities
{
    [Table("Task")]
    public class TaskEntity : BaseEntity
    {

        public TaskEntity()
        {
            Tags = new List<TagEntity>();
        }
        public string Description { get; set; }
        public StatusEnum Status { get; set; }

        [Write(false)]
        public UserEntity User { get; set; }
        public int UserId { get; set; }

        [Write(false)]
        public TagEntity Tag { get; set; }
        public int TagId { get; set; }

        [Write(false)]
        public List<TagEntity> Tags { get; set; }
    }
}
