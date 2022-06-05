using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE_GAME
{
    public partial class Form1 : Form
    {
        bool turn = true;//true = X turn; false = Y turn
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Michaela Espiritu", "Tic Tac Toe");

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";

            else
                b.Text = "O";


                turn = !turn;
            b.Enabled = false;

            checkForWinner();
        }
        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            //horizontal checks
         if((ButtonA1.Text == ButtonA2.Text) && (ButtonA2.Text == ButtonA3.Text) && (!ButtonA1.Enabled))
                there_is_a_winner = true;
         else if((ButtonB1.Text == ButtonB2.Text) && (ButtonB2.Text == ButtonB3.Text) && (!ButtonB2.Enabled))
                there_is_a_winner = true; 
         else if((ButtonC1.Text == ButtonC2.Text) && (ButtonC2.Text == ButtonC3.Text) && (!ButtonC1.Enabled))
                there_is_a_winner = true;

            //vertical checks
         else if ((ButtonA1.Text == ButtonB1.Text) && (ButtonB1.Text == ButtonC1.Text) && (!ButtonA1.Enabled))
                there_is_a_winner = true;
            else if ((ButtonA2.Text == ButtonB2.Text) && (ButtonB2.Text == ButtonC2.Text) && (!ButtonA2.Enabled))
                there_is_a_winner = true;
            else if ((ButtonA3.Text == ButtonB3.Text) && (ButtonB3.Text == ButtonC3.Text) && (!ButtonA3.Enabled))
                there_is_a_winner = true;

            //diagonal checks
            if ((ButtonA1.Text == ButtonB2.Text) && (ButtonB2.Text == ButtonC3.Text) && (!ButtonA1.Enabled))
                there_is_a_winner = true;
            else if ((ButtonA3.Text == ButtonB2.Text) && (ButtonB2.Text == ButtonC1.Text) && (!ButtonC1.Enabled))
                there_is_a_winner = true;
          
            if (there_is_a_winner)
         {
                disableButtons();

                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Wins!", "Congratulations!");
         }//end if
         else 
         {
                if (turn_count == 9)
                    MessageBox.Show("Draw!", "Game Over!");
         }

        }//end checkForWinner

        private void disableButtons()
        {
            try
            {
                foreach (Component c in Controls)
                {
                Button b = (Button)c;
                b.Enabled = false;
                    turn_count++;
                }//end foreach
            }//end try
            catch { }
        }

        private void NewGameMenuStrip_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    turn_count++;
                }//end foreach
            }//end try
            catch { }
        }
    }
}
