
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currentScore = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.healthbar = new System.Windows.Forms.ProgressBar();
            this.lifeLabel = new System.Windows.Forms.Label();
            this.menuScore = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HSButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.Ground = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.birdTimer = new System.Windows.Forms.Timer(this.components);
            this.GOText = new System.Windows.Forms.Label();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.pipe1 = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.PipeBottom1 = new System.Windows.Forms.PictureBox();
            this.pipe5 = new System.Windows.Forms.PictureBox();
            this.pipe4 = new System.Windows.Forms.PictureBox();
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            this.SuspendLayout();
            // 
            // currentScore
            // 
            this.currentScore.AutoSize = true;
            this.currentScore.BackColor = System.Drawing.Color.Transparent;
            this.currentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.currentScore.Location = new System.Drawing.Point(20, 9);
            this.currentScore.Name = "currentScore";
            this.currentScore.Size = new System.Drawing.Size(124, 39);
            this.currentScore.TabIndex = 3;
            this.currentScore.Text = "Score: ";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Khaki;
            this.MenuPanel.Controls.Add(this.healthbar);
            this.MenuPanel.Controls.Add(this.lifeLabel);
            this.MenuPanel.Controls.Add(this.menuScore);
            this.MenuPanel.Controls.Add(this.ExitButton);
            this.MenuPanel.Controls.Add(this.HSButton);
            this.MenuPanel.Controls.Add(this.StartButton);
            this.MenuPanel.Location = new System.Drawing.Point(728, 283);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(472, 315);
            this.MenuPanel.TabIndex = 4;
            // 
            // healthbar
            // 
            this.healthbar.ForeColor = System.Drawing.Color.Red;
            this.healthbar.Location = new System.Drawing.Point(302, 164);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(85, 23);
            this.healthbar.TabIndex = 5;
            // 
            // lifeLabel
            // 
            this.lifeLabel.AutoSize = true;
            this.lifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifeLabel.Location = new System.Drawing.Point(294, 83);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(131, 44);
            this.lifeLabel.TabIndex = 4;
            this.lifeLabel.Text = "LIVES";
            this.lifeLabel.Click += new System.EventHandler(this.lifeLabel_Click);
            // 
            // menuScore
            // 
            this.menuScore.AutoSize = true;
            this.menuScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuScore.Location = new System.Drawing.Point(135, 246);
            this.menuScore.Name = "menuScore";
            this.menuScore.Size = new System.Drawing.Size(78, 29);
            this.menuScore.TabIndex = 3;
            this.menuScore.Text = "score";
            this.menuScore.Click += new System.EventHandler(this.menuScore_Click);
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
            this.Ground.BackgroundImage = global::FlappyForm.Properties.Resources.edd1642b77bcabee7fa18846b2f8ff9d;
            this.Ground.Location = new System.Drawing.Point(-5, 879);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(2031, 171);
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
            // GOText
            // 
            this.GOText.AutoSize = true;
            this.GOText.BackColor = System.Drawing.Color.Transparent;
            this.GOText.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GOText.Location = new System.Drawing.Point(765, 230);
            this.GOText.Name = "GOText";
            this.GOText.Size = new System.Drawing.Size(179, 35);
            this.GOText.TabIndex = 8;
            this.GOText.Text = "Game Over";
            // 
            // pipe2
            // 
            this.pipe2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pipe2.Image = ((System.Drawing.Image)(resources.GetObject("pipe2.Image")));
            this.pipe2.Location = new System.Drawing.Point(1784, -2);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(100, 195);
            this.pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe2.TabIndex = 2;
            this.pipe2.TabStop = false;
            this.pipe2.Click += new System.EventHandler(this.pipe2_Click);
            // 
            // pipe1
            // 
            this.pipe1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pipe1.Image = ((System.Drawing.Image)(resources.GetObject("pipe1.Image")));
            this.pipe1.Location = new System.Drawing.Point(1784, 604);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(100, 685);
            this.pipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe1.TabIndex = 1;
            this.pipe1.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.BackColor = System.Drawing.Color.Lime;
            this.FlappyBird.Image = global::FlappyForm.Properties.Resources.png_transparent_flappy_bird_bird_flight_bird_frame_animals_smiley;
            this.FlappyBird.Location = new System.Drawing.Point(131, 265);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(100, 50);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            this.FlappyBird.Click += new System.EventHandler(this.FlappyBird_Click);
            // 
            // PipeBottom1
            // 
            this.PipeBottom1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PipeBottom1.Image = ((System.Drawing.Image)(resources.GetObject("PipeBottom1.Image")));
            this.PipeBottom1.Location = new System.Drawing.Point(341, 604);
            this.PipeBottom1.Name = "PipeBottom1";
            this.PipeBottom1.Size = new System.Drawing.Size(100, 685);
            this.PipeBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom1.TabIndex = 10;
            this.PipeBottom1.TabStop = false;
            // 
            // pipe5
            // 
            this.pipe5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pipe5.Image = ((System.Drawing.Image)(resources.GetObject("pipe5.Image")));
            this.pipe5.Location = new System.Drawing.Point(998, 604);
            this.pipe5.Name = "pipe5";
            this.pipe5.Size = new System.Drawing.Size(100, 685);
            this.pipe5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe5.TabIndex = 7;
            this.pipe5.TabStop = false;
            // 
            // pipe4
            // 
            this.pipe4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pipe4.Image = ((System.Drawing.Image)(resources.GetObject("pipe4.Image")));
            this.pipe4.Location = new System.Drawing.Point(998, -2);
            this.pipe4.Name = "pipe4";
            this.pipe4.Size = new System.Drawing.Size(100, 195);
            this.pipe4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe4.TabIndex = 6;
            this.pipe4.TabStop = false;
            this.pipe4.Click += new System.EventHandler(this.pipe4_Click);
            // 
            // pipeTop1
            // 
            this.pipeTop1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pipeTop1.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop1.Image")));
            this.pipeTop1.Location = new System.Drawing.Point(341, -2);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(100, 195);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 9;
            this.pipeTop1.TabStop = false;
            this.pipeTop1.Click += new System.EventHandler(this.pipeTop1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::FlappyForm.Properties.Resources.achtergrond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.pipe1);
            this.Controls.Add(this.GOText);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.currentScore);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.PipeBottom1);
            this.Controls.Add(this.pipe5);
            this.Controls.Add(this.pipe4);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.Ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox pipe1;
        private System.Windows.Forms.PictureBox pipe2;
        private System.Windows.Forms.Label currentScore;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button HSButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel Ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer birdTimer;
        private System.Windows.Forms.PictureBox pipe4;
        private System.Windows.Forms.PictureBox pipe5;
        private System.Windows.Forms.Label GOText;
        private System.Windows.Forms.Label menuScore;
        private System.Windows.Forms.ProgressBar healthbar;
        private System.Windows.Forms.Label lifeLabel;
        private System.Windows.Forms.PictureBox PipeBottom1;
        private System.Windows.Forms.PictureBox pipeTop1;
    }
}

