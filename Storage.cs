using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotek
{
    /*Klass för lagerhantering*/
    public partial class Storage : UserControl
    {
        BindingSource stockListSource;
        Stock selectedItem;
        MiddleLayer middleLayer;
        BindingList<Stock> bindingList;
        

        public Storage(BindingSource StockListSource)
        {
            InitializeComponent();
            this.stockListSource = StockListSource;
            dataGridView_Storage.DataSource = stockListSource;
            middleLayer = new MiddleLayer(stockListSource);
            bindingList = middleLayer.bindinglist;
        }

        private void dataGridView_Storage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Stored_Items = (Stock)dataGridView_Storage.Rows[e.RowIndex].DataBoundItem;
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

            EnableSaveButton();
            selectedItem = Stored_Items;

        }
        private void EnableSaveButton()
        {
            button_SaveNew.Enabled = true;
        }

        private void DisableSaveButton()
        {
            button_SaveNew.Enabled = false;
        }

        private void button_SaveNew_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
        private void SaveChanges()
        {
                selectedItem.name = textBox_Name.Text;
                selectedItem.type = textBox_Type.Text;
                selectedItem.author = textBox_Author.Text;
                selectedItem.genre = textBox_Genre.Text;
                selectedItem.format = textBox_Format.Text;
                selectedItem.language = textBox_Language.Text;
                selectedItem.platform = textBox_Platform.Text;

            int qNum = 0, pNum = 0, plNum = 0;

            if (int.TryParse(textBox_Quantity.Text, out qNum) && int.TryParse(textBox_Price.Text, out pNum)) 
                {
                    if (qNum > 0) { 

                        // selectedItem.playtime = textBox_Playtime.Text;
                        selectedItem.quantity = textBox_Quantity.Text;
                }
            else if(qNum < 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Antal får inte innehålla negativt antal", "Confirmation", MessageBoxButtons.OK);
                }

                if (pNum > 0)
                {
                    selectedItem.price = textBox_Price.Text;
                }
                else if (pNum < 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Pris får inte innehålla negativt pris", "Confirmation", MessageBoxButtons.OK);
                }

                if (plNum > 0 || textBox_Playtime.Text == "")
                {
                    selectedItem.playtime = textBox_Price.Text;
                }
                else if (plNum < 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Speltid får inte innehålla negativ tid", "Confirmation", MessageBoxButtons.OK);
                }
            }
            else
            {
               // DialogResult dialogResult = MessageBox.Show("Pris får inte innehålla negativt antal", "Confirmation", MessageBoxButtons.OK);
            
                    DialogResult dialogResult = MessageBox.Show("Pris, speltid och antal får bara inneha nummer", "Confirmation", MessageBoxButtons.OK);
                
            }

            clearTextBoxes();
            middleLayer.UpdateBindinglist(textBox_ID.Text, textBox_Name.Text, textBox_Price.Text, textBox_Type.Text, textBox_Author.Text, textBox_Genre.Text, textBox_Format.Text, textBox_Language.Text, textBox_Platform.Text, textBox_Playtime.Text, textBox_Quantity.Text);
                stockListSource.ResetCurrentItem();
        }
        /* Önskas en produkt raderas kommer fråga först om detta verkligen önskas innan det raderas*/
        private void button_Delete_Click(object sender, EventArgs e)
        {
            var itemToDelete = (Stock)dataGridView_Storage.SelectedRows[0].DataBoundItem;
            
            if (!itemToDelete.quantity.Equals("0"))
            {
                DialogResult dialogResult = MessageBox.Show("Vill du verkligen radera " + itemToDelete.name.ToString() + "? " +
                    "Det finns fortfarande " + itemToDelete.quantity + " st i lager", "Confirmation", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    string id_number = itemToDelete.ID_number.ToString();
                    middleLayer.DeleteItem(int.Parse(id_number));
                    middleLayer.DeleteItemBindinglist(itemToDelete.ID_number);
                    
                    stockListSource.Remove(itemToDelete);
                }
            }
            if (itemToDelete.quantity.Equals("0"))
            {
                string id_number = itemToDelete.ID_number.ToString();
                middleLayer.DeleteItem(int.Parse(id_number));
                middleLayer.DeleteItemBindinglist(itemToDelete.ID_number);
                stockListSource.Remove(itemToDelete);
            }
            clearTextBoxes();
        }

        private void clearTextBoxes()
        {
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
            DisableSaveButton();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            stockListSource.ResetCurrentItem();
            middleLayer.WriteToFile();
            System.Environment.Exit(0);
        }

        private void button_AddNew_Click(object sender, EventArgs e)
        {           
            AddNewItem addnewitem = new AddNewItem(middleLayer.idNum, middleLayer.bindinglist);
            this.Hide();

            if(addnewitem.ShowDialog() == DialogResult.OK)
            {
                stockListSource.Add(addnewitem.stock);
                stockListSource.ResetCurrentItem();
            }
            this.Show();          
        }

        private void button_Delivery_Click(object sender, EventArgs e)
        {
            middleLayer.DeliveryForm();
            this.Hide();
            middleLayer.openDelivery();
            stockListSource.ResetCurrentItem();
            this.Show();
        }        

        private void button_search_Click(object sender, EventArgs e)
        {
            middleLayer.SearchForm();
            this.Hide();
            middleLayer.openSearch();
            this.Show();
            
        }

        private void textBox_Platform_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
