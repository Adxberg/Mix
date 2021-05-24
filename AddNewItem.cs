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
    /* Klass för att lägga till en produkt*/
    public partial class AddNewItem : Form
    {
        internal Stock stock { get; private set; }
        List<int> id_num;
        BindingSource stockListSource;
        BindingList<Stock> list;

        public AddNewItem(List<int>id, BindingList<Stock>database)
        {
            InitializeComponent();
            id_num = new List<int>();
            id_num = id;
            list = new BindingList<Stock>();
            list = database;

        }
        /* När spara knappen tryck sparas alla fält i databasen. Ett nytt unikt idnummer tilldelas*/
        private void button_SaveNewItem_Click(object sender, EventArgs e)
        {
            stock = new Stock();
            
            stock.name = textBox_Name.Text;
            stock.type = textBox_Type.Text;
            stock.author = textBox_Author.Text;
            stock.genre = textBox_Genre.Text;
            stock.format = textBox_Format.Text;
            stock.language = textBox_Language.Text;
            stock.platform = textBox_Platform.Text;

            if (textBox_Name.Text == "")
            {
                DialogResult dialogResult = MessageBox.Show("Produkten måste inneha ett namn", "Confirmed", MessageBoxButtons.OK);
                ((AddNewItem)this.TopLevelControl).Hide();
            }
            int qNum = 0, pNum = 0, plNum = 0;

            if (int.TryParse(textBox_Quantity.Text, out qNum) && int.TryParse(textBox_Price.Text, out pNum))
            {
                if (qNum > 0)
                {
                    stock.quantity = textBox_Quantity.Text;
                }
                else if (qNum < 0|| qNum == null)
                {
                    DialogResult dialogResult = MessageBox.Show("Antal får inte innehålla negativt antal, kommer bli satt till 0", "Confirmation", MessageBoxButtons.OK);
                    stock.quantity = "0";
                }

                if (pNum > 0)
                {
                    stock.price = textBox_Price.Text;
                }
                else if (pNum < 0 || pNum == null)
                {
                    DialogResult dialogResult = MessageBox.Show("Pris får inte innehålla negativt pris, kommer bli satt till 0", "Confirmation", MessageBoxButtons.OK);
                    stock.price = "0";
                }

                if (plNum > 0 || textBox_Playtime.Text == "")
                {
                    stock.playtime = textBox_Price.Text;
                }
                else if (plNum < 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Speltid får inte innehålla negativ tid, kommer sättas blank", "Confirmation", MessageBoxButtons.OK);
                }
            }
             if(!int.TryParse(textBox_Quantity.Text, out qNum))
            {
                // DialogResult dialogResult = MessageBox.Show("Pris får inte innehålla negativt antal", "Confirmation", MessageBoxButtons.OK);

                DialogResult dialogResult = MessageBox.Show("Antal får bara inneha nummer, felaktiga fält kommer bli satta till 0", "Confirmation", MessageBoxButtons.OK);
                stock.quantity = "0";
            }
             if(!int.TryParse(textBox_Price.Text, out pNum))
            {

                DialogResult dialogResult = MessageBox.Show("Pris får bara inneha nummer, felaktiga fält kommer bli satta till 0", "Confirmation", MessageBoxButtons.OK);

                stock.price = "0";
            }
             if(!int.TryParse(textBox_Playtime.Text, out plNum))
            {

                DialogResult dialogResult = MessageBox.Show("Speltid får bara inneha nummer, felaktiga fält kommer bli satta tomma", "Confirmation", MessageBoxButtons.OK);
                stock.playtime = "";
            }
            int newId = id_num.Last()+1;
            id_num.Add(newId);
            stock.ID_number = newId.ToString();

            list.Add(stock);
            this.DialogResult = DialogResult.OK;
                                
        }

        private void buttonCancelNewItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
