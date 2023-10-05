using System;

namespace Pr02_conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Navn: ");
            string nameString = Console.ReadLine();
            Console.Write("Alder: ");
            string ageString = Console.ReadLine();
            string personType = "";                      // Tom variabel der ændres på senere. Vigtigt at den defineres nu for at gøre det til en global variabel.

            if (int.TryParse(ageString, out int age))    // Prøver at omdanne alderen fra string til int. Returnerer "false" hvis det ikke lykkedes.
            {
                if (age < 0)
                    Console.WriteLine("Alderen kan ikke være under 0.");
                else if (age >= 0 && age <= 12)
                    personType = "et barn";
                else if (age >= 13 && age <= 19)
                    personType = "en teenager";
                else if (age >= 20 && age <= 25)
                    personType = "en studerende";
                else if (age >= 26 && age <= 67)
                    personType = "i arbejde";
                else if (age > 67 && age < 120)
                    personType = "en pensionist";
                else if (age >= 120)
                    personType = "død";
            }
            else
                Console.WriteLine("Alderen du indtastede er ikke et tal.");  // Dette printes hvis "int.TryParse" ikke virkede.

            if (personType != "")
                Console.WriteLine(nameString + " er " + age + " år gammel og er " + personType + ".");
        }
    }
}