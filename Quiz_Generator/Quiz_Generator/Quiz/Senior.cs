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
    public partial class Senior : Form
    {
        public Senior()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S_High seniorHigh = new S_High();
            seniorHigh.Show();
        }

        private void Senior_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            S_Medium SeniorMedium = new S_Medium();
            SeniorMedium.Show();
        }
    }
}
