using System;

namespace GTSoft.Win.MorseDecoder
{
    public class MorseDecoder
    {
        public class MorseLetter
        {
            public char Letter { get; private set; }
            public MorseLetter Dot { get; internal set; }
            public MorseLetter Dash { get; internal set; }

            public MorseLetter(char letter = (char)0, MorseLetter dot = null, MorseLetter dash = null) 
            {
                Letter = letter;
                Dot = dot;
                Dash = dash;
            }
        }

        private MorseLetter baseLetter = new MorseLetter();

        public MorseDecoder()
        {
            MorseLetter chE = new MorseLetter('E');
            baseLetter.Dot = chE;
            MorseLetter chT = new MorseLetter('T');
            baseLetter.Dash = chT;

            MorseLetter chA = new MorseLetter('A'); 
            chE.Dash = chA;
            MorseLetter chI = new MorseLetter('I'); 
            chE.Dot = chI;
            MorseLetter chM = new MorseLetter('M'); 
            chT.Dash = chM;
            MorseLetter chN = new MorseLetter('N'); 
            chT.Dot = chN;


            MorseLetter chD = new MorseLetter('D'); 
            chN.Dot = chD;
            MorseLetter chB = new MorseLetter('B'); 
            chD.Dot = chB;
            MorseLetter chX = new MorseLetter('X'); 
            chD.Dash = chX;

            MorseLetter chG = new MorseLetter('G'); 
            chM.Dot = chG;
            MorseLetter chZ = new MorseLetter('Z'); 
            chG.Dot = chZ;
            MorseLetter chQ = new MorseLetter('Q'); 
            chG.Dash = chQ;

            MorseLetter chK = new MorseLetter('K'); 
            chN.Dash = chK;
            MorseLetter chC = new MorseLetter('C'); 
            chK.Dot = chC;
            MorseLetter chY = new MorseLetter('Y'); 
            chK.Dash = chY;

            MorseLetter chO = new MorseLetter('O'); 
            chM.Dash = chO;

            MorseLetter chR = new MorseLetter('R'); 
            chA.Dot = chR;
            MorseLetter chL = new MorseLetter('L'); 
            chR.Dot = chL;

            MorseLetter chS = new MorseLetter('S');
            chI.Dot = chS;
            MorseLetter chH = new MorseLetter('H'); 
            chS.Dot = chH;
            MorseLetter chV = new MorseLetter('V'); 
            chS.Dash = chV;

            MorseLetter chU = new MorseLetter('U'); 
            chI.Dash = chU;
            MorseLetter chF = new MorseLetter('F'); 
            chU.Dot = chF;

            MorseLetter chW = new MorseLetter('W'); 
            chA.Dash = chW;
            MorseLetter chP = new MorseLetter('P'); 
            chW.Dot = chP;
            MorseLetter chJ = new MorseLetter('J'); 
            chW.Dash = chJ;
        }

        public string Translate(string morse)
        {
            string decode = "";
	        ushort pos = 0;
	        MorseLetter letter = baseLetter;
	        while (pos < morse.Length ) 
            {
		        if (morse[pos] == '.') 
                {
			        letter = letter.Dot;
		        }
		        else if (morse[pos] == '-') 
                {
			        letter = letter.Dash;
		        }
		        else if (morse[pos] == '#') {
			        decode += letter.Letter;
			        letter = baseLetter;
		        }
		        else if (morse[pos] == ' ') {
			        decode += letter.Letter;
                    decode += ' ';
			        letter = baseLetter;
		        }
		        pos++;
	        }
            decode += letter.Letter;
	        return decode;
        }
 
    }
}
