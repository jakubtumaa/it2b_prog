using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace BlockGame
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameForm());
        }
    }

    class GameForm : Form
    {
        // velikost bloku
        private int tileSize = 40;

        // pozice hráče
        private int playerX = 0;
        private int playerY = 0;
        private Image playerImage;

        public GameForm()
        {
            this.Text = "BlockGame";
            this.ClientSize = new Size(800, 600);
            this.DoubleBuffered = true;
            this.KeyPreview = true;

            this.Paint += GameForm_Paint;
            this.KeyDown += GameForm_KeyDown;

            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "player.png")))
            {
                playerImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "player.png"));
            }
            else
            {
                playerImage = new Bitmap(tileSize, tileSize);
            }
        }

        // WASD
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                playerX--;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                playerX++;
            }

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                playerY--;
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                playerY++;
            }

            playerX = Math.Max(-100, Math.Min(100, playerX));
            playerY = Math.Max(-100, Math.Min(100, playerY));

            this.Invalidate();
        }

        // grafika
        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // pozadí
            g.Clear(Color.Black);

            // střed obrazovky
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            // mřížka
            for (int x = -20; x < 20; x++)
            {
                int lineX = centerX + (x * tileSize);

                g.DrawLine(
                    Pens.White,
                    lineX,
                    0,
                    lineX,
                    this.ClientSize.Height
                );
            }

            for (int y = -15; y < 15; y++)
            {
                int lineY = centerY + (y * tileSize);

                g.DrawLine(
                    Pens.White,
                    0,
                    lineY,
                    this.ClientSize.Width,
                    lineY
                );
            }

            // border
            int borderX = centerX + (-100 * tileSize);
            int borderY = centerY + (-100 * tileSize);
            int borderSize = 200 * tileSize;

            g.DrawRectangle(
                new Pen(Color.Black, 3),
                borderX,
                borderY,
                borderSize,
                borderSize
            );

            // pozice hráč
            int drawX = centerX + (playerX * tileSize);
            int drawY = centerY + (playerY * tileSize);

            // varvy hráč
            g.DrawImage(playerImage, drawX, drawY, tileSize, tileSize);

            // souřadnice
            string coords = $"X: {playerX} Y: {playerY}";
            Font font = new Font("Monocraft", 16);

            g.DrawString(coords, font, Brushes.White, 10, 10);
        }
    }
}