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
    /*Mainklass som startar systemet och kickar igång lagerhanteringen och kassan*/
    public partial class Storesystem : Form
    {
        BindingSource stockListSource;
        MiddleLayer middleLayer;

        public Storesystem()
        {
            InitializeComponent();
            
            stockListSource = new BindingSource();
            middleLayer = new MiddleLayer(stockListSource);
            stockListSource.DataSource = middleLayer.bindinglist;
            
        }

        private void Storesystem_Load(object sender, EventArgs e)
        {
            Management management = new Management( stockListSource);
            management.Dock = DockStyle.Fill;
            tab_CashRegister.Controls.Add(management);

            Storage storage = new Storage(stockListSource);
            storage.Dock = DockStyle.Fill;
            tab_Storage.Controls.Add(storage);


        }

        private void TabControl_Selected(Object sender, TabControlEventArgs e)
        {
            stockListSource.ResetCurrentItem();
        }
    }
}
