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
    public partial class GameWindow : Form
    {
        bool turn = true; //true = x turn,false = o turn
        int turn_count = 0;
        static String mode;


        public static void setMode(String m)
        {
            mode = m; 
        }

        public GameWindow()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (turn)
                bt.Text = "X";
            else
                bt.Text = "O";

            turn = !turn;
            turn_count++;
            bt.Enabled = false;

            checkForWinner();

            if((!turn) && mode == "One Player")
            {
                computer_make_move();
            }
        }

        private void computer_make_move()
        {
            //priority 1:  get tick tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space

            Button move = null;

            //look for tic tac toe opportunities
            move = look_for_win_or_block("O"); //look for win
            if (move == null)
            {
                move = look_for_win_or_block("X"); //look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }//end if
                }//end if
            }//end if

            try
            {
                move.PerformClick();
            }
            catch { }
        }

        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }

        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }

        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }


        private void checkForWinner()
        {
            bool there_is_winner = false;

            //Horizontal Checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_winner = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_winner = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_winner = true;

            //Vertical Checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_winner = true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_winner = true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_winner = true;

            //Diagonal Checks
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_winner = true;
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_winner = true;

            if (there_is_winner)
            {
                disableButtons();

                String Winner = "";

                if (turn)
                {
                    Winner = "Player 2";
                    p2_score.Text = (Int32.Parse(p2_score.Text) + 1).ToString();
                }
                else
                {
                    Winner = "Player 1";
                    p1_score.Text = (Int32.Parse(p1_score.Text) + 1).ToString();
                }

                MessageBox.Show(Winner + " Wins!", "Yay!");
            }

            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!", "Bummer");
                }
            }

        }//end checkforwinner

        private void disableButtons()
        {
            try
            {
                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
            }

            catch { };
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (bt.Enabled)
            {
                if (turn)
                    bt.Text = "X";
                else
                    bt.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (bt.Enabled)
            {
                bt.Text = "";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Nusrat Mojumder", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button bt = (Button)c;
                    bt.Enabled = true;
                    bt.Text = "";

                    p1_score.Text = "0";
                    p2_score.Text = "0";

                }
                catch
                {
                }
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

        }

        private void reset_score_Click(object sender, EventArgs e)
        {
            p1_score.Text = "0";
            p2_score.Text = "0";
        }

        private void play_again_btn_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button bt = (Button)c;
                    bt.Enabled = true;
                    bt.Text = "";
                }
                catch
                {
                }
            }
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}