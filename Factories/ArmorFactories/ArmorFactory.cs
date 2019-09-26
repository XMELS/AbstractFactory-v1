using Equipment;
using Factories.Extensions;
namespace Factories.ArmorFactories
{
    internal abstract class ArmorFactory : EquipmentFactory
    {
        public Armor Create(string type)
        {
            ValidateTypeName(type);
            return Types[type].CreateObjectWithoutParametrsByType<Armor>();
        }
    }
}