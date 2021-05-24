
namespace Bibliotek
{
    partial class Form_CheckOut
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
            this.textBox_totalCheckout = new System.Windows.Forms.TextBox();
            this.label_Total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Taxes = new System.Windows.Forms.TextBox();
            this.label_pay = new System.Windows.Forms.Label();
            this.textBox_FromCustomer = new System.Windows.Forms.TextBox();
            this.label_Change = new System.Windows.Forms.Label();
            this.textBox_Change = new System.Windows.Forms.TextBox();
            this.button_PayExit = new System.Windows.Forms.Button();
            this.button_Done = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_totalCheckout
            // 
            this.textBox_totalCheckout.Location = new System.Drawing.Point(185, 99);
            this.textBox_totalCheckout.Name = "textBox_totalCheckout";
            this.textBox_totalCheckout.ReadOnly = true;
            this.textBox_totalCheckout.Size = new System.Drawing.Size(240, 26);
            this.textBox_totalCheckout.TabIndex = 0;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(36, 105);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(93, 20);
            this.label_Total.TabIndex = 1;
            this.label_Total.Text = "Att betala:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Varav 25% moms: ";
            // 
            // textBox_Taxes
            // 
            this.textBox_Taxes.Location = new System.Drawing.Point(185, 142);
            this.textBox_Taxes.Name = "textBox_Taxes";
            this.textBox_Taxes.ReadOnly = true;
            this.textBox_Taxes.Size = new System.Drawing.Size(240, 26);
            this.textBox_Taxes.TabIndex = 3;
            // 
            // label_pay
            // 
            this.label_pay.AutoSize = true;
            this.label_pay.Location = new System.Drawing.Point(40, 239);
            this.label_pay.Name = "label_pay";
            this.label_pay.Size = new System.Drawing.Size(59, 20);
            this.label_pay.TabIndex = 4;
            this.label_pay.Text = "Betala:";
            // 
            // textBox_FromCustomer
            // 
            this.textBox_FromCustomer.Location = new System.Drawing.Point(185, 236);
            this.textBox_FromCustomer.Name = "textBox_FromCustomer";
            this.textBox_FromCustomer.Size = new System.Drawing.Size(240, 26);
            this.textBox_FromCustomer.TabIndex = 5;
            // 
            // label_Change
            // 
            this.label_Change.AutoSize = true;
            this.label_Change.Location = new System.Drawing.Point(44, 282);
            this.label_Change.Name = "label_Change";
            this.label_Change.Size = new System.Drawing.Size(56, 20);
            this.label_Change.TabIndex = 6;
            this.label_Change.Text = "Växel: ";
            // 
            // textBox_Change
            // 
            this.textBox_Change.Location = new System.Drawing.Point(185, 276);
            this.textBox_Change.Name = "textBox_Change";
            this.textBox_Change.ReadOnly = true;
            this.textBox_Change.Size = new System.Drawing.Size(240, 26);
            this.textBox_Change.TabIndex = 7;
            // 
            // button_PayExit
            // 
            this.button_PayExit.Location = new System.Drawing.Point(249, 379);
            this.button_PayExit.Name = "button_PayExit";
            this.button_PayExit.Size = new System.Drawing.Size(85, 36);
            this.button_PayExit.TabIndex = 8;
            this.button_PayExit.Text = "Betala";
            this.button_PayExit.UseVisualStyleBackColor = true;
            this.button_PayExit.Click += new System.EventHandler(this.button_Done_Click);
            // 
            // button_Done
            // 
            this.button_Done.Location = new System.Drawing.Point(341, 379);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(75, 35);
            this.button_Done.TabIndex = 9;
            this.button_Done.Text = "Klar";
            this.button_Done.UseVisualStyleBackColor = true;
            this.button_Done.Click += new System.EventHandler(this.button_Done_Click_1);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(158, 378);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(85, 36);
            this.button_reset.TabIndex = 10;
            this.button_reset.Text = "Kvitto";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // Form_CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_Done);
            this.Controls.Add(this.button_PayExit);
            this.Controls.Add(this.textBox_Change);
            this.Controls.Add(this.label_Change);
            this.Controls.Add(this.textBox_FromCustomer);
            this.Controls.Add(this.label_pay);
            this.Controls.Add(this.textBox_Taxes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.textBox_totalCheckout);
            this.MaximumSize = new System.Drawing.Size(603, 506);
            this.MinimumSize = new System.Drawing.Size(603, 506);
            this.Name = "Form_CheckOut";
            this.Text = "Kassa";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_totalCheckout;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Taxes;
        private System.Windows.Forms.Label label_pay;
        private System.Windows.Forms.TextBox textBox_FromCustomer;
        private System.Windows.Forms.Label label_Change;
        private System.Windows.Forms.TextBox textBox_Change;
        private System.Windows.Forms.Button button_PayExit;
        private System.Windows.Forms.Button button_Done;
        private System.Windows.Forms.Button button_reset;
    }
}