using Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factories.Extensions
{
    public static class TypeExtensions
    {
        public static object CreateObjectWithoutParametrs(this Type type)
        {
            var constructor = type?.GetConstructors()?.FirstOrDefault((x) => x.GetParameters().Count() == 0);
            object result = constructor?.Invoke(new object[0]);
            return result;
        }

        public static T CreateObjectWithoutParametrsByType<T>(this Type type) where T : Equip//шаблонный метод
        {
            var obj = type.CreateObjectWithoutParametrs();
            if (obj is T)
                return obj as T;
            throw new  ArgumentException("Incorrect type");
        }
    }
}
