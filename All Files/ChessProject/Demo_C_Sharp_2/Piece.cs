using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Demo_C_Sharp_2
{

    internal class Piece
    {
        public class Resources
        {
            public Image BISHOP_BLACK = Image.FromFile("images\\bishop_black.png");
            public Image KING_BLACK = Image.FromFile("images\\king_black.png");
            public Image QUEEN_BLACK = Image.FromFile("images\\queen_black.png");
            public Image KNIGHT_BLACK = Image.FromFile("images\\knight_black.png");
            public Image ROOK_BLACK = Image.FromFile("images\\rook_black.png");
            public Image PAWN_BLACK = Image.FromFile("images\\pawn_black.png");

            public Image BISHOP_WHITE = Image.FromFile("images\\bishop_white.png");
            public Image KING_WHITE = Image.FromFile("images\\king_white.png");
            public Image QUEEN_WHITE = Image.FromFile("images\\queen_white.png");
            public Image KNIGHT_WHITE = Image.FromFile("images\\knight_white.png");
            public Image ROOK_WHITE = Image.FromFile("images\\rook_white.png");
            public Image PAWN_WHITE = Image.FromFile("images\\pawn_white.png");
        }
        public enum PieceColor { White, Black }
        protected Image _image;
        public Image Image
        {
            get { return _image; }
            set { _image = Image; }
        }
        protected PieceColor _color;
        public PieceColor Color
        {
            get { return _color; }
            set { _color = Color; }
        }
        protected Program.Square _square;
        public Program.Square Square
        {
            get
            {
                return _square;
            }
            set
            {
                _square = value;
            }
        }
        public Piece(PieceColor color, Program.Square sq)
        {
            Color = color;
            Square = sq;
        }
    }
    class King : Piece
    {
        public King(PieceColor color, Program.Square sq): base(color, sq)
        {
            if (color == PieceColor.White)
            {
                Resources test = new Resources();
                Image = test.KING_WHITE;
                sq.Image = test.KING_WHITE;
            }
            else if (color == PieceColor.Black)
            {
                Resources test = new Resources();
                Image = test.KING_BLACK;
                sq.Image = test.KING_BLACK;
            }
        }
    }
    class Queen : Piece
    {
        public Queen(PieceColor color, Program.Square sq) : base(color, sq)
        {
            if (color == PieceColor.White)
            {
                Resources test = new Resources();
                Image = test.QUEEN_WHITE;
                sq.Image = test.QUEEN_WHITE;
            }
            else if (color == PieceColor.Black)
            {
                Resources test = new Resources();
                Image = test.QUEEN_BLACK;
                sq.Image = test.QUEEN_BLACK;
            }
        }
    }
    class Bishop : Piece
    {
        public Bishop(PieceColor color, Program.Square sq) : base(color, sq)
        {
            if (color == PieceColor.White)
            {
                Resources test = new Resources();
                Image = test.BISHOP_WHITE;
                sq.Image = test.BISHOP_WHITE;
            }
            else if (color == PieceColor.Black)
            {
                Resources test = new Resources();
                Image = test.BISHOP_BLACK;
                sq.Image = test.BISHOP_BLACK;
            }
        }
    }
    class Knight : Piece
    {
        public Knight(PieceColor color, Program.Square sq) : base(color, sq)
        {
            if (color == PieceColor.White)
            {
                Resources test = new Resources();
                Image = test.KNIGHT_WHITE;
                sq.Image = test.KNIGHT_WHITE;
            }
            else if (color == PieceColor.Black)
            {
                Resources test = new Resources();
                Image = test.KNIGHT_BLACK;
                sq.Image = test.KNIGHT_BLACK;
            }
        }
    }
    class Rook : Piece
    {
        public Rook(PieceColor color, Program.Square sq) : base(color, sq)
        {
            if (color == PieceColor.White)
            {
                Resources test = new Resources();
                Image = test.ROOK_WHITE;
                sq.Image = test.ROOK_WHITE;
            }
            else if (color == PieceColor.Black)
            {
                Resources test = new Resources();
                Image = test.ROOK_BLACK;
                sq.Image = test.ROOK_BLACK;
            }
        }
    }
    class Pawn : Piece
    {
        public Pawn(PieceColor color, Program.Square sq) : base(color, sq)
        {
            if (color == PieceColor.White)
            {
                Resources test = new Resources();
                Image = test.PAWN_WHITE;
                sq.Image = test.PAWN_WHITE;
            }
            else if (color == PieceColor.Black)
            {
                Resources test = new Resources();
                Image = test.PAWN_BLACK;
                sq.Image = test.PAWN_BLACK;
            }
        }
    }

}
