using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplication
{
    class StringUtil
    {
        public static bool IsNullOrWhiteSpace(string str)
        {
            return (str == string.Empty)||(str==null);
        }
    }
}
