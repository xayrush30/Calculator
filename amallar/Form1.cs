using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace amallar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c = 0;

            a = Convert.ToDouble(textBox4.Text);
            b = Convert.ToDouble(textBox3.Text);
            bool t = true;
            if (b == 0)
            { t = false; }

            if (radioButton14.Checked)
                c = a + b;
            else if (radioButton10.Checked)
                c = a - b;
            else if (radioButton11.Checked)
                c = a * b;
            else if (radioButton12.Checked && t)
                c = a / b;
            else if (radioButton12.Checked && !t)
            {
                label6.Text = "natija: mavjud njhghj ! ! ";
                return;
            }
            else if (radioButton13.Checked)
                c=Math.Pow(a, b);
            else if (radioButton9.Checked )
                c=Math.Sqrt(a);
            else if(radioButton8.Checked)
                c=Math.Sqrt(b);

            label6.Text = "natija:" + Convert.ToString(c);


        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,b;
            a = Convert.ToDouble(textBox1.Text);
            if (radiobutton_kos.Checked) ;
            b= Math.Cos(a);
           if (radioButton_sin.Checked) ;
            b = Math.Sin(a);
            if (radiobutton_tg.Checked) ;
            b = Math.Tan(a);
            if (radiobutton_kat.Checked) ;
            b = Math.Tan(a);    
            label3.Text="natija"+Convert.ToString(b);
            
        }
    }
}
