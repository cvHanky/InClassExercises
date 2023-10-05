namespace Pr06_færdighedsøvelser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            double age1, age2, age3, age4, ageAvg;
            
            age1 = 21; age2 = 23; age3 = 21; age4 = 26;
            Console.WriteLine("Personerne ved bordets aldre er: \n{0} \n{1} \n{2} \n{3}\n", age1, age2, age3, age4);
            ageAvg = (age1 + age2 + age3 + age4) / 4;

            Console.WriteLine("Den gennemsnitlige alder ved bordet er {0}.",ageAvg);

            Console.ReadKey();

            bool fortsætprogram = true;*/

            

            double[] ages = new double[500];
            double ageAvg;
            double avgTop = 0;

            int countOuter = 0;
            bool ageRunning = true;

            while (ageRunning = true)
            {
                Console.Clear();
                Console.Write("Tast 1 for at indtaste en ny alder, tast 2 for at fortsætte...");
                int menuTast = int.Parse(Console.ReadLine());
                if (menuTast == 1)
                {
                    Console.Write("Indtast alder: ");
                    ages[countOuter] = int.Parse((Console.ReadLine()));
                    countOuter++;
                }
                else if (menuTast == 2)
                {
                    Console.Clear();
                    ageRunning = false;
                    for (int countInner = 0; countInner < countOuter; countInner++)
                    {
                        if (countInner == 0)
                            Console.Write("Liste over alle aldrene: {0}", ages[countInner]);
                        else
                            Console.Write(" {0}", ages[countInner]);
                    }
                    break;
                }
            }
            /*
            ages[0] = 21; ages[1] = 23; ages[2] = 21; ages[3] = 26;

            for (int count = 0; count < ages.Length; count++)
            {
                Console.WriteLine(ages[count]);
                avgTop += ages[count];
                if (count == ages.Length - 1)
                    Console.WriteLine((avgTop)/ages.Length);
            }
            */
            Console.WriteLine("\n\nTryk på en knap for at afslutte...");
            Console.ReadKey();
                
        }
    }
}