namespace TicTacToeGame
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.one_player_btn = new System.Windows.Forms.Button();
            this.two_player_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one_player_btn
            // 
            this.one_player_btn.BackColor = System.Drawing.Color.Gray;
            this.one_player_btn.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_player_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.one_player_btn.Location = new System.Drawing.Point(844, 146);
            this.one_player_btn.Name = "one_player_btn";
            this.one_player_btn.Size = new System.Drawing.Size(300, 100);
            this.one_player_btn.TabIndex = 0;
            this.one_player_btn.Text = "One Player";
            this.one_player_btn.UseVisualStyleBackColor = false;
            this.one_player_btn.Click += new System.EventHandler(this.one_player_btn_Click);
            // 
            // two_player_btn
            // 
            this.two_player_btn.BackColor = System.Drawing.Color.Gray;
            this.two_player_btn.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_player_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.two_player_btn.Location = new System.Drawing.Point(844, 314);
            this.two_player_btn.Name = "two_player_btn";
            this.two_player_btn.Size = new System.Drawing.Size(300, 100);
            this.two_player_btn.TabIndex = 1;
            this.two_player_btn.Text = "Two Player";
            this.two_player_btn.UseVisualStyleBackColor = false;
            this.two_player_btn.Click += new System.EventHandler(this.two_player_btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToeGame.Properties.Resources.mainmenubg1;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.two_player_btn);
            this.Controls.Add(this.one_player_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button one_player_btn;
        private System.Windows.Forms.Button two_player_btn;
    }
}