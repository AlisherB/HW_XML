using System.Collections.Generic;
using System.Xml;
using static System.Console;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("https://habrahabr.ru/rss/interesting/");
            XmlElement root = xmlDoc.DocumentElement;
            XmlElement channel = root["channel"];
            if (channel.HasChildNodes)
            {
                foreach (XmlNode node in channel.ChildNodes)
                {
                    if (node.Name == "item")
                    {
                        Item item = new Item();
                        item.Title = node["title"].InnerText;
                        item.Link = node["link"].InnerText;
                        item.Description = node["description"].InnerText;
                        item.PubDate = node["pubDate"].InnerText;
                        items.Add(item);
                    }
                }
            }
            foreach (var i in items)
            {
                WriteLine(i.Title);
                WriteLine(i.Link);
                WriteLine(i.Description);
                WriteLine(i.PubDate);
            }
            ReadLine();
        }
    }
}
