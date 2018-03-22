using System;
using System.Text.RegularExpressions;

namespace Feeds.Views.Home
{
    /// <summary>
    /// Extension for removing unwanted characters from output text
    /// </summary>
    public static class EntityExtension
    {
        /// <summary>
        /// Method for removing unwanted characters from output
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string RemoveEntity(this string text)
        {
            if (text != null)
            {
                string pattern = "&.{7};|&.{8};|¶";
                Regex rgx = new Regex(pattern);
                text = rgx.Replace(text, String.Empty);
                return text;
            }
            else
            {
                return String.Empty;
            }
        }
    }
}