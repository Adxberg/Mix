using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotek
{/* klass för att lägga till en produkt i varukorgen*/
    public partial class AddNewItemToCart : Form
    {
        
        public double aPrice, sum;
        public int quantity = 0;
        public AddNewItemToCart(string info, string price)
        {
            InitializeComponent();          
            aPrice = double.Parse(price);
            textBox_info.Text = info;
            textBox_singleprice.Text = price;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox_quantity_TextChanged(object sender, EventArgs e)
        {
            int qNum = 0;

            if (int.TryParse(textBox_quantity.Text, out qNum))
            {
                if (qNum > 0)
                {
                    quantity = int.Parse(textBox_quantity.Text);
                    textBox_tot.Text = total(quantity).ToString();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Måste ange antal över 0", "confirmed", MessageBoxButtons.OK);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Måste ange antal över 0", "confirmed", MessageBoxButtons.OK);
            }
        }

        private double total(int quantity)
        {
            sum = aPrice * quantity;
            return sum;
        }
    }
}
