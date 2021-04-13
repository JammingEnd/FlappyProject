
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
            this.HighscorePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HSscoreViewer = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HSNameBox = new System.Windows.Forms.TextBox();
            this.sqlSendButton = new System.Windows.Forms.Button();
            this.HSBackbutton = new System.Windows.Forms.Button();
            this.SpeedUplabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            this.HighscorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // currentScore
            // 
            this.currentScore.AutoSize = true;
            this.currentScore.BackColor = System.Drawing.Color.Transparent;
            this.currentScore.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScore.Location = new System.Drawing.Point(798, 9);
            this.currentScore.Name = "currentScore";
            this.currentScore.Size = new System.Drawing.Size(139, 54);
            this.currentScore.TabIndex = 3;
            this.currentScore.Text = "Score: ";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Khaki;
            this.MenuPanel.Controls.Add(this.radioButton1);
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
            this.ExitButton.BackColor = System.Drawing.Color.Khaki;
            this.ExitButton.BackgroundImage = global::FlappyForm.Properties.Resources.Pbutton;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(21, 240);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 48);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HSButton
            // 
            this.HSButton.BackColor = System.Drawing.Color.Khaki;
            this.HSButton.BackgroundImage = global::FlappyForm.Properties.Resources.Bbutton;
            this.HSButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HSButton.Location = new System.Drawing.Point(73, 144);
            this.HSButton.Name = "HSButton";
            this.HSButton.Size = new System.Drawing.Size(126, 59);
            this.HSButton.TabIndex = 1;
            this.HSButton.Text = "Highscores";
            this.HSButton.UseVisualStyleBackColor = false;
            this.HSButton.Click += new System.EventHandler(this.HSButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Khaki;
            this.StartButton.BackgroundImage = global::FlappyForm.Properties.Resources.Gbutton;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.pipe2.Location = new System.Drawing.Point(1873, -2);
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
            this.pipe1.Location = new System.Drawing.Point(1873, 604);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(100, 685);
            this.pipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe1.TabIndex = 1;
            this.pipe1.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.BackColor = System.Drawing.Color.Transparent;
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
            this.PipeBottom1.Location = new System.Drawing.Point(518, 604);
            this.PipeBottom1.Name = "PipeBottom1";
            this.PipeBottom1.Size = new System.Drawing.Size(100, 685);
            this.PipeBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom1.TabIndex = 10;
            this.PipeBottom1.TabStop = false;
            this.PipeBottom1.Click += new System.EventHandler(this.PipeBottom1_Click);
            // 
            // pipe5
            // 
            this.pipe5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pipe5.Image = ((System.Drawing.Image)(resources.GetObject("pipe5.Image")));
            this.pipe5.Location = new System.Drawing.Point(1238, 604);
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
            this.pipe4.Location = new System.Drawing.Point(1238, -2);
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
            this.pipeTop1.Location = new System.Drawing.Point(518, -2);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(100, 195);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 9;
            this.pipeTop1.TabStop = false;
            this.pipeTop1.Click += new System.EventHandler(this.pipeTop1_Click);
            // 
            // HighscorePanel
            // 
            this.HighscorePanel.BackColor = System.Drawing.Color.NavajoWhite;
            this.HighscorePanel.Controls.Add(this.label1);
            this.HighscorePanel.Controls.Add(this.HSscoreViewer);
            this.HighscorePanel.Controls.Add(this.dataGridView1);
            this.HighscorePanel.Controls.Add(this.HSNameBox);
            this.HighscorePanel.Controls.Add(this.sqlSendButton);
            this.HighscorePanel.Controls.Add(this.HSBackbutton);
            this.HighscorePanel.Location = new System.Drawing.Point(41, 95);
            this.HighscorePanel.Name = "HighscorePanel";
            this.HighscorePanel.Size = new System.Drawing.Size(660, 476);
            this.HighscorePanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // HSscoreViewer
            // 
            this.HSscoreViewer.AutoSize = true;
            this.HSscoreViewer.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSscoreViewer.Location = new System.Drawing.Point(209, 375);
            this.HSscoreViewer.Name = "HSscoreViewer";
            this.HSscoreViewer.Size = new System.Drawing.Size(0, 31);
            this.HSscoreViewer.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(621, 328);
            this.dataGridView1.TabIndex = 3;
            // 
            // HSNameBox
            // 
            this.HSNameBox.Location = new System.Drawing.Point(215, 422);
            this.HSNameBox.Name = "HSNameBox";
            this.HSNameBox.Size = new System.Drawing.Size(219, 22);
            this.HSNameBox.TabIndex = 2;
            // 
            // sqlSendButton
            // 
            this.sqlSendButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.sqlSendButton.BackgroundImage = global::FlappyForm.Properties.Resources.Gbutton;
            this.sqlSendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sqlSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqlSendButton.Location = new System.Drawing.Point(548, 418);
            this.sqlSendButton.Name = "sqlSendButton";
            this.sqlSendButton.Size = new System.Drawing.Size(94, 34);
            this.sqlSendButton.TabIndex = 1;
            this.sqlSendButton.Text = "Send";
            this.sqlSendButton.UseVisualStyleBackColor = false;
            this.sqlSendButton.Click += new System.EventHandler(this.sqlSendButton_Click);
            // 
            // HSBackbutton
            // 
            this.HSBackbutton.BackColor = System.Drawing.Color.NavajoWhite;
            this.HSBackbutton.BackgroundImage = global::FlappyForm.Properties.Resources.Pbutton;
            this.HSBackbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HSBackbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HSBackbutton.Location = new System.Drawing.Point(21, 414);
            this.HSBackbutton.Name = "HSBackbutton";
            this.HSBackbutton.Size = new System.Drawing.Size(92, 38);
            this.HSBackbutton.TabIndex = 0;
            this.HSBackbutton.Text = "Back";
            this.HSBackbutton.UseVisualStyleBackColor = false;
            this.HSBackbutton.Click += new System.EventHandler(this.HSBackbutton_Click);
            // 
            // SpeedUplabel
            // 
            this.SpeedUplabel.AutoSize = true;
            this.SpeedUplabel.BackColor = System.Drawing.Color.Transparent;
            this.SpeedUplabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedUplabel.Location = new System.Drawing.Point(825, 63);
            this.SpeedUplabel.Name = "SpeedUplabel";
            this.SpeedUplabel.Size = new System.Drawing.Size(0, 31);
            this.SpeedUplabel.TabIndex = 12;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(162, 291);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(307, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Experimantel mode (kinda breaks the game)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::FlappyForm.Properties.Resources.achtergrond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.Controls.Add(this.SpeedUplabel);
            this.Controls.Add(this.HighscorePanel);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.pipe1);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.currentScore);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.PipeBottom1);
            this.Controls.Add(this.pipe5);
            this.Controls.Add(this.pipe4);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.GOText);
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
            this.HighscorePanel.ResumeLayout(false);
            this.HighscorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Panel HighscorePanel;
        private System.Windows.Forms.Button HSBackbutton;
        private System.Windows.Forms.Button sqlSendButton;
        private System.Windows.Forms.TextBox HSNameBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label HSscoreViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SpeedUplabel;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

