namespace TicTacToeGame
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pname2 = new System.Windows.Forms.Label();
            this.pname1 = new System.Windows.Forms.Label();
            this.p1_score = new System.Windows.Forms.Label();
            this.p2_score = new System.Windows.Forms.Label();
            this.reset_score = new System.Windows.Forms.Label();
            this.play_again_btn = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Gainsboro;
            this.A1.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.Color.Tomato;
            this.A1.Location = new System.Drawing.Point(86, 106);
            this.A1.Margin = new System.Windows.Forms.Padding(0);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(200, 140);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Silver;
            this.A2.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.Color.Tomato;
            this.A2.Location = new System.Drawing.Point(324, 106);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(200, 140);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.DarkGray;
            this.A3.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.Color.Tomato;
            this.A3.Location = new System.Drawing.Point(561, 106);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(200, 140);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Silver;
            this.B1.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.Color.Tomato;
            this.B1.Location = new System.Drawing.Point(86, 269);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(200, 140);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Gray;
            this.B3.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.Color.Tomato;
            this.B3.Location = new System.Drawing.Point(561, 269);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(200, 140);
            this.B3.TabIndex = 4;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.DarkGray;
            this.B2.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.Color.Tomato;
            this.B2.Location = new System.Drawing.Point(324, 269);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(200, 140);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.DarkGray;
            this.C1.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.ForeColor = System.Drawing.Color.Tomato;
            this.C1.Location = new System.Drawing.Point(86, 428);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(200, 140);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.Gray;
            this.C2.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.ForeColor = System.Drawing.Color.Tomato;
            this.C2.Location = new System.Drawing.Point(324, 428);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(200, 140);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.DimGray;
            this.C3.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.ForeColor = System.Drawing.Color.Tomato;
            this.C3.Location = new System.Drawing.Point(561, 428);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(200, 140);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1282, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 33);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(165, 34);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 33);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(128, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pname2
            // 
            this.pname2.AutoSize = true;
            this.pname2.BackColor = System.Drawing.Color.Transparent;
            this.pname2.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname2.ForeColor = System.Drawing.Color.GhostWhite;
            this.pname2.Location = new System.Drawing.Point(922, 237);
            this.pname2.Name = "pname2";
            this.pname2.Size = new System.Drawing.Size(220, 52);
            this.pname2.TabIndex = 10;
            this.pname2.Text = "Player 2 Score";
            this.pname2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pname1
            // 
            this.pname1.AutoSize = true;
            this.pname1.BackColor = System.Drawing.Color.Transparent;
            this.pname1.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname1.ForeColor = System.Drawing.Color.GhostWhite;
            this.pname1.Location = new System.Drawing.Point(922, 105);
            this.pname1.Name = "pname1";
            this.pname1.Size = new System.Drawing.Size(220, 52);
            this.pname1.TabIndex = 12;
            this.pname1.Text = "Player 1 Score";
            this.pname1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1_score
            // 
            this.p1_score.AutoSize = true;
            this.p1_score.BackColor = System.Drawing.Color.Transparent;
            this.p1_score.Font = new System.Drawing.Font("Mistral", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_score.ForeColor = System.Drawing.Color.Tomato;
            this.p1_score.Location = new System.Drawing.Point(996, 158);
            this.p1_score.Name = "p1_score";
            this.p1_score.Size = new System.Drawing.Size(66, 81);
            this.p1_score.TabIndex = 13;
            this.p1_score.Text = "0";
            this.p1_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2_score
            // 
            this.p2_score.AutoSize = true;
            this.p2_score.BackColor = System.Drawing.Color.Transparent;
            this.p2_score.Font = new System.Drawing.Font("Mistral", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_score.ForeColor = System.Drawing.Color.Tomato;
            this.p2_score.Location = new System.Drawing.Point(996, 296);
            this.p2_score.Name = "p2_score";
            this.p2_score.Size = new System.Drawing.Size(66, 81);
            this.p2_score.TabIndex = 14;
            this.p2_score.Text = "0";
            this.p2_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reset_score
            // 
            this.reset_score.AutoSize = true;
            this.reset_score.BackColor = System.Drawing.Color.Gray;
            this.reset_score.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_score.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reset_score.Location = new System.Drawing.Point(891, 480);
            this.reset_score.Margin = new System.Windows.Forms.Padding(10);
            this.reset_score.Name = "reset_score";
            this.reset_score.Size = new System.Drawing.Size(278, 71);
            this.reset_score.TabIndex = 16;
            this.reset_score.Text = " Reset Score  ";
            this.reset_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reset_score.Click += new System.EventHandler(this.reset_score_Click);
            // 
            // play_again_btn
            // 
            this.play_again_btn.AutoSize = true;
            this.play_again_btn.BackColor = System.Drawing.Color.Gray;
            this.play_again_btn.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_again_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.play_again_btn.Location = new System.Drawing.Point(891, 391);
            this.play_again_btn.Margin = new System.Windows.Forms.Padding(10);
            this.play_again_btn.Name = "play_again_btn";
            this.play_again_btn.Size = new System.Drawing.Size(277, 71);
            this.play_again_btn.TabIndex = 17;
            this.play_again_btn.Text = " Play Again ";
            this.play_again_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.play_again_btn.Click += new System.EventHandler(this.play_again_btn_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToeGame.Properties.Resources.gamebg1;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.play_again_btn);
            this.Controls.Add(this.reset_score);
            this.Controls.Add(this.p2_score);
            this.Controls.Add(this.p1_score);
            this.Controls.Add(this.pname1);
            this.Controls.Add(this.pname2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label pname2;
        private System.Windows.Forms.Label pname1;
        private System.Windows.Forms.Label p1_score;
        private System.Windows.Forms.Label p2_score;
        private System.Windows.Forms.Label reset_score;
        private System.Windows.Forms.Label play_again_btn;
    }
}

