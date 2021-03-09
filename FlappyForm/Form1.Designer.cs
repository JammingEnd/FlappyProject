
namespace FlappyForm
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
            this.components = new System.ComponentModel.Container();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.pipe1 = new System.Windows.Forms.PictureBox();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.currenScore = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HSButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.Ground = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.birdTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlappyBird
            // 
            this.FlappyBird.BackColor = System.Drawing.Color.Lime;
            this.FlappyBird.Location = new System.Drawing.Point(131, 265);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(100, 50);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            // 
            // pipe1
            // 
            this.pipe1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pipe1.Location = new System.Drawing.Point(803, 340);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(100, 337);
            this.pipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe1.TabIndex = 1;
            this.pipe1.TabStop = false;
            // 
            // pipe2
            // 
            this.pipe2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pipe2.Location = new System.Drawing.Point(803, 0);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(100, 195);
            this.pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe2.TabIndex = 2;
            this.pipe2.TabStop = false;
            // 
            // currenScore
            // 
            this.currenScore.AutoSize = true;
            this.currenScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.currenScore.Location = new System.Drawing.Point(20, 9);
            this.currenScore.Name = "currenScore";
            this.currenScore.Size = new System.Drawing.Size(124, 39);
            this.currenScore.TabIndex = 3;
            this.currenScore.Text = "Score: ";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Khaki;
            this.MenuPanel.Controls.Add(this.ExitButton);
            this.MenuPanel.Controls.Add(this.HSButton);
            this.MenuPanel.Controls.Add(this.StartButton);
            this.MenuPanel.Location = new System.Drawing.Point(344, 147);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(265, 315);
            this.MenuPanel.TabIndex = 4;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(21, 240);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 48);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HSButton
            // 
            this.HSButton.BackColor = System.Drawing.Color.Gray;
            this.HSButton.Location = new System.Drawing.Point(73, 144);
            this.HSButton.Name = "HSButton";
            this.HSButton.Size = new System.Drawing.Size(126, 59);
            this.HSButton.TabIndex = 1;
            this.HSButton.Text = "Highscores";
            this.HSButton.UseVisualStyleBackColor = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Gray;
            this.StartButton.Location = new System.Drawing.Point(73, 44);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(126, 59);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Gold;
            this.Ground.Location = new System.Drawing.Point(-5, 642);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1010, 57);
            this.Ground.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // birdTimer
            // 
            this.birdTimer.Enabled = true;
            this.birdTimer.Interval = 10;
            this.birdTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(993, 689);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.currenScore);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.pipe1);
            this.Controls.Add(this.Ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox pipe1;
        private System.Windows.Forms.PictureBox pipe2;
        private System.Windows.Forms.Label currenScore;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button HSButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel Ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer birdTimer;
    }
}

