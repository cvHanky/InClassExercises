namespace Pr34_Metronome_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metronome metronome = new Metronome(5, 3);
            TickListener tickListener = new TickListener();
            metronome.Tick += tickListener.SoundHeard;

            metronome.RunMetronome();

            Console.ReadKey();
        }
    }
}