using System;
using System.Collections.Generic;
namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            //-------------------------------------------


            //SKRIV MAIN-KOD HÄR
            UtskriftVarannan("hej jag heter hugo");
            UtskriftVarannan("håkon luktar mycket illa");
        }

        static void UtskriftVarannan(string utskrift)
        {
            string[] ord = utskrift.Split(' ');
            for (int i = 0; i < ord.Length; i++) 
            { 
                string tillfälligtOrd = i % 2 == 0 ? ord[i].ToUpper() : ord[i].ToLower();
                Console.Write(tillfälligtOrd + " ");
            }
            Console.WriteLine();
        }
    }
}
/*Skapa ett program som innehåller en metod som tar en sträng som parameter och
skriver ut strängen fast vartannat ord i strängen ska skrivas ut med enbart stora
bokstäver och vartannat ord med enbart små. Om metoden anropas med
argumentet Detta är ett exempel. Texten ändras när den skrivs ut. så ska utskriften bli DETTA
är ETT exempel. TEXTEN ändras NÄR den SKRIVS ut.*/