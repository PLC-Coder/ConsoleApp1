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
        private int btn1SwapState = 0;
        private int btn2SwapState = 0;

          public Form1()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
            if (btn1SwapState == 0)
            {
                label1.Text = "I am an awesome programmer!";
                btnInfo.Text = "Hide Info";
                btn1SwapState = 1;
            }
            else if (btn1SwapState == 1)
            {
                label1.Text = "";
                btnInfo.Text = "Show Info";
                btn1SwapState = 0;
            }
        }

          private void button2_Click(object sender, EventArgs e)
          {
            if (btn2SwapState == 0)
            {
                    pictureBox1.Show();
                    btnImage.Text = "Hide Image";
                    btn2SwapState = 1;
            }
            else if (btn2SwapState == 1)
            {
                pictureBox1.Hide();
                btnImage.Text = "Show Image";
                btn2SwapState = 0;
            }
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               label1.Text = "Click one of the buttons below";
          }
     }
}
