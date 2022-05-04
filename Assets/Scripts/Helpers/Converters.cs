using System;
using UnityEngine;

namespace Helpers
{
    public static class Converters
    {
        public static ulong ToULong(this object value)
        {
            return Convert.ToUInt64(value);
        }

        public static int ToInt(this object value)
        {
            return Convert.ToInt32(value);
        }

        public static ushort ToUShort(this object value)
        {
            return Convert.ToUInt16(value);
        }

        public static Vector2 To2D(this object value)
        {
            return (Vector2)(value);
        }
    }
}