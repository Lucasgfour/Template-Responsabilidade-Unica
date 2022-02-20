using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Common.Rules {
    public  class RuleTypes : Notifications {

        public RuleTypes() { }

        public void Equal(String value, String expected, String message) {

            if(value.Equals(expected)) 
                AddNotification(new Notification(message));

        }

        public void Contains(String value, string str, String message) {

            if(value.Contains(str)) 
                AddNotification(new Notification(message));

        }

        public void NullOrEmpty(String value, String message) {

            if (String.IsNullOrEmpty(value))
                AddNotification(new Notification(message));

        }

        public void NotEqual(String value, String expected, String message) {

            if (!value.Equals(expected))
                AddNotification(new Notification(message));

        }

        public void NotContains(String value, string str, String message) {

            if (!value.Contains(str))
                AddNotification(new Notification(message));

        }

        public void Equal(Object value, Object expected, String message) {

            if(double.Parse(value.ToString()) == double.Parse(expected.ToString())) 
                AddNotification(new Notification(message));

        }

        public void GreaterThan(Object value, Object expected, String message) {

            if (double.Parse(value.ToString()) > double.Parse(expected.ToString()))
                AddNotification(new Notification(message));

        }

        public void LessThan(Object value, Object expected, String message) {

            if (double.Parse(value.ToString()) < double.Parse(expected.ToString()))
                AddNotification(new Notification(message));

        }
        
        public void GreaterOrEqualThan(Object value, Object expected, String message) {

            Equal(value, expected, message);
            GreaterThan(value, expected, message);

        }

        public void LessOrEqualThan(Object value, Object expected, String message) {

            Equal(value, expected, message);
            LessThan(value, expected, message);

        }


    }
}
