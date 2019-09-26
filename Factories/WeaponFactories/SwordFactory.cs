using Equipment.Swords;
using System;
using System.Collections.Generic;
namespace Factories.WeaponFactories
{
    internal sealed class SwordFactory : WeaponFactory
    {
        private SwordFactory()
        {
            FillTypes(typeof(Sword));
        }
        private static SwordFactory swordFactory;
        public static SwordFactory Create()
        {
            return swordFactory ?? new SwordFactory();
        }
    }
}