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
    /*Klass för att kunna söka produkter i databasen*/
    public partial class Search : Form
    {
        BindingList<Stock> Database { get; }
        public Search(BindingList<Stock> list)
        {
            InitializeComponent();
            Database = list;
        }

        /* Finns 3 olika sätt att söka i databasen, namn genre och pris. hittade produkter placeras i en textbox. finns inte 
         * produkten kommer en dialogruta*/
        private void SearchItemsGenre()
        {
            string s = textBox_searchGenre.Text;
            List<Stock> tmp = Database.ToList();
            bool exists = false;

            foreach (var item in tmp)
            {
                
                if (String.Equals(item.genre, s, StringComparison.OrdinalIgnoreCase))
                {
                    textBox_searchresult.Text += item.ID_number + "  " + item.name + " " + item.price + ":- " + item.type
                        + " " + item.author + " " + item.genre + " " + item.format + " " + item.language + " " + item.platform
                        + " " + item.platform + " " + item.playtime + "min " + item.quantity+ "st";
                    exists = true;
                    button_searchGenre.Enabled = false;
                }

            }
            if (!exists)
            {
                {
                    DialogResult result = MessageBox.Show("Tyvärr finns inte produkten i lager", "Confirmation", MessageBoxButtons.OK);
                }
            }
        }
        private void SearchItemsPrice()
        {
            string s = textBox_searchPrice.Text;
            List<Stock> tmp = Database.ToList();
            bool exists = false;

            foreach (var item in tmp)
            {
                if (item.price.Contains(s))
                {
                    textBox_searchresult.Text += item.ID_number + "  " + item.name + " " + item.price + ":- " + item.type
                        + " " + item.author + " " + item.genre + " " + item.format + " " + item.language + " " + item.platform
                        + " " + item.platform + " " + item.playtime + "min " + item.quantity + "st \r\n";
                    exists = true;

                    button_searchPrice.Enabled = false;
                }
            }
            if (!exists)
            {
                {
                    DialogResult result = MessageBox.Show("Tyvärr finns inte produkten i lager", "Confirmation", MessageBoxButtons.OK);
                }
            }
        }
        private void SearchItemsName()
        {
            string s = textBox_searchName.Text;
            List<Stock> tmp = Database.ToList();
            bool exists = false;

            foreach(var item in tmp)
            {
                if (item.name.Contains(s)) 
                {
                    textBox_searchresult.Text += item.ID_number + "  " + item.name + " " + item.price + ":- " + item.type
                        + " " + item.author + " " + item.genre + " " + item.format + " " + item.language + " " + item.platform
                        + " " + item.platform + " " + item.playtime + "min " + item.quantity+ "st \r\n";
                    exists = true;
                    button_searchName.Enabled = false;
                }
            }
            if (!exists)
            {
                {
                    DialogResult result = MessageBox.Show("Tyvärr finns inte produkten i lager", "Confirmation", MessageBoxButtons.OK);
                }
            }
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            SearchItemsName();
        }

        private void button_done_Click_1(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.OK;
            this.Close();
        }

        private void button_searchGenre_Click(object sender, EventArgs e)
        {
            SearchItemsGenre();
        }

        private void button_searchPrice_Click(object sender, EventArgs e)
        {
            SearchItemsPrice();
        }

        private void textBox_searchName_TextChanged(object sender, EventArgs e)
        {
            button_searchName.Enabled = true;
        }

        private void textBox_searchPrice_TextChanged(object sender, EventArgs e)
        {
            button_searchPrice.Enabled = true;
        }

        private void textBox_searchGenre_TextChanged(object sender, EventArgs e)
        {
            button_searchGenre.Enabled = true;
        }
    }
}
