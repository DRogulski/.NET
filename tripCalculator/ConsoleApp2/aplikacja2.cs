
using System;
using System.Threading;   // for pauses- Thread.Sleep()

class BeepMethodSample
{
    static void Main()
    {
        ConsoleKeyInfo key1;   // or var but only in assign:    var key1 = Console.ReadKey(); 

        Console.WriteLine("----------- Play beep music --------------");
        Console.WriteLine("<up>-scale,<Down>-Happybirthday<Right>ra<left>mario");
        while (true){
            Console.WriteLine("press an arrow key or esc to exit");
            key1 = Console.ReadKey();
            switch (key1.Key)
            {

                case ConsoleKey.UpArrow: BeepMusic.BeepScale(); break;
                case ConsoleKey.DownArrow: BeepMusic.BeepHappyBirthday(); break;
                case ConsoleKey.LeftArrow: BeepMusic.BeepMario(); break;
                case ConsoleKey.RightArrow: BeepMusic.BeepRandom(); break;
                case ConsoleKey.Escape: return;
            }



        }
    }
}

public class BeepMusic
{
    // notes and the corresponding frequencies
    static int C = 264;
    static int D = 297;
    static int E = 330;
    static int F = 352;
    static int G = 396;
    static int A = 440;
    static int Bb = 466;
    static int B = 495;
    static int C2 = 528;

    // the tempo for a note, half note, quarter note, and eighth note.
    static int note = 1000;
    static int half = 1000 / 2;
    static int quarter = 1000 / 4;
    static int eighth = 1000 / 8;


    public static void BeepScale()
    {
        Console.WriteLine("------------------Scale-------------------");
        Thread.Sleep(2000);
        Console.Beep(C, quarter);
        Console.Beep(D, quarter);
        Console.Beep(E, quarter);
        Console.Beep(F, quarter);
        Console.Beep(G, quarter);
        Console.Beep(A, quarter);
        Console.Beep(B, quarter);
        Console.Beep(C2, half);
        Thread.Sleep(quarter);
        Console.Beep(C2, quarter);
        Console.Beep(B, quarter);
        Console.Beep(A, quarter);
        Console.Beep(G, quarter);
        Console.Beep(F, quarter);
        Console.Beep(E, quarter);
        Console.Beep(D, quarter);
        Console.Beep(C, half);
    }
    public static void BeepHappyBirthday()
    {
        Console.WriteLine("-------------Happy Birthday----------------");
        Thread.Sleep(2000);
        Console.Beep(C, eighth);
        Thread.Sleep(quarter);
        Console.Beep(C, eighth);
        Thread.Sleep(eighth);
        Console.Beep(D, half);
        Thread.Sleep(eighth);
        Console.Beep(C, half);
        Thread.Sleep(eighth);
        Console.Beep(F, half);
        Thread.Sleep(eighth);
        Console.Beep(E, note);
        Thread.Sleep(quarter);

        Console.Beep(C, eighth);
        Thread.Sleep(quarter);
        Console.Beep(C, eighth);
        Thread.Sleep(eighth);
        Console.Beep(D, half);
        Thread.Sleep(eighth);
        Console.Beep(C, half);
        Thread.Sleep(eighth);
        Console.Beep(G, half);
        Thread.Sleep(eighth);
        Console.Beep(F, note);

        Thread.Sleep(quarter);
        Console.Beep(C, eighth);
        Thread.Sleep(quarter);
        Console.Beep(C, eighth);
        Thread.Sleep(eighth);
        Console.Beep(C2, half);
        Thread.Sleep(eighth);
        Console.Beep(A, half);
        Thread.Sleep(eighth);
        Console.Beep(F, quarter);
        Thread.Sleep(eighth);
        Console.Beep(F, eighth);
        Thread.Sleep(eighth);
        Console.Beep(E, half);
        Thread.Sleep(eighth);
        Console.Beep(D, note);

        Thread.Sleep(quarter);
        Console.Beep(Bb, eighth);
        Thread.Sleep(quarter);
        Console.Beep(Bb, eighth);
        Thread.Sleep(eighth);
        Console.Beep(A, half);
        Thread.Sleep(eighth);
        Console.Beep(F, half);
        Thread.Sleep(eighth);
        Console.Beep(G, half);
        Thread.Sleep(eighth);
        Console.Beep(F, note);
    }

