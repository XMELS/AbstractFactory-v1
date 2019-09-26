using System;
using System.Linq;
using System.Collections.Generic;
using Equipment;
using Factories.Extensions;
using System.Reflection;
using System.Xml;

namespace Factories.WeaponFactories
{
    internal abstract class WeaponFactory : EquipmentFactory
    {
        public Weapon Create(string type)
        {
            ValidateTypeName(type);
            return Types[type].CreateObjectWithoutParametrsByType<Weapon>();
        }
    }
}