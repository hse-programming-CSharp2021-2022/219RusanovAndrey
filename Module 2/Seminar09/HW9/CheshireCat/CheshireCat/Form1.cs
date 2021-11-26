using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheshireCat
{
   
    public partial class Form1 : Form
    {
        bool textDissapeared = false;
        bool textAppeared = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.label1.ForeColor = Color.DeepPink;
            this.timer1.Enabled = true;
            label1.Font = new Font("Arial",40);
            label1.Text = "Чеширский кот";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textDissapeared == false)
            {
                if (label1.Text.Length > 0)
                {
                    label1.Text = label1.Text.Remove(label1.Text.Length - 1);
                }
                else textDissapeared = true;
            }
            else if (textAppeared == false)
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.1;
                }
                else
                {
                    label1.Text = "Кот уже ушёл";
                    textAppeared = true;

                }
            }
            else
            {
                this.Opacity += 0.1;


            }
        }
    }
    
}
