using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
namespace HtmlAgility
{
    class HtmlAgility
    {
        public void HtmlLoad()
        {
            HtmlDocument document2 = new HtmlDocument();
            document2.Load(@"D:\Data\Home.txt", Encoding.UTF8);


            HtmlNode nodes = document2.DocumentNode.SelectSingleNode("//body");
            foreach (var item in document2.DocumentNode.Descendants())
            {
                if (item.Name == "body") { item.ChildNodes.Clear(); }
                document2.Save(@"D:\Data\Home.txt");

            }
            HtmlDocument doc = new HtmlDocument();
            var maindiv=doc.CreateElement("div");
            maindiv.AddClass("container-fluid mt-3");
            nodes.AppendChild(maindiv);

            var row= doc.CreateElement("div");
            row.AddClass("row");
            maindiv.AppendChild(row);

            var col1 = doc.CreateElement("div");
            col1.AddClass("col-md-9");
            col1.SetAttributeValue("style","color:red");
            col1.InnerHtml = "I am from colum 1";
            row.AppendChild(col1);

            var col2 = doc.CreateElement("div");
            col2.AddClass("col-md-3");
            col2.SetAttributeValue("style", "color:black");
            col2.InnerHtml = "I am from colum 2";
            row.AppendChild(col2);

            document2.Save(@"D:\Data\Home.txt");





            foreach (var item in document2.DocumentNode.Descendants())
            {

                if (item.Name == "body")
                {
                    HtmlNode p = document2.CreateElement("p");
                    p.InnerHtml = "This Shivaji From Nashik";
                    item.AppendChild(p);
                    document2.Save(@"D:\Data\Home.txt");

                }
            }
        }
    }
}
