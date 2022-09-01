using System;

namespace SSMS
{
    public static class TypeExtensions
    {
        public static bool IsAssignableTo(this Type type, Type c) => c.IsAssignableFrom(type);
    }
}
