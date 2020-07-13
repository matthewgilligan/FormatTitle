using System;

namespace FormatTitle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var format = new Format();

            var move = format.DoIt("WhatsTheMove", true);
            var acc = format.DoIt("USDIsAmericanDollers", true);
            var jpy = format.DoIt("JPY_Funding", true);
            var baby = format.DoIt("Come_On_Baby", true);

            Console.WriteLine(move);
            Console.WriteLine(acc);
            Console.WriteLine(empty);
            Console.WriteLine(jpy);
            Console.WriteLine(baby);
        }
    }
}
