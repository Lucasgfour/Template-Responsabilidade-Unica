using System;

namespace LG4.Common.Utils {
    public static class RepositoryUtils {

        public static T NewInstance<T>() {
            T newObject = (T)Activator.CreateInstance(typeof(T), new object[] { });
            return newObject;
        }

    }
}
