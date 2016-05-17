using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GTSoft.Win.Morse
{
    class Program
    {
        static void Main(string[] args)
        {
            GTSoft.Win.MorseDecoder.MorseDecoder decoder = new GTSoft.Win.MorseDecoder.MorseDecoder();
            GTSoft.Win.MorseDecoder.MorseReader reader = new MorseDecoder.MorseReader(1000);
            bool ok = true;
            while (ok)
            {
                string morse = "-.#.#-#-..#..-#..#-.#--- -..#---#.#... --#---#.-.#...#.";
                string decode = decoder.Translate(morse);
                Console.WriteLine(decode);
                Console.ReadLine();
                //ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                //if (keyInfo.KeyChar == 's')
                //{
                //    ok = false;
                //}
                //else
                //{
                //    if (reader.Decode(keyInfo.KeyChar))
                //    {
                //        Console.Write(decoder.Translate(reader.ToString()));
                //        reader.Reset();
                //    }
                //}
            }
        }
    }
}
