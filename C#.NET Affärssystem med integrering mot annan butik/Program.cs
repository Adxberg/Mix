// Angelika Doxakis Berg Laboration 5 angedoxa100 C#.NET 210524

using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace MediaIntegrator
{
    class Program
    {
        static List<string> idNr = new List<string>();
        static FileSystemWatcher fileSystemWatcher;
        static int updatedCount = 0;
        static private string id, name, price, count, description, pathSimpleMedia, pathMyMedia;
        static List<string> paths = new List<string>();
        static List<Stock> databaseToSimpleMedia = new List<Stock>();
        static Stock stock = new Stock();
        static SimpleMediaStock simpleMediaStock = new SimpleMediaStock();
        static bool thatOne = false;
        static List<SimpleMediaStock> simpleMediaList = new List<SimpleMediaStock>();
        static XmlDocument xmlDoc = new XmlDocument();
        static int even = 1;
        static List<string> tmpId = new List<string>();
        static void Main(string[] args)
        {
            fileSystemWatcher = new FileSystemWatcher(AppDomain.CurrentDomain.BaseDirectory + "\\MyMedia");
            fileSystemWatcher.Filter = "*.txt";
            fileSystemWatcher.Changed += new FileSystemEventHandler(Watcher_Changed);
            fileSystemWatcher.Created += new FileSystemEventHandler(Watcher_Changed);
            fileSystemWatcher.IncludeSubdirectories = true;
            fileSystemWatcher.EnableRaisingEvents = true;
            xmlDoc.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Config.xml"));

            foreach (XmlElement elem in xmlDoc.FirstChild.ChildNodes)
            {
                if (elem.Name == "database")
                {
                    paths.Add(elem.InnerText);
                }
            }
            pathSimpleMedia = paths[0];
            pathMyMedia = paths[1];

            thatOne = false;
            Read(pathMyMedia);
            thatOne = true;
            Read(pathSimpleMedia);
            // Write();
            tmpId = idNr.ToList();
            UpdateFile();
            Console.Read();
}
        // Funktion kontrollerar om ett värde är jämnt eller ojämnt
        private static bool Even(int num)
        {
            return num % 2 == 0;
        }

        //Funktion håller koll på om en fil förändras i realtid. Har ett värde ett jämnt nummer så anropas olika funktioner.
        private static void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            even++;
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            if (Even(even))
            {
                simpleMediaList.Clear();
              
                idNr.Clear();
                thatOne = false;
                Read(pathMyMedia);
                UpdateFile();
                updatedCount++;

                Console.WriteLine("File updated " + updatedCount + " times");
            }
        }

        // Funktion som läser in fil från 2 olika mappar och placerar värden i en bindinglist
        static private void Read(string path)
        {
            string value;
            int count = 0;
            int countSimple = 0;
            List<string> tmp = new List<string>();

            if (!thatOne)
            {
                string[] elems = File.ReadAllLines(path);
                foreach (string elem in elems)
                {
                    string[] holeLine = elem.Split(',');

                    foreach (string EachColum in holeLine)
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
            if (thatOne)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(path);

                foreach (XmlElement xelem in xmlDoc.FirstChild.ChildNodes)
                {
                    simpleMediaStock = new SimpleMediaStock();
                    foreach (XmlElement elem in xelem.ChildNodes)
                    {
                        if (elem.Name == "id")
                        {
                            simpleMediaStock.id = elem.InnerText;
                             if (!idNr.Contains(elem.InnerText))
                             {
                                 idNr.Add(elem.InnerText);
                             }
                        }
                        else if (elem.Name == "price")
                        {
                            simpleMediaStock.price = elem.InnerText;
                        }
                        else if (elem.Name == "count")
                        {
                            simpleMediaStock.count = elem.InnerText;
                        }
                        else if (elem.Name == "name")
                        {
                            simpleMediaStock.name = elem.InnerText;
                        }
                        else if (elem.Name == "description")
                        {
                            simpleMediaStock.description = elem.InnerText;
                        }
                    }
                    simpleMediaList.Add(simpleMediaStock);
                }
            }
        }

        // Funktion som placerar värden ur en fil till att passa en annan fils struktur
        static private void PutInStock(List<string> tmp)
        {
            string description = "";
            simpleMediaStock = new SimpleMediaStock();

            for (int i = 0; i < tmp.Count; i++)
            {
                if (i.Equals(0))
                {
                    simpleMediaStock.id = "00" + tmp[i];
                    if (!idNr.Contains(tmp[i]))
                    {
                        idNr.Add("00" + tmp[i]);
                    }
                }
                if (i.Equals(1))
                {
                    simpleMediaStock.name = tmp[i];
                }
                if (i.Equals(2))
                {
                    simpleMediaStock.price = tmp[i];
                }
                if (i.Equals(3))
                {
                    description = "Type of item is " + tmp[i];
                }
                if (i.Equals(4))
                {
                    description += ". The author is " + tmp[i];
                }
                if (i.Equals(5))
                {
                    description += ". Genre " + tmp[i];
                }
                if (i.Equals(6))
                {
                    description += ". Format " + tmp[i];
                }
                if (i.Equals(7))
                {
                    description += ". Language will be " + tmp[i];
                }
                if (i.Equals(8))
                {
                    description += ". Platform " + tmp[i];
                }
                if (i.Equals(9))
                {
                    description += " and playtime " + tmp[i];
                    simpleMediaStock.description = description;
                }
                if (i.Equals(10))
                {
                    simpleMediaStock.count = tmp[i];
                }
            }
            simpleMediaList.Add(simpleMediaStock);
        }

        //Funktion som skapar ett xml dokument och placerar värden på rätt ställe utifrån en list
        static private void Write()
        {
            xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("products");
            xmlDoc.AppendChild(root);

            for (int i = 0; i < simpleMediaList.Count; i++)
            {
                XmlElement colum = xmlDoc.CreateElement("product");
                root.AppendChild(colum);

                XmlElement id = xmlDoc.CreateElement("id");
                id.InnerText = simpleMediaList[i].id;
                colum.AppendChild(id);
                XmlElement price = xmlDoc.CreateElement("price");
                price.InnerText = simpleMediaList[i].price;
                colum.AppendChild(price);
                XmlElement count = xmlDoc.CreateElement("count");
                count.InnerText = simpleMediaList[i].count;
                colum.AppendChild(count);
                XmlElement name = xmlDoc.CreateElement("name");
                name.InnerText = simpleMediaList[i].name;
                colum.AppendChild(name);
                XmlElement description = xmlDoc.CreateElement("description");
                description.InnerText = simpleMediaList[i].description;
                colum.AppendChild(description);
            }
            xmlDoc.Save(pathSimpleMedia);
        }

        // Funktion som uppdaterar redan existerande xmlfil med nya värden
        static private void UpdateFile()
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(pathSimpleMedia);
            XmlNode node;

            XmlNodeList nodeID = xmlDoc.SelectNodes("products/product/id");
            List<int> number = new List<int>();

            foreach (XmlNode idnode in nodeID)
            {
                number.Add(int.Parse(idnode.InnerText));
                foreach (var item in simpleMediaList)
                {
                    if (item.id.Equals(idnode.InnerText))
                    {
                        node = xmlDoc.SelectSingleNode("products/product/price");
                        node.InnerText = item.price;
                        node = xmlDoc.SelectSingleNode("products/product/count");
                        node.InnerText = item.count;
                        node = xmlDoc.SelectSingleNode("products/product/name");
                        node.InnerText = item.name;
                        node = xmlDoc.SelectSingleNode("products/product/description");
                        node.InnerText = item.description;
                    }
                }
            }
            foreach (var item in simpleMediaList)
            {
                if (!number.Contains(int.Parse(item.id)))
                {
                    node = xmlDoc.SelectSingleNode("/products");

                    XmlElement colum = xmlDoc.CreateElement("product");
                    node.AppendChild(colum);

                    XmlElement id = xmlDoc.CreateElement("id");
                    id.InnerText = item.id;
                    colum.AppendChild(id);
                    XmlElement price = xmlDoc.CreateElement("price");
                    price.InnerText = item.price;
                    colum.AppendChild(price);
                    XmlElement count = xmlDoc.CreateElement("count");
                    count.InnerText = item.count;
                    colum.AppendChild(count);
                    XmlElement name = xmlDoc.CreateElement("name");
                    name.InnerText = item.name;
                    colum.AppendChild(name);
                    XmlElement description = xmlDoc.CreateElement("description");
                    description.InnerText = item.description;
                    colum.AppendChild(description);
                }
            }
            xmlDoc.Save(pathSimpleMedia);

            delete();
        }
        // Funktion som kontrollerar om en produkt är bortagen ur ena filen för att sen radera den ur den andra
        static private void delete()
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(pathSimpleMedia);
            for (int i = 0; i < tmpId.Count; i++)
            {
                if (!idNr.Contains(tmpId[i]))
                {
                    if (tmpId[i].StartsWith("00"))
                    {
                        try
                        {                           
                           XmlNodeList nodeList = xmlDoc.SelectNodes("products/product");
                            foreach (XmlNode nodes in nodeList)
                            {
                                if (nodes.SelectSingleNode("id").InnerText == tmpId[i])
                                {
                                    nodes.ParentNode.RemoveChild(nodes);
                                }
                            }
                        }
                        catch(IOException e)
                        {
                            Console.WriteLine(e.Source);
                            throw;
                        }
                    }
                }                                             
            }               
              xmlDoc.Save(pathSimpleMedia);
        }
    }
}




