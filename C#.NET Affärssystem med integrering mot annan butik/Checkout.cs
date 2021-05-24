using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Bibliotek
{/*Klass för att betala i kassan*/
    public partial class Form_CheckOut : Form
    {
        double tot, cash, changeBack;
        string ResetText;
        PrintDocument print = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        public bool resetButton = false;
        public Form_CheckOut(string total, String cart)
        {
            InitializeComponent();

            tot = double.Parse(total);
            ResetText = cart;
            textBox_totalCheckout.Text = total;
            textBox_Taxes.Text = Taxes(tot);

            print.PrintPage += new PrintPageEventHandler(PageToPrint);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button_reset.Enabled = false;
        }

        private string Taxes(double tot)
        {
            double tax_sum = tot * 0.2;

            return tax_sum.ToString();
        }

        private string Change(double tot, double cash)
        {
             changeBack = cash - tot;

            return changeBack.ToString();
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            if (textBox_FromCustomer.Text == "")
            {
                ((Form_CheckOut)this.TopLevelControl).Close();
            }
            else
            {
                cash = double.Parse(textBox_FromCustomer.Text);
                textBox_Change.Text = Change(tot, cash);
                button_reset.Enabled = true;
                resetButton = true;
            }
        }

        private void button_Done_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            dialog.Document = print;
            print.Print();            
        }
        /* Skriver ut kvitto. Skriver allt som är lagt i kundkorgen och betalat för om användaren vill */
        private void PageToPrint(object sender, PrintPageEventArgs e)
        {
            string reset = "*** KVITTO ***\r\n" +  ResetText + "\r\n" + "Summa exkl. moms: " + ExTax(tot) + ":- \r\n" +"Moms 25%: " +Taxes(tot) + ":- \r\n"
                + "Att betala: " + tot + ":-\r\n" + "Betalat: " + cash+ ":- \r\n" + "Växel: " + changeBack+ ":-";
            e.Graphics.DrawString(reset, new Font("TimesNewRoman", 15, FontStyle.Regular), Brushes.Black, 20, 20);

        }

        private double ExTax(double total)
        {
            return total * 0.8;
        }
    }
}
