using HM.ExtensionToString.Helpers;
using System;

namespace HM.ExtensionToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Biz birlikde derse gede, birlikde oxuya ve yaza bilerik";
            int checker = text.PatternChecker("birlikde");
            Console.WriteLine(checker);

        }
    }
}
