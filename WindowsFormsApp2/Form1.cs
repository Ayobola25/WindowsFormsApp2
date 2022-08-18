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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bottoncal_Click(object sender, EventArgs e)
        {
            double length = double.Parse(textBox1.Text);
            double breath = double.Parse(textBox2.Text);
            if((length > 0) && (breath > 0))
            {
                double area = Area(length, breath);
                textBox3.Text = area.ToString();
            }
            else
            {
                textBox3.Text = "enter positive number";
            }
            
        }
        public double Area(double length, double breath)
        {
            return length * breath; 
        }

            
    }
}
