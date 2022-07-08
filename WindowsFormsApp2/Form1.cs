using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string value = input.Text.ToString();
            string[] tokens = value.Split(' ');
            string action1 = tokens[0];
            string first = tokens[1];
            string action2 = tokens[2];
            string second = tokens[3];
            string action3 = tokens[4];
            string third = tokens[5];
            string[] firs = first.Split('x');
            string[] seco = second.Split('x');
            int a = int.Parse(firs[0]);
            int b = int.Parse(seco[0]);
            if (action1=="-")
            {
                a = -a;
            }
            if (action2=="-")
            {
                b = -b;
            }
            int c = int.Parse(third);
            if (action3 == "-")
            {
                c = -c;
            }
            int d = b * b - 4 * a * c;

            if (d>0)
            {
                double sum1 = -b + Math.Sqrt(d);
                sum1 = sum1 / 2;

                double sum2 = -b - Math.Sqrt(d);
                sum2 = sum2 / 2;

                result.Text = ($"x1 = {sum1} x2 = {sum2}");

            }
            else if (d==0)
            {
                int temp = a * 2;
                double sum = -b / temp;
                result.Text = ($"x1=x2={sum}");
            }
            else if (d<0)
            {
                result.Text = "no solution!";
            }
        }
    }
}
