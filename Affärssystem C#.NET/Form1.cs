using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration_4_angedoxa100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_ID.Text = "Jasså\r\n och här kommer nästa";
        }

        private void textBox_CashOut_TextChanged(object sender, EventArgs e)
        {
            textBox_CashOut.Text = "Jasså\r\n och här kommer nästa";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_CashOut.Text = "Jasså\r\n och här kommer nästa";
        }
    }
}
