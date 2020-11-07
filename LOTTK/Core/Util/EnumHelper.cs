using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Core.Util
{
    public static class EnumHelper
    {
        public static string GetDescription<T>(this T value) where T : struct 
        {
            string result = value.ToString();
            Type type = typeof(T);
            FieldInfo info = type.GetField(value.ToString());
            var attributes = info.GetCustomAttributes(typeof(DescriptionAttribute), true);
            if (attributes != null && attributes.FirstOrDefault() != null)
            {
                result = (attributes.First() as DescriptionAttribute).Description;
            }

            return result;
        }
    }
}
