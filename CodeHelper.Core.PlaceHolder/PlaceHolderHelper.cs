using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
namespace CodeHelper.Core.PlaceHolder
{
    public static class PlaceHolderHelper
    {
        /// <summary>
        /// Replace the placeholders in a text with the values of the object
        /// </summary>
        /// <param name="text">String: the text containing the placeholders</param>
        /// <param name="MyObject">object: the object containing the values to replace the placeholders</param>
        /// <returns>string: the original text with the placeholders replaced with the real values.</returns>
        public static string Replace(string text, object MyObject)
        {
            if (MyObject != null)
            {
                List<PropertyInfo> placeholders = MyObject.GetType().GetProperties().ToList().FindAll(p => p.GetCustomAttribute(typeof(PlaceholderAttribute)) != null);
                if (placeholders != null && placeholders.Count != 0)
                {
                    foreach (PropertyInfo placeholder in placeholders)
                        text = text.Replace(((PlaceholderAttribute)placeholder.GetCustomAttribute(typeof(PlaceholderAttribute))).Text, Convert.ToString(placeholder.GetValue(MyObject)));
                }
            }
            return text;
        }
    }
}
