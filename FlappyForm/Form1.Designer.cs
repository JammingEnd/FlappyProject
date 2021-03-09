
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
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.Pipe1 = new System.Windows.Forms.PictureBox();
            this.Pipe2 = new System.Windows.Forms.PictureBox();
            this.currenScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.HSButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Ground = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlappyBird
            // 
            this.FlappyBird.BackColor = System.Drawing.Color.Lime;
            this.FlappyBird.Location = new System.Drawing.Point(27, 101);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(100, 50);
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            // 
            // Pipe1
            // 
            this.Pipe1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Pipe1.Location = new System.Drawing.Point(803, 586);
            this.Pipe1.Name = "Pipe1";
            this.Pipe1.Size = new System.Drawing.Size(100, 50);
            this.Pipe1.TabIndex = 1;
            this.Pipe1.TabStop = false;
            // 
            // Pipe2
            // 
            this.Pipe2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Pipe2.Location = new System.Drawing.Point(803, -2);
            this.Pipe2.Name = "Pipe2";
            this.Pipe2.Size = new System.Drawing.Size(100, 50);
            this.Pipe2.TabIndex = 2;
            this.Pipe2.TabStop = false;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.HSButton);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Location = new System.Drawing.Point(344, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 315);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(21, 240);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 48);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Gold;
            this.Ground.Location = new System.Drawing.Point(-5, 642);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1010, 57);
            this.Ground.TabIndex = 5;
            this.Ground.Paint += new System.Windows.Forms.PaintEventHandler(this.Ground_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(993, 689);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currenScore);
            this.Controls.Add(this.Pipe2);
            this.Controls.Add(this.Pipe1);
            this.Controls.Add(this.FlappyBird);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox Pipe1;
        private System.Windows.Forms.PictureBox Pipe2;
        private System.Windows.Forms.Label currenScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button HSButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel Ground;
    }
}

