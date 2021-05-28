using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplicationLibrary
{
    public class StringHelpers
    {
        /// <summary>
        /// Convert the word(s) in the sentence to sentence case.
        /// UPPER = Upper
        /// lower = Lower
        /// MiXEd = Mixed
        /// </summary>
        /// <param name="s"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static string ToSentanceCase(string s, char delimiter)
        {
            // Check null/empty
            if (string.IsNullOrEmpty(s))
                return s;

            s = s.Trim();
            if (string.IsNullOrEmpty(s))
                return s;

            // Only 1 token
            if (s.IndexOf(delimiter) < 0)
            {
                s = s.ToLower();
                s = s[0].ToString().ToUpper() + s.Substring(1);
                return s;
            }

            // More than 1 token.
            string[] tokens = s.Split(delimiter);
            StringBuilder buffer = new StringBuilder();

            foreach (string token in tokens)
            {
                string currentToken = token.ToLower();
                currentToken = currentToken[0].ToString().ToUpper() + currentToken.Substring(1);
                buffer.Append(currentToken + delimiter);
            }

            s = buffer.ToString();
            return s.TrimEnd(delimiter);
        }
    }
}
