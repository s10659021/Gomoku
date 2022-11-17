using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace gomoku
{
    abstract class Piece : PictureBox
    {
        private int IMAGE_WIDTH = 50;
        public Piece(int x, int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x - IMAGE_WIDTH / 2, y - IMAGE_WIDTH / 2);
            this.Size = new Size(50, 50);
        }
        public abstract PieceType GetPieceType();
        

        
    }
}
