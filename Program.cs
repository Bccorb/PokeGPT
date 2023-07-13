using System;

namespace PokeGPT {
    // Main Class
    class Program {
        public const char regulationSet = 'D';
        static void Main(string[] args) {
            showBanner();
            string format = getFormat();
            formatVariations(format);
        }

        // Show the PokeGPT banner
        static void showBanner() {
            string app = "PokeGPT";
            string appVersion = "1.0.0";

            Console.WriteLine("/////////////////////////////////////////////////");
            Console.WriteLine("//// \t\t\t\t\t   //////");
            Console.WriteLine("//// \t Welcome to {0} - v{1}       //////", app, appVersion);
            Console.WriteLine("//// \t A competetive pokemon helper      //////");
            Console.WriteLine("//// \t\t\t\t\t   //////");
            Console.WriteLine("/////////////////////////////////////////////////");
            Console.WriteLine();
        }

        // Determine which competetive playstle the user is looking to play
        static string getFormat() {
            printConsoleMessage(ConsoleColor.Green, "Which competive pokemon league are you using? (VGC/SMOGON)");
            string format = Console.ReadLine();

            while(format.ToUpper() != "VGC" && format.ToUpper() != "SMOGON") {
                printConsoleMessage(ConsoleColor.Red, "We only support 'VGC' or 'SMOGON' competitve formats at this time. Please choose one of those.");
                printConsoleMessage(ConsoleColor.Green, "Which Competive pokemon league are you using? (VGC/SMOGON)");
                format = Console.ReadLine();
            }

            Console.WriteLine("{0} format... CHECK!", format.ToUpper());
            return format.ToUpper();
        }

        // Display a console message with the given color and message.
        // Reset the color afterwards
        static void printConsoleMessage(ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void formatVariations(string format) {
            if (format == "VGC") {
                printConsoleMessage(ConsoleColor.Green, "We are optimizing and recommended based on VGC regulation set - " + regulationSet);
            } else {
                string smogonTier = "";
                printConsoleMessage(ConsoleColor.Green, "Choose which SMOGON teir you would like a team build for? (Uber, OU, UU, RU, NU)");
                smogonTier = Console.ReadLine();

                while (smogonTier.ToUpper() != "Uber" && smogonTier.ToUpper() != "OU" && smogonTier.ToUpper() != "UU" && smogonTier.ToUpper() != "RU" && smogonTier.ToUpper() != "NU") {
                    printConsoleMessage(ConsoleColor.Red, "Please choose a valid teir. Uber, OU, UU, RU, or NU");
                    printConsoleMessage(ConsoleColor.Green, "Choose which SMOGON teir you would like a team build for? (Uber, OU, UU, RU, NU)");
                    smogonTier = Console.ReadLine();
                }

                printConsoleMessage(ConsoleColor.Green, "Okay! We will optimize for " + smogonTier + " teir");
            }
        }

        // Call pokeGPT api server to generate a team
        static void teamSuggestion() {

        }
    }
}