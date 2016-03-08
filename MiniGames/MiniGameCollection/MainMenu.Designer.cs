namespace MiniGameCollection
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.tictactoeGame = new System.Windows.Forms.Button();
            this.snakeGame = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // tictactoeGame
            // 
            this.tictactoeGame.BackColor = System.Drawing.Color.OrangeRed;
            this.tictactoeGame.Font = new System.Drawing.Font("Super Mario 256", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tictactoeGame.ForeColor = System.Drawing.Color.White;
            this.tictactoeGame.Location = new System.Drawing.Point(569, 281);
            this.tictactoeGame.Name = "tictactoeGame";
            this.tictactoeGame.Size = new System.Drawing.Size(320, 85);
            this.tictactoeGame.TabIndex = 2;
            this.tictactoeGame.Text = "Tic Tac Toe";
            this.tictactoeGame.UseVisualStyleBackColor = false;
            this.tictactoeGame.Click += new System.EventHandler(this.tictactoeGame_Click);
            // 
            // snakeGame
            // 
            this.snakeGame.BackColor = System.Drawing.Color.OrangeRed;
            this.snakeGame.Font = new System.Drawing.Font("Super Mario 256", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snakeGame.ForeColor = System.Drawing.Color.White;
            this.snakeGame.Location = new System.Drawing.Point(569, 479);
            this.snakeGame.Name = "snakeGame";
            this.snakeGame.Size = new System.Drawing.Size(320, 88);
            this.snakeGame.TabIndex = 3;
            this.snakeGame.Text = "Snake";
            this.snakeGame.UseVisualStyleBackColor = false;
            this.snakeGame.Click += new System.EventHandler(this.snakeGame_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 32);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiniGameCollection.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.snakeGame);
            this.Controls.Add(this.tictactoeGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Game Collection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button tictactoeGame;
        private System.Windows.Forms.Button snakeGame;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

