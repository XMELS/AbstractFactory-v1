using Equipment.ChainMails;
using System;
using System.Collections.Generic;
namespace Factories.ArmorFactories
{
    internal sealed class ChainMailFactory : ArmorFactory
    {
        private ChainMailFactory()
        {
            FillTypes(typeof(ChainMail));
        }
        private static ChainMailFactory chainMailFactory;
        public static ChainMailFactory Create()
        {
            return chainMailFactory ?? new ChainMailFactory();
        }
    }
}