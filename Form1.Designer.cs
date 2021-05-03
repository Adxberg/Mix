
namespace Ordbehandlare
{
    partial class Form_Name
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.New = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Save_As = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.countWithSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.countWithoutSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.countLinesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.countWordsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 398);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(553, 27);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(107, 35);
            this.New.TabIndex = 1;
            this.New.Text = "Ny";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(553, 68);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(107, 35);
            this.Open.TabIndex = 2;
            this.Open.Text = "Öppna";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(553, 109);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(107, 35);
            this.Save.TabIndex = 3;
            this.Save.Text = "Spara";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Save_As
            // 
            this.Save_As.Location = new System.Drawing.Point(553, 150);
            this.Save_As.Name = "Save_As";
            this.Save_As.Size = new System.Drawing.Size(107, 35);
            this.Save_As.TabIndex = 4;
            this.Save_As.Text = "Spara som";
            this.Save_As.UseVisualStyleBackColor = true;
            this.Save_As.Click += new System.EventHandler(this.Save_As_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(553, 390);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(107, 35);
            this.Quit.TabIndex = 5;
            this.Quit.Text = "Avsluta";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(553, 192);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(107, 34);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Rensa";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countWithSpace,
            this.countWithoutSpace,
            this.countLinesLabel,
            this.countWordsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(885, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // countWithSpace
            // 
            this.countWithSpace.Name = "countWithSpace";
            this.countWithSpace.Size = new System.Drawing.Size(0, 15);
            // 
            // countWithoutSpace
            // 
            this.countWithoutSpace.Name = "countWithoutSpace";
            this.countWithoutSpace.Size = new System.Drawing.Size(0, 15);
            // 
            // countLinesLabel
            // 
            this.countLinesLabel.Name = "countLinesLabel";
            this.countLinesLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // countWordsLabel
            // 
            this.countWordsLabel.Name = "countWordsLabel";
            this.countWordsLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // Form_Name
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 480);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Save_As);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.New);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_Name";
            this.Text = "Namnlös";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragAndDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragAndEnter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Save_As;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel countWithSpace;
        private System.Windows.Forms.ToolStripStatusLabel countWithoutSpace;
        private System.Windows.Forms.ToolStripStatusLabel countLinesLabel;
        private System.Windows.Forms.ToolStripStatusLabel countWordsLabel;
    }
}

