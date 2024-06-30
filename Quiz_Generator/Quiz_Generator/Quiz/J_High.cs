using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class J_High : Form
    {
        public J_High()
        {
            InitializeComponent();
        }
        int correct = 0;
        int incorrect = 0;
        private void J_High_Load(object sender, EventArgs e)
        {
            label37.Hide();
            this.Hide();
            label38.Hide();
            this.Hide();
            label39.Hide();
            this.Hide();
            label40.Hide();
            this.Hide();
            button2.Hide();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                correct += 1;
            }
            else
            {
                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
                {
                    incorrect += 1;
                }
            }
            if (radioButton8.Checked)
            {
                correct += 1;
            }
            else
            {
                if (radioButton5.Checked || radioButton6.Checked || radioButton7.Checked)
                {
                    incorrect += 1;
                }
            }
            if (radioButton10.Checked)
            {
                correct += 1;
            }
            else
            {
                if (radioButton9.Checked || radioButton11.Checked || radioButton12.Checked)
                {
                    incorrect += 1;
                }
            }
            if (radioButton16.Checked)
            {
                correct += 1;
            }
            else
            {
                if (radioButton13.Checked || radioButton14.Checked || radioButton15.Checked)
                {
                    incorrect += 1;
                }
            }
            if (radioButton17.Checked)
            {
                correct += 1;
            }
            else
            {
                if (radioButton18.Checked || radioButton19.Checked || radioButton20.Checked)
                {
                    incorrect += 1;
                }
            }
            if (radioButton22.Checked)
            {
                correct += 1;
            }
            else
            {
                if (radioButton21.Checked || radioButton23.Checked || radioButton24.Checked)
                {
                    incorrect += 1;
                }
            }
            label38.Text = correct.ToString();
            label39.Text = incorrect.ToString();
            button1.Hide();
            this.Hide();
            label37.Show();
            this.Show();
            label38.Show();
            this.Show();
            label39.Show();
            this.Show();
            label40.Show();
            this.Show();
            button2.Show();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Junior_Answer_Key junior_answr_key = new Junior_Answer_Key();
            junior_answr_key.Show();
        }
    }
}
