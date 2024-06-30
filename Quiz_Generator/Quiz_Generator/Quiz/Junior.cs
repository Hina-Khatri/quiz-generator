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
    public partial class Junior : Form
    {
        public Junior()
        {
            InitializeComponent();
        }

        private void Junior_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            J_High juniorHigh = new J_High();
            juniorHigh.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            J_Medium juniorMedium = new J_Medium();
            juniorMedium.Show();
        }
    }
}
