
namespace Bibliotek
{
    partial class AddNewItemToCart
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
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.textBox_singleprice = new System.Windows.Forms.TextBox();
            this.textBox_tot = new System.Windows.Forms.TextBox();
            this.label_product = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_singleprice = new System.Windows.Forms.Label();
            this.label_Tot = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_info
            // 
            this.textBox_info.Location = new System.Drawing.Point(100, 135);
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.ReadOnly = true;
            this.textBox_info.Size = new System.Drawing.Size(210, 26);
            this.textBox_info.TabIndex = 0;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(100, 168);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(100, 26);
            this.textBox_quantity.TabIndex = 1;
            this.textBox_quantity.TextChanged += new System.EventHandler(this.textBox_quantity_TextChanged);
            // 
            // textBox_singleprice
            // 
            this.textBox_singleprice.Location = new System.Drawing.Point(100, 200);
            this.textBox_singleprice.Name = "textBox_singleprice";
            this.textBox_singleprice.ReadOnly = true;
            this.textBox_singleprice.Size = new System.Drawing.Size(100, 26);
            this.textBox_singleprice.TabIndex = 2;
            // 
            // textBox_tot
            // 
            this.textBox_tot.Location = new System.Drawing.Point(100, 250);
            this.textBox_tot.Name = "textBox_tot";
            this.textBox_tot.ReadOnly = true;
            this.textBox_tot.Size = new System.Drawing.Size(100, 26);
            this.textBox_tot.TabIndex = 3;
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Location = new System.Drawing.Point(30, 135);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(64, 20);
            this.label_product.TabIndex = 4;
            this.label_product.Text = "Produkt";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(30, 168);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(46, 20);
            this.label_quantity.TabIndex = 5;
            this.label_quantity.Text = "Antal";
            // 
            // label_singleprice
            // 
            this.label_singleprice.AutoSize = true;
            this.label_singleprice.Location = new System.Drawing.Point(30, 200);
            this.label_singleprice.Name = "label_singleprice";
            this.label_singleprice.Size = new System.Drawing.Size(48, 20);
            this.label_singleprice.TabIndex = 6;
            this.label_singleprice.Text = "á Pris";
            // 
            // label_Tot
            // 
            this.label_Tot.AutoSize = true;
            this.label_Tot.Location = new System.Drawing.Point(30, 250);
            this.label_Tot.Name = "label_Tot";
            this.label_Tot.Size = new System.Drawing.Size(44, 20);
            this.label_Tot.TabIndex = 7;
            this.label_Tot.Text = "Total";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(203, 322);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(107, 35);
            this.button_Cancel.TabIndex = 8;
            this.button_Cancel.Text = "Avbryt";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(34, 322);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(136, 35);
            this.button_OK.TabIndex = 9;
            this.button_OK.Text = "Lägg i varukorg";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // AddNewItemToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 405);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label_Tot);
            this.Controls.Add(this.label_singleprice);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.textBox_tot);
            this.Controls.Add(this.textBox_singleprice);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.textBox_info);
            this.MaximumSize = new System.Drawing.Size(379, 461);
            this.MinimumSize = new System.Drawing.Size(379, 461);
            this.Name = "AddNewItemToCart";
            this.Text = "AddNewItemToCart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.TextBox textBox_singleprice;
        private System.Windows.Forms.TextBox textBox_tot;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_singleprice;
        private System.Windows.Forms.Label label_Tot;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
    }
}
