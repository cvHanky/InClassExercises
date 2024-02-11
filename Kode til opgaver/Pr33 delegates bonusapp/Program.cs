namespace Pr33_delegates_bonusapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            int c = 6;
            int d = 10;

            if (a == 1 && b == 3 && c == 5 || d == 10)
                Console.WriteLine("it works!");
            else Console.WriteLine("no!");

            Console.ReadKey();


            /*
            
            2.  int CompareTo(int other)
            3.  int Factorial(int n)                        Func<int,int>
            7.  int Fibonacci(int n)

            13. int RectangleArea(int height, int width)    Func<int,int,int>

            4.  void Delete(int index)                      Action<int>

            8.  void NotifySubscribers(string message)      Action<string>
            11. void ShowScore(string tournamentName)

            6.  string GetUserChoice()                      Func<string, void>
            9.  string GetAllPets()

            5.  bool Exist(int id)                          Predicate<int>
            12. bool Contains(int id)

            10. bool IsMatchesFinished()                    Predicate<void>

            1.  double Calculate(string expression)         Func<string, double>

            */
        }
    }
}