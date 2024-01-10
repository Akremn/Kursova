using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using WindowsFormsApp7;

namespace TetrisGame
{
    
    public partial class TetrisForm : Form
    {
        public System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
        private const int GridWidth = 10;
        private const int GridHeight = 20;
        private const int BlockSize = 25;

        private static int score;
        private Timer gameTimer;
        private Tetromino currentTetromino;
        private Tetromino nextTetromino;
        private int[,] grid;

        
        // Constructs a new instance of the TetrisForm class.
        // Initializes the game grid and sets up the game timer.
        
        public TetrisForm()
        {
            // Set up the form properties.
            Text = "Tetris";
            ClientSize = new Size(380,500);
            BackColor = Color.SeaGreen;
            DoubleBuffered = true;


            label1.Location = new Point(270, 170);
            label1.Text = "Score: " + score;
            label1.Enabled = false;
            this.Controls.Add(label1);

            // Initialize the game grid.
            grid = new int[GridHeight, GridWidth];

            // Set up the game timer.
            gameTimer = new Timer();
            gameTimer.Interval = 500; // 500 milliseconds
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
            
            // Generate the first tetromino.
            currentTetromino = TetrominoGenerator.GenerateRandomTetromino();
            nextTetromino = TetrominoGenerator.GenerateRandomTetromino();
            Tetris();

        }

        
        // Handles the tick event of the game timer.
        // Moves the current tetromino down and checks for collisions.
        
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Move the current tetromino down.
            currentTetromino.MoveDown();

            // Check for collisions.
            if (IsCollision())
            {
                // If there is a collision, move the tetromino back up and fix it in place.
                currentTetromino.MoveUp();
                FixTetromino();

                // Check for completed rows and remove them.
                RemoveCompletedRows();

                // Generate the next tetromino.
                currentTetromino = nextTetromino;
                nextTetromino = TetrominoGenerator.GenerateRandomTetromino();

                // Check for game over.
                if (IsGameOver())
                {
                    gameTimer.Stop();
                    MessageBox.Show("Game Over");
                    Close();
                }
            }

            // Redraw the form.
            Invalidate();
        }
        
        
        // Overrides the OnPaint method to draw the game grid and the tetrominoes.
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            // Draw the game grid.
            for (int row = 0; row < GridHeight; row++)
            {
                for (int col = 0; col < GridWidth; col++)
                {
                    int block = grid[row, col];
                    if (block != 0)
                    {
                        Brush brush = new SolidBrush(Color.FromArgb(block));
                        g.FillRectangle(brush, col * BlockSize, row * BlockSize, BlockSize, BlockSize);
                    }
                }
            }
            
            {
                for (int i = 0; i <= 20; i++)
                {
                    g.DrawLine(Pens.Black, new Point(0, 0 + i * BlockSize), new Point(0 + 10 * BlockSize, 0 + i * BlockSize));
                }
                for (int i = 0; i <= 10; i++)
                {
                    g.DrawLine(Pens.Black, new Point(0 + i * BlockSize, 0), new Point(0 + i * BlockSize, 0 + 20 * BlockSize));
                }
            }
            // Draw the current tetromino.
            currentTetromino.Draw(g, BlockSize);

            // Draw the next tetromino.
            nextTetromino.DrawNextTetromino(g, BlockSize);
        }

        
        // Overrides the OnKeyDown method to handle keyboard input.
        
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            // Handle arrow keys for tetromino movement.
            if (e.KeyCode == Keys.Left)
            {
                currentTetromino.MoveLeft();
                if (IsCollision())
                {
                    currentTetromino.MoveRight();
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                currentTetromino.MoveRight();
                if (IsCollision())
                {
                    currentTetromino.MoveLeft();
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                currentTetromino.MoveDown();
                if (IsCollision())
                {
                    currentTetromino.MoveUp();
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                currentTetromino.Rotate();
                if (IsCollision())
                {
                    currentTetromino.RotateBack();
                }
            }

            // Redraw the form.
            Invalidate();
        }

        
        // Checks if there is a collision between the current tetromino and the game grid.
        
        private bool IsCollision()
        {
            foreach (Point block in currentTetromino.Blocks)
            {
                int row = currentTetromino.Position.Y + block.Y;
                int col = currentTetromino.Position.X + block.X;

                if (row >= 0 && row < GridHeight && col >= 0 && col < GridWidth)
                {
                    if (grid[row, col] != 0)
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        
        // Fixes the current tetromino in place by updating the game grid.
        
        private void FixTetromino()
        {
            foreach (Point block in currentTetromino.Blocks)
            {
                int row = currentTetromino.Position.Y + block.Y;
                int col = currentTetromino.Position.X + block.X;

                grid[row, col] = currentTetromino.Color.ToArgb();
                
            }
        }

        
        // Removes completed rows from the game grid and shifts the rows above them down.
        
        private void RemoveCompletedRows()
        {
            for (int row = GridHeight - 1; row >= 0; row--)
            {
                bool isRowCompleted = true;
                for (int col = 0; col < GridWidth; col++)
                {
                    if (grid[row, col] == 0)
                    {
                        isRowCompleted = false;
                        break;
                    }
                }

                if (isRowCompleted)
                {
                    // Shift the rows above the completed row down.
                    for (int r = row; r > 0; r--)
                    {
                        for (int c = 0; c < GridWidth; c++)
                        {
                            grid[r, c] = grid[r - 1, c];
                        }
                    }

                    // Clear the top row.
                    for (int c = 0; c < GridWidth; c++)
                    {
                        grid[0, c] = 0;
                    }
                    score += 10;
                    label1.Text = "Score: " + score;
                }
            }
        }

        
        // Checks if the game is over by checking if there is a collision at the top of the grid.
        
        private bool IsGameOver()
        {
            for (int col = 0; col < GridWidth; col++)
            {
                if (grid[0, col] != 0)
                {
                    return true;
                }
            }

            return false;
        }

        
        private Timer rowShiftTimer;

        
        public void Tetris()
        {

            rowShiftTimer = new Timer();
            rowShiftTimer.Interval = 30000; // 60000 milliseconds = 1 minute
            rowShiftTimer.Tick += RowShiftTimer_Tick;
            rowShiftTimer.Start();
        }

        private void RowShiftTimer_Tick(object sender, EventArgs e)
        {
            
            for (int col = 0; col < GridWidth; col++)
            {
                
                for (int row = 1; row < GridHeight; row++)
                {
                    grid[row - 1, col] = grid[row, col];
                }
            }
            for (int col = 0; col < GridWidth; col++)
            {
                grid[GridHeight - 1, col] = 0;
            }
            Random rnd = new Random();
            // Add a new random row at the bottom.
            for (int col = 0; col < GridWidth; col++)
            {
                grid[19, rnd.Next(1, 10)] = GetRandomBlockColor().ToArgb();
            }

            // Redraw the form.
            Invalidate();
        }

        
        private Color GetRandomBlockColor()
        {
            
            Random random = new Random();
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);
            return Color.FromArgb(r, g, b);
        }

        private void TetrisForm_Load_1(object sender, EventArgs e)
        {

        }
    }      
}