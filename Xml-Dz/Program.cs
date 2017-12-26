using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml_Dz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> itemCollection = new List<Item>();

            #region Read
            XmlDocument xmlDoc = new XmlDocument();
            const string way = @"https://habrahabr.ru/rss/interesting/";
            xmlDoc.Load(way);
            XmlNode xmlNode = xmlDoc.LastChild.LastChild;
            foreach (XmlNode tmp in xmlNode)
            {
                if (tmp.Name == "item")
                {
                    Item item = new Item();

                    var nodes = tmp.ChildNodes;
                    foreach (XmlNode childNode in nodes)
                    {
                        if (childNode.Name == "title") item.Title = childNode.InnerText;
                        else if (childNode.Name == "link") item.Link = childNode.InnerText;
                        else if (childNode.Name == "desription") item.Description = childNode.InnerText;
                        else if (childNode.Name == "pubDate") item.PubDate = DateTime.Parse(childNode.InnerText);
                    }
                    itemCollection.Add(item);
                }
            }
            Console.WriteLine("Информация успешно считана!");
            #endregion
            Console.ReadLine();
        }
    }
}
