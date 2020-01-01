namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn01 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.lblDraws = new System.Windows.Forms.Label();
            this.lblXWins = new System.Windows.Forms.Label();
            this.lblOWins = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lbl2Ply = new System.Windows.Forms.Label();
            this.PBSP = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(157, 131);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(100, 89);
            this.btn01.TabIndex = 0;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(280, 354);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(100, 89);
            this.btn22.TabIndex = 1;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(157, 354);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(100, 89);
            this.btn21.TabIndex = 2;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(28, 354);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(100, 89);
            this.btn20.TabIndex = 3;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(280, 238);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(100, 89);
            this.btn12.TabIndex = 4;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(157, 238);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(100, 89);
            this.btn11.TabIndex = 5;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(28, 238);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(100, 89);
            this.btn10.TabIndex = 6;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(280, 131);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(100, 89);
            this.btn02.TabIndex = 7;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(28, 131);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(100, 89);
            this.btn00.TabIndex = 8;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.buttonClick);
            // 
            // lblDraws
            // 
            this.lblDraws.AutoSize = true;
            this.lblDraws.Location = new System.Drawing.Point(402, 171);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(40, 13);
            this.lblDraws.TabIndex = 12;
            this.lblDraws.Text = "Draws:";
            // 
            // lblXWins
            // 
            this.lblXWins.AutoSize = true;
            this.lblXWins.Location = new System.Drawing.Point(398, 276);
            this.lblXWins.Name = "lblXWins";
            this.lblXWins.Size = new System.Drawing.Size(41, 13);
            this.lblXWins.TabIndex = 13;
            this.lblXWins.Text = "X wins:";
            // 
            // lblOWins
            // 
            this.lblOWins.AutoSize = true;
            this.lblOWins.Location = new System.Drawing.Point(402, 392);
            this.lblOWins.Name = "lblOWins";
            this.lblOWins.Size = new System.Drawing.Size(42, 13);
            this.lblOWins.TabIndex = 14;
            this.lblOWins.Text = "O wins:";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(450, 171);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(0, 13);
            this.lblD.TabIndex = 15;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(450, 276);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 13);
            this.lblX.TabIndex = 16;
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Location = new System.Drawing.Point(450, 392);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(0, 13);
            this.lblO.TabIndex = 17;
            // 
            // lbl2Ply
            // 
            this.lbl2Ply.AutoSize = true;
            this.lbl2Ply.BackColor = System.Drawing.Color.Transparent;
            this.lbl2Ply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl2Ply.ForeColor = System.Drawing.Color.Blue;
            this.lbl2Ply.Location = new System.Drawing.Point(151, 73);
            this.lbl2Ply.Name = "lbl2Ply";
            this.lbl2Ply.Size = new System.Drawing.Size(133, 31);
            this.lbl2Ply.TabIndex = 19;
            this.lbl2Ply.Text = "2 players";
            // 
            // PBSP
            // 
            this.PBSP.BackgroundImage = global::TicTacToe.Properties.Resources.button__1_;
            this.PBSP.Location = new System.Drawing.Point(463, 214);
            this.PBSP.Name = "PBSP";
            this.PBSP.Size = new System.Drawing.Size(325, 51);
            this.PBSP.TabIndex = 20;
            this.PBSP.TabStop = false;
            this.PBSP.Click += new System.EventHandler(this.PBSP_Click);
            this.PBSP.DoubleClick += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::TicTacToe.Properties.Resources.button__4_;
            this.btnExit.Location = new System.Drawing.Point(332, 458);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 55);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::TicTacToe.Properties.Resources.button__3_;
            this.btnReset.Location = new System.Drawing.Point(194, 460);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 45);
            this.btnReset.TabIndex = 10;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = global::TicTacToe.Properties.Resources.button__2_;
            this.btnNew.Location = new System.Drawing.Point(12, 465);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(138, 40);
            this.btnNew.TabIndex = 9;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.backG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.PBSP);
            this.Controls.Add(this.lbl2Ply);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblOWins);
            this.Controls.Add(this.lblXWins);
            this.Controls.Add(this.lblDraws);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn01);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.Label lblXWins;
        private System.Windows.Forms.Label lblOWins;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lbl2Ply;
        private System.Windows.Forms.PictureBox PBSP;
    }
}

