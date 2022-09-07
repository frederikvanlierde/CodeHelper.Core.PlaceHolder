using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeHelper.Core.PlaceHolder
{
    public static class PlaceHolderHelper
    {
        /// <summary>
        /// Replace the placeholders in a text with the values of the object
        /// </summary>
        /// <param name="text">String: the text containing the placeholders</param>
        /// <param name="MyObject">object: the object containing the values to replace the placeholders</param>
        /// <param name="isUrl">Optional: set to true when your text is an url and you want the t</param>
        /// <returns>string: the original text with the placeholders replaced with the real values.</returns>
        public static string Replace(this string text, object MyObject, bool isUrl = false)
        {
            if (MyObject != null)
            {
                List<PropertyInfo> placeholders = MyObject.GetType().GetProperties().ToList().FindAll(p => p.GetCustomAttribute(typeof(PlaceholderAttribute)) != null);
                if (placeholders != null && placeholders.Count != 0)
                {
                    PlaceholderAttribute _placeholder;
                    string _replaceText;
                    foreach (PropertyInfo placeholder in placeholders)
                    { 
                        _placeholder = (PlaceholderAttribute)placeholder.GetCustomAttribute(typeof(PlaceholderAttribute));
                        try
                        {
                            _replaceText = string.Format("{0" + (string.IsNullOrEmpty(_placeholder.Format) ? "" : ":" + _placeholder.Format) + "}", placeholder.GetValue(MyObject));
                        }
                        catch
                        {
                            _replaceText =  Convert.ToString(placeholder.GetValue(MyObject));
                        }
                        text = text.Replace(_placeholder.Text, _replaceText);
                    }
                }
            }
            //-- removes the empty parameters
            if(isUrl)
                text = Regex.Replace(text, @"(?:^|&)[a-zA-Z]+=(?=&|$)", "");
            return text;
        }

        
    }
}
