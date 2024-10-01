using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect5_fath_motaher_abdoh_saleh4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
        double x, y, z;
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        
        }
       private void Button_Click(object sender,EventArgs e)
        {
            panel1.Visible = true;
            Button btn = (Button)sender;
            if (btn.Text == "جمع")
                label5.Text = "+";
            else if (btn.Text == "طرح")
                label5.Text = "-";
            else if (btn.Text == "ضرب")
                label5.Text = "*";
            else if (btn.Text == "قسمة")
                label5.Text = "/";
        }
        private void txtnum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9' ||e.KeyChar==8)
                e.Handled = true;
        }
        private void btncompute_Click(object sender, EventArgs e)
        {

            if (txtnum1.Text.Trim() != "" && txtnum2.Text.Trim() != "")
            {
                x = Convert.ToDouble(txtnum1.Text);
                y = Convert.ToDouble(txtnum2.Text);
                switch (label5.Text)
                {
                    case "+":
                        z = x+y;
                        break;
                    case "-":
                        z = x - y;
                        break;
                    case "*":
                        z = x * y;
                        break;
                    case "/":
                        {
                            if (y != 0)
                                z = x / y;

                            else
                                MessageBox.Show("لايمكن القسمة على الصفر ");
                            break;
                        }
                    default:
                        MessageBox.Show("العملية خاطئة");
                        break;
                }
                txtresult.Text = z.ToString();

            }
            else
                MessageBox.Show("يوجد احد الصناديق فارغة");

        }
        private void txtnum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
