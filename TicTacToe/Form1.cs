using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// This program was developed by Uriel
//I hope you will enjoy!!
//recommended: try to beat my algo! hahaha
namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Initializa number of players
        public int player = 2;
        // Initialize turns
        public int turns = 0;
        //Player 1 score
        public int s1 = 0;
        //Player 2 score
        public int s2 = 0;
        //ties
        public int sd = 0;
        //When the user presses a buttun. Same fot all buttons 
        private void buttonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (button.Text == "")
            {
                //if its player1
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                //if its player2
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
                //Go to check winner function
                if (CheckWinner() == true)
                {
                    if ((button.Text) == "X")
                    {
                        MessageBox.Show("X won!");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O won!");
                        s2++;
                        NewGame();
                    }
                }
                if (CheckDraw())
                {
                    MessageBox.Show("tie!");
                    sd++;
                    NewGame();
                }
            }
        }
        //Initialize lables at form load
        private void Form1_Load(object sender, EventArgs e)
        {
            lblX.Text = "" + s1;
            lblO.Text = "" + s2;
            lblD.Text = "" + sd;
        }
        void NewGame()
        {
            lblX.Text = "" + s1;
            lblO.Text = "" + s2;
            lblD.Text = "" + sd;
            player = 2;
            turns = 0;
            btn00.Text = btn01.Text = btn02.Text = btn10.Text = btn11.Text = btn12.Text = btn20.Text = btn21.Text = btn22.Text = "";

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        bool CheckDraw()
        {
            if (turns == 9)
                return true;
            else
                return false;
        }
        //Checking who won
        bool CheckWinner()
        {
            //0 Horizontal (row)
            if (btn00.Text == btn01.Text && btn02.Text == btn01.Text && btn00.Text != "")
                return true;
            //1 Horizontal
            else
                   if (btn10.Text == btn11.Text && btn12.Text == btn11.Text && btn10.Text != "")
                return true;
            //2 Horizontal
            else
                   if (btn20.Text == btn21.Text && btn22.Text == btn21.Text && btn20.Text != "")
                return true;

            //0 Vertical (col)
            if (btn00.Text == btn11.Text && btn11.Text == btn22.Text && btn00.Text != "")
                return true;
            else
                  //1 Vertical (col)
                  if (btn01.Text == btn11.Text && btn11.Text == btn21.Text && btn21.Text != "")
                return true;
            //2 Vertical (col)
            else
                  if (btn02.Text == btn12.Text && btn12.Text == btn22.Text && btn22.Text != "")
                return true;
            else
                //slant bottom left to up-right
                if (btn02.Text == btn11.Text && btn11.Text == btn20.Text && btn20.Text != "")
                return true;
            //slant up-left to bottom-right
            if (btn00.Text == btn10.Text && btn20.Text == btn10.Text && btn10.Text != "")
                return true;

            return false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {

        }

        private void PBSP_Click(object sender, EventArgs e)
        {
            singlePlayer sp = new singlePlayer();
            sp.ShowDialog();
        }
    }
}

