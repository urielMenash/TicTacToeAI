﻿using System;
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
    public partial class singlePlayer : Form
    {
        public singlePlayer()
        {
            InitializeComponent();
        }
        public int player = 2; // 2 is PC
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0; //as PC
        public int sd = 0;
        private void buttonClick(object sender, EventArgs e)
        {
            Button rcv = new Button();
            Button button = (Button)sender;
            if (button.Text == "")
            {
                    button.Text = "X";
                    player++;
                    turns++;
                if (CheckDraw())
                {
                    MessageBox.Show("tie!");
                    sd++;
                    NewGame();
                }
                if (turns == 1 && btn11.Text == "")
                {
                    btn11.Text = "O";
                    player++;
                    turns++;
                    return;
                }
                else
                {
                    if (turns % 2 ==1)
                    {
                        rcv = CheckToWin();
                        if (rcv.Text != "f")
                        {
                            rcv.Text = "O";
                            MakeWin();
                            return;
                        }

                        rcv = CheckToLose();
                        if (rcv.Text != "f")
                        {
                            rcv.Text = "O";
                            player++;
                            turns++;
                            return;
                        }

                        if (btn11.Text == "")
                        {
                            btn11.Text = "O";
                            player++;
                            turns++;
                            return;
                        }
                        else
                        {
                            rcv = Fork();
                            if (rcv.Text != "f")
                            {
                                rcv.Text = "O";
                                player++;
                                turns++;
                                return;
                            }
                            else
                            {
                                rcv = RandomCorner();
                                if (rcv.Text != "f")
                                {
                                    rcv.Text = "O";
                                    player++;
                                    turns++;
                                    return;
                                }
                                else
                                {
                                    rcv = RandomCorner();
                                    if (rcv.Text != "f")
                                    {
                                        rcv.Text = "O";
                                        player++;
                                        turns++;
                                        return;
                                    }
                                }
                            }
                        }
                    }
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
                            }
            }
            else MessageBox.Show("press valid button");
        }
        private void MakeWin()
        {
            MessageBox.Show("O won!");
            s2++;
            NewGame();
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        Button CheckToWin()
        //meuzan
        { 
            if (((btn00.Text == btn01.Text) &&( btn01.Text == "O")) && btn02.Text == "")
                return btn02;
            else
                if (((btn00.Text == btn02.Text) && (btn02.Text == "O")) && btn01.Text == "")
                return btn01;
            else
                  if (((btn02.Text == btn01.Text) && (btn01.Text == "O")) && btn00.Text == "")
                return btn00;
            if (((btn10.Text == btn11.Text) && (btn11.Text == "O")) && btn12.Text == "")
                return btn12;
            else
              if (((btn10.Text == btn12.Text) && (btn12.Text == "O")) && btn11.Text == "")
                return btn11;
            else
                if (((btn12.Text == btn11.Text) && (btn11.Text == "O")) && btn10.Text == "")
                return btn10;
            if (((btn20.Text == btn21.Text) && (btn21.Text == "O")) && btn22.Text == "")
                return btn22;
            else
             if (((btn20.Text == btn22.Text) && (btn22.Text == "O")) && btn21.Text == "")
                return btn21;
            else
               if (((btn22.Text == btn21.Text) && (btn21.Text == "O")) && btn20.Text == "")
                return btn20;

            //meunach
            if (((btn00.Text == btn10.Text) && (btn10.Text == "O")) && btn20.Text == "")
                return btn20;
            else
       if (((btn00.Text == btn20.Text) && (btn20.Text == "O")) && btn10.Text == "")
                return btn10;
            else
         if (((btn20.Text == btn10.Text) && (btn10.Text == "O")) && btn00.Text == "")
                return btn00;
            if (((btn01.Text == btn11.Text) && (btn11.Text == "O")) && btn21.Text == "")
                return btn21;
            else
              if (((btn01.Text == btn21.Text) && (btn21.Text == "O")) && btn11.Text == "")
                return btn11;
            else
                if (((btn21.Text == btn11.Text) && (btn11.Text == "O")) && btn01.Text == "")
                return btn01;
            if (((btn02.Text == btn12.Text) && (btn12.Text == "O")) && btn22.Text == "")
                return btn22;
            else
             if (((btn02.Text == btn22.Text) && (btn22.Text == "O")) && btn12.Text == "")
                return btn12;
            else
               if (((btn22.Text == btn12.Text) && (btn12.Text == "O")) && btn02.Text == "")
                return btn02;
            //alachson
            if (((btn00.Text == btn11.Text) && (btn11.Text == "O")) && btn22.Text == "")
                return btn22;
            else if (((btn00.Text == btn22.Text) && (btn22.Text == "O")) && btn11.Text == "")
                return btn11;
            else if (((btn11.Text == btn22.Text) && (btn22.Text == "O")) && btn00.Text == "")
                return btn00;

            if (((btn02.Text == btn11.Text) && (btn11.Text == "O")) && btn20.Text == "")
                return btn20;
            else if (((btn02.Text == btn20.Text) && (btn20.Text == "O")) && btn11.Text == "")
                return btn11;
            else if (((btn11.Text == btn20.Text) && (btn20.Text == "O")) && btn02.Text == "")
                return btn02;
            Button flag = new Button();
            flag.Text = "f";
            return flag;
        }
        Button CheckToLose()
        //meuzan
        {
            if (((btn00.Text == btn01.Text) && (btn01.Text == "X"))&&btn02.Text=="")
                return btn02;
            else
                if (((btn00.Text == btn02.Text) && (btn02.Text == "X"))&&btn01.Text == "")
                return btn01;
            else
                  if (((btn02.Text == btn01.Text) && (btn01.Text == "X"))&&btn00.Text == "")
                return btn00;
            if (((btn10.Text == btn11.Text) && (btn11.Text == "X")) && btn12.Text == "")
                return btn12;
            else
              if (((btn10.Text == btn12.Text) && (btn12.Text == "X")) && btn11.Text == "")
                return btn11;
            else
                if (((btn12.Text == btn11.Text) && (btn11.Text == "X")) && btn10.Text == "")
                return btn10;
            if (((btn20.Text == btn21.Text) && (btn21.Text == "X")) && btn22.Text == "")
                return btn22;
            else
             if (((btn20.Text == btn22.Text) && (btn22.Text == "X")) && btn21.Text == "")
                return btn21;
            else
               if (((btn22.Text == btn21.Text) && (btn21.Text == "X")) && btn20.Text == "")
                return btn20;

            //meunach
            if (((btn00.Text == btn10.Text) && (btn10.Text == "X")) && btn20.Text == "")
                return btn20;
            else
       if (((btn00.Text == btn20.Text) && (btn20.Text == "X")) && btn10.Text == "")
                return btn10;
            else
         if (((btn20.Text == btn10.Text) && (btn10.Text == "X")) && btn00.Text == "")
                return btn00;
            if (((btn01.Text == btn11.Text) && (btn11.Text == "X")) && btn21.Text == "")
                return btn21;
            else
              if (((btn10.Text == btn21.Text) && (btn21.Text == "X")) && btn11.Text == "")
                return btn11;
            else
                if (((btn21.Text == btn11.Text) && (btn11.Text == "X")) && btn01.Text == "")
                return btn01;
            if (((btn02.Text == btn12.Text) && (btn12.Text == "X")) && btn22.Text == "")
                return btn22;
            else
             if (((btn02.Text == btn22.Text) && (btn22.Text == "X")) && btn12.Text == "")
                return btn12;
            else
               if (((btn22.Text == btn12.Text) && (btn12.Text == "X")) && btn02.Text == "")
                return btn02;
            //alachson
            if (((btn00.Text == btn11.Text) && (btn11.Text == "X")) && btn22.Text == "")
                return btn22;
            else if (((btn00.Text == btn22.Text) && (btn22.Text == "X")) && btn11.Text == "")
                return btn11;
            else if (((btn11.Text == btn22.Text) && (btn22.Text == "X")) && btn00.Text == "")
                return btn00;

            if (((btn02.Text == btn11.Text) && (btn11.Text == "X")) && btn20.Text == "")
                return btn20;
            else if (((btn02.Text == btn20.Text) && (btn20.Text == "X")) && btn11.Text == "")
                return btn11;
            else if (((btn11.Text == btn20.Text) && (btn20.Text == "X")) && btn02.Text == "")
                return btn02;
            Button flag = new Button();
            flag.Text = "f";
            return flag;
        }
        Button Fork()
        //meuzan
        { 
         if(turns==3)
            {
                //corners
                if(btn00.Text == "X")
                {
                    if ((btn21.Text == "X") || (btn22.Text == "X"))
                    {
                        return btn10;
                    }
                    else if (btn12.Text == "X")
                        return btn01;
                }
                else if (btn20.Text == "X")
                {
                    if ((btn12.Text == "X") || (btn02.Text == "X"))
                    {
                        return btn21;
                    }
                    else if (btn01.Text == "X")
                        return btn10;
                }
                if (btn02.Text == "X")
                {
                    if ((btn10.Text == "X") || (btn20.Text == "X"))
                    {
                        return btn01;
                    }
                    else if (btn21.Text == "X")
                        return btn12;
                }
              if (btn22.Text == "X")
                {
                    if ((btn01.Text == "X") || (btn00.Text == "X"))
                    {
                        return btn12;
                    }
                    else if (btn10.Text == "X")
                        return btn21;
                }
                if (btn22.Text == "X")
                {
                    if ((btn01.Text == "X") || (btn00.Text == "X"))
                    {
                        return btn12;
                    }
                    else if (btn10.Text == "X")
                        return btn21;
                }
                //sides, another fork check
                 if ((btn10.Text == "X") && (btn21.Text == "X"))
                    return btn20;
                 if ((btn10.Text == "X") && (btn01.Text == "X"))
                    return btn00;
                 if ((btn12.Text == "X") && (btn01.Text == "X"))
                    return btn02;
                 if ((btn12.Text == "X") && (btn21.Text == "X"))
                    return btn22;

            }






            Button flag = new Button();
            flag.Text = "f";
            return flag;
        }
        private void singlePlayer_Load(object sender, EventArgs e)
        {
            lblX.Text = "" + s1;
            lblO.Text = "" + s2;
            lblD.Text = "" + sd;
        }
        private static Random Rand = null;
        private Button RandomCorner()
        {
            Button b;
            Button[] arr = new Button []{ btn00, btn02, btn20,btn22 };
            // Create the Random object if it doesn't exist.
            if (Rand == null) Rand = new Random();

            // Pick an item and return it.
            for (int i = 0; ; i++)
            {
                b=arr[Rand.Next(0, arr.Length)];
                if (b.Text == "")
                    return b;
            }
        }
        private Button RandomGen()
        {
            Button b;
            Button[] arr = new Button[] { btn00,btn01, btn02,btn10,btn11,btn12, btn20,btn21, btn22 };
            // Create the Random object if it doesn't exist.
            if (Rand == null) Rand = new Random();

            // Pick an item and return it.
            for (int i = 0; ; i++)
            {
                b = arr[Rand.Next(0, arr.Length)];
                if (b.Text == "")
                    return b;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
