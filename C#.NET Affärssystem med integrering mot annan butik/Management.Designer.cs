
namespace Bibliotek
{
    partial class Management
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
            this.splitContainer_CashRegister = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Cash = new System.Windows.Forms.DataGridView();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.label_Total = new System.Windows.Forms.Label();
            this.textBox_Cart = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_CashButtons = new System.Windows.Forms.TableLayoutPanel();
            this.button_Pay = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Cart = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.dataGridView_CashRegister = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_AddToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CashRegister)).BeginInit();
            this.splitContainer_CashRegister.Panel1.SuspendLayout();
            this.splitContainer_CashRegister.Panel2.SuspendLayout();
            this.splitContainer_CashRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cash)).BeginInit();
            this.tableLayoutPanel_CashButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CashRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_CashRegister
            // 
            this.splitContainer_CashRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_CashRegister.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_CashRegister.Name = "splitContainer_CashRegister";
            // 
            // splitContainer_CashRegister.Panel1
            // 
            this.splitContainer_CashRegister.Panel1.Controls.Add(this.dataGridView_Cash);
            // 
            // splitContainer_CashRegister.Panel2
            // 
            this.splitContainer_CashRegister.Panel2.Controls.Add(this.textBox_Total);
            this.splitContainer_CashRegister.Panel2.Controls.Add(this.label_Total);
            this.splitContainer_CashRegister.Panel2.Controls.Add(this.textBox_Cart);
            this.splitContainer_CashRegister.Panel2.Controls.Add(this.tableLayoutPanel_CashButtons);
            this.splitContainer_CashRegister.Size = new System.Drawing.Size(745, 470);
            this.splitContainer_CashRegister.SplitterDistance = 305;
            this.splitContainer_CashRegister.TabIndex = 0;
            // 
            // dataGridView_Cash
            // 
            this.dataGridView_Cash.AllowUserToAddRows = false;
            this.dataGridView_Cash.AllowUserToDeleteRows = false;
            this.dataGridView_Cash.AllowUserToOrderColumns = true;
            this.dataGridView_Cash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Cash.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Cash.MultiSelect = false;
            this.dataGridView_Cash.Name = "dataGridView_Cash";
            this.dataGridView_Cash.ReadOnly = true;
            this.dataGridView_Cash.RowHeadersWidth = 62;
            this.dataGridView_Cash.RowTemplate.Height = 28;
            this.dataGridView_Cash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cash.ShowCellErrors = false;
            this.dataGridView_Cash.ShowCellToolTips = false;
            this.dataGridView_Cash.ShowEditingIcon = false;
            this.dataGridView_Cash.ShowRowErrors = false;
            this.dataGridView_Cash.Size = new System.Drawing.Size(305, 470);
            this.dataGridView_Cash.TabIndex = 0;
            this.dataGridView_Cash.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Cash_CellClick);
            // 
            // textBox_Total
            // 
            this.textBox_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Total.Location = new System.Drawing.Point(304, 370);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.ReadOnly = true;
            this.textBox_Total.Size = new System.Drawing.Size(126, 26);
            this.textBox_Total.TabIndex = 30;
            this.textBox_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Total
            // 
            this.label_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(230, 371);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(68, 25);
            this.label_Total.TabIndex = 29;
            this.label_Total.Text = "Total:";
            // 
            // textBox_Cart
            // 
            this.textBox_Cart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Cart.Location = new System.Drawing.Point(6, 3);
            this.textBox_Cart.Multiline = true;
            this.textBox_Cart.Name = "textBox_Cart";
            this.textBox_Cart.ReadOnly = true;
            this.textBox_Cart.Size = new System.Drawing.Size(424, 361);
            this.textBox_Cart.TabIndex = 28;
            this.textBox_Cart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel_CashButtons
            // 
            this.tableLayoutPanel_CashButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_CashButtons.ColumnCount = 4;
            this.tableLayoutPanel_CashButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CashButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CashButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CashButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_CashButtons.Controls.Add(this.button_Pay, 0, 0);
            this.tableLayoutPanel_CashButtons.Controls.Add(this.button_Exit, 1, 0);
            this.tableLayoutPanel_CashButtons.Controls.Add(this.button_Cart, 2, 0);
            this.tableLayoutPanel_CashButtons.Controls.Add(this.button_return, 3, 0);
            this.tableLayoutPanel_CashButtons.Location = new System.Drawing.Point(3, 402);
            this.tableLayoutPanel_CashButtons.Name = "tableLayoutPanel_CashButtons";
            this.tableLayoutPanel_CashButtons.RowCount = 1;
            this.tableLayoutPanel_CashButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_CashButtons.Size = new System.Drawing.Size(430, 65);
            this.tableLayoutPanel_CashButtons.TabIndex = 0;
            // 
            // button_Pay
            // 
            this.button_Pay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Pay.Location = new System.Drawing.Point(3, 3);
            this.button_Pay.Name = "button_Pay";
            this.button_Pay.Size = new System.Drawing.Size(101, 59);
            this.button_Pay.TabIndex = 2;
            this.button_Pay.Text = "Betala";
            this.button_Pay.UseVisualStyleBackColor = true;
            this.button_Pay.Click += new System.EventHandler(this.button_Pay_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Exit.Location = new System.Drawing.Point(110, 3);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(101, 59);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Avsluta";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Cart
            // 
            this.button_Cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cart.Location = new System.Drawing.Point(217, 3);
            this.button_Cart.Name = "button_Cart";
            this.button_Cart.Size = new System.Drawing.Size(101, 59);
            this.button_Cart.TabIndex = 5;
            this.button_Cart.Text = "Lägg i varukorg";
            this.button_Cart.UseVisualStyleBackColor = true;
            this.button_Cart.Click += new System.EventHandler(this.button_Cart_Click);
            // 
            // button_return
            // 
            this.button_return.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_return.Location = new System.Drawing.Point(324, 3);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(103, 59);
            this.button_return.TabIndex = 6;
            this.button_return.Text = "Retur";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // dataGridView_CashRegister
            // 
            this.dataGridView_CashRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CashRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_CashRegister.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_CashRegister.Name = "dataGridView_CashRegister";
            this.dataGridView_CashRegister.RowHeadersWidth = 62;
            this.dataGridView_CashRegister.RowTemplate.Height = 28;
            this.dataGridView_CashRegister.Size = new System.Drawing.Size(265, 470);
            this.dataGridView_CashRegister.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_CashRegister);
            this.splitContainer1.Panel1.Controls.Add(this.button_AddToCart);
            this.splitContainer1.Size = new System.Drawing.Size(493, 470);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_AddToCart
            // 
            this.button_AddToCart.Location = new System.Drawing.Point(3, 431);
            this.button_AddToCart.Name = "button_AddToCart";
            this.button_AddToCart.Size = new System.Drawing.Size(259, 36);
            this.button_AddToCart.TabIndex = 0;
            this.button_AddToCart.Text = "Lägg i varukorg";
            this.button_AddToCart.UseVisualStyleBackColor = true;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer_CashRegister);
            this.MaximumSize = new System.Drawing.Size(745, 470);
            this.MinimumSize = new System.Drawing.Size(745, 470);
            this.Name = "Management";
            this.Size = new System.Drawing.Size(745, 470);
            this.splitContainer_CashRegister.Panel1.ResumeLayout(false);
            this.splitContainer_CashRegister.Panel2.ResumeLayout(false);
            this.splitContainer_CashRegister.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CashRegister)).EndInit();
            this.splitContainer_CashRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cash)).EndInit();
            this.tableLayoutPanel_CashButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CashRegister)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_CashRegister;
        private System.Windows.Forms.DataGridView dataGridView_CashRegister;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_AddToCart;
        private System.Windows.Forms.DataGridView dataGridView_Cash;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_CashButtons;
        private System.Windows.Forms.Button button_Pay;
        private System.Windows.Forms.TextBox textBox_Cart;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Cart;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Button button_return;
    }
}
