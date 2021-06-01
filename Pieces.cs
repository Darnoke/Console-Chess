using System;

namespace coding
{
    class Pawn : Figure
    {
        public Pawn(char c)
        {
            moved = false;
            move_type = 'f';
            move_range = 1;
            color = c;
            type = 'p';
        }
    }

    class King : Figure
    {
        public King(char c)
        {
            moved = false;
            move_type = 'a';
            move_range = 1;
            color = c;
            type = 'K';
        }
    }

    class Quenn : Figure
    {
        public Quenn(char c)
        {
            moved = false;
            move_type = 'a';
            move_range = 7;
            color = c;
            type = 'q';
        }
    }
    class Rook : Figure
    {
        public Rook(char c)
        {
            moved = false;
            move_type = 's';
            move_range = 7;
            color = c;
            type = 'r';
        }
    }
    class Bishop : Figure
    {
        public Bishop(char c)
        {
            moved = false;
            move_type = 'd';
            move_range = 7;
            color = c;
            type = 'b';
        }
    }
    class Knight : Figure
    {
        public Knight(char c)
        {
            moved = false;
            move_type = 'L';
            move_range = 1;
            color = c;
            type = 'k';
        }
    }
}