using System;
using System.Linq;

namespace coding
{
    class Player
    {
        public char color;

        public Player(char c)
        {
            if(c != 'W' && c != 'B') throw new ArgumentException();
            color = c;
        }

        public Tuple<Tuple<int, int>, Tuple<int, int>> enter_move()
        {
            char[] allowed_chars = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};
            char[] allowed_nums = new char[] {'1', '2', '3', '4', '5', '6', '7', '8'};
            string inp = Console.ReadLine();
            if(inp == "save") return new Tuple<Tuple<int, int>, Tuple<int, int>>(null, null);
            if(inp.Length != 5 || inp[2] != ' ' || !allowed_chars.Contains(inp[0]) || !allowed_chars.Contains(inp[3])
                                                || !allowed_nums.Contains(inp[1])  || !allowed_nums.Contains(inp[4])) return null;
            int fst = inp[0] - 96;
            int snd = inp[1] - 48;
            return new Tuple<Tuple<int, int>, Tuple<int, int>>(new Tuple<int, int>(inp[0] - 97, inp[1] - 49), new Tuple<int, int>(inp[3] - 97, inp[4] - 49));
        }
    }
}