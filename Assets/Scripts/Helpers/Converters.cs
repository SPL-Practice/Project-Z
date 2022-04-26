using System;

namespace Helpers
{
    public static class Converters
    {
        public static int ToInt(this object value)
        {
            return Convert.ToInt32(value);
        }
    }
}