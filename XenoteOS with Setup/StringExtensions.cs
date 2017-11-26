
using System;
using System.Collections.Generic;

namespace dewitcher.Extensions
{
    /// <summary>
    /// Useful string extensions
    /// </summary>
    public static class StringExtensions
    {
        public static string rot13(this string str)
        {
            return Crypto.ROT13.encrypt(str);
        }
        public static string rot47(this string str)
        {
            return Crypto.ROT13.encrypt(str);
        }
        public static string md5(this string str)
        {
            return Crypto.MD5.hash(str);
        }
        public static string rockpotato(this string str)
        {
            return Crypto.RockPotato.Hash(str);
        }
        /// <summary>
        /// Checks if the string starts with [string]
        /// </summary>
        /// <param name="__str"></param>
        /// <param name="__expression"></param>
        /// <returns></returns>
        public static bool _StartsWith(this string __str, string __expression)
        {
            string str = "";
            if (__expression.Length <= __str.Length)
            {
                for (int i = 0; i < (__expression.Length); i++)
                {
                    str += __str[i];
                    if (str == __expression) return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Checks if the string ends with [string]
        /// </summary>
        /// <param name="__str"></param>
        /// <param name="__expression"></param>
        /// <returns></returns>
        public static bool _EndsWith(this string __str, string __expression)
        {
            string str = "";
            if (__expression.Length <= __str.Length)
            {
                for (int i = ((__str.Length - 1) - (__expression.Length - 1)); i == (__str.Length - 1); i++)
                {
                    str += __str[i];
                    if (str == __expression) return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Returns the char at position [string[index]]
        /// </summary>
        /// <param name="str"></param>
        /// <param name="null_based_index"></param>
        /// <returns></returns>
        public static char _GetCharAt(this string str, int null_based_index)
        {
            if (null_based_index >= 0 && null_based_index < str.Length)
                return str[null_based_index];
            else
            {
                Core.Bluescreen.Init("string._GetCharAt", "null_based_index must be >= 0 and <= the length of the string");
                return char.MinValue;
            }
        }
        /// <summary>
        /// Removes the char at position [string[index]]
        /// </summary>
        /// <param name="str"></param>
        /// <param name="null_based_index"></param>
        /// <returns></returns>
        public static string _RemoveCharAt(this string str, int null_based_index)
        {
            if (null_based_index < str.Length)
            {
                string _str = "";
                for (int i = 0; i < null_based_index; i++) _str += str[i];
                for (int i = null_based_index + 1; i < str.Length; i++) _str += str[i];
                return _str;
            }
            else
            {
                Core.Bluescreen.Init("string._GetCharAt", "null_based_index must be >= 0 and <= the length of the string");
                return str;
            }
        }
    }
}
