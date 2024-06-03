using System;
using System.Collections.Generic;
using System.Text;

namespace codeProduce
{
    public class CodeGenerator
    {
        private static readonly char[] allowedChars = "ACDEFGHKLMNPRTXYZ234579".ToCharArray();
        private static readonly int codeLength = 8;
        private static HashSet<string> generatedCodes = new HashSet<string>();
        private static Random random = new Random();

        public static string GenerateCode()
        {
            StringBuilder sb;
            string newCode;
            do
            {
                sb = new StringBuilder(codeLength);
                for (int i = 0; i < codeLength; i++)
                {
                    sb.Append(allowedChars[random.Next(allowedChars.Length)]);
                }
                newCode = sb.ToString();
            }
            while (!generatedCodes.Add(newCode));

            return newCode;
        }

        public static List<string> GenerateCodes(int quantity)
        {
            List<string> codes = new List<string>();
            for (int i = 0; i < quantity; i++)
            {
                codes.Add(GenerateCode());
            }
            return codes;
        }
    }
}
