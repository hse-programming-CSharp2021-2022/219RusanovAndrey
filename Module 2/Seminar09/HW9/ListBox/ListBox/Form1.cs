using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    
    public partial class Form1 : Form
    {
        string[] array = new string[] { "один", "два", "три", "четыре", "пять", "шесть", "семь" };
        string[] newArray = null;
       
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            listBox1.Visible = false;
            button2.Visible = false;
            button1.Text = "Отобразить начальный список";
            button2.Text = "Удалить выбранный элемент";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Отобразить начальный список";
            listBox1.Visible = true;
            button2.Visible = true;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(array);
            newArray = array;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Список пуст или нет выделенного элемента!");
                return;
            }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
