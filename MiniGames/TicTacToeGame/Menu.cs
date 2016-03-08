using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void two_player_btn_Click(object sender, EventArgs e)
        {
            GameWindow.setMode(two_player_btn.Text);
            this.Close();
        }

        private void one_player_btn_Click(object sender, EventArgs e)
        {
            GameWindow.setMode(one_player_btn.Text);
            this.Close();
        }
    }
}
