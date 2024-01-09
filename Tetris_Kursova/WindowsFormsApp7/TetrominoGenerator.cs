using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    // <summary>
    // Generates random tetrominoes for the Tetris game.
    // </summary>
    public static class TetrominoGenerator
    {
        private static Random random = new Random();

        // <summary>
        // Generates a random tetromino.
        // </summary>
        public static Tetromino GenerateRandomTetromino()
        {
            int index = random.Next(Tetrominoes.Length);
            TetrominoShape shape = Tetrominoes[index];

            Color color = TetrominoColors[index];

            return new Tetromino(new Point(4, 0), color)
            {
                Blocks = shape.Blocks
            };
        }

        // Tetromino shapes and colors.
        private static readonly TetrominoShape[] Tetrominoes = new TetrominoShape[]
        {
            new TetrominoShape(new Point[] { new Point(0, 0), new Point(1, 0), new Point(0, 1), new Point(1, 1) }, Color.Yellow), // Square
            new TetrominoShape(new Point[] { new Point(0, 0), new Point(-1, 0), new Point(1, 0), new Point(2, 0) }, Color.Cyan), // I
            new TetrominoShape(new Point[] { new Point(0, 0), new Point(-1, 0), new Point(1, 0), new Point(1, 1) }, Color.Orange), // L
            new TetrominoShape(new Point[] { new Point(0, 0), new Point(-1, 0), new Point(1, 0), new Point(-1, 1) }, Color.Blue), // J
            new TetrominoShape(new Point[] { new Point(0, 0), new Point(-1, 0), new Point(1, 0), new Point(0, 1) }, Color.Green), // T
            new TetrominoShape(new Point[] { new Point(0, 0), new Point(-1, 0), new Point(0, 1), new Point(1, 1) }, Color.Purple), // Z
            new TetrominoShape(new Point[] { new Point(0, 0), new Point(1, 0), new Point(0, 1), new Point(-1, 1) }, Color.Red) // S
        };

        private static readonly Color[] TetrominoColors = new Color[]
        {
            Color.Yellow,
            Color.Cyan,
            Color.Orange,
            Color.Blue,
            Color.Green,
            Color.Purple,
            Color.Red
        };

        // <summary>
        // Represents the shape of a tetromino.
        // </summary>
        private class TetrominoShape
        {
            public Point[] Blocks { get; }

            public TetrominoShape(Point[] blocks, Color green)
            {
                Blocks = blocks;
            }
        }

    }
}
