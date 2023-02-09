using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications
{
    public class Notifies
    {

        public Notifies()
        {
            Notifications = new List<Notifies>();
        }

        [NotMapped]
        public string PropName { get; set; }

        [NotMapped]
        public string message { get; set; }

        [NotMapped]
        public List<Notifies> Notifications;

        public bool ValidPropString(string value, string propName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propName))
            {
                Notifications.Add(new Notifies
                {
                    message = "Required Field",
                    PropName = propName
                });
                return false;
            }
            return true;
        }

        public bool ValidPropInt(int value, string propName)
        {
            if(value <1 || string.IsNullOrWhiteSpace(propName)){
                Notifications.Add(new Notifies
                {
                    message = "Value must be more than 0",
                    PropName = propName
                });
                return false;
            }
            return true;
        }

        public bool ValidPropDecimal(decimal value, string propName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propName)){
                Notifications.Add(new Notifies
                {
                    message = "Value must be more than 0",
                    PropName = propName
                });
                return false;
            }
            return true;
        }
    }
}
