﻿using System;

namespace JqGridHelper.Utils
{
    public static class ReflectionHelper
    {
        public static Type FindFieldType(this Type type, string fieldName, string parent = "", int dumpLevel = 3)
        {
            foreach (var property in type.GetProperties())
            {
                if (parent + property.Name == fieldName)
                    return property.PropertyType;

                if (parent.Split('.').Length > dumpLevel ||
                    property.PropertyType.Name.Equals(parent.TrimEnd('.')))
                    continue;

                if (isNestedProperty(property.PropertyType))
                {
                    var result = FindFieldType(property.PropertyType, fieldName, property.Name + ".", dumpLevel);
                    if (result != null)
                        return result;
                }
            }

            return null;
        }

        private static bool isNestedProperty(Type type)
        {
            if (type.Assembly.FullName.StartsWith("mscorlib", StringComparison.OrdinalIgnoreCase)) return false;
            return
                   (type.IsClass || type.IsInterface) &&
                   !type.IsValueType && type.Namespace != null &&
                   !string.IsNullOrEmpty(type.Namespace) &&
                   !type.Namespace.StartsWith("System.", StringComparison.OrdinalIgnoreCase);
        }
    }
}