using System;
using System.Linq;

namespace coding
{
    class Controller
    {
        public Controller()
        {
            Console.WriteLine("Jeśli chcesz wczytać gre podaj jej kod (puste aby pominac): ");
            string inp = Console.ReadLine();
            if(inp == "") new_game();
            else new_game(inp);
        }
        Player white, black;
        Info output;
        char turn;
        char effect;
        Board chessboard;
        public void new_game()
        {
            white = new Player('W');
            black = new Player('B');
            output = new Info();
            chessboard = new Board("eghichgeaaaaaaaa................................jjjjjjjjnpqrlqpn");
            effect = 'n';
            turn = 'W';
            play();
        }
        public void new_game(string code)
        {
            white = new Player('W');
            black = new Player('B');
            output = new Info();
            effect = 'n';
            read_game(code);
            play();
        }

        private void read_game(string code)
        {
            // a - white pawn
            // b - white moved pawn
            // c - white king
            // d - white moved king
            // e - white rook
            // f - white moved rook
            // g - white knight
            // h - white bishop
            // i - white queen
            // . - empty
            // rest is for black the same
            if(code.Length != 65) throw new ArgumentException("zły format wejscia");

            bool white_king = false;
            bool black_king = false;

            char[] allowed_chars = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', '.'};
            for(int i = 1; i < 65; i++)
            {
                if(!allowed_chars.Contains(code[i]))
                {
                    throw new ArgumentException("zły format wejscia");
                }
                if(code[i] == 'c' || code[i] == 'd')
                {
                    if(white_king) throw new ArgumentException("2 królów tego samego koloru");
                    white_king = true;
                }
                if(code[i] == 'l' || code[i] == 'm')
                {
                    if(black_king) throw new ArgumentException("2 królów tego samego koloru");
                    black_king = true;
                }
            }

            if(code[0] == 'W') turn = 'W';
            else turn = 'B';

            chessboard = new Board(code.Substring(1));
        }

        private void play()
        {
            Tuple<Tuple<int, int>, Tuple<int, int>> move;
            chessboard.update_view();
            Console.ResetColor();
            switch(effect)
            {
                case 's':
                    output.stalemate();
                    return;
                case 'm':
                    output.checkmate(turn);
                    return;
                case 'c':
                    output.check();
                    break;
                default:
                    break;
            }
            do
            {
                if(effect == 'e') output.error("nieprawidłowy ruch");
                output.turn(turn);
                if(turn == 'W') move = white.enter_move();
                else move = black.enter_move();
                if(move == null)
                {
                    output.error("zła notacja");
                    effect = 'n';
                }
                else if(move.Item1 == null)
                {
                    Console.WriteLine(turn + chessboard.get_code());
                    effect = 'n';
                }
                else effect = chessboard.make_move(move, turn);
            } while(effect == 'e' || effect == 'n');
            if(turn == 'W') turn = 'B';
            else turn = 'W';
            play();
        }
    }
}