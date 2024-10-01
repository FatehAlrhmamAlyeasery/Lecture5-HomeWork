using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {int s= 0;
            if (checkBox1.Checked)
                s += Convert.ToInt32(checkBox1.Text);
            if (checkBox2.Checked)
                s += Convert.ToInt32(checkBox2.Text);
            if (checkBox3.Checked)
                s += Convert.ToInt32(checkBox3.Text);
            
                textBox1.Text = s.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
       
                
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                label1.BackColor = Color.Red;
            else if (radioButton5.Checked)
                label1.BackColor = Color.Yellow;
            if (radioButton1.Checked)
                label1.ForeColor = Color.Red;
            else if (radioButton2.Checked)
                label1.ForeColor = Color.Yellow;
            else if (radioButton3.Checked)
                label1.ForeColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "enable")
            {
                button2.Text = "unenable";
                panel1.Enabled = true;
            }
            else if(button2.Text=="unenable")
            { button2.Text = "enable";
                panel1.Enabled = false;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {if (button4.Text == "unvisable")
            { button4.Text = "visable";
                panel1.Visible = true; 
                    }
        else if(button4.Text=="visable")
            { button4.Text = "unvisable";
                panel1.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible
                = false;
        }
    }
    }

