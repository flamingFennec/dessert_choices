using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dessert_choices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AskForDessert();
        }

        static void AskForDessert()
        {
            Console.WriteLine("Would you like dessert? (yes/no)");
            string userResponse = Console.ReadLine().Trim().ToLower();

            if (userResponse == "yes")
            {
                Console.WriteLine("Great choice! Here are some dessert options:");
                List<string> dessertOptions = new List<string>
            {
                "Rose Water Rice Pudding",
                "Tres Leches Cake",
                "Kulfi",
                "Bread Pudding",
                "Beignets"
            };

                foreach (string dessert in dessertOptions)
                {
                    Console.WriteLine("- " + dessert);
                }

                Console.WriteLine("Please enter the name of the dessert you'd like:");
                string selectedDessert = Console.ReadLine().Trim();

                if (dessertOptions.Contains(selectedDessert, StringComparer.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Excellent choice. I will get {selectedDessert} right away.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("I'm sorry, that dessert is not on the menu.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("No worries, I'll grab the check.");
                Console.ReadKey();
            }
        }
    }
}