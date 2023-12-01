using Pr33_Meddelsessystem_med_delegates.Domain;

namespace Pr33_Meddelsessystem_med_delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Academy("UCL", "Seebladsgade");

            var s1 = new Student(p, "Jens");
            var s2 = new Student(p, "Niels");
            var s3 = new Student(p, "Susan");

            p.MessageChanged += s1.Update;
            p.MessageChanged += s2.Update;
            p.MessageChanged = null;
            p.MessageChanged += s3.Update;

            p.Message = "Så er der julefrokost!";

            p.MessageChanged -= s2.Update;

            p.Message = "Så er der fredagsbar!";

            Console.ReadKey();
        }

    }
}