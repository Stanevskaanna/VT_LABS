using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onPlusClick(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label4.Text = "Введите число";
                label4.ForeColor = Color.Red;
            }
            else
            {
                int Sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                label4.Text = Sum.ToString();
            }
        }

        private void onMinusClick(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label4.Text = "Введите число";
                label4.ForeColor = Color.Red;
            }
            else
            {
                int Min = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                label4.Text = Min.ToString();
            }
        }
        private void onMultiplyClick(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label4.Text = "Введите число";
                label4.ForeColor = Color.Red;
            }
            else
            {
                int Mul = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                label4.Text = Mul.ToString();
            }
        }

        private void onDivideClick(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label4.Text = "Введите число";
                label4.ForeColor = Color.Red;
            }


            else if (int.Parse(textBox2.Text) == 0)
            {
                label4.Text = "Ошибка:делить на ноль нельзя";
                label4.ForeColor = Color.Red;
            }
            else
            {
                int Div = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                label4.Text = Div.ToString();
            }
        }
        private void onClearClick(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            label4.Text = "0";
        }
    }
}

    


        








    
