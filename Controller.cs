using System;

namespace coding
{
    class Controller
    {
        public Controller()
        {
            new_game();
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
            chessboard = new Board();
            effect = 'n';
            turn = 'W';
            play();
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
                else effect = chessboard.make_move(move, turn);
            } while(effect == 'e' || effect == 'n');
            if(turn == 'W') turn = 'B';
            else turn = 'W';
            play();
        }
    }
}