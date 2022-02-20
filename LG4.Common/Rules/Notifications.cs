using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Common.Rules {
    public class Notifications {

        private List<Notification> notifications = new List<Notification>();

        public Notifications() { }

        public Notification[] GetNotifications() {
            return notifications.ToArray();
        }

        public override String ToString() {
            return String.Join($"{Environment.NewLine}", GetNotifications().Select(x => x.message).ToArray());
        }

        public void AddNotification(Notification notification) {
            notifications.Add(notification);
        }

        public bool isOK() {
            return (notifications.Count == 0);
        }

        public void Verify() {
            if (!isOK())
                throw new Exception(ToString());
        }

    }
}
