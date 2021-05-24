
namespace Bibliotek
{
    partial class Storage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer_Storage = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Storage = new System.Windows.Forms.DataGridView();
            this.textBox_Platform = new System.Windows.Forms.TextBox();
            this.label_Platform = new System.Windows.Forms.Label();
            this.textBox_Playtime = new System.Windows.Forms.TextBox();
            this.label_Playtime = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.textBox_Language = new System.Windows.Forms.TextBox();
            this.label_Language = new System.Windows.Forms.Label();
            this.tableLayoutPanel_StorageButtons = new System.Windows.Forms.TableLayoutPanel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Delivery = new System.Windows.Forms.Button();
            this.button_SaveNew = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_AddNew = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Storage)).BeginInit();
            this.splitContainer_Storage.Panel1.SuspendLayout();
            this.splitContainer_Storage.Panel2.SuspendLayout();
            this.splitContainer_Storage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Storage)).BeginInit();
            this.tableLayoutPanel_StorageButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_Storage
            // 
            this.splitContainer_Storage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Storage.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Storage.Name = "splitContainer_Storage";
            // 
            // splitContainer_Storage.Panel1
            // 
            this.splitContainer_Storage.Panel1.Controls.Add(this.dataGridView_Storage);
            // 
            // splitContainer_Storage.Panel2
            // 
            this.splitContainer_Storage.Panel2.Controls.Add(this.textBox_Platform);
            this.splitContainer_Storage.Panel2.Controls.Add(this.label_Platform);
            this.splitContainer_Storage.Panel2.Controls.Add(this.textBox_Playtime);
            this.splitContainer_Storage.Panel2.Controls.Add(this.label_Playtime);
            this.splitContainer_Storage.Panel2.Controls.Add(this.textBox_Quantity);
            this.splitContainer_Storage.Panel2.Controls.Add(this.label_Quantity);
            this.splitContainer_Storage.Panel2.Controls.Add(this.textBox_Language);
            this.splitContainer_Storage.Panel2.Controls.Add(this.label_Language);
            this.splitContainer_Storage.Panel2.Controls.Add(this.tableLayoutPanel_StorageButtons);
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
            this.splitContainer_Storage.Size = new System.Drawing.Size(950, 550);
            this.splitContainer_Storage.SplitterDistance = 315;
            this.splitContainer_Storage.TabIndex = 0;
            // 
            // dataGridView_Storage
            // 
            this.dataGridView_Storage.AllowUserToAddRows = false;
            this.dataGridView_Storage.AllowUserToDeleteRows = false;
            this.dataGridView_Storage.AllowUserToOrderColumns = true;
            this.dataGridView_Storage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Storage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Storage.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Storage.MultiSelect = false;
            this.dataGridView_Storage.Name = "dataGridView_Storage";
            this.dataGridView_Storage.ReadOnly = true;
            this.dataGridView_Storage.RowHeadersWidth = 62;
            this.dataGridView_Storage.RowTemplate.Height = 28;
            this.dataGridView_Storage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Storage.ShowCellErrors = false;
            this.dataGridView_Storage.ShowCellToolTips = false;
            this.dataGridView_Storage.ShowEditingIcon = false;
            this.dataGridView_Storage.ShowRowErrors = false;
            this.dataGridView_Storage.Size = new System.Drawing.Size(315, 550);
            this.dataGridView_Storage.TabIndex = 0;
            this.dataGridView_Storage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Storage_CellClick);
             // 
            // textBox_Platform
            // 
            this.textBox_Platform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Platform.Location = new System.Drawing.Point(133, 264);
            this.textBox_Platform.Name = "textBox_Platform";
            this.textBox_Platform.Size = new System.Drawing.Size(474, 26);
            this.textBox_Platform.TabIndex = 22;
            this.textBox_Platform.TextChanged += new System.EventHandler(this.textBox_Platform_TextChanged);
            // 
            // label_Platform
            // 
            this.label_Platform.AutoSize = true;
            this.label_Platform.Location = new System.Drawing.Point(22, 270);
            this.label_Platform.Name = "label_Platform";
            this.label_Platform.Size = new System.Drawing.Size(73, 20);
            this.label_Platform.TabIndex = 21;
            this.label_Platform.Text = "Plattform";
            // 
            // textBox_Playtime
            // 
            this.textBox_Playtime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Playtime.Location = new System.Drawing.Point(133, 299);
            this.textBox_Playtime.Name = "textBox_Playtime";
            this.textBox_Playtime.Size = new System.Drawing.Size(474, 26);
            this.textBox_Playtime.TabIndex = 20;
            // 
            // label_Playtime
            // 
            this.label_Playtime.AutoSize = true;
            this.label_Playtime.Location = new System.Drawing.Point(22, 299);
            this.label_Playtime.Name = "label_Playtime";
            this.label_Playtime.Size = new System.Drawing.Size(58, 20);
            this.label_Playtime.TabIndex = 19;
            this.label_Playtime.Text = "Speltid";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Quantity.Location = new System.Drawing.Point(133, 331);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(474, 26);
            this.textBox_Quantity.TabIndex = 18;
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Location = new System.Drawing.Point(22, 331);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(92, 20);
            this.label_Quantity.TabIndex = 17;
            this.label_Quantity.Text = "Antal i lager";
            // 
            // textBox_Language
            // 
            this.textBox_Language.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Language.Location = new System.Drawing.Point(133, 232);
            this.textBox_Language.Name = "textBox_Language";
            this.textBox_Language.Size = new System.Drawing.Size(474, 26);
            this.textBox_Language.TabIndex = 16;
            // 
            // label_Language
            // 
            this.label_Language.AutoSize = true;
            this.label_Language.Location = new System.Drawing.Point(22, 239);
            this.label_Language.Name = "label_Language";
            this.label_Language.Size = new System.Drawing.Size(51, 20);
            this.label_Language.TabIndex = 15;
            this.label_Language.Text = "Språk";
            // 
            // tableLayoutPanel_StorageButtons
            // 
            this.tableLayoutPanel_StorageButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_StorageButtons.ColumnCount = 6;
            this.tableLayoutPanel_StorageButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_StorageButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_StorageButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_StorageButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_StorageButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_StorageButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_StorageButtons.Controls.Add(this.button_Exit, 0, 0);
            this.tableLayoutPanel_StorageButtons.Controls.Add(this.button_Delivery, 0, 0);
            this.tableLayoutPanel_StorageButtons.Controls.Add(this.button_SaveNew, 1, 0);
            this.tableLayoutPanel_StorageButtons.Controls.Add(this.button_Delete, 2, 0);
            this.tableLayoutPanel_StorageButtons.Controls.Add(this.button_AddNew, 4, 0);
            this.tableLayoutPanel_StorageButtons.Controls.Add(this.button_search, 5, 0);
            this.tableLayoutPanel_StorageButtons.Location = new System.Drawing.Point(3, 436);
            this.tableLayoutPanel_StorageButtons.Name = "tableLayoutPanel_StorageButtons";
            this.tableLayoutPanel_StorageButtons.RowCount = 1;
            this.tableLayoutPanel_StorageButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_StorageButtons.Size = new System.Drawing.Size(625, 111);
            this.tableLayoutPanel_StorageButtons.TabIndex = 14;
            // 
            // button_Exit
            // 
            this.button_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Exit.Location = new System.Drawing.Point(107, 3);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(98, 105);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "Avsluta";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Delivery
            // 
            this.button_Delivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Delivery.Location = new System.Drawing.Point(3, 3);
            this.button_Delivery.Name = "button_Delivery";
            this.button_Delivery.Size = new System.Drawing.Size(98, 105);
            this.button_Delivery.TabIndex = 0;
            this.button_Delivery.Text = "Leverans";
            this.button_Delivery.UseVisualStyleBackColor = true;
            this.button_Delivery.Click += new System.EventHandler(this.button_Delivery_Click);
            // 
            // button_SaveNew
            // 
            this.button_SaveNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SaveNew.Enabled = false;
            this.button_SaveNew.Location = new System.Drawing.Point(211, 3);
            this.button_SaveNew.Name = "button_SaveNew";
            this.button_SaveNew.Size = new System.Drawing.Size(98, 105);
            this.button_SaveNew.TabIndex = 1;
            this.button_SaveNew.Text = "Spara ";
            this.button_SaveNew.UseVisualStyleBackColor = true;
            this.button_SaveNew.Click += new System.EventHandler(this.button_SaveNew_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Delete.Location = new System.Drawing.Point(315, 3);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(98, 105);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Radera från listan";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_AddNew
            // 
            this.button_AddNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddNew.Location = new System.Drawing.Point(419, 3);
            this.button_AddNew.Name = "button_AddNew";
            this.button_AddNew.Size = new System.Drawing.Size(98, 105);
            this.button_AddNew.TabIndex = 6;
            this.button_AddNew.Text = "Ny";
            this.button_AddNew.UseVisualStyleBackColor = true;
            this.button_AddNew.Click += new System.EventHandler(this.button_AddNew_Click);
            // 
            // button_search
            // 
            this.button_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_search.Location = new System.Drawing.Point(523, 3);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(99, 105);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Sök";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_Format
            // 
            this.textBox_Format.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Format.Location = new System.Drawing.Point(133, 200);
            this.textBox_Format.Name = "textBox_Format";
            this.textBox_Format.Size = new System.Drawing.Size(474, 26);
            this.textBox_Format.TabIndex = 13;
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Genre.Location = new System.Drawing.Point(133, 168);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(474, 26);
            this.textBox_Genre.TabIndex = 12;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Author.Location = new System.Drawing.Point(133, 136);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(474, 26);
            this.textBox_Author.TabIndex = 11;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Type.Location = new System.Drawing.Point(133, 104);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(474, 26);
            this.textBox_Type.TabIndex = 10;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Price.Location = new System.Drawing.Point(133, 73);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(474, 26);
            this.textBox_Price.TabIndex = 9;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name.Location = new System.Drawing.Point(133, 42);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(474, 26);
            this.textBox_Name.TabIndex = 8;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ID.Location = new System.Drawing.Point(133, 13);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(474, 26);
            this.textBox_ID.TabIndex = 7;
            // 
            // label_Format
            // 
            this.label_Format.AutoSize = true;
            this.label_Format.Location = new System.Drawing.Point(22, 205);
            this.label_Format.Name = "label_Format";
            this.label_Format.Size = new System.Drawing.Size(60, 20);
            this.label_Format.TabIndex = 6;
            this.label_Format.Text = "Format";
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Location = new System.Drawing.Point(19, 170);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(54, 20);
            this.label_Genre.TabIndex = 5;
            this.label_Genre.Text = "Genre";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Location = new System.Drawing.Point(19, 133);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(80, 20);
            this.label_Author.TabIndex = 4;
            this.label_Author.Text = "Författare";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(19, 104);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(34, 20);
            this.label_Type.TabIndex = 3;
            this.label_Type.Text = "Typ";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(19, 73);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(35, 20);
            this.label_Price.TabIndex = 2;
            this.label_Price.Text = "Pris";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(19, 42);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(51, 20);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Namn";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(19, 13);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(26, 20);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID";
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer_Storage);
            this.Name = "Storage";
            this.Size = new System.Drawing.Size(950, 550);
            this.splitContainer_Storage.Panel1.ResumeLayout(false);
            this.splitContainer_Storage.Panel2.ResumeLayout(false);
            this.splitContainer_Storage.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Storage)).EndInit();
            this.splitContainer_Storage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Storage)).EndInit();
            this.tableLayoutPanel_StorageButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Storage;
        private System.Windows.Forms.DataGridView dataGridView_Storage;
        private System.Windows.Forms.Label label_Genre;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Format;
        private System.Windows.Forms.TextBox textBox_Format;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_StorageButtons;
        private System.Windows.Forms.Button button_Delivery;
        private System.Windows.Forms.Button button_SaveNew;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label_Language;
        private System.Windows.Forms.TextBox textBox_Language;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Button button_AddNew;
        private System.Windows.Forms.TextBox textBox_Platform;
        private System.Windows.Forms.Label label_Platform;
        private System.Windows.Forms.TextBox textBox_Playtime;
        private System.Windows.Forms.Label label_Playtime;
        private System.Windows.Forms.Button button_search;
    }
}
