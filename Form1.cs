/*Angelika Doxakis Berg angedoxa100 10 feb 2021, Laboration 3 ordbehandlare*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordbehandlare
{
    public partial class Form_Name : Form
    {
        string path = "";
        string fileName = "Namnlös";
        string allText = "";
        
        public Form_Name()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        /* Sparafunktion. Öppnar en SaveFileDialog. Sätter filtret till enbart .txt filer. placerar
         * filvägen i sträng path o innehållet i allText*/
        private void Save_As_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Spara fil";
            saveFile.Filter = "*.txt|*.txt";
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, textBox1.Text);
                fileName = Path.GetFileName(saveFile.FileName);
                path = saveFile.FileName;
                allText = textBox1.Text;
                Form1_Load(sender, e);
            }

        }
        /* funktion för att öppna .txt filer med OpenFileDialog. placerr innehållet i en textbox.
         * spar filvägen i en sträng.*/
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "*.txt|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFile.OpenFile();
                fileName = Path.GetFileName(openFile.FileName);
                path = openFile.FileName;

                textBox1.Text = File.ReadAllText(openFile.FileName);
                allText = textBox1.Text;
                Form1_Load(sender, e);
                fileStream.Dispose();
            }
        }
        /* kollar om filen redan finns, i annat fall öppnas en savefiledialog för att spara
         * filen som ny.*/
        private void Save_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                Save_As.PerformClick();
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = path;
                File.WriteAllText(saveFile.FileName, textBox1.Text);
                allText = textBox1.Text;
                MessageBox.Show("Sparad");
            }
        }
        /* döper om själva Form till filnamnet uppe i listen. Namnlös som default */
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = fileName;
        }       
        /* vill anv öppna en ny textbox kollar först om innehållet stämmer överens med originalinnehållet 
         * som sparades i en sträng. är innehållet ändrat får anv frågan om önskar spara o skickas isfl först
         * till sparafunktion o sen startas applikationen om. annars startas den bara om.*/
        private void New_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != allText)
            {
                if (MessageBox.Show("Vill du spara ändringarna för " + fileName + "?", "Avsluta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.No)
                {
                    Application.Restart();
                }
                else
                {
                    Save.PerformClick();
                    Application.Restart();
                }
            }
            else
            {
                Application.Restart();
            }
        }
        /* om användaren vill rensa innehållet rensas textboxen.*/
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        /* varje gång innehållet förändras sätts en asterix framför filnamnet samt räknar ord, rader och
         * tecken med och utan blanksteg som skrivs ut i en bar */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int countTextWithSpace;
            int countTextWithoutSpace;
            int countWords;
            int countLines;

            if (textBox1.Text != "")
            {
                this.Text = "*" + fileName;
            }

            countTextWithoutSpace = textBox1.Text.Replace(" ", String.Empty).Length;
            countTextWithSpace = textBox1.Text.Length;
            countLines = textBox1.Text.Split('\r').Length;
            countWords = textBox1.Text.Split(' ').Length;
                
            countWithSpace.Text = "Antal tecken utan space: " + countTextWithoutSpace.ToString() + "  Antal tecken: " + countTextWithSpace.ToString() + "  Antal rader: " + countLines.ToString() + "  Antalet ord: " + countWords.ToString();
        }
        /* om anv vill avsluta kontrolleras först om texten är förändrad från originaltext. om, så öppnas
         * en messagebox som frågar om anv vill spara eller inte eller avbryta.*/
        private void Quit_Click(object sender, EventArgs e)
        {
            string name = this.Text;
            if (name.Trim().StartsWith("*") || textBox1.Text != allText)
            {
                var quitForm = MessageBox.Show("Vill du spara ändringarna för " + fileName + "?", "Avsluta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (quitForm == DialogResult.No)
                {
                    Application.Exit();
                }
               if(quitForm == DialogResult.Cancel)
                {
                    this.DialogResult = DialogResult.None;
                }
                if(quitForm == DialogResult.Yes)
                {
                    Save.PerformClick();
                }

            }
            else
            {   
                Application.Exit();
            }
        }
        /* om anv klickar på krysset för att avsluta kontrolleras först om texten är förändrad från originaltext. om, så öppnas
         * en messagebox som frågar om anv vill spara eller inte eller avbryta. denna gång avbryts förfrågan genom
         att sätta e.cancel till true */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                string name = this.Text;

                if (textBox1.Text != allText || name.Trim().StartsWith("*"))
                {
                    var quitForm = MessageBox.Show("Vill du spara ändringarna för " + fileName + "?", "Avsluta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (quitForm == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    if (quitForm == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        
                    }
                    if (quitForm == DialogResult.Yes)
                    {
                        Save.PerformClick();
                    }

                }
                else
                {
                    Application.Exit();
                }
            }
        }
        /* drag and drop funktioner. en openfiledialog öppnas för att komma åt filens innehåll. om filen
         * är av format .txt är drag n drop möjligt annars händer ingenting. Först kontrolleras om filen förändrats
         med en messagebox och sedan anropas PerformDrop för att lägga till den nya filen*/
        private void DragAndDrop(object sender, DragEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "*.txt|*.txt";
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (textBox1.Text != allText)
            {
                var saveFile = MessageBox.Show("Vill du spara ändringarna för " + fileName + "?", "Avsluta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (saveFile == DialogResult.Cancel)
                {
                    this.DialogResult = DialogResult.None;
                }
                if (saveFile == DialogResult.Yes)
                {
                    foreach (string file in s)
                    {
                        if (System.IO.Path.GetExtension(file).Equals(".txt", StringComparison.InvariantCultureIgnoreCase))
                        {
                            Save.PerformClick();
                            performDrop(file, openFile, sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Fel format");
                        }
                    }
                }
                if (saveFile == DialogResult.No)
                {
                    foreach (string file in s)
                    {
                        if (System.IO.Path.GetExtension(file).Equals(".txt", StringComparison.InvariantCultureIgnoreCase))
                        {
                            performDrop(file, openFile, sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Fel format");
                        }
                    }
                }
            }
            else
            {
                foreach (string file in s)
                {
                    if (System.IO.Path.GetExtension(file).Equals(".txt", StringComparison.InvariantCultureIgnoreCase))
                    {
                        performDrop(file, openFile, sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Fel format");
                    }
                }
            }
           
        }

        private string collectFilename(string n)
        {
            return Path.GetFileNameWithoutExtension(n);
        }
        private void DragAndEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
         /*Funktionen tar emot en sträng, fileDialog, object och DragEventArgs från draganddrop. Med 
          * hjälp av if-satser kontrolleras om användaren tryckt ner CTRL, SHIFT eller ingen av dom.
          * Om CTRL är nedtryckt läggs nya filen till i slutet av den nuvarande filen, är SHIFT nedtryckt 
          * läggs den till där användaren önskat i nuvarance filen. I annat fall byts texten ut till den
          * fil som dragits dit */
        private void performDrop(string s, OpenFileDialog open, object sender, DragEventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile = open;
            string file = s;

            fileName = collectFilename(file);
            this.Text = fileName;
            path = file;
            openfile.FileName = path;

            if (Control.ModifierKeys == Keys.Control)
            {
                textBox1.Text = allText + " " + File.ReadAllText(openfile.FileName);
                allText = textBox1.Text;
            }
            if (ModifierKeys == Keys.Shift)
            {
                textBox1.Paste(File.ReadAllText(openfile.FileName));
                allText = textBox1.Text;
            }
            if(ModifierKeys != Keys.Control && ModifierKeys != Keys.Shift)
            {
                textBox1.Text = File.ReadAllText(openfile.FileName);
                allText = textBox1.Text;
               // Form1_Load(sender, e);
            }
        }
    }

}
