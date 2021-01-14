using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        double sayı1 = 0;
        double sayı2 = 0;
        string operation = " ";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSonuç.Text = txtSonuç.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSonuç.Text = txtSonuç.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSonuç.Text = txtSonuç.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSonuç.Text = txtSonuç.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSonuç.Text = txtSonuç.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSonuç.Text = txtSonuç.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSonuç.Text = txtSonuç.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSonuç.Text = txtSonuç.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSonuç.Text = txtSonuç.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSonuç.Text = txtSonuç.Text + "9";
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToDouble(txtSonuç.Text);
            txtİşlem.Text = txtSonuç.Text;
            txtİşlem.Text = txtİşlem.Text + "+";
            txtSonuç.Text = " ";
            operation = "+";
        }

        private void btnÇıkarma_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToDouble(txtSonuç.Text);
            txtİşlem.Text = txtSonuç.Text;
            txtİşlem.Text = txtİşlem.Text + "-";
            txtSonuç.Text = " ";
            operation = "-";
        }

        private void btnÇarpma_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToDouble(txtSonuç.Text);
            txtİşlem.Text = txtSonuç.Text;
            txtİşlem.Text = txtİşlem.Text + "x";
            txtSonuç.Text = " ";
            operation = "x";
        }

        private void btnBölme_Click(object sender, EventArgs e)
        {
            sayı1= Convert.ToDouble(txtSonuç.Text);
            txtİşlem.Text = txtSonuç.Text;
            txtİşlem.Text = txtİşlem.Text + "/";
            txtSonuç.Text = " ";
            operation = "/";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtSonuç.Text = " ";
            txtİşlem.Text = " ";
            sayı1 = 0;
            sayı2 = 0;
            operation = " ";
        }

        private void btnSonuç_Click(object sender, EventArgs e)
        {
            sayı2= Convert.ToDouble(txtSonuç.Text);


            if (operation == "/")
            {
                double sonuç = sayı1 / sayı2;
                txtİşlem.Text = " ";
                txtSonuç.Text = Convert.ToString(sonuç);
            }
            else if (operation == "-")
            {
                double sonuç = sayı1 - sayı2;
                txtİşlem.Text = " ";
                txtSonuç.Text = Convert.ToString(sonuç);
            }
            else if (operation =="x")
            {
                double sonuç = sayı1 * sayı2;
                txtİşlem.Text = " ";
                txtSonuç.Text = Convert.ToString(sonuç);
            }
            else if(operation =="+")
            {
                double sonuç = sayı1 + sayı2;
                txtİşlem.Text = " ";
                txtSonuç.Text = Convert.ToString(sonuç);
            }
        }
    }
}
