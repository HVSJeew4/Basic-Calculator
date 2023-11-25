
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            compute();
        }
        int count;
        float num1;
       
  
              #region btnset


        private void btn1_Click(object sender, EventArgs e)
        {

            txtb1.Text = txtb1.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtb1.Text = txtb1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtb1.Text = txtb1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtb1.Text = txtb1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtb1.Text = txtb1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtb1.Text = txtb1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtb1.Text = txtb1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtb1.Text = txtb1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtb1.Text = txtb1.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtb1.Text = txtb1.Text + "0";
        }
        
        private void btndot_Click(object sender, EventArgs e)
        {
            txtb1.Text = txtb1.Text + ".";
            btndot.Enabled = false;
        }


        #endregion btnset
          
       

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (lblDis.Text == "")
            {
            lblDis.Text = txtb1.Text;
            txtb1.Clear();
            txtb1.Focus();
            count = 1;
           
            }
            else
            {
                num1=float.Parse(lblDis.Text)+float.Parse(txtb1.Text);
                txtb1.Clear();
                txtb1.Focus();
                lblDis.Text=num1.ToString();
            }
            btndot.Enabled=true;
        }
        private void btnsub_Click(object sender, EventArgs e)
        {
            if (lblDis.Text == "")
            {
                lblDis.Text = txtb1.Text;
                txtb1.Clear();
                txtb1.Focus();
                count = 2;
            }
            else
            {
                num1 = float.Parse(lblDis.Text) - float.Parse(txtb1.Text);
                txtb1.Clear();
                txtb1.Focus();
                lblDis.Text = num1.ToString();

            }
            btndot.Enabled = true;
        }
        private void btncross_Click(object sender, EventArgs e)
        {
            if (lblDis.Text == "")
            {
                lblDis.Text = txtb1.Text;
                txtb1.Clear();
                txtb1.Focus();
                count = 3;
            }
            else
            {
                num1 = float.Parse(lblDis.Text) * float.Parse(txtb1.Text);
                txtb1.Clear();
                txtb1.Focus();
                lblDis.Text = num1.ToString();

            }
            btndot.Enabled = true;
        }

        private void btndevide_Click(object sender, EventArgs e)
        {
            if (lblDis.Text == "")
            {
                lblDis.Text = txtb1.Text;
                txtb1.Clear();
                txtb1.Focus();
                count = 4;
            }
            else
            {
                num1 = float.Parse(lblDis.Text) / float.Parse(txtb1.Text);
                txtb1.Clear();
                txtb1.Focus();
                lblDis.Text = num1.ToString();

            }
            btndot.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            compute();
            txtb1.Clear();
            txtb1.Focus();
        }
       

        public void compute()
        {
            switch(count)
            {          
                case 1:
                    num1 = float.Parse(lblDis.Text) + float.Parse(txtb1.Text);
                    lblDis.Text=num1.ToString();
                    break;
                case 2:
                    num1=float.Parse(lblDis.Text) - float.Parse(txtb1.Text);
                    lblDis.Text = num1.ToString();
                    break;
                case 3:
                    num1 = float.Parse(lblDis.Text) * float.Parse(txtb1.Text);
                    lblDis.Text = num1.ToString();
                    break;
                case 4:
                    num1 = float.Parse(lblDis.Text) / float.Parse(txtb1.Text);
                    lblDis.Text = num1.ToString();
                    break;
            }
        }

    }
}

