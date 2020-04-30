using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double val = 0;
        string text = "";
        bool oper_pres = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(output.Text == "0" ||(oper_pres))
            {
                output.Clear();
            }

            Button button = (Button)sender;
            output.Text = output.Text + button.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void op_pres(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            val = Double.Parse(output.Text);
            oper_pres = true;

        }

        private void op_res(object sender, EventArgs e)
        {
            switch (text)
            {
                case "+":
                    output.Text = (val + Double.Parse(output.Text)).ToString();
                    break;
                case "-":
                    output.Text = (val - Double.Parse(output.Text)).ToString();
                    break;
                case "/":
                    output.Text = (val / Double.Parse(output.Text)).ToString();
                    break;
                case "*":
                    output.Text = (val * Double.Parse(output.Text)).ToString();
                    break;
                default:
                    break;
            }
            oper_pres = false;
        }

        private void C_press(object sender, EventArgs e)
        {
            output.Clear();
            val = 0;
        }
    }
}
