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
{
    /* Leveransklass. Ett formulär öppnas där produkt som ska levereras kan väljas ur en lista och sedan skriva in antal levererade varor*/
    public partial class Delivery : UserControl
    {
        BindingSource stockListSource;
        Stock selectedItems;
        BindingList<Stock> bindinglist;
        
        public Delivery(BindingSource bindingsource, BindingList<Stock>list)
        {
            InitializeComponent();
            stockListSource = bindingsource;
            dataGridView_delivery.DataSource = stockListSource;
            bindinglist = list;
        }

        private void UserControlDelivery_Load(object sender, EventArgs e)
        {
           
        }       

        private void textBox_Genre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_delivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Stored_Items = (Stock)dataGridView_delivery.Rows[e.RowIndex].DataBoundItem;
            textBox_ID.Text = Stored_Items.ID_number;
            textBox_Name.Text = Stored_Items.name;
            textBox_Price.Text = Stored_Items.price;
            textBox_Type.Text = Stored_Items.type;
            textBox_Author.Text = Stored_Items.author;
            textBox_Genre.Text = Stored_Items.genre;
            textBox_Format.Text = Stored_Items.format;
            textBox_Language.Text = Stored_Items.language;
            textBox_Platform.Text = Stored_Items.platform;
            textBox_Playtime.Text = Stored_Items.playtime;
            textBox_Quantity.Text = Stored_Items.quantity;

            selectedItems = Stored_Items;
            
        }

        private void button_next_Click_1(object sender, EventArgs e)
        {
            if(textBox_delivery.Text == "")
            {
                DialogResult result = MessageBox.Show("Du har inte angett någon produkt eller antal levererade produkter", "Confirmed", MessageBoxButtons.OK);
            }
            else if (int.Parse(textBox_delivery.Text) >= 0)
            {
                int q = int.Parse(selectedItems.quantity) + int.Parse(textBox_delivery.Text);
                selectedItems.quantity = q.ToString();
                stockListSource.ResetCurrentItem();
                for (int i = 0; i < bindinglist.Count; i++)
                {
                    if (bindinglist[i].ID_number.Equals(selectedItems.ID_number))
                    {
                        bindinglist[i].quantity = selectedItems.quantity;
                    }
                }

                textBox_ID.Text = "";
                textBox_Name.Text = "";
                textBox_Price.Text = "";
                textBox_Type.Text = "";
                textBox_Author.Text = "";
                textBox_Genre.Text = "";
                textBox_Format.Text = "";
                textBox_Language.Text = "";
                textBox_Platform.Text = "";
                textBox_Playtime.Text = "";
                textBox_Quantity.Text = "";
                textBox_delivery.Text = "";
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Antal levererade produkter får inte innehålla negativt antal", "Confirmation", MessageBoxButtons.OK);

            }

        }
        private void button_finished_Click_1(object sender, EventArgs e)
        {
            if (textBox_delivery.Text == "")
            {
                ((Form_Delivery)this.TopLevelControl).Hide();
            }

            else if (int.Parse(textBox_delivery.Text) >= 0)
            {
                int q = int.Parse(selectedItems.quantity) + int.Parse(textBox_delivery.Text);
                selectedItems.quantity = q.ToString();
                stockListSource.ResetCurrentItem();
                for (int i = 0; i < bindinglist.Count; i++)
                {
                    if (bindinglist[i].ID_number.Equals(selectedItems.ID_number))
                    {
                        bindinglist[i].quantity = selectedItems.quantity;
                    }
                }

                ((Form_Delivery)this.TopLevelControl).Hide();
                
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Antal levererade produkter får inte innehålla negativt antal", "Confirmation", MessageBoxButtons.OK);
            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            ((Form_Delivery)this.TopLevelControl).Hide();
        }
    }
}

