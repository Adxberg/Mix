
namespace Bibliotek
{
    partial class Search
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
            this.textBox_searchName = new System.Windows.Forms.TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.button_searchName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_searchPrice = new System.Windows.Forms.TextBox();
            this.label_searchGenre = new System.Windows.Forms.Label();
            this.textBox_searchGenre = new System.Windows.Forms.TextBox();
            this.button_searchPrice = new System.Windows.Forms.Button();
            this.button_searchGenre = new System.Windows.Forms.Button();
            this.button_done = new System.Windows.Forms.Button();
            this.textBox_searchresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_searchName
            // 
            this.textBox_searchName.Location = new System.Drawing.Point(133, 326);
            this.textBox_searchName.Name = "textBox_searchName";
            this.textBox_searchName.Size = new System.Drawing.Size(225, 26);
            this.textBox_searchName.TabIndex = 0;
            this.textBox_searchName.TextChanged += new System.EventHandler(this.textBox_searchName_TextChanged);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(24, 329);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(89, 20);
            this.label_search.TabIndex = 1;
            this.label_search.Text = "Sök namn: ";
            // 
            // button_searchName
            // 
            this.button_searchName.Enabled = false;
            this.button_searchName.Location = new System.Drawing.Point(184, 367);
            this.button_searchName.Name = "button_searchName";
            this.button_searchName.Size = new System.Drawing.Size(100, 36);
            this.button_searchName.TabIndex = 2;
            this.button_searchName.Text = "Sök namn";
            this.button_searchName.UseVisualStyleBackColor = true;
            this.button_searchName.Click += new System.EventHandler(this.button_done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Sök pris:";
            // 
            // textBox_searchPrice
            // 
            this.textBox_searchPrice.Location = new System.Drawing.Point(459, 326);
            this.textBox_searchPrice.Name = "textBox_searchPrice";
            this.textBox_searchPrice.Size = new System.Drawing.Size(84, 26);
            this.textBox_searchPrice.TabIndex = 70;
            this.textBox_searchPrice.TextChanged += new System.EventHandler(this.textBox_searchPrice_TextChanged);
            // 
            // label_searchGenre
            // 
            this.label_searchGenre.AutoSize = true;
            this.label_searchGenre.Location = new System.Drawing.Point(559, 326);
            this.label_searchGenre.Name = "label_searchGenre";
            this.label_searchGenre.Size = new System.Drawing.Size(86, 20);
            this.label_searchGenre.TabIndex = 71;
            this.label_searchGenre.Text = "Sök genre:";
            // 
            // textBox_searchGenre
            // 
            this.textBox_searchGenre.Location = new System.Drawing.Point(651, 323);
            this.textBox_searchGenre.Name = "textBox_searchGenre";
            this.textBox_searchGenre.Size = new System.Drawing.Size(104, 26);
            this.textBox_searchGenre.TabIndex = 72;
            this.textBox_searchGenre.TextChanged += new System.EventHandler(this.textBox_searchGenre_TextChanged);
            // 
            // button_searchPrice
            // 
            this.button_searchPrice.Enabled = false;
            this.button_searchPrice.Location = new System.Drawing.Point(459, 367);
            this.button_searchPrice.Name = "button_searchPrice";
            this.button_searchPrice.Size = new System.Drawing.Size(100, 36);
            this.button_searchPrice.TabIndex = 73;
            this.button_searchPrice.Text = "Sök pris";
            this.button_searchPrice.UseVisualStyleBackColor = true;
            this.button_searchPrice.Click += new System.EventHandler(this.button_searchPrice_Click);
            // 
            // button_searchGenre
            // 
            this.button_searchGenre.Enabled = false;
            this.button_searchGenre.Location = new System.Drawing.Point(651, 367);
            this.button_searchGenre.Name = "button_searchGenre";
            this.button_searchGenre.Size = new System.Drawing.Size(100, 36);
            this.button_searchGenre.TabIndex = 74;
            this.button_searchGenre.Text = "Sök genre";
            this.button_searchGenre.UseVisualStyleBackColor = true;
            this.button_searchGenre.Click += new System.EventHandler(this.button_searchGenre_Click);
            // 
            // button_done
            // 
            this.button_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_done.Location = new System.Drawing.Point(651, 183);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(84, 70);
            this.button_done.TabIndex = 75;
            this.button_done.Text = "Klar";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Click += new System.EventHandler(this.button_done_Click_1);
            // 
            // textBox_searchresult
            // 
            this.textBox_searchresult.Location = new System.Drawing.Point(13, 13);
            this.textBox_searchresult.Multiline = true;
            this.textBox_searchresult.Name = "textBox_searchresult";
            this.textBox_searchresult.ReadOnly = true;
            this.textBox_searchresult.Size = new System.Drawing.Size(632, 291);
            this.textBox_searchresult.TabIndex = 76;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_searchresult);
            this.Controls.Add(this.button_done);
            this.Controls.Add(this.button_searchGenre);
            this.Controls.Add(this.button_searchPrice);
            this.Controls.Add(this.textBox_searchGenre);
            this.Controls.Add(this.label_searchGenre);
            this.Controls.Add(this.textBox_searchPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_searchName);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.textBox_searchName);
            this.MaximumSize = new System.Drawing.Size(822, 506);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_searchName;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Button button_searchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_searchPrice;
        private System.Windows.Forms.Label label_searchGenre;
        private System.Windows.Forms.TextBox textBox_searchGenre;
        private System.Windows.Forms.Button button_searchPrice;
        private System.Windows.Forms.Button button_searchGenre;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.TextBox textBox_searchresult;
    }
}