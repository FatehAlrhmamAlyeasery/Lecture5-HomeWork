using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fath_Motaher_Abdoh_Saleh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = this.Width + 100;//ملاحضظة ويمكمن عمل width فقط بدلا عن this.width
            this.Height = this.Height + 100;
        }

        private void btntop_Click(object sender, EventArgs e)
        {
            btnbbottom.Top += 5;
            btnleft.Top += 5;
            btnminus.Top += 5;
            btnplus.Top += 5;
            btnright.Top += 5;
            btntop.Top += 5;
            btnwright.Top += 5;
            btnwminus.Top += 5;
           
        }

        private void btnbbottom_Click(object sender, EventArgs e)
        {
            btnbbottom.Top -= 5;
            btnleft.Top -= 5;
            btnminus.Top -= 5;
            btnplus.Top -= 5;
            btnright.Top -= 5;
            btntop.Top -= 5;
            btnwright.Top -= 5;
            btnwminus.Top -= 5;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            btnbbottom.Height += 5;
            btnleft.Height += 5;
            btnminus.Height += 5;
            btnplus.Height += 5;
            btnright.Height += 5;
            btntop.Height += 5;
            btnwright.Height += 5;
            btnwminus.Height += 5;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            btnbbottom.Height -=5;
            btnleft.Height -= 5;
            btnminus.Height -= 5;
            btnplus.Height -= 5;
            btnright.Height -= 5;
            btntop.Height -= 5;
            btnwright.Height -= 5;
            btnwminus.Height -= 5;
        }

        private void btnwright_Click(object sender, EventArgs e)
        {
            btnbbottom.Width += 5;
            btnleft.Width += 5;
            btnminus.Width += 5;
            btnplus.Width += 5;
            btnright.Width += 5;
            btntop.Width += 5;
            btnwright.Width += 5;
            btnwminus.Width += 5;
        }

        private void btnwminus_Click(object sender, EventArgs e)
        {
            btnbbottom.Width -= 5;
            btnleft.Width -= 5;
            btnminus.Width -= 5;
            btnplus.Width -= 5;
            btnright.Width -= 5;
            btntop.Width -= 5;
            btnwright.Width -= 5;
            btnwminus.Width -= 5;
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            btnbbottom.Left += 5;
            btnleft.Left += 5;
            btnminus.Left += 5;
            btnplus.Left += 5;
            btnright.Left += 5;
            btntop.Left += 5;
            btnwright.Left += 5;
            btnwminus.Left += 5;
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            btnbbottom.Left -= 5;
            btnleft.Left -= 5;
            btnminus.Left -= 5;
            btnplus.Left -= 5;
            btnright.Left -= 5;
            btntop.Left -= 5;
            btnwright.Left -= 5;
            btnwminus.Left -= 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
