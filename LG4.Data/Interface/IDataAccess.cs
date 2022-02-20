using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Data.Interface {
    public interface IDataAccess<T> {

        T Consult(int cod);

        T List(String search);

        void Insert(T obj);

        void Update(T obj);

    }
}
