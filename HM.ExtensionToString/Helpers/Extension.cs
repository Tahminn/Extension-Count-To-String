using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HM.ExtensionToString.Helpers
{
    public static class Extension
    {
        public static int PatternChecker(this string str, string pattern)
        {
            return Regex.Matches(str, pattern).Count;
        }
    }
}
