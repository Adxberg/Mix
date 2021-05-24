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
    /* klass för retur*/
    public partial class Return : UserControl
    {
        BindingSource stockListSource;
        Stock selectedItems;
        MiddleLayer middleLayer;
        bool buttonReturn = false;
        public Return (BindingSource bindingsource)
        {
            InitializeComponent();
            stockListSource = bindingsource;
            dataGridView_return.DataSource = stockListSource;
            middleLayer = new MiddleLayer(stockListSource);
        }

        private void dataGridView_return_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Stored_Items = (Stock)dataGridView_return.Rows[e.RowIndex].DataBoundItem;
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
        /* Vid retur uppdateras antalet för produkten som returneras*/
        private void button_finished_Click_1(object sender, EventArgs e)
        {
            if (textBox_return.Text == "")
            {
                ((ReturnForm)this.TopLevelControl).Hide();

            }

            else if (int.Parse(textBox_return.Text) >= 0)
            {
                int q = int.Parse(selectedItems.quantity) + int.Parse(textBox_return.Text);
                selectedItems.quantity = q.ToString();
                stockListSource.ResetCurrentItem();
                middleLayer.UpdateBindinglist(selectedItems.ID_number, selectedItems.name, selectedItems.price, selectedItems.type, selectedItems.author, selectedItems.genre, selectedItems.format, selectedItems.language, selectedItems.platform, selectedItems.playtime, selectedItems.quantity);
                ((ReturnForm)this.TopLevelControl).Hide();

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Antal returnerade produkter får inte innehålla negativt antal", "Confirmation", MessageBoxButtons.OK);
            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            ((ReturnForm)this.TopLevelControl).Hide();
        }

        private void textBox_Format_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

