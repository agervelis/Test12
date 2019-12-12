using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snacks
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "admin")
                {
                
                f3.Show();
                }
                
            }
            else if (textBox1.Text=="naudotojas")
            {
                if(textBox2.Text == "naudotojas")
                {
                    
                    f2.Show();

                }
             
            }
            else
            {
                label3.Show();
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
