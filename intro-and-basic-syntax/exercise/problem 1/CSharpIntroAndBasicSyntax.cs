using System;
//CONFIRMED from mbrz
namespace CSharpIntroAndBasicSyntax
{
    class CSharpIntroAndBasicSyntax
    {
        static void Main()
        {
            int buffer = 1;
            string output = String.Empty;
            while (buffer <= 4)
            {
                string strInteger = Console.ReadLine();
                if (strInteger.Length < 4)
                {
                    strInteger = FormatIntegers(strInteger);
                }

                output += strInteger + " ";
                buffer++;
            }
            
            Console.WriteLine(output.Trim());
        }

        static string FormatIntegers(string integers)
        {
            return integers.PadLeft(4, '0');
        }
    }
}
