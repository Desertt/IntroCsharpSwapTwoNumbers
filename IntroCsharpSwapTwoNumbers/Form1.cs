using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroCsharpSwapTwoNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int number1, number2, tempValue, resultValue;

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            labelFirstNumber.BackColor = Color.Blue;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelFirstNumber.BackColor = Color.Red;
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBoxNumber1.Text);
            number2 = Convert.ToInt32(textBoxNumber2.Text);
            labelFirstNumber.Text = number1.ToString();
            labelFirstNumber.BackColor = Color.GreenYellow;
            labelFirstNumber.TextAlign = ContentAlignment.MiddleCenter;
            tempValue = number1;
            number1 = number2;
            number2 = tempValue;
            labelResultN1.Text = number1.ToString();
            labelResultN2.Text = number2.ToString();
        }
    }
}
