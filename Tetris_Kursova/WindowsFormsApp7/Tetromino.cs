using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    
    public class Tetromino
    {
        public Point Position { get; set; }
        public Color Color { get; set; }
        public Point[] Blocks { get; set; }

        
        // Constructs a new instance of the Tetromino class with the specified position and color.
        
        public Tetromino(Point position, Color color)
        {
            Position = position;
            Color = color;
        }

        
        // Moves the tetromino one step to the left.
        
        public void MoveLeft()
        {
            Position = new Point(Position.X - 1, Position.Y);
        }

        
        // Moves the tetromino one step to the right.
        
        public void MoveRight()
        {
            Position = new Point(Position.X + 1, Position.Y);
        }

        
        // Moves the tetromino one step down.
        
        public void MoveDown()
        {
            Position = new Point(Position.X, Position.Y + 1);
        }

        
        // Moves the tetromino one step up.
        
        public void MoveUp()
        {
            Position = new Point(Position.X, Position.Y - 1);
        }

        // Rotates the tetromino 90 degrees clockwise.
        
        public void Rotate()
        {
            for (int i = 0; i < Blocks.Length; i++)
            {
                int x = Blocks[i].X;
                int y = Blocks[i].Y;

                Blocks[i] = new Point(-y, x);
            }
        }

        
        // Rotates the tetromino 90 degrees counter-clockwise.
        
        public void RotateBack()
        {
            for (int i = 0; i < Blocks.Length; i++)
            {
                int x = Blocks[i].X;
                int y = Blocks[i].Y;

                Blocks[i] = new Point(y, -x);
            }
        }

        
        // Draws the tetromino on the specified graphics object.
        
        public void Draw(Graphics g, int blockSize)
        {
            Brush brush = new SolidBrush(Color);

            foreach (Point block in Blocks)
            {
                int x = (Position.X + block.X) * blockSize;
                int y = (Position.Y + block.Y) * blockSize;

                g.FillRectangle(brush, x, y, blockSize, blockSize);
            }
        }

        
        // Draws the next tetromino on the specified graphics object.
        
        public void DrawNextTetromino(Graphics g, int blockSize)
        {
            Brush brush = new SolidBrush(Color);

            foreach (Point block in Blocks)
            {
                int x = (Position.X + block.X) * blockSize + 200;
                int y = (Position.Y + block.Y) * blockSize + 50;

                g.FillRectangle(brush, x, y, blockSize, blockSize);
            }
        }
    }
}
