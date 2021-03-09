using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movePipe(5);
        }
        void movePipe(int speed)
        {
            if (Pipe1.Left >= 0)
            { Pipe1.Left += -speed; }
            else
            { Pipe1.Left = 1020; } //waarschijnlijk de zijkant van de form
            if (Pipe2.Left >= 0)
            { Pipe2.Left += -speed; }
            else
            { Pipe2.Left = 1020; } //waarschijnlijk de zijkant van de form
            




            }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
