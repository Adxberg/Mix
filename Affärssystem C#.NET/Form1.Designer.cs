
namespace Laboration_4_angedoxa100
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab = new System.Windows.Forms.TabControl();
            this.CashregisterTab = new System.Windows.Forms.TabPage();
            this.splitContainer_Cashregister = new System.Windows.Forms.SplitContainer();
            this.Cashregister_dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox_CashOut = new System.Windows.Forms.TextBox();
            this.label_Total = new System.Windows.Forms.Label();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_AddCart = new System.Windows.Forms.Button();
            this.button_Pay = new System.Windows.Forms.Button();
            this.button_ClearCart = new System.Windows.Forms.Button();
            this.Usercontrol_cashregister = new System.Windows.Forms.UserControl();
            this.StorageTab = new System.Windows.Forms.TabPage();
            this.splitContainer_Storage = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Storage = new System.Windows.Forms.DataGridView();
            this.button_AddNewItem = new System.Windows.Forms.Button();
            this.button_DeleteItem = new System.Windows.Forms.Button();
            this.button_Delivery = new System.Windows.Forms.Button();
            this.textBox_Format = new System.Windows.Forms.TextBox();
            this.textBox_Genre = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_Format = new System.Windows.Forms.Label();
            this.label_Genre = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.label_Type = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.Usercontrol_storage = new System.Windows.Forms.UserControl();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tab.SuspendLayout();
            this.CashregisterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Cashregister)).BeginInit();
            this.splitContainer_Cashregister.Panel1.SuspendLayout();
            this.splitContainer_Cashregister.Panel2.SuspendLayout();
            this.splitContainer_Cashregister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cashregister_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.StorageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Storage)).BeginInit();
            this.splitContainer_Storage.Panel1.SuspendLayout();
            this.splitContainer_Storage.Panel2.SuspendLayout();
            this.splitContainer_Storage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Storage)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.CashregisterTab);
            this.tab.Controls.Add(this.StorageTab);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(800, 450);
            this.tab.TabIndex = 0;
            // 
            // CashregisterTab
            // 
            this.CashregisterTab.Controls.Add(this.splitContainer_Cashregister);
            this.CashregisterTab.Controls.Add(this.Usercontrol_cashregister);
            this.CashregisterTab.Location = new System.Drawing.Point(4, 29);
            this.CashregisterTab.Name = "CashregisterTab";
            this.CashregisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.CashregisterTab.Size = new System.Drawing.Size(792, 417);
            this.CashregisterTab.TabIndex = 0;
            this.CashregisterTab.Text = "Kassabruk";
            this.CashregisterTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer_Cashregister
            // 
            this.splitContainer_Cashregister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Cashregister.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_Cashregister.Name = "splitContainer_Cashregister";
            // 
            // splitContainer_Cashregister.Panel1
            // 
            this.splitContainer_Cashregister.Panel1.Controls.Add(this.Cashregister_dataGridView);
            // 
            // splitContainer_Cashregister.Panel2
            // 
            this.splitContainer_Cashregister.Panel2.Controls.Add(this.textBox_CashOut);
            this.splitContainer_Cashregister.Panel2.Controls.Add(this.label_Total);
            this.splitContainer_Cashregister.Panel2.Controls.Add(this.textBox_Total);
            this.splitContainer_Cashregister.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer_Cashregister.Size = new System.Drawing.Size(786, 411);
            this.splitContainer_Cashregister.SplitterDistance = 262;
            this.splitContainer_Cashregister.TabIndex = 2;
            // 
            // Cashregister_dataGridView
            // 
            this.Cashregister_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cashregister_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cashregister_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.Cashregister_dataGridView.Name = "Cashregister_dataGridView";
            this.Cashregister_dataGridView.RowHeadersWidth = 62;
            this.Cashregister_dataGridView.RowTemplate.Height = 28;
            this.Cashregister_dataGridView.Size = new System.Drawing.Size(262, 411);
            this.Cashregister_dataGridView.TabIndex = 1;
            // 
            // textBox_CashOut
            // 
            this.textBox_CashOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CashOut.Location = new System.Drawing.Point(285, 12);
            this.textBox_CashOut.Multiline = true;
            this.textBox_CashOut.Name = "textBox_CashOut";
            this.textBox_CashOut.ReadOnly = true;
            this.textBox_CashOut.Size = new System.Drawing.Size(217, 260);
            this.textBox_CashOut.TabIndex = 9;
            this.textBox_CashOut.TextChanged += new System.EventHandler(this.textBox_CashOut_TextChanged);
            // 
            // label_Total
            // 
            this.label_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(294, 284);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(59, 20);
            this.label_Total.TabIndex = 11;
            this.label_Total.Text = "Total: ";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Total.Location = new System.Drawing.Point(372, 278);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.ReadOnly = true;
            this.textBox_Total.Size = new System.Drawing.Size(130, 26);
            this.textBox_Total.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 322);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_AddCart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_Pay);
            this.splitContainer1.Panel2.Controls.Add(this.button_ClearCart);
            this.splitContainer1.Size = new System.Drawing.Size(512, 84);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_AddCart
            // 
            this.button_AddCart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_AddCart.Location = new System.Drawing.Point(23, 36);
            this.button_AddCart.Name = "button_AddCart";
            this.button_AddCart.Size = new System.Drawing.Size(238, 37);
            this.button_AddCart.TabIndex = 6;
            this.button_AddCart.Text = "Lägg i kundvagn";
            this.button_AddCart.UseVisualStyleBackColor = true;
            // 
            // button_Pay
            // 
            this.button_Pay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Pay.Location = new System.Drawing.Point(16, 42);
            this.button_Pay.Name = "button_Pay";
            this.button_Pay.Size = new System.Drawing.Size(204, 31);
            this.button_Pay.TabIndex = 8;
            this.button_Pay.Text = "Betala";
            this.button_Pay.UseVisualStyleBackColor = true;
            // 
            // button_ClearCart
            // 
            this.button_ClearCart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_ClearCart.Location = new System.Drawing.Point(16, 5);
            this.button_ClearCart.Name = "button_ClearCart";
            this.button_ClearCart.Size = new System.Drawing.Size(204, 31);
            this.button_ClearCart.TabIndex = 7;
            this.button_ClearCart.Text = "Rensa Kundvagn";
            this.button_ClearCart.UseVisualStyleBackColor = true;
            // 
            // Usercontrol_cashregister
            // 
            this.Usercontrol_cashregister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Usercontrol_cashregister.Location = new System.Drawing.Point(3, 3);
            this.Usercontrol_cashregister.Name = "Usercontrol_cashregister";
            this.Usercontrol_cashregister.Size = new System.Drawing.Size(786, 411);
            this.Usercontrol_cashregister.TabIndex = 0;
            // 
            // StorageTab
            // 
            this.StorageTab.Controls.Add(this.splitContainer_Storage);
            this.StorageTab.Controls.Add(this.Usercontrol_storage);
            this.StorageTab.Location = new System.Drawing.Point(4, 29);
            this.StorageTab.Name = "StorageTab";
            this.StorageTab.Padding = new System.Windows.Forms.Padding(3);
            this.StorageTab.Size = new System.Drawing.Size(792, 417);
            this.StorageTab.TabIndex = 1;
            this.StorageTab.Text = "Lagerarbete";
            this.StorageTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer_Storage
            // 
            this.splitContainer_Storage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Storage.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_Storage.Name = "splitContainer_Storage";
            // 
            // splitContainer_Storage.Panel1
            // 
            this.splitContainer_Storage.Panel1.Controls.Add(this.dataGridView_Storage);
            // 
            // splitContainer_Storage.Panel2
            // 
            this.splitContainer_Storage.Panel2.Controls.Add(this.button_AddNewItem);
            this.splitContainer_Storage.Panel2.Controls.Add(this.button_DeleteItem);
            this.splitContainer_Storage.Panel2.Controls.Add(this.button_Delivery);
            this.splitContainer_Storage.Panel2.Controls.Add(this.textBox_Format);
            this.splitContainer_Storage.Panel2.Controls.Add(this.textBox_Genre);
            this.splitContainer_Storage.Panel2.Controls.Add(this.textBox_Author);
            this.splitContainer_Storage.Panel2.Controls.Add(this.textBox_Type);
            this.splitContainer_Storage.Panel2.Controls.Add(this.textBox_Price);
            this.splitContainer_Storage.Panel2.Controls.Add(this.textBox_Name);
            this.splitContainer_Storage.Panel2.Controls.Add(this.textBox_ID);
            this.splitContainer_Storage.Panel2.Controls.Add(this.label_Format);
            this.splitContainer_Storage.Panel2.Controls.Add(this.label_Genre);
            this.splitContainer_Storage.Panel2.Controls.Add(this.label_Author);
            this.splitContainer_Storage.Panel2.Controls.Add(this.label_Type);
            this.splitContainer_Storage.Panel2.Controls.Add(this.label_Price);
            this.splitContainer_Storage.Panel2.Controls.Add(this.label_Name);
            this.splitContainer_Storage.Panel2.Controls.Add(this.label_ID);
            this.splitContainer_Storage.Size = new System.Drawing.Size(786, 411);
            this.splitContainer_Storage.SplitterDistance = 262;
            this.splitContainer_Storage.TabIndex = 2;
            // 
            // dataGridView_Storage
            // 
            this.dataGridView_Storage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Storage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Storage.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Storage.Name = "dataGridView_Storage";
            this.dataGridView_Storage.RowHeadersWidth = 62;
            this.dataGridView_Storage.RowTemplate.Height = 28;
            this.dataGridView_Storage.Size = new System.Drawing.Size(262, 411);
            this.dataGridView_Storage.TabIndex = 0;
            // 
            // button_AddNewItem
            // 
            this.button_AddNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddNewItem.Location = new System.Drawing.Point(104, 351);
            this.button_AddNewItem.Name = "button_AddNewItem";
            this.button_AddNewItem.Size = new System.Drawing.Size(83, 55);
            this.button_AddNewItem.TabIndex = 3;
            this.button_AddNewItem.Text = "Ny";
            this.button_AddNewItem.UseVisualStyleBackColor = true;
            // 
            // button_DeleteItem
            // 
            this.button_DeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteItem.Location = new System.Drawing.Point(255, 351);
            this.button_DeleteItem.Name = "button_DeleteItem";
            this.button_DeleteItem.Size = new System.Drawing.Size(86, 55);
            this.button_DeleteItem.TabIndex = 4;
            this.button_DeleteItem.Text = "Radera";
            this.button_DeleteItem.UseVisualStyleBackColor = true;
            // 
            // button_Delivery
            // 
            this.button_Delivery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delivery.Location = new System.Drawing.Point(409, 351);
            this.button_Delivery.Name = "button_Delivery";
            this.button_Delivery.Size = new System.Drawing.Size(91, 55);
            this.button_Delivery.TabIndex = 5;
            this.button_Delivery.Text = "Leverans";
            this.button_Delivery.UseVisualStyleBackColor = true;
            // 
            // textBox_Format
            // 
            this.textBox_Format.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Format.Location = new System.Drawing.Point(104, 186);
            this.textBox_Format.Name = "textBox_Format";
            this.textBox_Format.Size = new System.Drawing.Size(396, 26);
            this.textBox_Format.TabIndex = 48;
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Genre.Location = new System.Drawing.Point(104, 157);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(396, 26);
            this.textBox_Genre.TabIndex = 47;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Author.Location = new System.Drawing.Point(104, 128);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(396, 26);
            this.textBox_Author.TabIndex = 46;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Type.Location = new System.Drawing.Point(104, 99);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(396, 26);
            this.textBox_Type.TabIndex = 45;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Price.Location = new System.Drawing.Point(104, 70);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(396, 26);
            this.textBox_Price.TabIndex = 44;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name.Location = new System.Drawing.Point(104, 40);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(396, 26);
            this.textBox_Name.TabIndex = 43;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ID.Location = new System.Drawing.Point(104, 9);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(396, 26);
            this.textBox_ID.TabIndex = 42;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_Format
            // 
            this.label_Format.AutoSize = true;
            this.label_Format.Location = new System.Drawing.Point(14, 192);
            this.label_Format.Name = "label_Format";
            this.label_Format.Size = new System.Drawing.Size(60, 20);
            this.label_Format.TabIndex = 41;
            this.label_Format.Text = "Format";
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Location = new System.Drawing.Point(14, 163);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(54, 20);
            this.label_Genre.TabIndex = 40;
            this.label_Genre.Text = "Genre";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Location = new System.Drawing.Point(14, 134);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(80, 20);
            this.label_Author.TabIndex = 39;
            this.label_Author.Text = "Författare";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(14, 105);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(34, 20);
            this.label_Type.TabIndex = 38;
            this.label_Type.Text = "Typ";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(14, 76);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(35, 20);
            this.label_Price.TabIndex = 37;
            this.label_Price.Text = "Pris";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(14, 46);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(51, 20);
            this.label_Name.TabIndex = 36;
            this.label_Name.Text = "Namn";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(14, 9);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(26, 20);
            this.label_ID.TabIndex = 35;
            this.label_ID.Text = "ID";
            // 
            // Usercontrol_storage
            // 
            this.Usercontrol_storage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Usercontrol_storage.Location = new System.Drawing.Point(3, 3);
            this.Usercontrol_storage.Name = "Usercontrol_storage";
            this.Usercontrol_storage.Size = new System.Drawing.Size(786, 411);
            this.Usercontrol_storage.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Affärssystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab.ResumeLayout(false);
            this.CashregisterTab.ResumeLayout(false);
            this.splitContainer_Cashregister.Panel1.ResumeLayout(false);
            this.splitContainer_Cashregister.Panel2.ResumeLayout(false);
            this.splitContainer_Cashregister.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Cashregister)).EndInit();
            this.splitContainer_Cashregister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cashregister_dataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.StorageTab.ResumeLayout(false);
            this.splitContainer_Storage.Panel1.ResumeLayout(false);
            this.splitContainer_Storage.Panel2.ResumeLayout(false);
            this.splitContainer_Storage.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Storage)).EndInit();
            this.splitContainer_Storage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Storage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage CashregisterTab;
        private System.Windows.Forms.TabPage StorageTab;
        private System.Windows.Forms.UserControl Usercontrol_cashregister;
        private System.Windows.Forms.UserControl Usercontrol_storage;
        private System.Windows.Forms.SplitContainer splitContainer_Cashregister;
        private System.Windows.Forms.DataGridView Cashregister_dataGridView;
        private System.Windows.Forms.SplitContainer splitContainer_Storage;
        private System.Windows.Forms.DataGridView dataGridView_Storage;
        private System.Windows.Forms.Button button_Delivery;
        private System.Windows.Forms.Button button_DeleteItem;
        private System.Windows.Forms.Button button_AddNewItem;
        private System.Windows.Forms.TextBox textBox_Format;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_Format;
        private System.Windows.Forms.Label label_Genre;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button_ClearCart;
        private System.Windows.Forms.Button button_Pay;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Button button_AddCart;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.TextBox textBox_CashOut;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

