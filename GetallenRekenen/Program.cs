using System;

namespace GetallenRekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ik kan het gemiddlede van drie getallen voor je uitrekenen!");

            Console.WriteLine("type het eertste getal");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("type het tweede getal");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("type het derde getal");
            int thurd = Convert.ToInt32(Console.ReadLine());

            int opgeteld = first + second + thurd;

            int gemiddelde = opgeteld / 3;

            Console.WriteLine("Het gemiddelde is:");
            Console.WriteLine(gemiddelde);
            */

            /*
            Console.WriteLine("hoeveel Liter past er in je Tank?");
            decimal tank = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("En wat is de prijs van de benzien in liters?");

            decimal test = Convert.ToDecimal(Console.ReadLine());
            decimal litersss = tank * test;
            Console.WriteLine(litersss);
            */

            string test = "1,16";
            decimal eenDollar = Convert.ToDecimal(test);
            decimal hoeveelheid = Convert.ToDecimal(Console.ReadLine());
            decimal dollar = hoeveelheid * eenDollar;

            Console.WriteLine(dollar);

        }
    }
}
