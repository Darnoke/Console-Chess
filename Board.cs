using System;

namespace coding
{
    class Board
    {
        Figure[,] chessboard = new Figure[8, 8];

        public Board()
        {
            chessboard[0, 0]= new Rook('W');
            chessboard[0, 1]= new Knight('W');
            chessboard[0, 2]= new Bishop('W');
            chessboard[0, 3]= new Quenn('W');
            chessboard[0, 4]= new King('W');
            chessboard[0, 5]= new Bishop('W');
            chessboard[0, 6]= new Knight('W');
            chessboard[0, 7]= new Rook('W');
            for(int i = 0; i < 8; i++) chessboard[1, i] = new Pawn('W');
            for(int i = 2; i < 6; i++)
            {
                for(int j = 0; j < 8; j++) chessboard[i, j] = null;
            }
            for(int i = 0; i < 8; i++) chessboard[6, i] = new Pawn('B');
            chessboard[7, 0]= new Rook('B');
            chessboard[7, 1]= new Knight('B');
            chessboard[7, 2]= new Bishop('B');
            chessboard[7, 3]= new Quenn('B');
            chessboard[7, 4]= new King('B');
            chessboard[7, 5]= new Bishop('B');
            chessboard[7, 6]= new Knight('B');
            chessboard[7, 7]= new Rook('B');
        }

        public Board(string code)
        {
            for(int i = 0; i < 64; i++)
            {
                switch(code[i])
                {
                    case '.':
                        chessboard[i / 8 , i % 8] = null;
                        break;
                    case 'a':
                        chessboard[i / 8 , i % 8] = new Pawn('W');
                        break;
                    case 'b':
                        chessboard[i / 8 , i % 8] = new Pawn('W');
                        chessboard[i / 8 , i % 8].moved = true;
                        break;
                    case 'c':
                        chessboard[i / 8 , i % 8] = new King('W');
                        break;
                    case 'd':
                        chessboard[i / 8 , i % 8] = new King('W');
                        chessboard[i / 8 , i % 8].moved = true;
                        break;
                    case 'e':
                        chessboard[i / 8 , i % 8] = new Rook('W');
                        break;
                    case 'f':
                        chessboard[i / 8 , i % 8] = new Rook('W');
                        chessboard[i / 8 , i % 8].moved = true;
                        break;
                    case 'g':
                        chessboard[i / 8 , i % 8] = new Knight('W');
                        break;
                    case 'h':
                        chessboard[i / 8 , i % 8] = new Bishop('W');
                        break;
                    case 'i':
                        chessboard[i / 8 , i % 8] = new Quenn('W');
                        break;
                    case 'j':
                        chessboard[i / 8 , i % 8] = new Pawn('B');
                        break;
                    case 'k':
                        chessboard[i / 8 , i % 8] = new Pawn('B');
                        chessboard[i / 8 , i % 8].moved = true;
                        break;
                    case 'l':
                        chessboard[i / 8 , i % 8] = new King('B');
                        break;
                    case 'm':
                        chessboard[i / 8 , i % 8] = new King('B');
                        chessboard[i / 8 , i % 8].moved = true;
                        break;
                    case 'n':
                        chessboard[i / 8 , i % 8] = new Rook('B');
                        break;
                    case 'o':
                        chessboard[i / 8 , i % 8] = new Rook('B');
                        chessboard[i / 8 , i % 8].moved = true;
                        break;
                    case 'p':
                        chessboard[i / 8 , i % 8] = new Knight('B');
                        break;
                    case 'q':
                        chessboard[i / 8 , i % 8] = new Bishop('B');
                        break;
                    case 'r':
                        chessboard[i / 8 , i % 8] = new Quenn('B');
                        break;

                }
            }
        }
        public string get_code()
        {
            string ret = "";
            for(int i = 0; i < 64; i++)
            {
                if(chessboard[i / 8 , i % 8] == null)
                { 
                    ret += '.';
                    continue;
                }
                switch(chessboard[i / 8 , i % 8].type)
                {
                    case 'p':
                        if(chessboard[i / 8 , i % 8].color == 'W')
                        {
                            if(chessboard[i / 8 , i % 8].moved)
                            {
                                ret += 'b';
                            }
                            else
                            {
                                ret += 'a';
                            }
                        }
                        else
                        {
                            if(chessboard[i / 8 , i % 8].moved)
                            {
                                ret += 'k';
                            }
                            else 
                            {
                                ret += 'j';
                            }
                        }
                        break;
                    case 'K':
                        if(chessboard[i / 8 , i % 8].color == 'W')
                        {
                            if(chessboard[i / 8 , i % 8].moved)
                            {
                                ret += 'd';
                            }
                            else
                            {
                                ret += 'c';
                            }
                        }
                        else
                        {
                            if(chessboard[i / 8 , i % 8].moved)
                            {
                                ret += 'm';
                            }
                            else 
                            {
                                ret += 'l';
                            }
                        }
                        break;
                    case 'r':
                        if(chessboard[i / 8 , i % 8].color == 'W')
                        {
                            if(chessboard[i / 8 , i % 8].moved)
                            {
                                ret += 'f';
                            }
                            else
                            {
                                ret += 'e';
                            }
                        }
                        else
                        {
                            if(chessboard[i / 8 , i % 8].moved)
                            {
                                ret += 'o';
                            }
                            else 
                            {
                                ret += 'n';
                            }
                        }
                        break;
                    case 'k':
                        if(chessboard[i / 8 , i % 8].color == 'W') ret += 'g';
                        else ret += 'p';
                        break;
                    case 'b':
                        if(chessboard[i / 8 , i % 8].color == 'W') ret += 'h';
                        else ret += 'q';
                        break;
                    case 'q':
                        if(chessboard[i / 8 , i % 8].color == 'W') ret += 'i';
                        else ret += 'r';
                        break;
                }
            }
            return ret;
        }

