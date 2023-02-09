using Entities.Notifications;

namespace Entities.Entities
{
    public class BaseEntity : Notifies
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
