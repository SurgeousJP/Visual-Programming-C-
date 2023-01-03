using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
namespace Demo_C_Sharp_2
{
    internal class Program
    {
        public enum SquareColor { White, Black };
        public class Square : PictureBox
        {
            public Color Clrtemp = new Color();
            public Image Imgtemp;
            protected void OnClickButton(object sender, EventArgs ea)
            {
                this.BackColor = System.Drawing.Color.Aqua;
            }
            protected void MouseDownEvent(object sender, EventArgs ea)
            {
                Clrtemp = this.BackColor;
                this.BackColor = System.Drawing.Color.Aqua;
            }
            protected void MouseUpEvent(object sender, EventArgs ea)
            {
                this.BackColor = Clrtemp;
            }
            protected void MouseClick1stEvent(object sender, MouseEventArgs e)
            {
                if (this.Image != null)
                {
                    Imgtemp = this.Image;
                    this.Image = null;
                }
                else
                {
                    this.MouseClick += new MouseEventHandler(MouseClick2ndEvent);
                }
                    
            }
            protected void MouseClick2ndEvent(object sender, MouseEventArgs e)
            {
                    this.Image = Imgtemp;
            }
            protected ChessBoard _board;
            public ChessBoard Board
            {
                get
                {
                    return _board;
                }
                set
                {
                    _board = Board;
                }
            }
            protected Piece _piece;
            public Piece Piece
            {
                get
                {
                    return _piece;
                }
                set
                {
                    _piece = Piece;
                }
            }
            public Square()
            {

            }
            public Square(SquareColor c, ChessBoard b, Piece p = null)
            {
                this.Color = c;
                Board = b;
                Piece = p;
                this.MouseClick += new MouseEventHandler(MouseClick1stEvent);
            }
            protected SquareColor _color;
            public SquareColor Color
            {
                get { return _color; }
                set
                {
                    _color = value;
                    if (Color == SquareColor.White) this.BackColor = System.Drawing.Color.White;
                    else this.BackColor = System.Drawing.Color.Gray;
                }
            }
        }
        public class ChessBoard : Square
        {
            const int DEFAULT_CHESS_WIDTH = 80;
            const int DEFAULT_CHESS_HEIGHT = 80;

            Form form { get; set; }
            protected Square[,] _squares;
            protected Piece[,] _pieces = new Piece[8, 8];
            protected int _chessWidth;
            protected int _chessHeight;

            public ChessBoard(Form ParentForm, int chessWidth = DEFAULT_CHESS_WIDTH, int chessHeight = DEFAULT_CHESS_HEIGHT)
            {
                _squares = new Square[8, 8];
                this._chessWidth = chessWidth;
                this._chessHeight = chessHeight;
                this.form = ParentForm;
                this.Size = new Size(640, 640);
                Init();
            }
            protected void Init()
            {
                int left, top = 0;
                SquareColor c = SquareColor.White;
                for (int i = 0; i < 8; i++)
                {
                    left = 0;
                    for (int j = 0; j < 8; j++)
                    {
                        Square sq = new Square(c, this);
                        sq.Size = new System.Drawing.Size(_chessWidth, _chessHeight);
                        sq.Left = left;
                        sq.Top = top;
                        sq.SizeMode = PictureBoxSizeMode.StretchImage;

                        if (c == SquareColor.White)
                        {
                            c = SquareColor.Black;
                        }
                        else c = SquareColor.White;

                        left += _chessWidth;
                        _squares[i, j] = sq;
                        form.Controls.Add(sq);
                    }
                    top += _chessHeight;
                    if (c == SquareColor.White)
                    {
                        c = SquareColor.Black;
                    }
                    else c = SquareColor.White;
                }
                // King
                this._pieces[0, 4] = new King(Piece.PieceColor.Black, this._squares[0, 4]);
                this._pieces[7, 4] = new King(Piece.PieceColor.White, this._squares[7, 4]);
                // Rook
                this._pieces[0, 0] = new Rook(Piece.PieceColor.Black, this._squares[0, 0]);
                this._pieces[0, 7] = new Rook(Piece.PieceColor.Black, this._squares[0, 7]);
                this._pieces[7, 0] = new Rook(Piece.PieceColor.White, this._squares[7, 0]);
                this._pieces[7, 7] = new Rook(Piece.PieceColor.White, this._squares[7, 7]);
                // Pawn
                for (int i = 0; i < 8; i++)
                {
                    this._pieces[1, i] = new Pawn(Piece.PieceColor.Black, this._squares[1, i]);
                    this._pieces[6, i] = new Pawn(Piece.PieceColor.White, this._squares[6, i]);
                }
                // Queen
                this._pieces[0, 3] = new Queen(Piece.PieceColor.Black, this._squares[0, 3]);
                this._pieces[7, 3] = new Queen(Piece.PieceColor.White, this._squares[7, 3]);
                // Knight
                this._pieces[0, 1] = new Knight(Piece.PieceColor.Black, this._squares[0, 1]);
                this._pieces[0, 6] = new Knight(Piece.PieceColor.Black, this._squares[0, 6]);
                this._pieces[7, 1] = new Knight(Piece.PieceColor.White, this._squares[7, 1]);
                this._pieces[7, 6] = new Knight(Piece.PieceColor.White, this._squares[7, 6]);
                // Bishop
                this._pieces[0, 2] = new Bishop(Piece.PieceColor.Black, this._squares[0, 2]);
                this._pieces[0, 5] = new Bishop(Piece.PieceColor.Black, this._squares[0, 5]);
                this._pieces[7, 2] = new Bishop(Piece.PieceColor.White, this._squares[7, 2]);
                this._pieces[7, 5] = new Bishop(Piece.PieceColor.White, this._squares[7, 5]);
            }
            
        }
        
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Size = new System.Drawing.Size(768, 768);

            //PictureBox pictureBox = new PictureBox();
            //pictureBox.Location = new Point(100, 100);
            //pictureBox.Size = new Size(128, 128);
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox.Image = Image.FromFile("images\\queen_black.png");
            //form.Controls.Add(pictureBox);
            ChessBoard test = new ChessBoard(form);
            Application.Run(form);

        }
    }

}
