using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSoft.Win.MorseDecoder
{
    public class MorseReader
    {
        private string decode = "";
        private long start;
        private long delay;

        public MorseReader(long delay)
        {
            this.delay = delay;
        }

        public void Reset()
        {
            decode = "";
            start = DateTime.Now.Ticks;
        }

        public bool Decode(char ch)
        {
            decode += ch;
            return (ch == ' ' || ch == '#');
        }

        public override string ToString()
        {
 	        return decode.Trim();    
        }
    }
}
