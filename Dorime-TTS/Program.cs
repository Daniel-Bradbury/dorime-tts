using System;
using System.Media;
namespace Dorime_TTS
{
    class Dorime
    {
        static SoundPlayer _a = new SoundPlayer(@"./audio/a.wav");
        static SoundPlayer _a2 = new SoundPlayer(@"./audio/a2.wav");
        static SoundPlayer _d = new SoundPlayer(@"./audio/d.wav");
        static SoundPlayer _da = new SoundPlayer(@"./audio/da.wav");
        static SoundPlayer _do = new SoundPlayer(@"./audio/do.wav");
        static SoundPlayer _i = new SoundPlayer(@"./audio/i.wav");
        static SoundPlayer _la = new SoundPlayer(@"./audio/la.wav");
        static SoundPlayer _me = new SoundPlayer(@"./audio/me.wav");
        static SoundPlayer _me2 = new SoundPlayer(@"./audio/me2.wav");
        static SoundPlayer _mo = new SoundPlayer(@"./audio/mo.wav");
        static SoundPlayer _mo2 = new SoundPlayer(@"./audio/mo2.wav");
        static SoundPlayer _n = new SoundPlayer(@"./audio/n.wav");
        static SoundPlayer _no = new SoundPlayer(@"./audio/no.wav");
        static SoundPlayer _o = new SoundPlayer(@"./audio/o.wav");
        static SoundPlayer _pa = new SoundPlayer(@"./audio/pa.wav");
        static SoundPlayer _re = new SoundPlayer(@"./audio/re.wav");
        static SoundPlayer _re2 = new SoundPlayer(@"./audio/re2.wav");
        static SoundPlayer _ri = new SoundPlayer(@"./audio/ri.wav");
        static SoundPlayer _t = new SoundPlayer(@"./audio/t.wav");
        static SoundPlayer _te = new SoundPlayer(@"./audio/te.wav");
        static SoundPlayer _ti = new SoundPlayer(@"./audio/ti.wav");
        static Boolean Sound(String inp)
        {
            if (soundArray[position] == inp)
            {
                return true;
            }
            return false;
        }
        static String[] soundArray;
        static int position;
        public static void TTS(String[] input)
        {
            for (int i=0; i<input.Length; i++)
            {
                soundArray = input;
                position = i;
                if (Sound("a")) { _a.PlaySync(); }
                if (Sound("a2")) { _a2.PlaySync(); }
                if (Sound("d")) { _d.PlaySync(); }
                if (Sound("da")) { _da.PlaySync(); }
                if (Sound("do")) { _do.PlaySync(); }
                if (Sound("i")) { _i.PlaySync(); }
                if (Sound("la")) { _la.PlaySync(); }
                if (Sound("me")) { _me.PlaySync(); }
                if (Sound("me2")) { _me2.PlaySync(); }
                if (Sound("mo")) { _mo.PlaySync(); }
                if (Sound("mo2")) { _mo2.PlaySync(); }
                if (Sound("n")) { _n.PlaySync(); }
                if (Sound("no")) { _no.PlaySync(); }
                if (Sound("o")) { _o.PlaySync(); }
                if (Sound("pa")) { _pa.PlaySync(); }
                if (Sound("re")) { _re.PlaySync(); }
                if (Sound("re2")) { _re2.PlaySync(); }
                if (Sound("ri")) { _ri.PlaySync(); }
                if (Sound("t")) { _t.PlaySync(); }
                if (Sound("te")) { _te.PlaySync(); }
                if (Sound("ti")) { _ti.PlaySync(); }
            }
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Dorime-TTS");
            Dorime.TTS(new String[] {"la", "ti", "n", "do", "ri", "t", "o"});
        }
    }
}
