using Pr33_Meddelsessystem_med_delegates.Domain;

namespace Pr33_Meddelsessystem_med_delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Academy("UCL", "Seebladsgade");

            var s1 = new Student("Jens");
            var s2 = new Student("Niels");
            var s3 = new Student("Susan");

            p.PropertyChanged += s1.Update;
            p.PropertyChanged += s2.Update;
            p.PropertyChanged += s3.Update;

            p.Message = "Så er der julefrokost!";

            p.PropertyChanged -= s2.Update;

            p.Message = "Så er der fredagsbar!";

            Console.ReadKey();
        }

    }
}