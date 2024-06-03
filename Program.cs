using System;

namespace codeProduce
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 1000 adet benzersiz kod üretme
            var codes = CodeGenerator.GenerateCodes(1000);
            foreach (var code in codes)
            {
                Console.WriteLine(code);
            }

            // Kod geçerliliğini kontrol etme
            string testCode = codes[0];
            bool isValid = CodeValidator.CheckCode(testCode);
            Console.WriteLine($"Kod {testCode} geçerli mi? {isValid}");
        }
    }
}
