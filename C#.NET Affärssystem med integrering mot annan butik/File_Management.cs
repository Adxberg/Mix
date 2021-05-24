using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Bibliotek
{
    /*Filhanteringsklass */
    public class File_Management
    {
        public BindingList<Stock> Database { get; set; }
        public List<int> id_num;
        Stock stock;
        string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\StockFile.csv";
        XmlDocument xmlDoc;
        XmlElement root;

        public File_Management()
        {
            Database = new BindingList<Stock>();
            id_num = new List<int>();
            Read();
        }
        /* Läser in en CSV fil och stoppar in i en lista som sen addas till databasen*/
        public void Read()
        {
            string[] items = System.IO.File.ReadAllLines(path);
            int count = 0;
            List<string> tmp = new List<string>();

            foreach (string item in items)
            {
                string[] AllColums = item.Split(';');

                foreach (string EachColum in AllColums)
                {
                    if (!string.IsNullOrEmpty(EachColum))
                    {
                        tmp.Add(EachColum);
                        count++;

                        if (count == 11)
                        {
                            count = 0;
                            PutInStock(tmp);
                            tmp.Clear();
                        }
                    }
                }
            }
        }

        /* FUnktion som lägger till databasen. Idnumret läggs även till i en lista för att sen kunna finna närmast unika idnummer*/
        private void PutInStock(List<string> items)
        {

            stock = new Stock();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == "empty")
                {
                    items[i] = "";
                }

                switch (i)
                {
                    case 0:
                        stock.ID_number = items[i];
                        id_num.Add(int.Parse(items[i]));
                        break;
                    case 1:
                        stock.name = items[i];
                        break;
                    case 2:
                        stock.price = items[i];
                        break;
                    case 3:
                        stock.type = items[i];
                        break;
                    case 4:
                        stock.author = items[i];
                        break;
                    case 5:
                        stock.genre = items[i];
                        break;
                    case 6:
                        stock.format = items[i];
                        break;
                    case 7:
                        stock.language = items[i];
                        break;
                    case 8:
                        stock.platform = items[i];
                        break;
                    case 9:
                        stock.playtime = items[i];
                        break;
                    case 10:
                        stock.quantity = items[i];
                        break;
                }

            }
            Database.Add(stock);

        }

        public void UpdateDatabase(string id, string name, string price, string type, string author, string genre, string format, string language, string platform, string playtime, string quantity)
        {
            for (int i = 0; i < Database.Count; i++)
            {
                if (Database[i].ID_number.Equals(id))
                {
                    Database[i].name = name;
                    Database[i].price = price;
                    Database[i].type = type;
                    Database[i].genre = genre;
                    Database[i].author = author;
                    Database[i].genre = genre;
                    Database[i].platform = platform;
                    Database[i].playtime = playtime;
                    Database[i].quantity = quantity;
                }
            }
            Write();
        }

        public void DeleteItemDatabase(string id)
        {
            for (int i = 0; i < Database.Count; i++)
            {
                if (Database[i].ID_number.Equals(id))
                {
                    Database.Remove(Database[i]);
                }
            }
            Write();
        }
        /* Funktion för att skriva till fil. Alla tomma fält fylls med strängen Empty */
        public void Write()
        {
            string databasePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\database.txt";

            using (StreamWriter file = new StreamWriter(path))
            using (StreamWriter filetxt = new StreamWriter(databasePath))

                foreach (var item in Database)
                {
                    if (string.IsNullOrEmpty(item.name))
                    {
                        item.name = "empty";
                    }
                    if (string.IsNullOrEmpty(item.price))
                    {
                        item.price = "empty";
                    }
                    if (string.IsNullOrEmpty(item.type))
                    {
                        item.type = "empty";
                    }
                    if (string.IsNullOrEmpty(item.author))
                    {
                        item.author = "empty";
                    }
                    if (string.IsNullOrEmpty(item.genre))
                    {
                        item.genre = "empty";
                    }
                    if (string.IsNullOrEmpty(item.format))
                    {
                        item.format = "empty";
                    }
                    if (string.IsNullOrEmpty(item.language))
                    {
                        item.language = "empty";
                    }
                    if (string.IsNullOrEmpty(item.platform))
                    {
                        item.platform = "empty";
                    }
                    if (string.IsNullOrEmpty(item.playtime))
                    {
                        item.playtime = "empty";
                    }
                    if (string.IsNullOrEmpty(item.quantity))
                    {
                        item.quantity = "empty";

                    }

                    var writeLineToFile = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                        item.ID_number + ";",
                       item.name + ";",
                       item.price + ";",
                      item.type + ";",
                       item.author + ";",
                       item.genre + ";",
                       item.format + ";",
                       item.language + ";",
                       item.platform + ";",
                       item.playtime + ";",
                       item.quantity + ";"
                       );
                    var writeToTxt = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                        item.ID_number + "\r\n",
                       item.name + "\r\n",
                       item.price + "\r\n",
                      item.type + "\r\n",
                       item.author + "\r\n",
                       item.genre + "\r\n",
                       item.format + "\r\n",
                       item.language + "\r\n",
                       item.platform + "\r\n",
                       item.playtime + "\r\n",
                       item.quantity
                       );
                    if (writeLineToFile.Contains(","))
                    {
                        writeLineToFile = writeLineToFile.Replace(",", "");
                    }

                    if (writeToTxt.Contains(","))
                    {
                        writeToTxt = writeToTxt.Replace(",", "");
                    }

                    string trimmed = writeLineToFile.TrimEnd();
                    file.WriteLine(writeLineToFile);
                    filetxt.WriteLine(writeToTxt);
                }
          //  WriteToXml();
        }

        private void WriteToXml()
        {
            string databasePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\database.txt";

            xmlDoc = new XmlDocument();
             root = xmlDoc.CreateElement("products");
            foreach (var item in Database)
            {
                 XmlElement colum = xmlDoc.CreateElement("product");
                 root.AppendChild(colum);

                 XmlElement id = xmlDoc.CreateElement("id");
                 id.InnerText = item.ID_number;
                 colum.AppendChild(id);
                 XmlElement name = xmlDoc.CreateElement("name");
                 name.InnerText = item.name;
                 colum.AppendChild(name);
                 XmlElement price = xmlDoc.CreateElement("price");
                 price.InnerText = item.price;
                 colum.AppendChild(price);
                 XmlElement type = xmlDoc.CreateElement("type");
                 type.InnerText = item.type;
                 colum.AppendChild(type);
                 XmlElement author = xmlDoc.CreateElement("author");
                 author.InnerText = item.author;
                 colum.AppendChild(author);
                 XmlElement genre = xmlDoc.CreateElement("genre");
                 genre.InnerText = item.genre;
                 colum.AppendChild(genre);
                 XmlElement format = xmlDoc.CreateElement("format");
                 format.InnerText = item.format;
                 colum.AppendChild(format);
                 XmlElement platform = xmlDoc.CreateElement("platform");
                 platform.InnerText = item.platform;
                 colum.AppendChild(platform);
                 XmlElement playtime = xmlDoc.CreateElement("playtime");
                 playtime.InnerText = item.playtime;
                 colum.AppendChild(playtime);
                 XmlElement count = xmlDoc.CreateElement("count");
                 count.InnerText = item.quantity;
                 colum.AppendChild(count);
             }

             xmlDoc.AppendChild(root);
             Console.Read();
             xmlDoc.Save(databasePath);
            }

        }


    }