    public static void BeepMario()
    {
        Console.WriteLine("-------------Mario----------------");
        Console.Beep(658, 125);
        Console.Beep(1320, 500);
        Console.Beep(990, 250);
        Console.Beep(1056, 250);
        Console.Beep(1188, 250);
        Console.Beep(1320, 125);
        Console.Beep(1188, 125);
        Console.Beep(1056, 250);
        Console.Beep(990, 250);
        Console.Beep(880, 500);
        Console.Beep(880, 250);
        Console.Beep(1056, 250);
        Console.Beep(1320, 500);
        Console.Beep(1188, 250);
        Console.Beep(1056, 250);
        Console.Beep(990, 750);
        Console.Beep(1056, 250);
        Console.Beep(1188, 500);
        Console.Beep(1320, 500);
        Console.Beep(1056, 500);
        Console.Beep(880, 500);
        Console.Beep(880, 500);
        Thread.Sleep(250);
        Console.Beep(1188, 500);
        Console.Beep(1408, 250);
        Console.Beep(1760, 500);
        Console.Beep(1584, 250);
        Console.Beep(1408, 250);
        Console.Beep(1320, 750);
        Console.Beep(1056, 250);
        Console.Beep(1320, 500);
        Console.Beep(1188, 250);
        Console.Beep(1056, 250);
        Console.Beep(990, 500);
        Console.Beep(990, 250);
        Console.Beep(1056, 250);
        Console.Beep(1188, 500);
        Console.Beep(1320, 500);
        Console.Beep(1056, 500);
        Console.Beep(880, 500);
        Console.Beep(880, 500);
        Thread.Sleep(500);
        Console.Beep(1320, 500);
        Console.Beep(990, 250);
        Console.Beep(1056, 250);
        Console.Beep(1188, 250);
        Console.Beep(1320, 125);
        Console.Beep(1188, 125);
        Console.Beep(1056, 250);
        Console.Beep(990, 250);
        Console.Beep(880, 500);
        Console.Beep(880, 250);
        Console.Beep(1056, 250);
        Console.Beep(1320, 500);
        Console.Beep(1188, 250);
        Console.Beep(1056, 250);
        Console.Beep(990, 750);
        Console.Beep(1056, 250);
        Console.Beep(1188, 500);
        Console.Beep(1320, 500);
        Console.Beep(1056, 500);
        Console.Beep(880, 500);
        Console.Beep(880, 500);
        Thread.Sleep(250);
        Console.Beep(1188, 500);
        Console.Beep(1408, 250);
        Console.Beep(1760, 500);
        Console.Beep(1584, 250);
        Console.Beep(1408, 250);
        Console.Beep(1320, 750);
        Console.Beep(1056, 250);
        Console.Beep(1320, 500);
        Console.Beep(1188, 250);
        Console.Beep(1056, 250);
        Console.Beep(990, 500);
        Console.Beep(990, 250);
        Console.Beep(1056, 250);
        Console.Beep(1188, 500);
        Console.Beep(1320, 500);
        Console.Beep(1056, 500);
        Console.Beep(880, 500);
        Console.Beep(880, 500);
    }
    public static void BeepRandom()
    {
        Thread.Sleep(2000);
        // Some random sounds that should remind you of some old, old games:
        Console.WriteLine("-----------------Random sounds-----------------");

        Random randomSounds = new Random();
        for (int i = 0; i < 100; i++)
        {
            Console.Beep(randomSounds.Next(1000) + 100, 100);
        }
    }
}
