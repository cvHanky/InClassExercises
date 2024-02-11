namespace Quickbrownfoxjumpedoverthebingbong
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;

    /**
     * Auto-generated code below aims at helping you parse
     * the standard input according to the problem statement.
     **/
    class Solution
    {
        static void Main(string[] args)
        {
            string phrase1 = Console.ReadLine();
            string phrase1BrailleTopRow = Console.ReadLine();
            string phrase1BrailleMidRow = Console.ReadLine();
            string phrase1BrailleBotRow = Console.ReadLine();
            string dividingLine = Console.ReadLine();
            string phrase2BrailleTopRow = Console.ReadLine();
            string phrase2BrailleMidRow = Console.ReadLine();
            string phrase2BrailleBotRow = Console.ReadLine();

            string newWord = "";

            for (int i = 0; i < phrase2BrailleTopRow.Length / 3 + 1; i++)
            {
                for (int j = 0; j < phrase1BrailleTopRow.Length / 3 + 1; j++)
                {
                    if (phrase2BrailleTopRow[i * 3] == phrase1BrailleTopRow[j * 3] &&
                    phrase2BrailleTopRow[i * 3 + 1] == phrase1BrailleTopRow[j * 3 + 1])
                    {
                        if (phrase2BrailleMidRow[i * 3] == phrase1BrailleMidRow[j * 3] &&
                    phrase2BrailleMidRow[i * 3 + 1] == phrase1BrailleMidRow[j * 3 + 1])
                        {
                            if (phrase2BrailleBotRow[i * 3] == phrase1BrailleBotRow[j * 3] &&
                        phrase2BrailleBotRow[i * 3 + 1] == phrase1BrailleBotRow[j * 3 + 1])
                            {
                                newWord += phrase1[j];
                            }
                        }
                    }
                }
            }

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(newWord);

            Console.ReadKey();
        }
    }
}
