using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Repository.MySQL {
    public class TableColumn {

        public String Field { get; set; }

        public String Type { get; set; }

        public String Null { get; set; }

        public String Key { get; set; }

        public String Default { get; set; }

        public String Extra { get; set; }

        public TableColumn() { }

        public bool IsPrimaryAndAutoIncrement() {

            return (Key.Equals("PRI") && Extra.Contains("auto_increment"));

        }

        public bool AllowNull() {

            return (!Null.Equals("NO") && Default != null);
        }

    }
}
