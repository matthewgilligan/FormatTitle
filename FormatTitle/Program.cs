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

            Console.WriteLine(move);
            Console.WriteLine(acc);
        }
    }
}
