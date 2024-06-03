using System;
using System.Linq;

namespace codeProduce
{
    public class CodeValidator
    {
        private static readonly char[] allowedChars = "ACDEFGHKLMNPRTXYZ234579".ToCharArray();

        public static bool CheckCode(string code)
        {
            if (code.Length != 8)
            {
                return false;
            }

            return code.All(c => allowedChars.Contains(c));
        }
    }
}
