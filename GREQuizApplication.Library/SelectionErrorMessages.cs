using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplicationLibrary
{
    public static class SelectionErrorMessages
    {
        private static StringBuilder sb = new StringBuilder();
        private const string starting = "";
        private const string PleaseSelectA = "Please Select a ";
        private const string ending = "!";

        public static string GetErrorMessageFor(Type type)
        {
            sb.Remove(0, sb.Length);

            sb.Append(starting);
            sb.Append(PleaseSelectA);
            sb.Append(type.Name);
            sb.Append(ending);

            return sb.ToString();
        }
    }
}
