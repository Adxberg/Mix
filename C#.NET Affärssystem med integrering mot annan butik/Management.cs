using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotek
{
    /* Klass för kassa*/
    public partial class Management : UserControl
    {
        BindingSource stockListSource;
        MiddleLayer middleLayer;
        Stock selectedItem;
        int index = 0;
        double total = 0;
        public BindingList<Stock> tmp = new BindingList<Stock>();

        public Management(BindingSource StockListSource)
        {
            InitializeComponent();
            this.stockListSource = StockListSource;
            dataGridView_Cash.DataSource = stockListSource;
            middleLayer = new MiddleLayer(stockListSource);
        }
        private void dataGridView_Cash_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Stored_Items = (Stock)dataGridView_Cash.Rows[e.RowIndex].DataBoundItem;
            index = e.RowIndex;

            if (Stored_Items.quantity == "0")
            {
                DisableCart();

            }
            else
            {
                EnableCart();
            }
        }

       private void EnableCart()
        {
            button_Cart.Enabled = true;
        }
        private void DisableCart()
        {
            button_Cart.Enabled = false;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            stockListSource.ResetCurrentItem();
            middleLayer.WriteToFile();
            System.Environment.Exit(0);
        }
        /*Funktion som öppnar en dialog när vald produkt är klickad "lägg i varukorg" här ska antal av produkten anges*/
        private void button_Cart_Click(object sender, EventArgs e)
        {       
           var Stored_Items = (Stock)dataGridView_Cash.Rows[index].DataBoundItem;
            AddNewItemToCart addnewitemtocart = new AddNewItemToCart(Stored_Items.ID_number+" "+Stored_Items.name, Stored_Items.price);
            addnewitemtocart.StartPosition = FormStartPosition.CenterParent;
            addnewitemtocart.ShowDialog();
             

            if (addnewitemtocart.ShowDialog() == DialogResult.OK)
            {
                if (addnewitemtocart.quantity > 0)
                {
                    textBox_Cart.Text += Stored_Items.ID_number + " " + Stored_Items.name + " "
                    + "   á " + Stored_Items.price + " :- " + addnewitemtocart.quantity + " st " + "  " + addnewitemtocart.sum + " :-" + "\r\n";

                    TotalPriceAdd(addnewitemtocart.sum);
                    selectedItem = Stored_Items;
                    Stored_Items.quantity = addnewitemtocart.quantity.ToString();
                    tmp.Add(Stored_Items);
                                       

                }
                
            }
            
        }

       

        private void TotalPriceAdd(double price)
        {
            total += price;
            textBox_Total.Text = total.ToString() + " :- ";
        }
        /* Öppnar form för betlaning*/
        private void button_Pay_Click(object sender, EventArgs e)
        {
            middleLayer.getCart(tmp);
            middleLayer.PayForm(total.ToString(), textBox_Cart.Text);
            this.Hide();
            middleLayer.showPay();            
            this.Show();
            textBox_Cart.Text = "";
            textBox_Total.Text = "";
        }
        /* öppnar form för retur*/
        private void button_return_Click(object sender, EventArgs e)
        {
            middleLayer.returnForm();
            this.Hide();
            middleLayer.showReturn();
            this.Show();
        }
    }
}
