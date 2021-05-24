
namespace Bibliotek
{
    partial class Storesystem
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
            this.TabForm = new System.Windows.Forms.TabControl();
            this.tab_CashRegister = new System.Windows.Forms.TabPage();
            this.tab_Storage = new System.Windows.Forms.TabPage();
            this.TabForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabForm
            // 
            this.TabForm.Controls.Add(this.tab_CashRegister);
            this.TabForm.Controls.Add(this.tab_Storage);
            this.TabForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabForm.Location = new System.Drawing.Point(0, 0);
            this.TabForm.Name = "TabForm";
            this.TabForm.SelectedIndex = 0;
            this.TabForm.Size = new System.Drawing.Size(834, 494);
            this.TabForm.TabIndex = 0;
            // 
            // tab_CashRegister
            // 
            this.tab_CashRegister.Location = new System.Drawing.Point(4, 29);
            this.tab_CashRegister.Name = "tab_CashRegister";
            this.tab_CashRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CashRegister.Size = new System.Drawing.Size(826, 461);
            this.tab_CashRegister.TabIndex = 0;
            this.tab_CashRegister.Text = "Kassabruk";
            this.tab_CashRegister.UseVisualStyleBackColor = true;
            // 
            // tab_Storage
            // 
            this.tab_Storage.Location = new System.Drawing.Point(4, 29);
            this.tab_Storage.Name = "tab_Storage";
            this.tab_Storage.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Storage.Size = new System.Drawing.Size(792, 417);
            this.tab_Storage.TabIndex = 1;
            this.tab_Storage.Text = "Lagerarbete";
            this.tab_Storage.UseVisualStyleBackColor = true;
            // 
            // Storesystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 494);
            this.Controls.Add(this.TabForm);
            this.MaximizeBox = false;
            this.Name = "Storesystem";
            this.Text = "Affärshanteringssystem";
            this.Load += new System.EventHandler(this.Storesystem_Load);
            this.TabForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabForm;
        private System.Windows.Forms.TabPage tab_CashRegister;
        private System.Windows.Forms.TabPage tab_Storage;
    }
}

