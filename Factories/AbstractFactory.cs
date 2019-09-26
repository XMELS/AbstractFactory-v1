using System;
using System.Collections.Generic;
using Equipment;
namespace Factories
{
    public abstract class AbstractFactory
    {
        //protected Dictionary<string, Type> _types;
        //protected void ValidateType(string type)
        //{

        //}

        public abstract Weapon CreateWeapon(string type);
        public abstract Armor CreateArmor(string type);
    }
}