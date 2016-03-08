using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGameCollection
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void tictactoeGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicTacToeGame.GameWindow tictactoe = new TicTacToeGame.GameWindow();
            tictactoe.Show();
        }

        private void snakeGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snake.SnakeGameWindow snake = new Snake.SnakeGameWindow();
            snake.Show();
        }
    }
}
