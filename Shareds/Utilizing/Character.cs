﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Shareds.Utilizing
{
    /// <summary>
    /// 
    /// </summary>
    public static class Character
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static string Remove(this string message, IEnumerable<char> chars)
        {
            return new string(message.Where(o => !chars.Contains(o)).ToArray());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public static IEnumerable<int> IndexOfAll(this string source, string keywords)
        {
            keywords = Regex.Escape(keywords);

            foreach (Match match in Regex.Matches(source, keywords))
            {
                yield return match.Index;
            }
        }
    }
}