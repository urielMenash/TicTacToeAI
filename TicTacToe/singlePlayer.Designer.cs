namespace TicTacToe
{
    partial class singlePlayer
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
            this.lblOWins = new System.Windows.Forms.Label();
            this.lblXWins = new System.Windows.Forms.Label();
            this.lblDraws = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.lblO = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOWins
            // 
            this.lblOWins.AutoSize = true;
            this.lblOWins.Location = new System.Drawing.Point(544, 342);
            this.lblOWins.Name = "lblOWins";
            this.lblOWins.Size = new System.Drawing.Size(42, 13);
            this.lblOWins.TabIndex = 29;
            this.lblOWins.Text = "O wins:";
            // 
            // lblXWins
            // 
            this.lblXWins.AutoSize = true;
            this.lblXWins.Location = new System.Drawing.Point(540, 226);
            this.lblXWins.Name = "lblXWins";
            this.lblXWins.Size = new System.Drawing.Size(41, 13);
            this.lblXWins.TabIndex = 28;
            this.lblXWins.Text = "X wins:";
            // 
            // lblDraws
            // 
            this.lblDraws.AutoSize = true;
            this.lblDraws.Location = new System.Drawing.Point(544, 121);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(40, 13);
            this.lblDraws.TabIndex = 27;
            this.lblDraws.Text = "Draws:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(450, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 34);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Maroon;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReset.ForeColor = System.Drawing.Color.Yellow;
            this.btnReset.Location = new System.Drawing.Point(311, 409);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 34);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Maroon;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNew.ForeColor = System.Drawing.Color.Yellow;
            this.btnNew.Location = new System.Drawing.Point(123, 399);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(139, 49);
            this.btnNew.TabIndex = 24;
            this.btnNew.Text = "new game";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(182, 81);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(100, 89);
            this.btn00.TabIndex = 23;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(434, 81);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(100, 89);
            this.btn02.TabIndex = 22;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(182, 188);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(100, 89);
            this.btn10.TabIndex = 21;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(311, 188);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(100, 89);
            this.btn11.TabIndex = 20;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(434, 188);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(100, 89);
            this.btn12.TabIndex = 19;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(182, 304);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(100, 89);
            this.btn20.TabIndex = 18;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(311, 304);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(100, 89);
            this.btn21.TabIndex = 17;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(434, 304);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(100, 89);
            this.btn22.TabIndex = 16;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(311, 81);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(100, 89);
            this.btn01.TabIndex = 15;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.buttonClick);
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Location = new System.Drawing.Point(592, 342);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(0, 13);
            this.lblO.TabIndex = 32;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(588, 226);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 13);
            this.lblX.TabIndex = 31;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(592, 121);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(0, 13);
            this.lblD.TabIndex = 30;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(270, -8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 63);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Unbeatable";
            // 
            // singlePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.fire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.lblTitle);
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
            this.Name = "singlePlayer";
            this.Text = "singlePlayer";
            this.Load += new System.EventHandler(this.singlePlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOWins;
        private System.Windows.Forms.Label lblXWins;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblTitle;
    }
}