using System;
using System.Media;
using System.IO;
using System.Reflection;
namespace Dorime_TTS
{
    class Dorime
    {
        static SoundPlayer _a = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/a.wav");
        static SoundPlayer _a2 = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/a2.wav");
        static SoundPlayer _d = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/d.wav");
        static SoundPlayer _da = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/da.wav");
        static SoundPlayer _do = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/do.wav");
        static SoundPlayer _i = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/i.wav");
        static SoundPlayer _la = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/la.wav");
        static SoundPlayer _me = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/me.wav");
        static SoundPlayer _me2 = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/me2.wav");
        static SoundPlayer _mo = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/mo.wav");
        static SoundPlayer _mo2 = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/mo2.wav");
        static SoundPlayer _n = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/n.wav");
        static SoundPlayer _no = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/no.wav");
        static SoundPlayer _o = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/o.wav");
        static SoundPlayer _pa = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/pa.wav");
        static SoundPlayer _re = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/re.wav");
        static SoundPlayer _re2 = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/re2.wav");
        static SoundPlayer _ri = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/ri.wav");
        static SoundPlayer _t = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/t.wav");
        static SoundPlayer _te = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/te.wav");
        static SoundPlayer _ti = new SoundPlayer(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)+@"/audio/ti.wav");
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
            Console.WriteLine("Playing...");
            Dorime.TTS(args);
        }
    }
}
