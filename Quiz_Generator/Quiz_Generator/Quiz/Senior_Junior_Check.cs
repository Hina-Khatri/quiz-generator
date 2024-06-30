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
    public partial class Senior_Junior_Check : Form
    {
        public Senior_Junior_Check()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Senior senior = new Senior();
            senior.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Junior junior = new Junior();
            junior.Show();
        }
    }
}