        public void update_view()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("  ");
            for(int i = 1; i < 9; i++) Console.Write(i + " ");
            Console.WriteLine("");
            for(int i = 7; i >= 0; i--)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                char s = (char)(97 + i);
                Console.Write(s + " ");
                for(int j = 0; j < 8; j++)
                {
                    if((i + j) % 2 == 0) Console.BackgroundColor = ConsoleColor.DarkBlue;
                    else Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    if(chessboard[i, j] == null) Console.Write(" ");
                    else
                    {
                        char color = chessboard[i, j].color;
                        switch(chessboard[i, j].type)
                        {
                            case 'p':
                                if(color == 'W') Console.Write('\u2659');
                                else Console.Write('\u265F');
                                break;
                            case 'K':
                                if(color == 'W') Console.Write('\u2654');
                                else Console.Write('\u265A');
                                break;
                            case 'q':
                                if(color == 'W') Console.Write('\u2655');
                                else Console.Write('\u265B');
                                break;
                            case 'r':
                                if(color == 'W') Console.Write('\u2656');
                                else Console.Write('\u265C');
                                break;
                            case 'b':
                                if(color == 'W') Console.Write('\u2657');
                                else Console.Write('\u265D');
                                break;
                            case 'k':
                                if(color == 'W') Console.Write('\u2658');
                                else Console.Write('\u265E');
                                break;
                        }
                    }
                    Console.Write(" ");
                    
                }
                Console.WriteLine("");
            }
        }

        private bool correct_move(Tuple<Tuple<int, int>, Tuple<int, int>> move)
        {
            int from_x = move.Item1.Item1;
            int from_y = move.Item1.Item2;
            int to_x = move.Item2.Item1;
            int to_y = move.Item2.Item2;
            Figure from = chessboard[from_x, from_y];
            Figure to = chessboard[to_x, to_y];
            if(from == null || (to != null && to.color == from.color)) return false;
            if(from.type == 'p') // Pawn
            {
                if(from.color == 'W' && to_x - from_x == 1 || (from.moved == false && to_x - from_x == 2))
                {
                    if(Math.Abs(from_y - to_y) == 1)
                    {
                        return (to != null && to.color == 'B');
                    }
                    else if(Math.Abs(from_y - to_y) == 0)
                    {
                        if(to_x - from_x == 2)
                        {
                            return chessboard[from_x + 1, from_y] == null && to == null;
                        }
                        return to == null;
                    }
                }
                else if(to_x - from_x == -1 || (from.moved == false && to_x - from_x == -2))
                {
                    if(Math.Abs(from_y - to_y) == 1)
                    {
                        return (to != null && to.color == 'W');
                    }
                    else if(Math.Abs(from_y - to_y) == 0)
                    {
                        if(to_x - from_x == -2)
                        {
                            return chessboard[from_x - 1, from_y] == null && to == null;
                        }
                        return to == null;
                    }
                }
                return false;
            }
            else if(from.type == 'K' && from.moved == false && Math.Abs(from_y - to_y) == 2) //Castles
            {
                if(from.color == 'W')
                {
                    if(to_y == 6 && chessboard[0, 7] != null && chessboard[0, 7].moved == false && chessboard[0, 6] == null && chessboard[0, 5] == null)
                    {
                        if(!is_check(from.color))
                        {
                            chessboard[0, 5] = from;
                            chessboard[0, 4] = null;
                            if(!is_check(from.color))
                            {
                                chessboard[0, 6] = from;
                                chessboard[0, 5] = null;
                                if(!is_check(from.color))
                                {
                                    chessboard[0, 4] = from;
                                    chessboard[0, 5] = null;
                                    chessboard[0, 6] = null;
                                    return true;
                                }
                                chessboard[0, 6] = null;
                            }
                            chessboard[0, 4] = from;
                            chessboard[0, 5] = null;
                        }
                    }
                    else if(to_y == 2 && chessboard[0, 0] != null && chessboard[0, 0].moved == false && chessboard[0, 1] == null && chessboard[0, 2] == null && chessboard[0, 3] == null)
                    {
                        if(!is_check(from.color))
                        {
                            chessboard[0, 3] = from;
                            chessboard[0, 4] = null;
                            if(!is_check(from.color))
                            {
                                chessboard[0, 2] = from;
                                chessboard[0, 3] = null;
                                if(!is_check(from.color))
                                {
                                    chessboard[0, 4] = from;
                                    chessboard[0, 2] = null;
                                    chessboard[0, 3] = null;
                                    return true;
                                }
                                chessboard[0, 2] = null;
                            }
                            chessboard[0, 4] = from;
                            chessboard[0, 3] = null;
                        }
                    }
                }
                else
                {
                    if(to_y == 6 && chessboard[7, 7] != null && chessboard[7, 7].moved == false && chessboard[7, 6] == null && chessboard[7, 5] == null)
                    {
                        if(!is_check(from.color))
                        {
                            chessboard[7, 5] = from;
                            chessboard[7, 4] = null;
                            if(!is_check(from.color))
                            {
                                chessboard[7, 6] = from;
                                chessboard[7, 5] = null;
                                if(!is_check(from.color))
                                {
                                    chessboard[7, 4] = from;
                                    chessboard[7, 5] = null;
                                    chessboard[7, 6] = null;
                                    return true;
                                }
                                chessboard[7, 6] = null;
                            }
                            chessboard[7, 4] = from;
                            chessboard[7, 5] = null;
                        }
                    }
                    else if(to_y == 2 && chessboard[7, 0] != null && chessboard[7, 0].moved == false && chessboard[7, 1] == null && chessboard[7, 2] == null && chessboard[7, 3] == null)
                    {
                        if(!is_check(from.color))
                        {
                            chessboard[7, 3] = from;
                            chessboard[7, 4] = null;
                            if(!is_check(from.color))
                            {
                                chessboard[7, 2] = from;
                                chessboard[7, 3] = null;
                                if(!is_check(from.color))
                                {
                                    chessboard[7, 4] = from;
                                    chessboard[7, 2] = null;
                                    chessboard[7, 3] = null;
                                    return true;
                                }
                                chessboard[7, 2] = null;
                            }
                            chessboard[7, 4] = from;
                            chessboard[7, 3] = null;
                        }
                    }
                }
                return false;
            }

            else
            {
                char move_type = 'n';
                int x_diff = Math.Abs(from_x - to_x);
                int y_diff = Math.Abs(from_y - to_y);
                if(x_diff == y_diff) move_type = 'd';
                if(y_diff == 0 || x_diff == 0) move_type = 's';
                if((x_diff == 1 && y_diff == 2) || (y_diff == 1 && x_diff == 2)) move_type = 'L';
                switch(move_type)
                {
                    case 'd':
                        if((from.move_type != 'd' && from.move_type != 'a') || x_diff > from.move_range) return false;
                        char direction;
                        if(from_x > to_x)
                        {
                            if(from_y > to_y) direction = '3';
                            else direction = '4';
                        }
                        else
                        {
                            if(from_y > to_y) direction = '2';
                            else direction = '1';
                        }
                        for(int i = 1; i < x_diff; i++)
                        {
                            if(direction == '1') 
                            {
                                if(chessboard[from_x + i, from_y + i] != null) return false;
                            }
                            if(direction == '2') 
                            {
                                if(chessboard[from_x + i, from_y - i] != null) return false;
                            }
                            if(direction == '3') 
                            {
                                if(chessboard[from_x - i, from_y - i] != null) return false;
                            }
                            if(direction == '4') 
                            {
                                if(chessboard[from_x - i, from_y + i] != null) return false;
                            }
                        }
                        return true;

                    case 's':
                        if((from.move_type != 's' && from.move_type != 'a') || Math.Max(x_diff, y_diff) > from.move_range) return false;
                        //char direction;
                        if(x_diff != 0)
                        {
                            if(from_x > to_x) direction = 's';
                            else direction = 'n';
                        }
                        else
                        {
                            if(from_y > to_y) direction = 'w';
                            else direction = 'e';
                        }
                        for(int i = 1; i < Math.Max(x_diff, y_diff); i++)
                        {
                            if(direction == 'n')
                            {
                                if(chessboard[from_x + i, from_y] != null) return false;
                            }
                            if(direction == 's')
                            {
                                if(chessboard[from_x - i, from_y] != null) return false;
                            }
                            if(direction == 'e')
                            {
                                if(chessboard[from_x, from_y + i] != null) return false;
                            }
                            if(direction == 'w')
                            {
                                if(chessboard[from_x, from_y - i] != null) return false;
                            }
                        }
                        return true;
                    case 'L':
                        return from.move_type == 'L';
                    default: 
                        return false;
                }
            }
        }

        private Tuple<int, int> find_king(char color)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if(chessboard[i, j] != null && chessboard[i, j].type == 'K' && chessboard[i, j].color == color) return new Tuple<int, int>(i, j);
                }
            }
            return null;
        }
        private bool is_check(char color) // for this color
        {
            Tuple<int, int> target = find_king(color);
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    Tuple<int, int> current = new Tuple<int, int>(i, j);
                    if(correct_move(new Tuple<Tuple<int, int>, Tuple<int, int>>(current, target))) return true;
                }
            }
            return false;
        }

        private bool can_move(char color)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if(chessboard[i, j] != null && chessboard[i, j].color == color)
                    {
                        Tuple<int, int> current = new Tuple<int, int>(i, j);
                        for(int ii = 0; ii < 8; ii++)
                        {
                            for(int jj = 0; jj < 8; jj++)
                            {
                                Tuple<int, int> target = new Tuple<int, int>(ii, jj);
                                if(correct_move(new Tuple<Tuple<int, int>, Tuple<int, int>>(current, target)))
                                {
                                    Figure tmp = chessboard[ii, jj];
                                    chessboard[ii, jj] = chessboard[i, j]; 
                                    chessboard[i, j] = null; 
                                    bool is_good = !is_check(color);
                                    chessboard[i, j] = chessboard[ii, jj];
                                    chessboard[ii, jj] = tmp;
                                    if(is_good)
                                    {
                                        return false;
                                    } 
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
        public char make_move(Tuple<Tuple<int, int>, Tuple<int, int>> move, char color)
        {
            if(!correct_move(move)) return 'e';
            int from_x = move.Item1.Item1;
            int from_y = move.Item1.Item2;
            int to_x = move.Item2.Item1;
            int to_y = move.Item2.Item2;
            Figure tmp = chessboard[to_x, to_y];
            chessboard[to_x, to_y] = chessboard[from_x, from_y]; 
            chessboard[from_x, from_y] = null; 
            if(is_check(color))
            {
                chessboard[from_x, from_y] = chessboard[to_x, to_y];
                chessboard[to_x, to_y] = tmp;
                return 'e';
            }
            chessboard[to_x, to_y].moved = true;
            if(chessboard[to_x, to_y].type == 'K' && Math.Abs(to_y - from_y) == 2) // castles
            {
                if(color == 'W')
                {
                    if(to_y == 6)
                    {
                        chessboard[0, 5] = chessboard[0, 7];
                        chessboard[0, 5].moved = true;
                        chessboard[0, 7] = null;
                    }
                    else
                    {
                        chessboard[0, 3] = chessboard[0, 0];
                        chessboard[0, 3].moved = true;
                        chessboard[0, 0] = null;
                    }
                }
                else
                {
                    if(to_y == 6)
                    {
                        chessboard[7, 5] = chessboard[7, 7];
                        chessboard[7, 5].moved = true;
                        chessboard[7, 7] = null;
                    }
                    else
                    {
                        chessboard[7, 3] = chessboard[7, 0];
                        chessboard[7, 3].moved = true;
                        chessboard[7, 0] = null;
                    }
                }
            }
            if(chessboard[to_x, to_y].type == 'p' && (to_x == 7 || to_x == 0))
            {
                do
                {
                    Console.Write("Promocja pionka(Q, R, K, B): ");
                    string inp = Console.ReadLine();
                    if(inp.Length == 1 && (inp[0] == 'Q' || inp[0] == 'R' || inp[0] == 'K' || inp[0] == 'B'))
                    {
                        if(inp[0] == 'Q')
                        {
                            chessboard[to_x, to_y] = new Quenn(color);
                            chessboard[to_x, to_y].moved = true;
                        }
                        if(inp[0] == 'R')
                        {
                            chessboard[to_x, to_y] = new Rook(color);
                            chessboard[to_x, to_y].moved = true;
                        }
                        if(inp[0] == 'K')
                        {
                            chessboard[to_x, to_y] = new Knight(color);
                            chessboard[to_x, to_y].moved = true;
                        }
                        if(inp[0] == 'B')
                        {
                            chessboard[to_x, to_y] = new Bishop(color);
                            chessboard[to_x, to_y].moved = true;
                        }
                    }
                    else Console.WriteLine("Błąd zapisu, spróbuj jeszcze raz");
                }while(chessboard[to_x, to_y].type == 'p');
            }
            char opponent;
            if(color == 'W') opponent = 'B';
            else opponent = 'W';
            if(is_check(opponent))
            {
                if(can_move(opponent)) return 'm';
                return 'c';
            }
            else if(can_move(opponent)) return 's';
            return 'g';
        }
    }
}