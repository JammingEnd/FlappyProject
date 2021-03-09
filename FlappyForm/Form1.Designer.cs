
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
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe2)).BeginInit();
            this.SuspendLayout();
            // 
            // FlappyBird
            // 
            this.FlappyBird.BackColor = System.Drawing.Color.Lime;
            this.FlappyBird.Location = new System.Drawing.Point(70, 33);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(100, 50);
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            // 
            // Pipe1
            // 
            this.Pipe1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Pipe1.Location = new System.Drawing.Point(70, 276);
            this.Pipe1.Name = "Pipe1";
            this.Pipe1.Size = new System.Drawing.Size(100, 50);
            this.Pipe1.TabIndex = 1;
            this.Pipe1.TabStop = false;
            // 
            // Pipe2
            // 
            this.Pipe2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Pipe2.Location = new System.Drawing.Point(70, 346);
            this.Pipe2.Name = "Pipe2";
            this.Pipe2.Size = new System.Drawing.Size(100, 50);
            this.Pipe2.TabIndex = 2;
            this.Pipe2.TabStop = false;
            // 
            // currenScore
            // 
            this.currenScore.AutoSize = true;
            this.currenScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.currenScore.Location = new System.Drawing.Point(211, 33);
            this.currenScore.Name = "currenScore";
            this.currenScore.Size = new System.Drawing.Size(124, 39);
            this.currenScore.TabIndex = 3;
            this.currenScore.Text = "Score: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currenScore);
            this.Controls.Add(this.Pipe2);
            this.Controls.Add(this.Pipe1);
            this.Controls.Add(this.FlappyBird);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox Pipe1;
        private System.Windows.Forms.PictureBox Pipe2;
        private System.Windows.Forms.Label currenScore;
    }
}

