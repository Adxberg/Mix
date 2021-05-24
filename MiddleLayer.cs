using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotek
{
    /*Mellanlager som skiljer frontend från backend*/
    class MiddleLayer
    {
        File_Management file_Management; 
        public BindingList<Stock> bindinglist;
        public List<int> idNum;
        BindingSource stockListSource;
        ReturnForm Returnform = new ReturnForm();
        Form_CheckOut checkout;
        Search search;
        Form_Delivery delivery;
        AddNewItem addNewItem;
        Management management;
        BindingList<Stock> tmpCart = new BindingList<Stock>();
        int quantityCart = 0;
        Return userReturn;

        public MiddleLayer(BindingSource source) 
        {
            file_Management = new File_Management();
            idNum = new List<int>(); 
            bindinglist = file_Management.Database; 
            idNum = file_Management.id_num;
            stockListSource = source;
            //management = new Management(stockListSource);
            
        }
        public void DeleteItem(int i)
        {
            file_Management.id_num.Remove(i);
        }

        public void returnForm()
        {
            userReturn = new Return(stockListSource);
            Returnform.Controls.Add(userReturn);
        }
        public void showPay()
        {
            
            checkout.ShowDialog();
            if (checkout.resetButton)
            {
                for (int i = 0; i < bindinglist.Count; i++)
                {
                    for (int j = 0; j < tmpCart.Count; j++)
                    {

                        if (bindinglist[i].ID_number.Equals(tmpCart[j].ID_number))
                        {
                            int q = int.Parse(bindinglist[i].quantity);
                            int qtmp = int.Parse(tmpCart[j].quantity);
                            int sum = q - qtmp;

                            bindinglist[i].quantity = sum.ToString();
                        }
                    }
                }
                tmpCart.Clear();
                WriteToFile();
            }
        }

        public void getCart(BindingList<Stock>tmp)
        {
            tmpCart = tmp;
        }
        public void showReturn()
        {
            Returnform.Show();
        }
        public void PayForm(string total, string cart)
        {
             checkout = new Form_CheckOut(total,cart);
        }

        public void WriteToFile()
        {
            
            file_Management.Write();
        }

        public void SearchForm()
        {
             search = new Search(bindinglist);
        }
        public void openSearch()
        {
            search.Show();
        }

        public void DeliveryForm()
        {
            delivery = new Form_Delivery();
            Delivery userControlDelivery = new Delivery(stockListSource, bindinglist);
            delivery.Controls.Add(userControlDelivery);
        }

        public void DeleteItemBindinglist(string id)
        {
            file_Management.DeleteItemDatabase(id);            
        }

        public void UpdateBindinglist(string id, string name, string price, string type, string author, string genre, string format, string language, string platform, string playtime, string quantity)
        {
            file_Management.UpdateDatabase(id, name, price, type, author, genre, format, language, platform, playtime, quantity);
        }
        public void openDelivery()
        {
            delivery.Show();
        }

    }
}
