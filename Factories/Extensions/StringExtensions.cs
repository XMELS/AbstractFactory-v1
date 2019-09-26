using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Factories.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string str)
        {
            return str == null || !str.Any();
        }
    }
}
