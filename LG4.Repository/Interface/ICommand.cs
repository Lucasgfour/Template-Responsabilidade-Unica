using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Repository.Interface {
    public interface ICommand {

        int Execute();
        T Read<T>();
        List<T> ReadAll<T>();
        void NewParameter(string name, object value);


    }
}
