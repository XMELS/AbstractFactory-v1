using Factories.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Factories
{
    internal class EquipmentFactory
    {
        protected void ValidateTypeName(string typeName)
        {
            if (typeName.IsNullOrEmpty()) throw new ArgumentNullException("Тип не может быть null или пустой строкой");
            if (!Types.ContainsKey(typeName))
                throw new ArgumentException("не существует такого типа брони");
        }
        protected Dictionary<string, Type> Types = new Dictionary<string, Type>();
        protected void FillTypes(Type baseType)
        {
            if (baseType == null) throw new ArgumentException("One or more arguments is null");
            //var res = typeof(Bow).GetType().Assembly; Возвращает все типы
            var assembly = Assembly.Load(new AssemblyName(baseType.GetTypeInfo().Assembly.FullName));
            var res = assembly.GetTypes().Where(t => t.GetTypeInfo().BaseType == baseType);
            foreach (var el in res)
            {
                Types.Add(el.Name, el);
            }
        }
    }
}
