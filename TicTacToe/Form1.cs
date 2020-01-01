using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        private void buttonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
               
                if (CheckWinner() == true)
                {
                    if ((button.Text)=="X")
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

        private void Form1_Load(object sender, EventArgs e)
        {
            lblX.Text =""+s1;
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
       
        bool CheckWinner()
        {
            if (btn00.Text == btn01.Text && btn02.Text == btn01.Text && btn00.Text != "")
                return true;
            else
                   if (btn10.Text == btn11.Text && btn12.Text == btn11.Text && btn10.Text != "")
                return true;
            else
                   if (btn20.Text == btn21.Text && btn22.Text == btn21.Text && btn20.Text != "")
                return true;


            if (btn00.Text == btn11.Text && btn11.Text == btn22.Text && btn00.Text != "")
                return true;
            else
                if (btn02.Text == btn11.Text && btn11.Text == btn20.Text && btn20.Text != "")
                return true;

            if (btn00.Text == btn10.Text && btn20.Text == btn10.Text && btn10.Text != "")
                return true;
            else
                  if (btn01.Text == btn11.Text && btn11.Text == btn21.Text && btn21.Text != "")
                return true;
            else
                  if (btn02.Text == btn12.Text && btn12.Text == btn22.Text && btn22.Text != "")
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

