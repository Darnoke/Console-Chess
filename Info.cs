using System;

namespace coding
{
    class Info
    {
        public void check()
        {
            Console.WriteLine("Szach!");
        }
        public void stalemate()
        {
            Console.WriteLine("Pat! :(");
        }
        public void checkmate(char c)
        {
            string color = "Biały"; 
            if(c == 'W') color = "Czarny"; // reversed
            Console.WriteLine("Szach mat! Wygrywa gracz " + color);
        }
        public void error(string e)
        {
            Console.WriteLine("Błąd: " + e);
        }
        public void turn(char c)
        {
            string color = "Biały";
            if(c == 'B') color = "Czarny";
            Console.Write("Ruch gracza " + color + ": ");
        }
    }
}