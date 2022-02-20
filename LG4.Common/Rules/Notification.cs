using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Common.Rules {
    public class Notification {

        public String message { get; private set; }

        public Notification(String message) {
            this.message = message;
        }

        public override String ToString() => message;

    }
}
